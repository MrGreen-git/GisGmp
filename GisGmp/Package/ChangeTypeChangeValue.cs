using System;
using System.Xml.Serialization;

namespace GisGmp.Package
{
    /// <summary>
    /// Новое значение изменяемого поля. Множественное значение (до 10 штук) допустимо только для тех полей, в схеме которых определено максимальное количество – больше одного. Изменение множественных полей  выполняется всем передаваемым блоком. Переданные ранее значения в ГИС ГМП не сохраняются
    /// </summary>
    [Serializable()]
    [XmlRoot("ChangeTypeChangeValue", Namespace = "http://roskazna.ru/gisgmp/xsd/Package/2.1.1")]
    public class ChangeTypeChangeValue
    {
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
