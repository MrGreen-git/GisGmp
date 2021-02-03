using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    /// <summary>
    /// Индивидуальный предприниматель
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.2.0")]
    public class IndividualBusiness
    {
        /// <summary>
        /// ИНН, полученный из ЕСИА
        /// </summary>
        [XmlAttribute("personINN")]
        public string PersonINN { get; set; }
    }
}