using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    /// <summary>
    /// Дополнительные условия оплаты
    /// </summary>
    [Serializable()]
    [XmlRoot("DiscountType", Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.1.1")]
    public abstract class DiscountType
    {
        /// <summary>
        /// Значение
        /// </summary>
        [XmlElement("Value", Order = 1)]
        public string Value { get; set; }

        /// <summary>
        /// срок действия
        /// </summary>
        [XmlElement("Expiry", Order = 2)]
        public string Expiry { get; set; }
    }
}