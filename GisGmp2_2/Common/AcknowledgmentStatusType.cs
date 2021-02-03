using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    /// <summary>
    /// Статус, присваиваемый начислению при создании квитанции
    /// </summary>
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.2.0")]
    public enum AcknowledgmentStatusType
    {
        /// <summary />
        [XmlIgnore]
        None,

        /// <summary>
        /// сквитировано
        /// </summary>
        [XmlEnum("1")]
        Item1,

        /// <summary>
        /// предварительно сквитировано
        /// </summary>
        [XmlEnum("2")]
        Item2,

        /// <summary>
        /// не сквитировано
        /// </summary>
        [XmlEnum("3")]
        Item3,

        /// <summary>
        /// сквитировано по инициативе АН/ГАН с отсутствующим в ГИС ГМП платежом
        /// </summary>
        [XmlEnum("4")]
        Item4,

        /// <summary>
        /// принудительно сквитировано по инициативе АН/ГАН с платежом
        /// </summary>
        [XmlEnum("5")]
        Item5,
    }
}