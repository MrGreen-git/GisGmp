using System;
using System.Xml.Serialization;

namespace GisGmp.Services.SubscriptionService
{
    /// <summary>
    /// Запрос на оформление подписки на предоставление уведомлений (или изменение, удаление подписки) с указанием значений параметров при необходимости
    /// </summary>
    [Serializable()]
    [XmlRoot("ItemChoiceType4", Namespace = "urn://roskazna.ru/gisgmp/xsd/services/SubscriptionService/2.1.1")]
    public enum ItemChoiceType4
    {
        /// <summary>
        /// Идентификатор подписки, присвоенный в ГИС ГМП. Указывается при изменении или удалении подписки (статус подписки "2" или "3")
        /// </summary>
        [XmlEnum("http://roskazna.ru/gisgmp/xsd/Subscription/2.1.1:SubscriptionIdentifier")]
        SubscriptionIdentifier,

        /// <summary>
        /// Код варианта уведомления. Указывается для новой подписки (для статуса подписки "1")
        /// </summary>
        SubscriptionCode,
    }
}