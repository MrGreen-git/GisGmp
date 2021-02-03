using System;
using System.Xml.Serialization;

namespace GisGmp.Services.SubscriptionService
{
    /// <remarks/>
    [Serializable]
    [XmlType(Namespace = "urn://roskazna.ru/gisgmp/xsd/services/SubscriptionService/2.2.0", IncludeInSchema = false)]
    public enum ItemChoiceType4
    {
        /// <remarks/>
        [XmlEnum("http://roskazna.ru/gisgmp/xsd/Subscription/2.2.0:SubscriptionIdentifier")]
        SubscriptionIdentifier,

        /// <remarks/>
        SubscriptionCode,
    }
}