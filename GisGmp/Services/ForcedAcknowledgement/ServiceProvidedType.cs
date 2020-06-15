using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ForcedAcknowledgement
{
    /// <summary>
    /// Установление платежу признака "Услуга предоставлена"
    /// </summary>
    [Serializable()]
    [XmlRoot("ServiceProvidedType", Namespace = "urn://roskazna.ru/gisgmp/xsd/services/forced-ackmowledgement/2.1.1")]
    public class ServiceProvidedType
    {
        protected ServiceProvidedType() { }

        public ServiceProvidedType(string[] paymentId) => PaymentId = paymentId;

        /// <summary>
        /// УИП
        /// </summary>
        [XmlElement("PaymentId", Order = 1)]
        public string[] PaymentId { get; set; }
    }
}