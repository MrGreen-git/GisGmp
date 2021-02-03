using System;
using System.Xml.Serialization;

namespace GisGmp.Common.Nsi
{
    /// <remarks/>
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Common-nsi/2.2.0")]
    [XmlRoot("directoryOKTMO", Namespace = "urn://roskazna.ru/gisgmp/xsd/services/SubscriptionService/attachments/directoryOKTMO/2.2.0", IsNullable = false)]
    public class directoryOKTMOType
    {
        /// <remarks/>
        [XmlElement("oktmoNSIInfo")]
        public oktmoNSIInfoType[] oktmoNSIInfo { get; set; }
    }
}