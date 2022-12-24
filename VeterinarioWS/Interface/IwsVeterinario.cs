using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;
using VeterinarioEN;

namespace VeterinarioWS.Interface
{

    [ServiceContract]
    public interface IwsVeterinario
    {
        [OperationContract]
        UsuarioEN WsAutenticarUsuario(string psCorreo, string psClave);


    }
}