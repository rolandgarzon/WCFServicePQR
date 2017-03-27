using System;
using System.Runtime.Serialization;

namespace WCFServicePQR
{
    public class DatosFactura : BaseRespuesta
    {

        [DataMember]
        public long nuIdSuscriptor { get; set; }

        [DataMember]
        public string vaNombre { get; set; }

        [DataMember]
        public double valortotalfacturado { get; set; }

        [DataMember]
        public DateTime daFechaGeneracion { get; set; }

        [DataMember]
        public long nuIdCuentaCobro { get; set; }

        [DataMember]
        public int nuIdPais { get; set; }

        [DataMember]
        public int nuIdDepartamento { get; set; }

        [DataMember]
        public int nuIdMunicipio { get; set; }
    }
}