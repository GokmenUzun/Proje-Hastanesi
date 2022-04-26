using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proje_Hastane
{
    public partial class sekreterKayit : Form
    {
        sqlBaglantisi bag=new sqlBaglantisi();
        public sekreterKayit()
        {
            InitializeComponent();
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into sekreterler (ad,soyad,TCno,sifre,cinsiyet) values (@p1,@p2,@p3,@p4,@p5)", bag.baglanti());
            cmd.Parameters.AddWithValue("@p1",txtAd.Text);
            cmd.Parameters.AddWithValue("@p2",txtSoyad.Text);
            cmd.Parameters.AddWithValue("@p3",mskTCno.Text);
            cmd.Parameters.AddWithValue("@p4",txtSifre.Text);
            cmd.Parameters.AddWithValue("@p5",cmbCinsiyet.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Kayıt başarıyla eklenmiştir!");
            bag.baglanti().Close();
        }

        private void btnGeriDön_Click(object sender, EventArgs e)
        {
            sekreterGirisi frm = new sekreterGirisi();
            frm.Show();
            this.Hide();
        }
    }
}
