using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFServicePQR
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IWSPQR
    {

        [OperationContract]
        List<DatosSuscriptor> obtenerDatosSuscriptor(long nuIdsuscriptor);

        [OperationContract]
        List<DatosFactura> obtenerDatosFactura(long nuIdsuscriptor);

        [OperationContract]
        List<DatosCuponPago> obtenerDatosCuponPago(long nuIdcuponpago);

        [OperationContract]
        Boolean obtenerEstadoFacturacion(long nuIdcuponpago);

        [OperationContract]
        List<DatosCuponPago> generarDatosCuponPago(long nuIdSuscriptor, int nuValorCuponPago, long nuIdCuentaCobro);

    }


}
