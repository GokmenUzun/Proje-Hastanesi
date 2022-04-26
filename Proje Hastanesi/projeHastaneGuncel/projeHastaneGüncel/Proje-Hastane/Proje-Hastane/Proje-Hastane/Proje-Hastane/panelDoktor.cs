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
    public partial class panelDoktor : Form
    {
        public panelDoktor()
        {
            InitializeComponent();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (mskTCno.Text == "")
            {
                MessageBox.Show("Önce kayıt seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlCommand komut = new SqlCommand("update doktorlar set ad=@p1,soyad=@p2,brans=@p3,sifre=@p4 where TCno=@p0 ", bag.baglanti());
                komut.Parameters.AddWithValue("@p0", mskTCno.Text);
                komut.Parameters.AddWithValue("@p1", txtKullaniciAdi.Text);
                komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
                komut.Parameters.AddWithValue("@p3", cmbBrans.Text);
                komut.Parameters.AddWithValue("@p4", txtSifre.Text);
                komut.ExecuteNonQuery();
                MessageBox.Show("Bilgileriniz güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
       
            }
        }
        sqlBaglantisi bag = new sqlBaglantisi();
        private void btnKaydet_Click(object sender, EventArgs e)
        {

            SqlCommand komut = new SqlCommand("insert into doktorlar  (ad,soyad,brans,TCno,sifre) values (@p1,@p2,@p3,@p4,@p5)", bag.baglanti());
            komut.Parameters.AddWithValue("@p1", txtKullaniciAdi.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", cmbBrans.Text);
            komut.Parameters.AddWithValue("@p4", mskTCno.Text);
            komut.Parameters.AddWithValue("@p5", txtSifre.Text);
            
            komut.ExecuteNonQuery();
            bag.baglanti().Close();
            MessageBox.Show("Doktor başarıyla kaydedildi!");

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from doktorlar", bag.baglanti());
            da.Fill(dt);
            dgwDoktorlar.DataSource = dt;

        }

        private void panelDoktor_Load(object sender, EventArgs e)
        {
            SqlCommand cmdBrans = new SqlCommand("select ad from branslar", bag.baglanti());
            SqlDataReader drBrans = cmdBrans.ExecuteReader();
            while (drBrans.Read())
            {
                cmbBrans.Items.Add(drBrans[0]);
            }
            bag.baglanti().Close();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from doktorlar", bag.baglanti());
            da.Fill(dt);
            dgwDoktorlar.DataSource = dt;

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komutBransSil = new SqlCommand("delete from doktorlar where TCno=@p1", bag.baglanti());
            komutBransSil.Parameters.AddWithValue("@p1", mskTCno.Text);
            komutBransSil.ExecuteNonQuery();
            bag.baglanti().Close();
            MessageBox.Show("Sectiğiniz Branş silindi");
        }

        private void dgwDoktorlar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtKullaniciAdi.Text = dgwDoktorlar.CurrentRow.Cells[1].Value.ToString();
            txtSoyad.Text = dgwDoktorlar.CurrentRow.Cells[2].Value.ToString();
            mskTCno.Text = dgwDoktorlar.CurrentRow.Cells[3].Value.ToString();
            cmbBrans.Text = dgwDoktorlar.CurrentRow.Cells[4].Value.ToString();
            txtSifre.Text = dgwDoktorlar.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnGeriDön_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
