using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace GisGmp.Services.ForcedAcknowledgement
{
    /// <remarks/>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/forced-ackmowledgement/2.2.0")]
    public class AnnulmentServiceProvided
    {
        /// <summary />
        protected AnnulmentServiceProvided() { }

        /// <summary />
        public AnnulmentServiceProvided(PaymentIdType[] paymentId) => PaymentId = paymentId;

        /// <remarks/>
        [XmlIgnore]
        public PaymentIdType[] PaymentId 
        {
            get => _PaymentId;
            set => _PaymentId = Validator.ArrayObj(value: value, name: nameof(PaymentId), required: true, min: 1, max: 100);
        }

        PaymentIdType[] _PaymentId;

        /// <remarks/>
        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlElement("PaymentId")]
        public string[] WrapperPaymentId { get; set; }
    }
}