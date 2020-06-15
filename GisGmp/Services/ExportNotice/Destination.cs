using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ExportNotice
{
    /// <summary>
    /// Идентификатор получателя уведомлений по подписке
    /// </summary>
    [Serializable()]
    [XmlRoot("Destination", Namespace = "urn://roskazna.ru/gisgmp/xsd/services/ExportNotice/2.1.1")]
    public class Destination
    {
        /// <summary>
        /// УРН участника получателя [required]
        /// </summary>
        [XmlAttribute("recipientIdentifier")]
        public string RecipientIdentifier { get; set; }

        /// <summary>
        /// Код маршрутизации участника для предоставления информации по ВС с табличной маршрутизацией
        /// </summary>
        [XmlElement("RoutingCode", Order = 1)]
        public string RoutingCode { get; set; }
    }
}