using PromosyonTakip.Core.Entities;
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
    public partial class HediyeGoster : Form
    {
        public HediyeGoster(PromosyonUrun data )
        {
            InitializeComponent();
            lblHediyeAciklama.Text = data.tanim + " " + data.aciklama;
        }

        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            Form AnaEkranFrm= Application.OpenForms["AnaEkran"];
            AnaEkranFrm.Close();

            AnaEkran AnaForm = new AnaEkran();
            AnaForm.Show();
            this.Close();
        }
    }
}
