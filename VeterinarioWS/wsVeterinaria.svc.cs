using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using VeterinarioEN;
using VeterinarioRN;
using VeterinarioWS.Interface;

namespace VeterinarioWS
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class wsVeterinario : IwsVeterinario
    {

        private GestionRN rnGestion;

        public UsuarioEN WsAutenticarUsuario(string psCorreo, string psClave)
        {
            try
            {
                rnGestion = new GestionRN();
                return rnGestion.AutenticarUsuario(psCorreo, psClave);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
