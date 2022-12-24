using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinarioAD.Helpers;

namespace VeterinarioAD
{
    public class MantenedorAD: ADConexion
    {
        public MantenedorAD(SqlConnection con) { 
            conexion= con;
        }
    }
}
