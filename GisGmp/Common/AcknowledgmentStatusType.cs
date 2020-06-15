using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    /// <summary>
    /// Статус, присваиваемый начислению при создании квитанции
    /// </summary>
    [Serializable()]
    [XmlRoot("AcknowledgmentStatusType", Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.1.1")]
    public enum AcknowledgmentStatusType
    {
        /// <summary>
        /// Сквитировано
        /// </summary>
        [XmlEnum("1")]
        Item1,

        /// <summary>
        /// Предварительно сквитировано
        /// </summary>
        [XmlEnum("2")]
        Item2,

        /// <summary>
        /// Не сквитировано
        /// </summary>
        [XmlEnum("3")]
        Item3,

        /// <summary>
        /// Сквитировано по инициативе АН/ГАН с отсутствующим в ГИС ГМП платежом
        /// </summary>
        [XmlEnum("4")]
        Item4,

        /// <summary>
        /// Принудительно сквитировано по инициативе АН/ГАН с платежом
        /// </summary>
        [XmlEnum("5")]
        Item5,
    }
}