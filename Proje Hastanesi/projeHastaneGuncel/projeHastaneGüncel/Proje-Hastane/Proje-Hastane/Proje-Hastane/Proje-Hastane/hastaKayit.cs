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
    public partial class hastaKayit : Form
    {
        public hastaKayit()
        {
            InitializeComponent();
        }

        sqlBaglantisi bag = new sqlBaglantisi();
      
        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            if (txtAd.Text==""|| txtSoyad.Text==""||mskTCno.Text==""|| mskTelefon.Text==""||txtSifre.Text==""|| cmbCinsiyet.Text==""  )
	{
                MessageBox.Show("Tüm alanlara veri girişi yapınız.","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
	}
            else
	{
                  SqlCommand komut = new SqlCommand("insert into Hastalar (ad,soyad,TCno,telefon,sifre,cinsiyet) values (@p1,@p2,@p3,@p4,@p5,@p6)", bag.baglanti());
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", mskTCno.Text);
            komut.Parameters.AddWithValue("@p4", mskTelefon.Text);
            komut.Parameters.AddWithValue("@p5", txtSifre.Text);
            komut.Parameters.AddWithValue("@p6", cmbCinsiyet.Text);
            komut.ExecuteNonQuery();
            bag.baglanti().Close();
            MessageBox.Show("Kaydınız gerçekleşmiştir şifreniz:"+txtSifre.Text,"Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
	}
        }

        private void btnGeriDön_Click(object sender, EventArgs e)
        {
            anaGiris frm = new anaGiris();
            frm.Show();
            this.Hide();
        }
    }
}
