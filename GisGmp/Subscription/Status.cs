using System;
using System.Xml.Serialization;

namespace GisGmp.Subscription
{
    /// <summary>
    /// Cтатус для обработки значения параметра (группы параметров)
    /// </summary>
    [Serializable()]
    [XmlRoot("Status", Namespace = "http://roskazna.ru/gisgmp/xsd/Subscription/2.1.1")]
    public enum Status
    {
        /// <summary>
        /// Новое значение
        /// </summary>
        [XmlEnum("1")]
        Item1,

        /// <summary>
        /// Удаление значения
        /// </summary>
        [XmlEnum("2")]
        Item2,
    }
}