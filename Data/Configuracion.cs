using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Configuracion
    {
        public static string CONEXION_MAIN(string DataSource)
        {
            Source.Main(DataSource);
            return "Data Source=" + ConnectionString.DataSource + ";Initial Catalog=" + ConnectionString.DataBase + ";User ID=" + ConnectionString.User + ";Password=" + ConnectionString.Password + ";";
        }
    }
}
