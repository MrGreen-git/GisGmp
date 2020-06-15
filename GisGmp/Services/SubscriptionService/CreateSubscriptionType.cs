using GisGmp.Subscription;
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.SubscriptionService
{
    /// <summary>
    /// Запрос на оформление подписки на предоставление уведомлений (или изменение, удаление подписки) с указанием значений параметров при необходимости
    /// </summary>
    [Serializable()]
    [XmlRoot("CreateSubscriptionType", Namespace = "urn://roskazna.ru/gisgmp/xsd/services/SubscriptionService/2.1.1")]
    public class CreateSubscriptionType
    {
        /// <summary>
        /// Реквизиты платежного документа
        /// </summary>
        protected CreateSubscriptionType() { }

        public CreateSubscriptionType(
            SubscriptionStatus SubscriptionStatus,
            string Item,
            ItemChoiceType4 ItemElementName
            )
        {
            this.SubscriptionStatus = SubscriptionStatus;
            this.Item = Item;
            this.ItemElementName = ItemElementName;
        }

        /// <summary>
        /// Cтатус подписки к варианту уведомлений.
        /// </summary>
        [XmlAttribute("subscriptionStatus")]
        public SubscriptionStatus SubscriptionStatus { get; set; }

        /// <summary>
        /// Код маршрутизации участника в ВС "Предоставление из ГИС ГМП уведомлений по рассылке". Обязательно указывается для новой подписки (статус подписки "1"- добавить)
        /// </summary>
        [XmlAttribute("routingCode")]
        public string RoutingCode { get; set; }

        /// <summary>
        /// SubscriptionCode - Код варианта уведомления. Указывается для новой подписки (для статуса подписки "1") SubscriptionIdentifier - Идентификатор подписки, присвоенный в ГИС ГМП. Указывается при изменении или удалении подписки (статус подписки "2" или "3")
        /// </summary>
        [XmlElement("SubscriptionIdentifier", typeof(string), Order = 1, Namespace = "http://roskazna.ru/gisgmp/xsd/Subscription/2.1.1")]
        [XmlElement("SubscriptionCode", typeof(string), Order = 1)]
        [XmlChoiceIdentifier("ItemElementName")]
        public string Item { get; set; }

        /// <summary/>
        [XmlIgnore()]
        public ItemChoiceType4 ItemElementName { get; set; }

        /// <summary>
        /// Значения параметра (группы параметров) подписки
        /// </summary>
        [XmlElement("SubscriptionParameters", Order = 2)]
        public SubscriptionParametersType[] SubscriptionParameters { get; set; }
    }
}
