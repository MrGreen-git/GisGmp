using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    /// <summary>
    /// Сведения о статусе и основаниях его изменения
    /// </summary>
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.2.0")]
    public abstract class ChangeStatusType
    {
        /// <summary>
        /// Статус, отражающий изменение данных: 1 - новый 2 - уточнение 3 - аннулирование 4 - деаннулировании
        /// </summary>
        public string Meaning { get; set; }

        /// <summary>
        /// Основание изменения
        /// </summary>
        public string Reason { get; set; }

        /// <summary>
        /// Дата и время уточнения информации
        /// </summary>
        public DateTime ChangeDate { get; set; }

        /// <remarks/>
        [XmlIgnore]
        public bool ChangeDateSpecified { get; set; }
    }
}