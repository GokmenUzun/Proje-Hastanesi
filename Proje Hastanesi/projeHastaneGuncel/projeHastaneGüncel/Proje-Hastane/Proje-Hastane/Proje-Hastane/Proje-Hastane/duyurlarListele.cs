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
    public partial class duyurlarListele : Form
    {
        public duyurlarListele()
        {
            InitializeComponent();
        }
        sqlBaglantisi bag = new sqlBaglantisi();
        private void duyurlarListele_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select icerigi from duyurular", bag.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);

            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bag.baglanti().Close();
        }
    }
}
