using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Progra1Bot.Clases
{
    class clsprodal
    {
        public static int agregar(clscliente pclscliente)
        {
            int retorno = 0;
            using (SqlConnection conn = clsconexion.obtener_conexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("insert into TB_cliente(recargas,consultas)values('{0}','{1}')",
                    pclscliente.recargas, pclscliente.consultas), conn);

                retorno = comando.ExecuteNonQuery();
            }
            return retorno;
        }
    }
}
