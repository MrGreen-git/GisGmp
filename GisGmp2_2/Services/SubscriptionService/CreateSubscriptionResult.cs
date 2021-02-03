using GisGmp.Subscription;
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.SubscriptionService
{
    /// <remarks/>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/SubscriptionService/2.2.0")]
    public class CreateSubscriptionResult
    {
        /// <summary />
        protected CreateSubscriptionResult() { }

        /// <summary />
        public CreateSubscriptionResult(SubscriptionProtocolType[] subscriptionProtocol) => SubscriptionProtocol = subscriptionProtocol;      

        /// <remarks/>
        [XmlElement("SubscriptionProtocol")]
        public SubscriptionProtocolType[] SubscriptionProtocol { get; set; }

        /// <remarks/>
        [XmlAttribute("dispatchDate")]
        public DateTime DispatchDate { get; set; }

        /// <remarks/>
        [XmlIgnore]
        public bool DispatchDateSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute("expiryDate", DataType = "date")]
        public DateTime ExpiryDate { get; set; }

        /// <remarks/>
        [XmlIgnore]
        public bool ExpiryDateSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute("subscriptionCode")]
        public string SubscriptionCode { get; set; }

        /// <remarks/>
        [XmlAttribute("subscriptionIdentifier")]
        public string SubscriptionIdentifier { get; set; }
    }
}