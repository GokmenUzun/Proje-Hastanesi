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
    public partial class doktorBilgiDuzenle : Form
    {
        public doktorBilgiDuzenle()
        {
            InitializeComponent();
        }

        private void doktorBilgiDuzenle_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select ad from branslar", bag.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbBrans.Items.Add(dr[0]);
            }
            bag.baglanti().Close();
        }
        sqlBaglantisi bag = new sqlBaglantisi();
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update doktorlar set ad=@p1,soyad=@p2,brans=@p3,sifre=@p4,cinsiyet=@p5 where TCno=@p6", bag.baglanti());
            komut.Parameters.AddWithValue("@p1", txtKullaniciAdi.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", cmbBrans.Text);
            komut.Parameters.AddWithValue("@p4", txtSifre.Text);
            komut.Parameters.AddWithValue("@p5", cmbCinsiyet.Text);
            komut.Parameters.AddWithValue("@p6", mskTCno.Text);
            komut.ExecuteNonQuery();
            bag.baglanti().Close();
            MessageBox.Show("Bilgileriniz güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);


            SqlCommand cmdBrans = new SqlCommand("select ad from branslar", bag.baglanti());
            SqlDataReader drBrans = cmdBrans.ExecuteReader();
            while (drBrans.Read())
            {
                cmbBrans.Items.Add(drBrans[0]);
            }
            bag.baglanti().Close();

           
        }

        private void mskTCno_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            SqlCommand komutSecilen = new SqlCommand("select * from doktorlar where TCno like  '"+mskTCno.Text+"'", bag.baglanti());
            SqlDataReader read = komutSecilen.ExecuteReader();

            while (read.Read())
            {
                txtKullaniciAdi.Text = read["ad"].ToString();
                txtSoyad.Text = read["soyad"].ToString();
                mskTCno.Text = read["TCno"].ToString();
                txtSifre.Text = read["sifre"].ToString();
                cmbCinsiyet.Text = read["cinsiyet"].ToString();
                cmbBrans.Text = read["brans"].ToString();

            }
        }

        private void btnGeriDön_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
