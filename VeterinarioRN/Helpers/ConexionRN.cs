using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinarioRN.Helpers
{
    public class ConexionRN
    {
        public String sConexion { get; set; }

        public ConexionRN()
        {
            sConexion = ConfigurationManager.ConnectionStrings["conConexion"].ConnectionString;
        }
    }
}
