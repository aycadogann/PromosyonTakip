using PromosyonTakip.Core.BussinessLogicService;
using PromosyonTakip.Core.Entities;
using PromosyonTakip.Core.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PromosyonTakip.UIMusteri
{
    public partial class AnaEkran : Form
    {
        PotansiyelMusteri data;
        public AnaEkran()
        {
            InitializeComponent();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            GroupBox musteriBilgileri=(GroupBox)this.Controls["gboxMusteriBilgileri"];
            foreach (Control item in musteriBilgileri.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = string.Empty;
                }
                else if (item is CheckBox)
                {
                    ((CheckBox)item).Checked = false;
                }
               
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            PotansiyelMusteriServis servispotansiyelMusteri = new PotansiyelMusteriServis();
            int TCKontrol=servispotansiyelMusteri.TCSorgula(txtTCNo.Text);
            if (TCKontrol>0)
            {
                MessageBox.Show("Daha önce kayıt oldunuz", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                data = new PotansiyelMusteri();
                data.tcKimlikNo = txtTCNo.Text;
                data.isim = txtIsim.Text;
                data.soyisim = txtSoyisim.Text;
                data.dogumTarih = txtDogumTarih.Value;
                data.cinsiyet = ((Cinsiyet)cmbCinsiyet.SelectedItem).id;
                data.meslek = txtMeslek.Text;
                data.emailAdres = txtEmail.Text;
                data.emailBildirimiOnay = chcEpostaOnay.Checked;
                data.telefon = txtTelefon.Text;
                data.telefonBildirimiOnay = chcSMSOnay.Checked;
                data.olusturmaTarih = DateTime.Now;
                data.olusturanMagaza = StaticFieldList.magazaID;
                int musteriKayit=servispotansiyelMusteri.KayitYeni(data);
                if (musteriKayit>0)
                {
                    MessageBox.Show("Kayıt işleminiz başarılı. Lütfen hediye seçimini yapınız", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HediyeSecimHazirla();
                }
                else
                {
                    MessageBox.Show("Sistemsel Hata", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void HediyeSecimHazirla()
        {
            List<PromosyonUrun> hediyeUrunListesi = new List<PromosyonUrun>();
            PromosyonUrunServis servisPromosyon = new PromosyonUrunServis();
            hediyeUrunListesi = servisPromosyon.UrunListeGetir();
            if (hediyeUrunListesi!=null  && hediyeUrunListesi.Count>0)
            {
                for (int i = 0; i < hediyeUrunListesi.Count; i++)
                {
                    PictureBox pctBox = new PictureBox();
                    pctBox.Width = 52;
                    pctBox.Height = 57;
                    pctBox.Image = Image.FromFile(@"C:\Users\Asus\Desktop\C#\icon\gift-icon.png");
                    pctBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    pctBox.Tag = hediyeUrunListesi[i];
                    pctBox.Click += PctBox_Click;
                    hediyePanel.Controls.Add(pctBox);
                }
            }
            else
            {
                MessageBox.Show("Kampanya Bitmiştir", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void PctBox_Click(object sender, EventArgs e)
        {
            PictureBox secilenHediye = (PictureBox)sender;
            PromosyonUrun kazanilanUrun = (PromosyonUrun)secilenHediye.Tag;
            if (kazanilanUrun!=null && kazanilanUrun.id>0)
            {
                KatilimciPromosyonServis servisKatilimci = new KatilimciPromosyonServis();
                PromosyonUrunServis servisPromosyon = new PromosyonUrunServis();
                PotansiyelMusteriServis servisPotansiyelMusteri = new PotansiyelMusteriServis();

                servisPromosyon.urunKullanildiIsaretle(kazanilanUrun.id);
                servisKatilimci.KayitYeni(new KatilimciPromosyon()
                {
                    magazaId = StaticFieldList.magazaID,
                    olusturmaTarih = DateTime.Now,
                    promosyonUrunId=kazanilanUrun.id,
                    potansiyelMusteriId=servisPotansiyelMusteri.TCSorgula(txtTCNo.Text)
                });

                HediyeGoster hediyeGösterFrm = new HediyeGoster(kazanilanUrun);
                hediyeGösterFrm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Kampanya Bitmiştir", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            
        }

        private void AnaEkran_Load(object sender, EventArgs e)
        {
            cmbCinsiyet.DataSource = StaticFieldList.cinsiyetYukle();
        }
    }
}
