using GisGmp.Common;
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.SubscriptionService
{
    /// <remarks/>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/SubscriptionService/2.2.0")]
    [XmlRoot(Namespace = "urn://roskazna.ru/gisgmp/xsd/services/SubscriptionService/2.2.0", IsNullable = false)]
    public class SubscriptionServiceResponse : ResponseType
    {
        /// <summary/>
        protected SubscriptionServiceResponse() { }

        /// <summary/>
        public SubscriptionServiceResponse(ResponseType config, CreateSubscriptionResult[] createSubscriptionResult)
            : base(config) => Items = createSubscriptionResult;

        /// <summary/>
        public SubscriptionServiceResponse(ResponseType config, Subscriptions[] subscriptions)
            : base(config) => Items = subscriptions;

        /// <remarks/>
        [XmlElement("CreateSubscriptionResult", typeof(CreateSubscriptionResult))]
        [XmlElement("Subscriptions", typeof(Subscriptions))]
        public object[] Items { get; set; } //TODO [multi]
    }
}