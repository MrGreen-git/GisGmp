using System;
using System.Xml.Serialization;

namespace GisGmp.SearchConditions
{
    /// <summary>
    /// Идентификатор плательщика
    /// </summary>
    [Serializable()]
    [XmlRoot("ItemsChoiceType", Namespace = "http://roskazna.ru/gisgmp/xsd/SearchConditions/2.1.1")]
    public enum ItemsChoiceType
    {
        /// <summary>
        /// Идентификатор плательщика
        /// </summary>
        PayerIdentifier,

        /// <summary>
        /// ИНН юридического лица
        /// </summary>
        PayerInn,
    }
}
