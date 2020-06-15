using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    /// <summary>
    /// Код документа, удостоверяющего личность
    /// </summary>
    [Serializable()]
    [XmlRoot("EsiaUserInfoPersonDocumentIdentityCode", Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.1.1")]
    public enum EsiaUserInfoPersonDocumentIdentityCode
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