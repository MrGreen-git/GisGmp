using GisGmp.Common;
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ImportPayments
{
    /// <summary />
    [Serializable()]
    [XmlRoot("ImportPaymentsResponse", Namespace = "urn://roskazna.ru/gisgmp/xsd/services/import-payments/2.2.0")]
    public class ImportPaymentsResponse : ImportPackageResponseType
    {
        /// <summary/>
        protected ImportPaymentsResponse() { }

        /// <summary/>
        public ImportPaymentsResponse(ResponseType config, ImportProtocolType[] importProtocol)
            : base(config, importProtocol) { }       
    }
}