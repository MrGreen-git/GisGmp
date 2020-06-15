using System;
using System.Xml.Serialization;
using GisGmp.Common;

namespace GisGmp.Services.ImportPayments
{
    [Serializable()]
    [XmlRoot("ImportPaymentsResponse", Namespace = "urn://roskazna.ru/gisgmp/xsd/services/import-payments/2.1.1")]
    public class ImportPaymentsResponse : ImportPackageResponseType
    {
        protected ImportPaymentsResponse() { }

        public ImportPaymentsResponse(ResponseType config, ImportProtocolType[] importProtocol) 
            : base(config, importProtocol)
        { }
    }
}
