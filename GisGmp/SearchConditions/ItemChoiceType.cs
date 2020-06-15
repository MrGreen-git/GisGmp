using System;
using System.Xml.Serialization;

namespace GisGmp.SearchConditions
{
    /// <summary>
    /// Условия для получения информации
    /// </summary>
    [Serializable()]
    [XmlRoot("ItemChoiceType", Namespace = "http://roskazna.ru/gisgmp/xsd/SearchConditions/2.1.1")]
    public enum ItemChoiceType
    {
        /// <summary>
        /// Условия для получения информации по УИН с указанием дополнительных параметров (при необходимости)
        /// </summary>
        ChargesConditions,

        /// <summary>
        /// Условия для получения информации по идентификатору плательщика с указанием дополнительных параметров (при необходимости)
        /// </summary>
        PayersConditions,

        /// <summary>
        /// Условия для получения информации по УИП
        /// </summary>
        PaymentsConditions,

        /// <summary>
        /// Условия для получения информации по уникальному идентификатору возврата (УИВ)
        /// </summary>
        RefundsConditions,

        /// <summary>
        /// Условия для получения информации за временной интервал с указанием дополнительных параметров (при необходимости)
        /// </summary>
        TimeConditions,
    }
}