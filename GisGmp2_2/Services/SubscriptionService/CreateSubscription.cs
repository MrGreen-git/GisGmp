using GisGmp.Subscription;
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.SubscriptionService
{
    /// <remarks/>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/SubscriptionService/2.2.0")]
    public class CreateSubscription
    {
        /// <summary />
        protected CreateSubscription() { }

        /// <summary />
        public CreateSubscription(SubscriptionStatus subscriptionStatus, ItemChoiceType4 itemElementName, string item)
        {
            SubscriptionStatus = subscriptionStatus;
            ItemElementName = itemElementName;
            Item = item;
        }

        /// <remarks/>
        [XmlElement("SubscriptionIdentifier", typeof(string), Namespace = "http://roskazna.ru/gisgmp/xsd/Subscription/2.2.0")]
        [XmlElement("SubscriptionCode", typeof(string))]
        [XmlChoiceIdentifier("ItemElementName")]
        public string Item { get; set; } //TODO [multi]

        /// <remarks/>
        [XmlIgnore]
        public ItemChoiceType4 ItemElementName { get; set; }

       
        /// <remarks/>
        [XmlElement("SubscriptionParameters")]
        public SubscriptionParametersType[] SubscriptionParameters 
        {
            get => _SubscriptionParameters;
            set => _SubscriptionParameters = Validator.ArrayObj(value: value, name: nameof(SubscriptionParameters), required: false, min: 1, max: 250);
        }

        SubscriptionParametersType[] _SubscriptionParameters;

        /// <remarks/>
        [XmlAttribute("subscriptionStatus")]
        public SubscriptionStatus SubscriptionStatus { get; set; }

        /// <remarks/>
        [XmlAttribute("routingCode")]
        public string RoutingCode { get; set; } //TODO [?]
    }
}