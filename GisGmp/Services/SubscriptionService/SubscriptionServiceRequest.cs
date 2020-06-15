using GisGmp.Common;
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.SubscriptionService
{
    /// <summary>
    /// Подписка на предоставление из ГИС ГМП уведомлений. Типы запросов: 1) запрос на предоставление перечня доступных участнику вариантов уведомлений для оформления подписки 2) запрос на оформление подписки(изменение, удаления подписки) с указанием при необходимости значений параметров
    /// </summary>
    [Serializable()]
    [XmlRoot("SubscriptionServiceRequest", Namespace = "urn://roskazna.ru/gisgmp/xsd/services/SubscriptionService/2.1.1")]
    public class SubscriptionServiceRequest : RequestType
    {
        protected SubscriptionServiceRequest() { }

        public SubscriptionServiceRequest(RequestType config, object item)
            : base(config) => Item = item;
        
        /// <summary>
        /// Тип запроса (ExportSubscriptions Запрос на предоставление перечня доступных участнику вариантов уведомлений)
        /// </summary>
        [XmlElement("CreateSubscription", typeof(CreateSubscriptionType), Order = 1)]
        [XmlElement("ExportSubscriptions", typeof(bool), Order = 1)]
        public object Item { get; set; }
    }
}
