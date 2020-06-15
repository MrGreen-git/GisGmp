using System;
using System.Xml.Serialization;

namespace GisGmp.Services.SubscriptionService
{
    /// <summary>
    /// Ответ на запрос предоставления перечня доступных участнику вариантов уведомлений
    /// </summary>
    [Serializable()]
    [XmlRoot("SubscriptionsType", Namespace = "urn://roskazna.ru/gisgmp/xsd/services/SubscriptionService/2.1.1")]
    public class SubscriptionsType
    {
        /// <summary>
        /// Перечень параметров, значения которых необходимо указать при оформлении подписки
        /// </summary>
        [XmlElement("SubscriptionParameter", Order = 1)]
        public SubscriptionParameterType[] SubscriptionParameter { get; set; }

        /// <summary>
        /// Код варианта уведомлений
        /// </summary>
        [XmlAttribute("subscriptionCode")]
        public string subscriptionCode { get; set; }

        /// <summary>
        /// Наименование варианта
        /// </summary>
        [XmlAttribute("subscriptionName")]
        public string subscriptionName { get; set; }

        /// <summary>
        /// Описание типа уведомления
        /// </summary>
        [XmlAttribute("subscriptionOperation")]
        public string subscriptionOperation { get; set; }
    }
}