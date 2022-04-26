namespace Proje_Hastane
{
    partial class randevuListesi
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
            this.dgwRandevuListesi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwRandevuListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwRandevuListesi
            // 
            this.dgwRandevuListesi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwRandevuListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwRandevuListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwRandevuListesi.Location = new System.Drawing.Point(0, 0);
            this.dgwRandevuListesi.Name = "dgwRandevuListesi";
            this.dgwRandevuListesi.Size = new System.Drawing.Size(687, 547);
            this.dgwRandevuListesi.TabIndex = 0;
            // 
            // randevuListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(687, 547);
            this.Controls.Add(this.dgwRandevuListesi);
            this.Name = "randevuListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "randevuListesi";
            this.Load += new System.EventHandler(this.randevuListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwRandevuListesi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwRandevuListesi;
    }
}