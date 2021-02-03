using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    /// <remarks/>
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.2.0")]
    //[XmlRoot("ImportChargesResponse", Namespace = "urn://roskazna.ru/gisgmp/xsd/services/import-charges/2.2.0", IsNullable = false)]
    public class ImportPackageResponseType : ResponseType
    {
        /// <summary/>
        protected ImportPackageResponseType() { }

        /// <summary/>
        public ImportPackageResponseType(ResponseType configResponse, ImportProtocolType[] importProtocol)
            : base(configResponse) => ImportProtocol = importProtocol;

        /// <remarks/>
        [XmlElement("ImportProtocol")]
        public ImportProtocolType[] ImportProtocol { get; set; }
    }
}