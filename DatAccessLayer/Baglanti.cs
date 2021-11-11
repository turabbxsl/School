using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DatAccessLayer
{
    public class Baglanti
    {
        public static SqlConnection bg = new SqlConnection(@"Data Source = localhost; Initial Catalog = MEKTEB; Integrated Security = True");
         
    }
}
