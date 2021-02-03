using System;

using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace GisGmp
{
    /// <summary>
    /// УИП
    /// </summary>
    public class PaymentIdType : IConvertToString
    {
        /// <summary/>
        public string Value { get; set; }

        /// <summary/>
        public PaymentIdType(string PaymentIdType) //TODO [regex]
        {
            
            if (PaymentIdType is null) throw new Exception("УИП не может иметь значение null");
            Value = PaymentIdType;
        }

        /// <summary/>
        public override string ToString() => Value;

        /// <summary/>
        public static implicit operator PaymentIdType(string paymentIdType) => new PaymentIdType(paymentIdType);

        /// <summary/>
        public static implicit operator string(PaymentIdType paymentIdType) => paymentIdType?.Value;
    }
}