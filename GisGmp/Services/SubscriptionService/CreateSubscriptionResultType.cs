using GisGmp.Subscription;
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.SubscriptionService
{
    /// <summary>
    /// Ответ с результатом обработки запроса о подписке (изменении/удалении подписки) участника
    /// </summary>
    [Serializable()]
    [XmlRoot("CreateSubscriptionResultType", Namespace = "urn://roskazna.ru/gisgmp/xsd/services/SubscriptionService/2.1.1")]
    public class CreateSubscriptionResultType
    {
        /// <summary>
        /// Дата и время добавления/удаления подписки или изменения значений параметров подписки
        /// </summary>
        [XmlAttribute("dispatchDate")]
        public DateTime dispatchDate { get; set; }

        /// <summary/>
        [XmlIgnore()]
        public bool dispatchDateSpecified { get; set; }

        /// <summary>
        /// Дата автоматического окончания срока действия значений параметров подписки в ГИС ГМП
        /// </summary>
        [XmlAttribute("expiryDate")]
        public DateTime expiryDate { get; set; }

        /// <summary/>
        [XmlIgnore()]
        public bool expiryDateSpecified { get; set; }

        /// <summary>
        /// Код варианта уведомлений
        /// </summary>
        [XmlAttribute("subscriptionCode")]
        public string subscriptionCode { get; set; }

        /// <summary>
        /// Идентификатор подписки
        /// </summary>
        [XmlAttribute("subscriptionIdentifier")]
        public string subscriptionIdentifier { get; set; }

        /// <summary>
        /// Результат обработки запроса о подписке или уточнения/удаления подписки
        /// </summary>
        [XmlElement("SubscriptionProtocol", Order = 1)]
        public SubscriptionProtocolType[] SubscriptionProtocol { get; set; }
    }
}
