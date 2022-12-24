using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinarioAD.Helpers;
using VeterinarioAD;
using VeterinarioRN.Helpers;
using VeterinarioEN;

namespace VeterinarioRN
{
    public class GestionRN : ConexionRN
    {
        private ADGestion adGestion;
        public UsuarioEN AutenticarUsuario(string psCorreo, string psClave)
        {
            UsuarioEN oEnUsuario = new UsuarioEN();
            try
            {
                using (SqlConnection con = new SqlConnection(sConexion))
                {
                    con.Open();
                    adGestion = new ADGestion(con);
                    oEnUsuario = adGestion.AutenticarUsuario(psCorreo, psClave);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return oEnUsuario;
        }
    }
}
