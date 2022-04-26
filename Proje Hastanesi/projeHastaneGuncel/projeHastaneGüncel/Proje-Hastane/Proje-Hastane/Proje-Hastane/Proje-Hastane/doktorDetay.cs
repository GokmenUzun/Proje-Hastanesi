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
    public partial class doktorDetay : Form
    {
        public doktorDetay()
        {
            InitializeComponent();
        }
        public string TC;
        sqlBaglantisi bag = new sqlBaglantisi();
        private void doktorDetay_Load(object sender, EventArgs e)
        {
            lblTC.Text = TC;
            SqlCommand komut = new SqlCommand("select ad,soyad from doktorlar where TCno=@p1", bag.baglanti());
            komut.Parameters.AddWithValue("@p1", TC);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblAdSoyad.Text = dr[0] + " " + dr[1];
            }
            bag.baglanti().Close();

            SqlCommand komutRandevuCek = new SqlCommand("Select * from randevular", bag.baglanti());
            SqlDataAdapter daRandevuCek = new SqlDataAdapter(komutRandevuCek);
            DataTable dtRandevuCek = new DataTable();
            daRandevuCek.Fill(dtRandevuCek);
            dgvAktifRandevular.DataSource = dtRandevuCek;

            SqlCommand cmdBrans = new SqlCommand("select ad from branslar", bag.baglanti());
            SqlDataReader drBrans = cmdBrans.ExecuteReader();
            while (drBrans.Read())
            {
                cmbBrans.Items.Add(drBrans[0]);
            }
            bag.baglanti().Close();

        }

        private void btnGeriDön_Click(object sender, EventArgs e)
        {
            doktorgirisi frm = new doktorgirisi();
            frm.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoktor.Items.Clear();
            SqlCommand cmdDoktor = new SqlCommand("select ad,soyad from doktorlar where brans=@p1", bag.baglanti());
            cmdDoktor.Parameters.AddWithValue("@p1", cmbBrans.Text);
            SqlDataReader drDoktor = cmdDoktor.ExecuteReader();
            while (drDoktor.Read())
            {
                cmbDoktor.Items.Add(drDoktor[0] + " " + drDoktor[1]);
            }
            bag.baglanti().Close();
        }

        private void cmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dtAktifRandevu = new DataTable();
            SqlDataAdapter daAktifRandevular = new SqlDataAdapter("select * from randevular where durum='0' and brans='" + cmbBrans.Text + "'" + "and doktor ='" + cmbDoktor.Text + "'", bag.baglanti());
            daAktifRandevular.Fill(dtAktifRandevu);
            dgvAktifRandevular.DataSource = dtAktifRandevu;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            doktorBilgiDuzenle frmGuncelle = new doktorBilgiDuzenle();
            frmGuncelle.Show();


        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            doktorBilgiDuzenle frm = new doktorBilgiDuzenle();
            frm.Show();
        }

        private void btnDuyurular_Click(object sender, EventArgs e)
        {
            duyurlarListele frm = new duyurlarListele();
            frm.Show();
           

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}