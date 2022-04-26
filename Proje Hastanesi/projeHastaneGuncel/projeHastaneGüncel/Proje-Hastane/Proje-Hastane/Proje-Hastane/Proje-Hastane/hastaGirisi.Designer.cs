namespace Proje_Hastane
{
    partial class hastaGirisi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hastaGirisi));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.btnGiriş = new System.Windows.Forms.Button();
            this.btnUyeOl = new System.Windows.Forms.Button();
            this.btnGeriDön = new System.Windows.Forms.Button();
            this.lblHak = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(33, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Yellow;
            this.label2.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(32, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciAdi.Location = new System.Drawing.Point(171, 20);
            this.txtKullaniciAdi.Margin = new System.Windows.Forms.Padding(5);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(164, 36);
            this.txtKullaniciAdi.TabIndex = 2;
            this.txtKullaniciAdi.Text = "99999999999";
            // 
            // txtSifre
            // 
            this.txtSifre.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.Location = new System.Drawing.Point(170, 70);
            this.txtSifre.Margin = new System.Windows.Forms.Padding(5);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(164, 36);
            this.txtSifre.TabIndex = 3;
            this.txtSifre.Text = "9999";
            // 
            // btnGiriş
            // 
            this.btnGiriş.BackColor = System.Drawing.Color.Yellow;
            this.btnGiriş.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiriş.Location = new System.Drawing.Point(37, 126);
            this.btnGiriş.Margin = new System.Windows.Forms.Padding(5);
            this.btnGiriş.Name = "btnGiriş";
            this.btnGiriş.Size = new System.Drawing.Size(300, 67);
            this.btnGiriş.TabIndex = 4;
            this.btnGiriş.Text = "Giriş";
            this.btnGiriş.UseVisualStyleBackColor = false;
            this.btnGiriş.Click += new System.EventHandler(this.btnGiriş_Click);
            // 
            // btnUyeOl
            // 
            this.btnUyeOl.BackColor = System.Drawing.Color.Yellow;
            this.btnUyeOl.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUyeOl.Location = new System.Drawing.Point(37, 204);
            this.btnUyeOl.Margin = new System.Windows.Forms.Padding(5);
            this.btnUyeOl.Name = "btnUyeOl";
            this.btnUyeOl.Size = new System.Drawing.Size(300, 36);
            this.btnUyeOl.TabIndex = 5;
            this.btnUyeOl.Text = "Kayıt Ol";
            this.btnUyeOl.UseVisualStyleBackColor = false;
            this.btnUyeOl.Click += new System.EventHandler(this.btnUyeOl_Click);
            // 
            // btnGeriDön
            // 
            this.btnGeriDön.BackColor = System.Drawing.Color.Lime;
            this.btnGeriDön.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeriDön.Location = new System.Drawing.Point(343, 17);
            this.btnGeriDön.Name = "btnGeriDön";
            this.btnGeriDön.Size = new System.Drawing.Size(95, 39);
            this.btnGeriDön.TabIndex = 6;
            this.btnGeriDön.Text = "Geri Dön";
            this.btnGeriDön.UseVisualStyleBackColor = false;
            this.btnGeriDön.Click += new System.EventHandler(this.btnGeriDön_Click);
            // 
            // lblHak
            // 
            this.lblHak.AutoSize = true;
            this.lblHak.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHak.Location = new System.Drawing.Point(356, 76);
            this.lblHak.Name = "lblHak";
            this.lblHak.Size = new System.Drawing.Size(0, 29);
            this.lblHak.TabIndex = 14;
            // 
            // hastaGirisi
            // 
            this.AcceptButton = this.btnGiriş;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(442, 368);
            this.Controls.Add(this.lblHak);
            this.Controls.Add(this.btnGeriDön);
            this.Controls.Add(this.btnUyeOl);
            this.Controls.Add(this.btnGiriş);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "hastaGirisi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hasta Girişi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Button btnGiriş;
        private System.Windows.Forms.Button btnUyeOl;
        private System.Windows.Forms.Button btnGeriDön;
        private System.Windows.Forms.Label lblHak;
    }
}