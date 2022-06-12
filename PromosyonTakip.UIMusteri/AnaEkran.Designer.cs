
namespace PromosyonTakip.UIMusteri
{
    partial class AnaEkran
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gboxMusteriBilgileri = new System.Windows.Forms.GroupBox();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.chcSMSOnay = new System.Windows.Forms.CheckBox();
            this.chcEpostaOnay = new System.Windows.Forms.CheckBox();
            this.cmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.txtDogumTarih = new System.Windows.Forms.DateTimePicker();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMeslek = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoyisim = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIsim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTCNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.hediyePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.gboxMusteriBilgileri.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxMusteriBilgileri
            // 
            this.gboxMusteriBilgileri.Controls.Add(this.btnIptal);
            this.gboxMusteriBilgileri.Controls.Add(this.btnKaydet);
            this.gboxMusteriBilgileri.Controls.Add(this.chcSMSOnay);
            this.gboxMusteriBilgileri.Controls.Add(this.chcEpostaOnay);
            this.gboxMusteriBilgileri.Controls.Add(this.cmbCinsiyet);
            this.gboxMusteriBilgileri.Controls.Add(this.txtDogumTarih);
            this.gboxMusteriBilgileri.Controls.Add(this.txtTelefon);
            this.gboxMusteriBilgileri.Controls.Add(this.label8);
            this.gboxMusteriBilgileri.Controls.Add(this.txtEmail);
            this.gboxMusteriBilgileri.Controls.Add(this.label7);
            this.gboxMusteriBilgileri.Controls.Add(this.txtMeslek);
            this.gboxMusteriBilgileri.Controls.Add(this.label6);
            this.gboxMusteriBilgileri.Controls.Add(this.label5);
            this.gboxMusteriBilgileri.Controls.Add(this.label4);
            this.gboxMusteriBilgileri.Controls.Add(this.txtSoyisim);
            this.gboxMusteriBilgileri.Controls.Add(this.label3);
            this.gboxMusteriBilgileri.Controls.Add(this.txtIsim);
            this.gboxMusteriBilgileri.Controls.Add(this.label2);
            this.gboxMusteriBilgileri.Controls.Add(this.txtTCNo);
            this.gboxMusteriBilgileri.Controls.Add(this.label1);
            this.gboxMusteriBilgileri.Location = new System.Drawing.Point(418, 12);
            this.gboxMusteriBilgileri.Name = "gboxMusteriBilgileri";
            this.gboxMusteriBilgileri.Size = new System.Drawing.Size(392, 486);
            this.gboxMusteriBilgileri.TabIndex = 0;
            this.gboxMusteriBilgileri.TabStop = false;
            this.gboxMusteriBilgileri.Text = "Müşteri Bilgileri";
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(139, 390);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(231, 31);
            this.btnIptal.TabIndex = 11;
            this.btnIptal.Text = "İPTAL";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(139, 353);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(231, 31);
            this.btnKaydet.TabIndex = 10;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // chcSMSOnay
            // 
            this.chcSMSOnay.AutoSize = true;
            this.chcSMSOnay.Location = new System.Drawing.Point(139, 315);
            this.chcSMSOnay.Name = "chcSMSOnay";
            this.chcSMSOnay.Size = new System.Drawing.Size(211, 21);
            this.chcSMSOnay.TabIndex = 9;
            this.chcSMSOnay.Text = "SMS bildirimi almak istiyorum";
            this.chcSMSOnay.UseVisualStyleBackColor = true;
            // 
            // chcEpostaOnay
            // 
            this.chcEpostaOnay.AutoSize = true;
            this.chcEpostaOnay.Location = new System.Drawing.Point(139, 260);
            this.chcEpostaOnay.Name = "chcEpostaOnay";
            this.chcEpostaOnay.Size = new System.Drawing.Size(231, 21);
            this.chcEpostaOnay.TabIndex = 7;
            this.chcEpostaOnay.Text = "E-posta bildirimi almak istiyorum";
            this.chcEpostaOnay.UseVisualStyleBackColor = true;
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.FormattingEnabled = true;
            this.cmbCinsiyet.Location = new System.Drawing.Point(139, 174);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Size = new System.Drawing.Size(234, 24);
            this.cmbCinsiyet.TabIndex = 4;
            // 
            // txtDogumTarih
            // 
            this.txtDogumTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDogumTarih.Location = new System.Drawing.Point(139, 145);
            this.txtDogumTarih.MaxDate = new System.DateTime(2000, 12, 31, 0, 0, 0, 0);
            this.txtDogumTarih.MinDate = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            this.txtDogumTarih.Name = "txtDogumTarih";
            this.txtDogumTarih.Size = new System.Drawing.Size(234, 22);
            this.txtDogumTarih.TabIndex = 3;
            this.txtDogumTarih.Value = new System.DateTime(2000, 12, 31, 0, 0, 0, 0);
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(139, 287);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(233, 22);
            this.txtTelefon.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 292);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Telefon";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(139, 232);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(233, 22);
            this.txtEmail.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "E-posta Adresi";
            // 
            // txtMeslek
            // 
            this.txtMeslek.Location = new System.Drawing.Point(140, 204);
            this.txtMeslek.Name = "txtMeslek";
            this.txtMeslek.Size = new System.Drawing.Size(233, 22);
            this.txtMeslek.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Meslek";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Cinsiyet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Doğum Tarihi";
            // 
            // txtSoyisim
            // 
            this.txtSoyisim.Location = new System.Drawing.Point(140, 114);
            this.txtSoyisim.Name = "txtSoyisim";
            this.txtSoyisim.Size = new System.Drawing.Size(233, 22);
            this.txtSoyisim.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Soyisim";
            // 
            // txtIsim
            // 
            this.txtIsim.Location = new System.Drawing.Point(140, 86);
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.Size = new System.Drawing.Size(233, 22);
            this.txtIsim.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "İsim";
            // 
            // txtTCNo
            // 
            this.txtTCNo.Location = new System.Drawing.Point(140, 58);
            this.txtTCNo.Name = "txtTCNo";
            this.txtTCNo.Size = new System.Drawing.Size(233, 22);
            this.txtTCNo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC Kimlik Numara";
            // 
            // hediyePanel
            // 
            this.hediyePanel.Location = new System.Drawing.Point(12, 12);
            this.hediyePanel.Name = "hediyePanel";
            this.hediyePanel.Size = new System.Drawing.Size(400, 486);
            this.hediyePanel.TabIndex = 1;
            // 
            // AnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 510);
            this.Controls.Add(this.hediyePanel);
            this.Controls.Add(this.gboxMusteriBilgileri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AnaEkran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Promosyon Müşteri Takip Ekranı";
            this.Load += new System.EventHandler(this.AnaEkran_Load);
            this.gboxMusteriBilgileri.ResumeLayout(false);
            this.gboxMusteriBilgileri.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxMusteriBilgileri;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.CheckBox chcSMSOnay;
        private System.Windows.Forms.CheckBox chcEpostaOnay;
        private System.Windows.Forms.ComboBox cmbCinsiyet;
        private System.Windows.Forms.DateTimePicker txtDogumTarih;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMeslek;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSoyisim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIsim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTCNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel hediyePanel;
    }
}