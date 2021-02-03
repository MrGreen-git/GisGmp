using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    /// <remarks/>
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.2.0")]
    public abstract class DiscountType
    {
        /// <summary>
        /// значение
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// срок действия
        /// </summary>
        public string Expiry { get; set; }
    }
}