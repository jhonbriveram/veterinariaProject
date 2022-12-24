using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinarioAD.Helpers;
using VeterinarioEN;

namespace VeterinarioAD
{
    public class ADGestion : ADConexion
    {
        public ADGestion(SqlConnection con) {
        conexion= con;
        }
        public UsuarioEN AutenticarUsuario(string sLogin, string sPassWord)
        {
            UsuarioEN oUsuarioEN = null;

            try
            {
                using (SqlCommand cmd = new SqlCommand("SP_AutenticarUsuario", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@pvLogin", SqlDbType.VarChar).Value = sLogin;
                    cmd.Parameters.Add("@pvPass", SqlDbType.VarChar).Value = sPassWord;

                    using (SqlDataReader drd = cmd.ExecuteReader())
                    {
                        if (drd != null)
                        {
                            int pos_IdUsuario = drd.GetOrdinal("idusuario");
                            int pos_Login = drd.GetOrdinal("login");
                            int pos_Password = drd.GetOrdinal("password");
                            int pos_Nombre = drd.GetOrdinal("nombre");
                            int pos_Apellido = drd.GetOrdinal("apellido");
                            int pos_Direccion = drd.GetOrdinal("direccion");
                            int pos_Observacion = drd.GetOrdinal("observacion");
                           // int pos_TipoUsuario = drd.GetOrdinal("idTipoUsuario");

                            while (drd.Read())
                            {
                                oUsuarioEN = new UsuarioEN();

                                oUsuarioEN.iIdUsuario = drd.IsDBNull(pos_IdUsuario) ? 0 : drd.GetInt32(pos_IdUsuario);
                                oUsuarioEN.sLogin = drd.IsDBNull(pos_Login) ? string.Empty : drd.GetString(pos_Login);
                                oUsuarioEN.sPassWord = drd.IsDBNull(pos_Password) ? string.Empty : drd.GetString(pos_Apellido);
                                oUsuarioEN.sNombres = drd.IsDBNull(pos_Nombre) ? string.Empty : drd.GetString(pos_Nombre);
                                oUsuarioEN.sApellidos = drd.IsDBNull(pos_Apellido) ? string.Empty : drd.GetString(pos_Apellido);
                                oUsuarioEN.sDireccion = drd.IsDBNull(pos_Direccion) ? string.Empty : drd.GetString(pos_Direccion);
                                oUsuarioEN.sObservacion = drd.IsDBNull(pos_Observacion) ? string.Empty : drd.GetString(pos_Observacion);
                               // oUsuarioEN.idTipoUsuario = drd.IsDBNull(pos_TipoUsuario) ? 0 : drd.GetInt32(pos_TipoUsuario);

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return oUsuarioEN;
        }
        
    }
}
