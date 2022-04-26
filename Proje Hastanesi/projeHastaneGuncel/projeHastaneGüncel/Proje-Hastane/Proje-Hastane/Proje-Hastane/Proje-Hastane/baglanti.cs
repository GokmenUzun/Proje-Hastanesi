using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje_Hastane
{
    class sqlBaglantisi
    {
        public SqlConnection baglanti()
        {
           // SqlConnection baglan = new SqlConnection("Data Source=ONURCAKAR\\SQLEXPRESS;Initial Catalog=hastane;Integrated Security=True");
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-G79G7E9;Initial Catalog=projeHastanesi;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
