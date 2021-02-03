using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace GisGmp.Services.ExportNoticeNSI
{
    /// <summary>
    /// Идентификаторы получателя уведомлений по подписке
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/ExportNoticeNSI/2.2.0")]
    public class Destination
    {
        /// <summary />
        protected Destination() { }

        /// <summary />
        public Destination(string routingCode, URNType recipientIdentifier)
        {
            RoutingCode = routingCode;
            RecipientIdentifier = recipientIdentifier;
        }

        /// <summary>
        /// Код маршрутизации участника для предоставления информации по ВС с табличной маршрутизацией
        /// </summary>
        public string RoutingCode 
        {
            get => _RoutingCode;
            set => _RoutingCode = Validator.String(value: ref value, name: nameof(RoutingCode), required: true, min: 0, max: 200); 
        }

        string _RoutingCode;


        /// <summary>
        /// УРН участника получателя
        /// </summary>
        [XmlIgnore]
        public URNType RecipientIdentifier { get; set; }

        /// <summary />
        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlAttribute("recipientIdentifier")]
        public string WrapperRecipientIdentifier { get => RecipientIdentifier; set => RecipientIdentifier = value; }
    }
}