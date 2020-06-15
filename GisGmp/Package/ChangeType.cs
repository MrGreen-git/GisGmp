using System;
using System.Xml.Serialization;

namespace GisGmp.Package
{
    /// <summary>
    /// Изменяемые поля
    /// </summary>
    [Serializable()]
    [XmlRoot("ChangeType", Namespace = "http://roskazna.ru/gisgmp/xsd/Package/2.1.1")]
    public class ChangeType
    {
        /// <summary>
        /// Новое значение изменяемого поля. Множественное значение (до 10 штук) допустимо только для тех полей, в схеме которых определено максимальное количество – больше одного. Изменение множественных полей  выполняется всем передаваемым блоком. Переданные ранее значения в ГИС ГМП не сохраняются
        /// </summary>
        [XmlElement("ChangeValue", Order = 1)]
        public ChangeTypeChangeValue[] ChangeValue { get; set; }

        /// <summary>
        /// Номер поля, в которое вносятся изменения [required]
        /// </summary>
        [XmlAttribute("fieldNum")]
        public string FieldNum { get; set; }
    }
}