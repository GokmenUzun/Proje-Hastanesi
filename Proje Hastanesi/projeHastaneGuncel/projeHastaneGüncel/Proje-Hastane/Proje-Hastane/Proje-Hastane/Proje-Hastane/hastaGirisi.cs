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
    public partial class hastaGirisi : Form
    {
        public hastaGirisi()
        {
            InitializeComponent();
        }

        private void btnUyeOl_Click(object sender, EventArgs e)
        {
            hastaKayit frm = new hastaKayit();
            frm.Show();
            this.Hide();
        }
        int hak = 3;
        //------------------
        sqlBaglantisi bag = new sqlBaglantisi();
        private void btnGiriş_Click(object sender, EventArgs e)
        {

            if (txtKullaniciAdi.Text == "" && txtSifre.Text == "")
            {
                MessageBox.Show("boş alan bırakmayınız");
            }

            else
            {

                
                SqlCommand komut = new SqlCommand("select * from hastalar where TCno=@p1 and sifre=@p2", bag.baglanti());

                
                komut.Parameters.AddWithValue("@p1", txtKullaniciAdi.Text);
                komut.Parameters.AddWithValue("@p2", txtSifre.Text);

     
                SqlDataReader dr = komut.ExecuteReader();

                if (dr.Read())
                {
                    hastaDetay frm = new hastaDetay();

                    frm.TC = txtKullaniciAdi.Text;
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    hak--;
                    lblHak.Text = hak.ToString();
                    if (hak==0)
                    {
                        MessageBox.Show("Size verilen hak dolmuştur, program kilitleniyor!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtKullaniciAdi.Enabled = false;
                        txtSifre.Enabled = false;
                        btnGiriş.Enabled = false;
                    }
                    MessageBox.Show("Giriş bilgileriniz eksik yada hatalı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
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
