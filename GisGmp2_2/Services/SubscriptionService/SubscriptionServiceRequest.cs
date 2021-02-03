using GisGmp.Common;
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.SubscriptionService
{
    /// <remarks/>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/SubscriptionService/2.2.0")]
    [XmlRoot(Namespace = "urn://roskazna.ru/gisgmp/xsd/services/SubscriptionService/2.2.0", IsNullable = false)]
    public class SubscriptionServiceRequest : RequestType
    {
        /// <summary/>
        protected SubscriptionServiceRequest() { }

        /// <summary/>
        public SubscriptionServiceRequest(RequestType config, CreateSubscription createSubscription)
            : base(config) => Item = createSubscription;

        /// <summary/>
        public SubscriptionServiceRequest(RequestType config, bool exportSubscriptions)
            :base(config) => Item = exportSubscriptions;

        /// <remarks/>
        [XmlElement("CreateSubscription", typeof(CreateSubscription))]
        [XmlElement("ExportSubscriptions", typeof(bool))]
        public object Item { get; set; } //TODO [multi]
    }
}