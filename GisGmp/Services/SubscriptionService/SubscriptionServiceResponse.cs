using GisGmp.Common;
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.SubscriptionService
{
    /// <summary>
    /// Ответ на запрос участника. Типы ответов: 1) предоставление перечня доступных участнику вариантов уведомлений 2) результат обработки запроса о подписке(изменении/удалении подписки) участника
    /// </summary>
    [Serializable()]
    [XmlRoot("SubscriptionServiceResponse", Namespace = "urn://roskazna.ru/gisgmp/xsd/services/SubscriptionService/2.1.1")]
    public class SubscriptionServiceResponse : ResponseType
    {
        protected SubscriptionServiceResponse() { }
 
        public SubscriptionServiceResponse(ResponseType config, CreateSubscriptionResultType[] createSubscriptionResultType)
            : base(config) => Items = createSubscriptionResultType;

        public SubscriptionServiceResponse(ResponseType config, SubscriptionsType[] subscriptionsTypes)
            : base(config) => Items = subscriptionsTypes;
        
        /// <summary>
        /// Ответ на запрос предоставления перечня доступных участнику вариантов уведомлений / Ответ с результатом обработки запроса о подписке (изменении/удалении подписки) участника
        /// </summary>
        [XmlElement("CreateSubscriptionResult", typeof(CreateSubscriptionResultType), Order = 1)]
        [XmlElement("Subscriptions", typeof(SubscriptionsType), Order = 1)]
        public object[] Items { get; set; }
    }
}