using System;
using System.Xml.Serialization;

namespace GisGmp.Services.SubscriptionService
{
    /// <summary>
    /// Cтатус подписки к варианту уведомлений
    /// </summary>
    [Serializable()]
    [XmlRoot("SubscriptionStatus", Namespace = "urn://roskazna.ru/gisgmp/xsd/services/SubscriptionService/2.1.1")]
    public enum SubscriptionStatus
    {
        /// <summary>
        /// Новая подписка
        /// </summary>
        [XmlEnum("1")]
        Item1,

        /// <summary>
        /// Изменение подписки
        /// </summary>
        [XmlEnum("2")]
        Item2,

        /// <summary>
        /// Удаление подписки
        /// </summary>
        [XmlEnum("3")]
        Item3,
    }
}