using GisGmp.Common;
using System;
using System.Xml.Serialization;

namespace GisGmp.Payment
{
    /// <remarks/>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/Payment/2.2.0")]
    [XmlRoot("Payer", Namespace = "http://roskazna.ru/gisgmp/xsd/Payment/2.2.0", IsNullable = false)]
    public class PaymentPayer : PayerType
    {
        /// <summary />
        protected PaymentPayer() { }

        /// <summary />
        public PaymentPayer(string payerIdentifier, string payerName)
            : base(payerIdentifier) => PayerName = payerName;

        /// <summary />
        public PaymentPayer(string payerIdentifier, string payerName, string payerAccount)
            : this(payerIdentifier, payerName) => PayerAccount = payerAccount;

        /// <summary>
        /// Поле номер 8: Плательщик
        /// </summary>
        [XmlAttribute("payerName")]
        public string PayerName 
        {
            get => _PayerName;
            set => _PayerName = Validator.String(value: ref value, name: nameof(PayerName), required: true, min: 0, max: 160); 
        }

        string _PayerName;


        /// <summary>
        /// Поле номер 9: Номер счета плательщика(при наличии) в организации, принявшей платеж
        /// </summary>
        [XmlAttribute("payerAccount")]
        public string PayerAccount
        {
            get => _PayerAccount;
            set => _PayerAccount = Validator.String(value: ref value, name: nameof(PayerAccount), required: false, min: 0, max: 20);
        }

        string _PayerAccount;
    }
}