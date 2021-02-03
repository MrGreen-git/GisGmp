using System;
using System.Xml.Serialization;

namespace GisGmp.Package
{
    /// <summary>
    /// Новое значение изменяемого поля
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/Package/2.2.0")]
    public class ChangeValue
    {
        /// <summary />
        protected ChangeValue() { }

        /// <summary />
        public ChangeValue(string value)
        {
            Value = value;
        }

        /// <summary>
        /// Наименование изменяемого поля
        /// </summary>
        [XmlAttribute("name")]
        public string Name { get; set; }

        /// <summary>
        /// Значение изменяемого поля. Если требуется не изменить, а удалить переданное ранее значение поля, то в поле следует указать значение NULL
        /// </summary>
        [XmlAttribute("value")]
        public string Value { get; set; }
    }
}