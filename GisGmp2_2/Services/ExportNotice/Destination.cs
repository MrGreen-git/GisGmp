using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace GisGmp.Services.ExportNotice
{
    /// <summary>
    /// Идентификаторы получателя уведомлений по подписке
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/ExportNotice/2.2.0")]
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
        public URNType RecipientIdentifier 
        {
            get => _RecipientIdentifier;
            set => _RecipientIdentifier = Validator.IsNull(value: value, name: nameof(RecipientIdentifier));
        }

        URNType _RecipientIdentifier;

        /// <summary />
        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlAttribute("recipientIdentifier")]
        public string WrapperRecipientIdentifier { get => RecipientIdentifier; set => RecipientIdentifier = value; }
    }
}