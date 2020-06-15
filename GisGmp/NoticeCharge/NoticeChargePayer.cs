using GisGmp.Common;
using System;
using System.Xml.Serialization;

namespace GisGmp.NoticeCharge
{
    /// <summary>
    /// Сведения о плательщике
    /// </summary>
    [Serializable()]
    [XmlRoot("NoticeChargePayer", Namespace = "http://roskazna.ru/gisgmp/xsd/NoticeCharge/2.1.1")]
    public class NoticeChargePayer : PayerType
    {
        /// <summary>
        /// Предназначен только для сериализации/десериализации
        /// </summary>
        protected NoticeChargePayer() { }

        public NoticeChargePayer(
            string PayerName,
            string PayerIdentifier
            ) : base (PayerIdentifier)
        {
            this.PayerName = PayerName;
        }

        /// <summary>
        /// Плательщик
        /// </summary>
        [XmlAttribute("payerName")]
        public string PayerName { get; set; }

        /// <summary>
        /// Дополнительный идентификатор плательщика
        /// </summary>
        [XmlAttribute("additionalPayerIdentifier")]
        public string AdditionalPayerIdentifier { get; set; }
    }
}