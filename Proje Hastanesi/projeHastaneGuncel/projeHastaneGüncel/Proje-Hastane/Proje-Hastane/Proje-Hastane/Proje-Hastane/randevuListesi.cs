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
    public partial class randevuListesi : Form
    {
        public randevuListesi()
        {
            InitializeComponent();
        }
        sqlBaglantisi bag = new sqlBaglantisi();
        private void randevuListesi_Load(object sender, EventArgs e)
        {
            DataTable dtRandevu = new DataTable();
            SqlDataAdapter daRandevu = new SqlDataAdapter("select * from randevular", bag.baglanti());
            daRandevu.Fill(dtRandevu);
            dgwRandevuListesi.DataSource = dtRandevu;
        }
    }
}
