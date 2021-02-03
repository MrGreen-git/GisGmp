using System;
using System.Xml.Serialization;

namespace GisGmp.SearchConditions
{
    /// <summary>
    /// Идентификация получателя средств
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/SearchConditions/2.2.0")]
    public class Beneficiary
    {
        /// <summary>
        /// ИНН получателя средств, указанный в возвращаемом элементе
        /// </summary>
        [XmlAttribute("inn")]
        public string Inn { get; set; }

        /// <summary>
        /// КПП получателя средств, указанный в возвращаемом элементе
        /// </summary>
        [XmlAttribute("kpp")]
        public string Kpp { get; set; }
    }
}