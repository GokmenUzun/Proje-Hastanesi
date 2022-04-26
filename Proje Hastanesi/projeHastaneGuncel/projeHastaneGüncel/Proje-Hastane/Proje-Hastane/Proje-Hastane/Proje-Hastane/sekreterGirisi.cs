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
    public partial class sekreterGirisi : Form
    {
        public sekreterGirisi()
        {
            InitializeComponent();
        }
        sqlBaglantisi bag=new sqlBaglantisi();
        int hak = 3;
        private void btnGiriş_Click(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text == "" && txtSifre.Text == "")
            {
                MessageBox.Show("boş alan bırakmayınız");
            }
            else
            {
                
                SqlCommand komut = new SqlCommand("select * from sekreterler where TCno=@p1 and sifre=@p2", bag.baglanti());

                
                komut.Parameters.AddWithValue("@p1", txtKullaniciAdi.Text);
                komut.Parameters.AddWithValue("@p2", txtSifre.Text);

                
                SqlDataReader dr = komut.ExecuteReader();

                
                if (dr.Read())
                {
                   
                    sekreterDetay frm = new sekreterDetay();

                    
                    frm.TC = txtKullaniciAdi.Text;
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Giriş bilgileriniz eksik yada hatalı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    hak -= 1;
                    lblHak.Text = hak.ToString();
                    if (hak == 0)
                    {
                        MessageBox.Show("Size verilen hak dolmuştur, program kilitleniyor!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtKullaniciAdi.Enabled = false;
                        txtSifre.Enabled = false;
                        btnGiriş.Enabled = false;

                    }
                }

            }
        }

        private void btnGeriDön_Click(object sender, EventArgs e)
        {
            anaGiris frm = new anaGiris();
            frm.Show();
            this.Hide();
        }

        private void btnUyeOl_Click(object sender, EventArgs e)
        {
            sekreterKayit frm = new sekreterKayit();
            frm.Show();
            this.Hide();
        }
    }
}
