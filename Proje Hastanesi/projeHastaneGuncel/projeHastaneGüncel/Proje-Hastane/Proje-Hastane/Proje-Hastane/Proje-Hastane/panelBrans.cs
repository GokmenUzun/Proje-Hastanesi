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
    public partial class panelBrans : Form
    {
        public panelBrans()
        {
            InitializeComponent();
        }
        sqlBaglantisi bag = new sqlBaglantisi();
        private void dgwBrans_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dgwBrans.SelectedCells[0].RowIndex;
            lblBransID.Text = dgwBrans.Rows[secilen].Cells[0].Value.ToString();
            txtBransAdi.Text = dgwBrans.Rows[secilen].Cells[1].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komutBransSil = new SqlCommand("delete from branslar where id=@p1", bag.baglanti());
            komutBransSil.Parameters.AddWithValue("@p1", lblBransID.Text);
            komutBransSil.ExecuteNonQuery();
            bag.baglanti().Close();
            MessageBox.Show("Sectiğiniz Branş silindi");
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtBransAdi.Text=="")
            {
                MessageBox.Show("Tüm alanlara veri girişi yapınız.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlCommand komut = new SqlCommand("insert into branslar (ad) values (@p1)", bag.baglanti());
                komut.Parameters.AddWithValue("@p1", txtBransAdi.Text);
                komut.ExecuteNonQuery();
                bag.baglanti().Close();
                MessageBox.Show("Branş başarıyla kayıt edildi!");
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update branslar set ad=@p1 where id=@p2",bag.baglanti() );
            komut.Parameters.AddWithValue("@p1", txtBransAdi.Text);
            komut.Parameters.AddWithValue("@p2",lblBransID.Text);
            komut.ExecuteNonQuery();
            bag.baglanti().Close();
            MessageBox.Show("Bilgileriniz güncellendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void panelBrans_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from branslar", bag.baglanti());
            da.Fill(dt);
            dgwBrans.DataSource = dt;
        }
        }
    }

