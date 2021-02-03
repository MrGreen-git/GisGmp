using System;
using System.Xml.Serialization;

namespace GisGmp.Package
{
    /// <summary>
    /// Изменяемые поля
    /// </summary>
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Package/2.2.0")]
    public class ChangeType
    {
        /// <summary />
        protected ChangeType() { }

        /// <summary />
        public ChangeType(string fieldNum)
        {
            FieldNum = fieldNum;
        }

        /// <summary>
        /// Новое значение изменяемого поля. Множественное значение (до 10 штук) допустимо только для тех полей, в схеме которых определено максимальное количество – больше одного. Изменение множественных полей  выполняется всем передаваемым блоком. Переданные ранее значения в ГИС ГМП не сохраняются
        /// </summary>
        [XmlElement("ChangeValue")]
        public ChangeValue[] ChangeValue { get; set; }

        /// <summary>
        /// Номер поля, в которое вносятся изменения
        /// </summary>
        [XmlAttribute("fieldNum")]
        public string FieldNum { get; set; }
    }
}