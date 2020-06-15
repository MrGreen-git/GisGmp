using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    /// <summary>
    /// Временной интервал, за который запрашивается информация из ГИС ГМП
    /// </summary>
    [Serializable()]
    [XmlRoot("TimeInterval", Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.1.1")]
    public class TimeIntervalType
    {
        /// <summary>
        /// Предназначен только для сериализации/десериализации
        /// </summary>
        protected TimeIntervalType() { }

        public TimeIntervalType(
            DateTime StartDate,
            DateTime EndDate
            )
        {
            this.StartDate = StartDate;
            this.EndDate = EndDate;
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