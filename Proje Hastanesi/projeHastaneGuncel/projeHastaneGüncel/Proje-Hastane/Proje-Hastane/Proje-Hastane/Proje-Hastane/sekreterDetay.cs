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
    public partial class sekreterDetay : Form
    {
        public sekreterDetay()
        {
            InitializeComponent();
        }
        public string TC;

        private void btnDoktorPanel_Click(object sender, EventArgs e)
        {
            panelDoktor frm2 = new panelDoktor();
            frm2.Show();
          
        }

        private void btnGeriDön_Click(object sender, EventArgs e)
        {
            sekreterGirisi frm = new sekreterGirisi();
            frm.Show();
            this.Hide();

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (mskSaat.Text=="" || cmbBrans.Text==""|| cmbDoktor.Text=="")
            {
                MessageBox.Show("Tüm alanlara veri girişi yapınız.","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                SqlCommand komutRandevu = new SqlCommand("insert into randevular (tarih,saat,brans,doktor,TCno,durum) values (@p1,@p2,@p3,@p4,@p5,@p6)", bag.baglanti());
                komutRandevu.Parameters.AddWithValue("@p1", mskTarıh.Text);
                komutRandevu.Parameters.AddWithValue("@p2", mskSaat.Text);
                komutRandevu.Parameters.AddWithValue("@p3", cmbBrans.Text);
                komutRandevu.Parameters.AddWithValue("@p4", cmbDoktor.Text);
                komutRandevu.Parameters.AddWithValue("@p5", mskTCno.Text);
                komutRandevu.Parameters.AddWithValue("@p6", chckbxDurum.Checked);
                komutRandevu.ExecuteNonQuery();
                bag.baglanti().Close();
                MessageBox.Show("Randevu başarıyla oluşturuldu!");
            }


            
        }
        sqlBaglantisi bag = new sqlBaglantisi();
        private void cmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoktor.Items.Clear();
            SqlCommand komutDoktor = new SqlCommand("select ad,soyad from doktorlar where brans=@p1", bag.baglanti());
            komutDoktor.Parameters.AddWithValue("@p1", cmbBrans.Text);
            SqlDataReader drDoktor = komutDoktor.ExecuteReader();
            while (drDoktor.Read())
            {
                cmbDoktor.Items.Add(drDoktor[0] + " " + drDoktor[1]);
            }
            bag.baglanti().Close();
        }

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            SqlCommand komutRandevu = new SqlCommand("insert into duyurular (icerigi) values (@p1)", bag.baglanti());
            komutRandevu.Parameters.AddWithValue("@p1", rtcDuyuru.Text);
           komutRandevu.ExecuteNonQuery();
            bag.baglanti().Close();
            MessageBox.Show("Duyuru oluşturuldu ","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

        private void dgwBranslar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
            
        }

        private void btnBransPanel_Click(object sender, EventArgs e)
        {
            panelBrans frm3 = new panelBrans();
            frm3.Show();
            
        }

        private void btnRandevuPanel_Click(object sender, EventArgs e)
        {
            randevuListesi frm4 = new randevuListesi();
            frm4.Show();
           
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            if (mskTCno.Text=="")
            {
                MessageBox.Show("Lütfen boş değer bırakmayın!");
            }
            else
            {
                SqlCommand komut = new SqlCommand("update randevular set tarih=@p1,saat=@p2,brans=@p3,doktor=@p4,TCno=@p5 where id=@p1", bag.baglanti());
                komut.Parameters.AddWithValue("@p1", mskTarıh.Text);
                komut.Parameters.AddWithValue("@p2", mskSaat.Text);
                komut.Parameters.AddWithValue("@p3", cmbBrans.Text);
                komut.Parameters.AddWithValue("@p4", cmbDoktor.Text);
                komut.Parameters.AddWithValue("@p5", mskTCno.Text);
                komut.ExecuteNonQuery();
                bag.baglanti().Close();
                MessageBox.Show("Bilgileriniz güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
       
        private void sekreterDetay_Load(object sender, EventArgs e)
        {
            lblTC.Text = TC;
            SqlCommand komut = new SqlCommand("select ad,soyad from sekreterler where TCno=@p1", bag.baglanti());
            komut.Parameters.AddWithValue("@p1", TC);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblAdSoyad.Text = dr[0] + " " + dr[1];
            }
            bag.baglanti().Close();


            SqlCommand komutBransCek = new SqlCommand("Select * from branslar", bag.baglanti());
            SqlDataAdapter daBrans = new SqlDataAdapter(komutBransCek);
            DataTable dt = new DataTable();
            daBrans.Fill(dt);
           dgwBranslar.DataSource = dt;

            SqlCommand komutDoktorCek = new SqlCommand("Select * from doktorlar", bag.baglanti());
            SqlDataAdapter daDoktor = new SqlDataAdapter(komutDoktorCek);
            DataTable dtDoktor = new DataTable();
            daDoktor.Fill(dtDoktor);
           dgwDoktorlar.DataSource = dtDoktor;
           SqlCommand komu = new SqlCommand("select ad from branslar", bag.baglanti());
           SqlDataReader dr2 = komu.ExecuteReader();
           while (dr2.Read())
           {
               cmbBrans.Items.Add(dr2[0]);
           }
           bag.baglanti().Close();
        }
       // int durum = 0;
        private void Durum_CheckedChanged(object sender, EventArgs e)
        {
          //  SqlCommand komutGüncelle = new SqlCommand("update randevular set durum=@p1 where id=@p1", bag.baglanti());
          // komutGüncelle.Parameters.AddWithValue("@p1", Durum.CheckedChanged=true);
          // komutGüncelle.Parameters.AddWithValue("@p2", txtID.Text);
           
          //komutGüncelle.ExecuteNonQuery();
          // bag.baglanti().Close();
        }

        private void cmbDurum_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
