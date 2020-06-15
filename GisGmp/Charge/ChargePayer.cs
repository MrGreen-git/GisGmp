using GisGmp.Common;
using System;
using System.Xml.Serialization;

namespace GisGmp.Charge
{
    /// <summary>
    /// Сведения о плательщике
    /// </summary>
    [Serializable()]
    [XmlRoot("ChargePayer", Namespace = "http://roskazna.ru/gisgmp/xsd/Charge/2.1.1")]
    public class ChargePayer : PayerType
    {
        /// <summary>
        /// Предназначен только для сериализации/десериализации
        /// </summary>
        protected ChargePayer() { }

        public ChargePayer(
            string PayerName,
            string PayerIdentifier
            ) : base(PayerIdentifier)
        {
            this.PayerName = PayerName;
        }

        /// <summary>
        /// Поле номер 8: Плательщик
        /// </summary>
        [XmlAttribute("payerName")]
        public string PayerName { get; set; }

        /// <summary>
        /// Поле номер 1201: Дополнительный идентификатор плательщика
        /// </summary>
        [XmlAttribute("additionalPayerIdentifier")]
        public string AdditionalPayerIdentifier { get; set; }
    }
}
