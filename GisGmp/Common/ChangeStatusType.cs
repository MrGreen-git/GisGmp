using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    /// <summary>
    /// Сведения о статусе и основаниях его изменения
    /// </summary>
    [Serializable()]
    [XmlRoot("ChangeStatusType", Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.1.1")]
    public abstract class ChangeStatusType
    {
        /// <summary>
        /// Статус, отражающий изменение данных: 1 - новый 2 - уточнение 3 - аннулирование 4 - деаннулировании
        /// </summary>
        [XmlElement("Meaning", Order = 1)]
        public string Meaning { get; set; }

        /// <summary>
        /// Основание изменения
        /// </summary>
        [XmlElement("Reason", Order = 2)]
        public string Reason { get; set; }

        /// <summary>
        /// Дата и время уточнения информации
        /// </summary>
        [XmlElement("ChangeDate", Order = 3)]
        public DateTime ChangeDate { get; set; }

        /// <summary />
        [XmlIgnore()]
        public bool ChangeDateSpecified { get; set; }
    }
}
