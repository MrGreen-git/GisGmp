using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    /// <summary>
    /// Вид операции. Проставляется шифр исполняемого распоряжения
    /// </summary>
    [Serializable()]
    [XmlRoot("TransKindType", Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.1.1")]
    public enum TransKindType
    {
        /// <summary>
        /// Платежное поручение
        /// </summary>
        [XmlEnum("01")]
        Item01,

        /// <summary>
        /// Инкассовое поручение
        /// </summary>
        [XmlEnum("06")]
        Item06,

        /// <summary>
        /// Платежный  ордер
        /// </summary>
        [XmlEnum("16")]
        Item16,
    }
}