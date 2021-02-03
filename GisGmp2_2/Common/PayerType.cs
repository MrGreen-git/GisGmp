using GisGmp.Charge;
using GisGmp.Payment;
using GisGmp.Refund;
using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    /// <remarks/>
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.2.0")]
    public class PayerType
    {
        /// <remarks />
        protected PayerType() { }

        /// <remarks />
        public PayerType(string payerIdentifier) => PayerIdentifier = payerIdentifier;

        /// <remarks/>
        [XmlAttribute("payerIdentifier")]
        public string PayerIdentifier { get; set; }
    }
}
