using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ForcedAcknowledgement
{
    /// <summary>
    /// Отмена факта установления платежу признака "Услуга  предоставлена"
    /// </summary>
    [Serializable()]
    [XmlRoot("AnnulmentServiceProvidedType", Namespace = "urn://roskazna.ru/gisgmp/xsd/services/forced-ackmowledgement/2.1.1")]
    public class AnnulmentServiceProvidedType
    {
        protected AnnulmentServiceProvidedType() { }

        public AnnulmentServiceProvidedType(string[] paymentId) => PaymentId = paymentId;

        /// <summary>
        /// УИП
        /// </summary>
        [XmlElement("PaymentId", Order = 1)]
        public string[] PaymentId { get; set; }
    }
}