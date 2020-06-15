using GisGmp.Common;
using System;
using System.Xml.Serialization;

namespace GisGmp.SearchConditions
{
    /// <summary>
    /// Условия для получения информации за временной интервал с указанием дополнительных параметров (при необходимости)
    /// </summary>
    [Serializable()]
    [XmlRoot("TimeConditionsType", Namespace = "http://roskazna.ru/gisgmp/xsd/SearchConditions/2.1.1")]
    public class TimeConditionsType
    {
        protected TimeConditionsType() { }

        public TimeConditionsType(TimeIntervalType timeInterval) => TimeInterval = timeInterval;
        /// <summary>
        /// Временной интервал, за который запрашивается информация из ГИС ГМП
        /// </summary>
        [XmlElement("TimeInterval", Order = 1, Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.1.1")]
        public TimeIntervalType TimeInterval { get; set; }

        /// <summary>
        /// Идентификация получателя средств
        /// </summary>
        [XmlElement("Beneficiary", Order = 2)]
        public Beneficiary[] Beneficiary { get; set; }

        /// <summary>
        /// Перечень КБК
        /// </summary>
        [XmlArray("KBKlist", Order = 3,  Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.1.1")]
        [XmlArrayItem("KBK", IsNullable = false)]
        public string[] KBKlist { get; set; }
    }
}