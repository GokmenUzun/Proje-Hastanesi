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
    public partial class doktorKayit : Form
    {
        public doktorKayit()
        {
            InitializeComponent();
        }

        private void btnGeriDön_Click(object sender, EventArgs e)
        {
            doktorgirisi frm = new doktorgirisi();
            frm.Show();
            this.Hide();
        }
        sqlBaglantisi bag = new sqlBaglantisi();
        private void btnKayit_Click(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text == "" || txtSoyad.Text == "" || mskTCno.Text == "" ||  txtSifre.Text == "" || cmbCinsiyet.Text == "")
            {
                MessageBox.Show("Tüm alanlara veri girişi yapınız.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlCommand komut = new SqlCommand("insert into doktorlar (ad,soyad,TCno,brans,sifre,cinsiyet) values (@p1,@p2,@p3,@p4,@p5,@p6)", bag.baglanti());
                komut.Parameters.AddWithValue("@p1", txtKullaniciAdi.Text);
                komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
                komut.Parameters.AddWithValue("@p3", mskTCno.Text);
                komut.Parameters.AddWithValue("@p4", cmbBrans.Text);
                komut.Parameters.AddWithValue("@p5", txtSifre.Text);
                komut.Parameters.AddWithValue("@p6", cmbCinsiyet.Text);
                komut.ExecuteNonQuery();
                bag.baglanti().Close();
                MessageBox.Show("Kaydınız gerçekleşmiştir şifreniz:" + txtSifre.Text, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void doktorKayit_Load(object sender, EventArgs e)
        {
            SqlCommand komu = new SqlCommand("select ad from branslar", bag.baglanti());
            SqlDataReader dr = komu.ExecuteReader();
            while (dr.Read())
            {
               cmbBrans.Items.Add(dr[0]);
            }
            bag.baglanti().Close();
        }
    }
}
