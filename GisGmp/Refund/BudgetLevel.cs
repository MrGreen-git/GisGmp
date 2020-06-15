using System;
using System.Xml.Serialization;

namespace GisGmp.Refund
{
    /// <summary>
    /// Уровень бюджета
    /// </summary>
    [Serializable()]
    [XmlRoot("BudgetLevel", Namespace = "http://roskazna.ru/gisgmp/xsd/Refund/2.1.1")]
    public enum BudgetLevel
    {
        /// <summary>
        /// «федеральный»
        /// </summary>
        [XmlEnum("1")]
        Item1,

        /// <summary>
        /// «бюджет субъекта РФ»
        /// </summary>
        [XmlEnum("2")]
        Item2,

        /// <summary>
        /// «местный бюджет»
        /// </summary>
        [XmlEnum("3")]
        Item3,

        /// <summary>
        /// «бюджет ГВФ РФ»
        /// </summary>
        [XmlEnum("4")]
        Item4,

        /// <summary>
        /// «бюджет ТГВФ РФ»
        /// </summary>
        [XmlEnum("5")]
        Item5,

        /// <summary>
        /// «средства ЮЛ»
        /// </summary>
        [XmlEnum("6")]
        Item6,
    }
}