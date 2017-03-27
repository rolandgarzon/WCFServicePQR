using System.Runtime.Serialization;

namespace WCFServicePQR
{
    [DataContract]
    public class BaseRespuesta
    {
        [DataMember]
        public string MensajeRespuestaOk { get; set; }
        [DataMember]
        public string MensajeRespuestaError { get; set; }
    }
}