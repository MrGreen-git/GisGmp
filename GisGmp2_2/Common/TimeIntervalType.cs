using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    /// <remarks/>
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.2.0")]
    [XmlRoot("TimeInterval", Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.2.0", IsNullable = false)]
    public class TimeIntervalType
    {
        /// <summary />
        protected TimeIntervalType() { }

        /// <summary />
        public TimeIntervalType(DateTime startDate, DateTime endDate)
        {
            StartDate = startDate;
            EndDate = endDate;
        }

        /// <summary>
        /// Начальная дата временного интервала запроса
        /// </summary>
        [XmlAttribute("startDate")]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Конечная дата временного интервала запроса
        /// </summary>
        [XmlAttribute("endDate")]
        public DateTime EndDate { get; set; }
    }
}