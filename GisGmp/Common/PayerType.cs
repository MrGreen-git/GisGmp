using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    /// <summary>
    /// Сведения о плательщике
    /// </summary>   
    [Serializable()]
    [XmlRoot("PayerType", Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.1.1")]
    public class PayerType
    {
        /// <summary>
        /// Предназначен только для сериализации/десериализации
        /// </summary>
        protected PayerType() { }

        public PayerType(
            string PayerIdentifier
            )
        {
            this.PayerIdentifier = PayerIdentifier;
        }

        /// <summary>
        /// Поле номер 201: Идентификатор плательщика
        /// </summary>
        [XmlAttribute("payerIdentifier")]
        public string PayerIdentifier { get; set; }
    }
}
