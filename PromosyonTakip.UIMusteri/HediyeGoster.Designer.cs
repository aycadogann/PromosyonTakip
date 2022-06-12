
namespace PromosyonTakip.UIMusteri
{
    partial class HediyeGoster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HediyeGoster));
            this.btnYeniKayit = new System.Windows.Forms.Button();
            this.pctHediyeResim = new System.Windows.Forms.PictureBox();
            this.lblHediyeAciklama = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctHediyeResim)).BeginInit();
            this.SuspendLayout();
            // 
            // btnYeniKayit
            // 
            this.btnYeniKayit.Location = new System.Drawing.Point(46, 203);
            this.btnYeniKayit.Name = "btnYeniKayit";
            this.btnYeniKayit.Size = new System.Drawing.Size(466, 28);
            this.btnYeniKayit.TabIndex = 0;
            this.btnYeniKayit.Text = "YENİ KAYIT GİRİŞ";
            this.btnYeniKayit.UseVisualStyleBackColor = true;
            this.btnYeniKayit.Click += new System.EventHandler(this.btnYeniKayit_Click);
            // 
            // pctHediyeResim
            // 
            this.pctHediyeResim.Image = ((System.Drawing.Image)(resources.GetObject("pctHediyeResim.Image")));
            this.pctHediyeResim.Location = new System.Drawing.Point(13, 13);
            this.pctHediyeResim.Name = "pctHediyeResim";
            this.pctHediyeResim.Size = new System.Drawing.Size(174, 184);
            this.pctHediyeResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctHediyeResim.TabIndex = 1;
            this.pctHediyeResim.TabStop = false;
            // 
            // lblHediyeAciklama
            // 
            this.lblHediyeAciklama.AutoSize = true;
            this.lblHediyeAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHediyeAciklama.Location = new System.Drawing.Point(217, 97);
            this.lblHediyeAciklama.Name = "lblHediyeAciklama";
            this.lblHediyeAciklama.Size = new System.Drawing.Size(0, 20);
            this.lblHediyeAciklama.TabIndex = 2;
            // 
            // HediyeGoster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 243);
            this.Controls.Add(this.lblHediyeAciklama);
            this.Controls.Add(this.pctHediyeResim);
            this.Controls.Add(this.btnYeniKayit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HediyeGoster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HediyeGoster";
            ((System.ComponentModel.ISupportInitialize)(this.pctHediyeResim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnYeniKayit;
        private System.Windows.Forms.PictureBox pctHediyeResim;
        private System.Windows.Forms.Label lblHediyeAciklama;
    }
}