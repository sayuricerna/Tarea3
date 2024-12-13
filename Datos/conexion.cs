using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea3.Datos
{
    public class conexion

    {
        private readonly string varconexion = "Server=localhost\\SQLEXPRESS;Database=master;Trusted_Connection=True";
        public SqlConnection obtenerConexion()
        {
            return new SqlConnection(varconexion);
        }
     
    }
}
