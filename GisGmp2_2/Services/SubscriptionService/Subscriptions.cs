using System;
using System.Xml.Serialization;

namespace GisGmp.Services.SubscriptionService
{
    /// <remarks/>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/SubscriptionService/2.2.0")]
    public class Subscriptions
    {
        /// <summary />
        protected Subscriptions() { }

        /// <summary />
        public Subscriptions(string subscriptionCode, string subscriptionName, string subscriptionOperation)
        {
            SubscriptionCode = subscriptionCode;
            SubscriptionName = subscriptionName;
            SubscriptionOperation = subscriptionOperation;
        }

        /// <summary />
        public Subscriptions(string subscriptionCode, string subscriptionName, string subscriptionOperation, SubscriptionParameter[] subscriptionParameter)
            : this(subscriptionCode, subscriptionName, subscriptionOperation) => SubscriptionParameter = subscriptionParameter;

       
        /// <remarks/>
        [XmlElement("SubscriptionParameter")]
        public SubscriptionParameter[] SubscriptionParameter 
        {
            get => _SubscriptionParameter;
            set => _SubscriptionParameter = Validator.ArrayObj(value: value, name: nameof(SubscriptionParameter), required: false, min: 1, max: 10);
        }

        SubscriptionParameter[] _SubscriptionParameter;

        /// <remarks/>
        [XmlAttribute("subscriptionCode")]
        public string SubscriptionCode { get; set; } //TODO [?]
        
        /// <remarks/>
        [XmlAttribute("subscriptionName")]
        public string SubscriptionName 
        {
            get => _SubscriptionName;
            set => _SubscriptionName = Validator.String(value: ref value, name: nameof(SubscriptionName), required: true, min: 0, max: 2000);
        }

        string _SubscriptionName;
       
        /// <remarks/>
        [XmlAttribute("subscriptionOperation")]
        public string SubscriptionOperation
        {
            get => _SubscriptionOperation;
            set => _SubscriptionOperation = Validator.String(value: ref value, name: nameof(SubscriptionOperation), required: true, min: 0, max: 2000);
        }

        string _SubscriptionOperation;
    }
}