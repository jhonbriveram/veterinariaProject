using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace VeterinarioEN
{
    [DataContract]
    public class BaseEN
    {
        [DataMember]
        public bool bEstado { get; set; }
        [DataMember]
        public string sFechaRegistro { get; set; }
        [DataMember]
        public string sRespuesta { get; set; }
        [DataMember]
        public string sEstado { get; set; }

        //Paginación
        [DataMember]
        public int iNumeroFila { set; get; }
        [DataMember]
        public int iNumeroPagina { set; get; }
        [DataMember]
        public int iNumeroRegistros { set; get; }
        [DataMember]
        public int iTotalRegistros { set; get; }
    }
}
