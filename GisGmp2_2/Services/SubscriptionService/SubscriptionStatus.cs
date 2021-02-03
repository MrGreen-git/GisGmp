using System;
using System.Xml.Serialization;

namespace GisGmp.Services.SubscriptionService
{
    /// <remarks/>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/SubscriptionService/2.2.0")]
    public enum SubscriptionStatus
    {
        /// <remarks/>
        [XmlEnum("1")]
        Item1,

        /// <remarks/>
        [XmlEnum("2")]
        Item2,

        /// <remarks/>
        [XmlEnum("3")]
        Item3,
    }
}