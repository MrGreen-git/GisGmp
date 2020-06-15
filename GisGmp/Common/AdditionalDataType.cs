using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    /// <summary>
    /// Дополнительные поля
    /// </summary>
    [Serializable()]
    [XmlRoot("AdditionalDataType", Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.1.1")]
    public class AdditionalDataType
    {
        protected AdditionalDataType() { }

        public AdditionalDataType(
            string Name,
            string Value
            )
        {
            this.Name = Name;
            this.Value = Value;
        }

        /// <summary>
        /// Наименование поля
        /// </summary>
        [XmlElement("Name", Order = 1)]
        public string Name { get; set; }

        /// <summary>
        /// Значение поля
        /// </summary>
        [XmlElement("Value", Order = 2)]
        public string Value { get; set; }
    }
}