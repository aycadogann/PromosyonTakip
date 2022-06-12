using PromosyonTakip.Core.BussinessLogicService;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtKullaniciAdi.Text) && !string.IsNullOrEmpty(txtSifre.Text))
            {
                SistemMagazaServis servisMagaza = new SistemMagazaServis();
                int magazaID=servisMagaza.MagazaKullaniciKontrol(txtKullaniciAdi.Text, txtSifre.Text);
                if (magazaID > 0)
                {
                    StaticFieldList.magazaID = magazaID;
                    AnaEkran _anaEkran = new AnaEkran();
                    _anaEkran.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı kullanıcı adı veya şifre", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Form alanlarını eksiksiz olarak doldurunuz", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        
        }
    }
}
