using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace GisGmp.Services.ForcedAcknowledgement
{
    /// <remarks/>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/forced-ackmowledgement/2.2.0")]
    public class ServiceProvided
    {
        /// <summary />
        protected ServiceProvided() { }

        /// <summary />
        public ServiceProvided(PaymentIdType[] paymentId) => PaymentId = paymentId;

        /// <remarks/>
        [XmlIgnore]
        public PaymentIdType[] PaymentId { get; set; }

        /// <remarks/>
        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlElement("PaymentId")]
        public string[] WrapperPaymentId { get => PaymentId.ToArrayString(); set => PaymentId = value.ToArray<PaymentIdType>(s => s); }
    }
}