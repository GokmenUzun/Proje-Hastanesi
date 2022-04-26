using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Hastane
{
    public partial class hastaBilgiDuzenle : Form
    {
        public hastaBilgiDuzenle()
        {
            InitializeComponent();
        }

        public string TCno;
        sqlBaglantisi bag = new sqlBaglantisi();
        private void hastaBilgiDuzenle_Load(object sender, EventArgs e)
        {
            mskTCno.Text = TCno;
            SqlCommand komut = new SqlCommand("select * from hastalar where TCno=@p1", bag.baglanti());
            komut.Parameters.AddWithValue("@p1", mskTCno.Text);
            SqlDataReader dr=komut.ExecuteReader();
            while (dr.Read())
            {
                txtAdi.Text = dr[1].ToString();
                txtSoyad.Text = dr[2].ToString();
                mskTelefon.Text = dr[4].ToString();
                txtSifre.Text = dr[5].ToString();
                cmbCinsiyet.Text = dr[6].ToString();
            }
            bag.baglanti().Close();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update hastalar set ad=@p1,soyad=@p2,telefon=@p3,sifre=@p4,cinsiyet=@p5 where TCno=@p6",bag.baglanti());
            komut.Parameters.AddWithValue("@p1", txtAdi.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", mskTelefon.Text);
            komut.Parameters.AddWithValue("@p4", txtSifre.Text);
            komut.Parameters.AddWithValue("@p5", cmbCinsiyet.Text);
            komut.Parameters.AddWithValue("@p6", mskTCno.Text);
            komut.ExecuteNonQuery();
            bag.baglanti().Close();
            MessageBox.Show("Bilgileriniz güncellendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnGeriDön_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
