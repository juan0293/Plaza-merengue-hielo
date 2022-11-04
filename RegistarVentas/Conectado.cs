using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace RegistarVentas
{
    public class Conectado
    {
        public static SqlConnection conexion()
        {
            SqlConnection Con = new SqlConnection(@"Data source = .\SQLEXPRESS; initial Catalog = beuty; integrated security = true");
            Con.Open();

            return Con;
        }
    }
}
