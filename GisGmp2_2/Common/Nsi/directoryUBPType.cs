using System;
using System.Xml.Serialization;

namespace GisGmp.Common.Nsi
{
    /// <remarks/>
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Common-nsi/2.2.0")]
    [XmlRoot("directoryUBP", Namespace = "urn://roskazna.ru/gisgmp/xsd/services/SubscriptionService/attachments/directoryUBP/2.1.3", IsNullable = false)]
    public class directoryUBPType
    {
        /// <remarks/>
        [XmlElement("PayeeNSIInfo")]
        public PayeeNSIInfoType[] PayeeNSIInfo { get; set; }
    }
}