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
    public partial class hastaDetay : Form
    {
        public hastaDetay()
        {
            InitializeComponent();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            hastaBilgiDuzenle frm = new hastaBilgiDuzenle();
            frm.TCno = lblTC.Text;
            frm.Show();
            
        }
        public string TC;
        sqlBaglantisi bag = new sqlBaglantisi();
        private void hastaDetay_Load(object sender, EventArgs e)
        {
            //hasta ad soyadı çekme
            lblTC.Text = TC;
            SqlCommand komut = new SqlCommand("select ad,soyad from hastalar where TCno=@p1",bag.baglanti());
            komut.Parameters.AddWithValue("@p1", TC);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                lblAdSoyad.Text = dr[0] +" "+ dr[1];
            }
            bag.baglanti().Close();

            //randevu geçmişi
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from randevular where durum='1' and TCno="+lblTC.Text, bag.baglanti());
            da.Fill(dt);
            dgvRandevuGecmisi.DataSource = dt;

            //aktif randevular
            DataTable dtAktifRandevu = new DataTable();
            SqlDataAdapter daAktifRandevu = new SqlDataAdapter("select * from randevular where durum='0'", bag.baglanti());
            daAktifRandevu.Fill(dtAktifRandevu);
            dgvAktifRandevular.DataSource = dtAktifRandevu;

            //branşları çekelim
            SqlCommand cmdBrans = new SqlCommand("select ad from branslar", bag.baglanti());
            SqlDataReader drBrans = cmdBrans.ExecuteReader();
            while (drBrans.Read())
            {
                cmbBrans.Items.Add(drBrans[0]);
            }
            bag.baglanti().Close();
        }

        private void cmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoktor.Items.Clear();
            SqlCommand cmdDoktor = new SqlCommand("select ad,soyad from doktorlar where brans=@p1", bag.baglanti());
            cmdDoktor.Parameters.AddWithValue("@p1", cmbBrans.Text);
            SqlDataReader drDoktor = cmdDoktor.ExecuteReader();
            while(drDoktor.Read())
            {
                cmbDoktor.Items.Add(drDoktor[0] + " " + drDoktor[1]);
            }
            bag.baglanti().Close();
        }

        private void lblDuzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            hastaBilgiDuzenle frm=new hastaBilgiDuzenle();
            frm.Show();
            this.Hide();
        }

        private void btnGeriDön_Click(object sender, EventArgs e)
        {
            hastaGirisi frm = new hastaGirisi();
            frm.Show();
            this.Hide();
        }

        private void btnRandevuAl_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update randevular set durum='1' ,TCno=@p1,sikayet=@p2 where id=@p3", bag.baglanti());
            komut.Parameters.AddWithValue("@p1", lblTC.Text);
            komut.Parameters.AddWithValue("@p2", rtbSikayet.Text);
            komut.Parameters.AddWithValue("@p3", lblRandevuId.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Randevu başarıyla alındı "+" "+rtbSikayet.Text,"Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);

            DataTable dtAktifRandevu2 = new DataTable();
            SqlDataAdapter daAktifRandevular2 = new SqlDataAdapter("select * from randevular where durum='0' and brans='" + cmbBrans.Text + "'" + "and doktor ='" + cmbDoktor.Text + "'", bag.baglanti());
            daAktifRandevular2.Fill(dtAktifRandevu2);
            dgvAktifRandevular.DataSource = dtAktifRandevu2;

            DataTable dtAktifRandevu = new DataTable();
            SqlDataAdapter daAktifRandevular = new SqlDataAdapter("select * from randevular where durum='1' and TCno="+lblTC.Text, bag.baglanti());
            daAktifRandevular.Fill(dtAktifRandevu);
            dgvRandevuGecmisi.DataSource = dtAktifRandevu;
        }

        private void cmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dtAktifRandevu = new DataTable();
            SqlDataAdapter daAktifRandevular = new SqlDataAdapter("select * from randevular where durum='0' and brans='" + cmbBrans.Text+"'" + "and doktor ='" + cmbDoktor.Text + "'", bag.baglanti());
            daAktifRandevular.Fill(dtAktifRandevu);
            dgvAktifRandevular.DataSource = dtAktifRandevu;
        }

        private void dgvAktifRandevular_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvAktifRandevular_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dgvAktifRandevular.SelectedCells[0].RowIndex;
            lblRandevuId.Text = dgvAktifRandevular.Rows[secilen].Cells[0].Value.ToString();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
