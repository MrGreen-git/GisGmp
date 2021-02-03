using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    /// <summary>
    /// Код документа, удостоверяющего личность
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.2.0")]
    public enum Code
    {
        /// <summary>
        /// Паспорт гражданина Российской Федерации
        /// </summary>
        [XmlEnum("1")]
        Item1,

        /// <summary>
        /// Документ иностранного гражданина
        /// </summary>
        [XmlEnum("2")]
        Item2,
    }
}