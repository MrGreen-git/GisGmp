using GisGmp.Common;
using System;
using System.Xml.Serialization;

namespace GisGmp.NoticeCharge
{
    /// <remarks/>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/NoticeCharge/2.2.0")]
    public class NoticeChargeTypePayer : PayerType
    {
        /// <remarks/>
        [XmlAttribute]
        public string payerName { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string additionalPayerIdentifier { get; set; }
    }
}