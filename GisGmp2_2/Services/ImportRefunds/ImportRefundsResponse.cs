using GisGmp.Common;
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ImportRefunds
{
    /// <summary/>
    [Serializable()]
    [XmlRoot("ImportRefundsResponse", Namespace = "urn://roskazna.ru/gisgmp/xsd/services/import-refunds/2.2.0")]
    public class ImportRefundsResponse : ImportPackageResponseType
    {
        /// <summary/>
        protected ImportRefundsResponse() { }

        /// <summary/>
        public ImportRefundsResponse(ResponseType config, ImportProtocolType[] importProtocol)
            : base(config, importProtocol)
        {
        }
    }
}