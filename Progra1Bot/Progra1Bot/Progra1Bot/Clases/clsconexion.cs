
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra1Bot.Clases
{
    class clsconexion


    {
        public static SqlConnection obtener_conexion()
        {
            SqlConnection conn = new SqlConnection("data source=UMG-VM\\SQLEXPRESS; initial catalog=DBBOT;integrated security=true");
            conn.Open();
            return conn;
        }


    }
}


