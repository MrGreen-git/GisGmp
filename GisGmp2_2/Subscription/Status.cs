using System;
using System.Xml.Serialization;

namespace GisGmp.Subscription
{
    /// <summary>
    /// Cтатус для обработки значения параметра (группы параметров)
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/Subscription/2.2.0")]
    public enum Status
    {
        /// <summary>
        /// новое значение
        /// </summary>
        [XmlEnum("1")]
        Item1,

        /// <summary>
        /// удаление значения
        /// </summary>
        [XmlEnum("2")]
        Item2,
    }
}