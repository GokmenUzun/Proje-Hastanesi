namespace Proje_Hastane
{
    partial class panelBrans
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(panelBrans));
            this.txtBransAdi = new System.Windows.Forms.TextBox();
            this.lblBransAdi = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.dgwBrans = new System.Windows.Forms.DataGridView();
            this.lblBransID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBrans)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBransAdi
            // 
            this.txtBransAdi.Location = new System.Drawing.Point(132, 31);
            this.txtBransAdi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBransAdi.Multiline = true;
            this.txtBransAdi.Name = "txtBransAdi";
            this.txtBransAdi.Size = new System.Drawing.Size(379, 43);
            this.txtBransAdi.TabIndex = 0;
            // 
            // lblBransAdi
            // 
            this.lblBransAdi.AutoSize = true;
            this.lblBransAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblBransAdi.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBransAdi.Location = new System.Drawing.Point(9, 48);
            this.lblBransAdi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBransAdi.Name = "lblBransAdi";
            this.lblBransAdi.Size = new System.Drawing.Size(93, 23);
            this.lblBransAdi.TabIndex = 1;
            this.lblBransAdi.Text = "Brans Adı";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnGuncelle.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(399, 107);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(129, 41);
            this.btnGuncelle.TabIndex = 74;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSil.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(132, 107);
            this.btnSil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(129, 41);
            this.btnSil.TabIndex = 73;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnKaydet.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(561, 27);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(113, 44);
            this.btnKaydet.TabIndex = 72;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // dgwBrans
            // 
            this.dgwBrans.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgwBrans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwBrans.Location = new System.Drawing.Point(13, 155);
            this.dgwBrans.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgwBrans.Name = "dgwBrans";
            this.dgwBrans.RowHeadersWidth = 51;
            this.dgwBrans.Size = new System.Drawing.Size(700, 290);
            this.dgwBrans.TabIndex = 75;
            this.dgwBrans.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwBrans_CellClick);
            // 
            // lblBransID
            // 
            this.lblBransID.AutoSize = true;
            this.lblBransID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblBransID.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBransID.Location = new System.Drawing.Point(16, 11);
            this.lblBransID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBransID.Name = "lblBransID";
            this.lblBransID.Size = new System.Drawing.Size(84, 23);
            this.lblBransID.TabIndex = 76;
            this.lblBransID.Text = "Brans ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 77;
            this.label1.Text = "000";
            // 
            // panelBrans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(729, 460);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBransID);
            this.Controls.Add(this.dgwBrans);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.lblBransAdi);
            this.Controls.Add(this.txtBransAdi);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "panelBrans";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "panelBrans";
            this.Load += new System.EventHandler(this.panelBrans_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwBrans)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBransAdi;
        private System.Windows.Forms.Label lblBransAdi;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.DataGridView dgwBrans;
        private System.Windows.Forms.Label lblBransID;
        private System.Windows.Forms.Label label1;
    }
}