using GisGmp.Common;
using System;
using System.Xml.Serialization;

namespace GisGmp.Payment
{
    /// <summary>
    /// Информация о плательщике
    /// </summary>
    [Serializable()]
    [XmlRoot("Payer", Namespace = "http://roskazna.ru/gisgmp/xsd/Payment/2.1.1")]
    public class PaymentPayer : PayerType
    {
        /// <summary>
        /// Предназначен только для сериализации/десериализации
        /// </summary>
        protected PaymentPayer() { }

        public PaymentPayer(
            string PayerName,
            string PayerIdentifier
            ) : base (PayerIdentifier)
        {
            this.PayerName = PayerName;
        }

        /// <summary>
        /// Поле номер 8: Плательщик [required]
        /// </summary>
        [XmlAttribute("payerName")]
        public string PayerName { get; set; }

        /// <summary>
        /// Поле номер 9: Номер счета плательщика(при наличии) в организации, принявшей платеж
        /// </summary>
        [XmlAttribute("payerAccount")]
        public string PayerAccount { get; set; }
    }
}