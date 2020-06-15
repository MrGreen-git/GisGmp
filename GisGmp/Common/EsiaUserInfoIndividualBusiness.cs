using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    /// <summary>
    /// Индивидуальный предприниматель
    /// </summary>
    [Serializable()]
    [XmlRoot("EsiaUserInfoIndividualBusiness", Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.1.1")]
    public class EsiaUserInfoIndividualBusiness
    {
        /// <summary>
        /// ИНН, полученный из ЕСИА
        /// </summary>
        [XmlAttribute("personINN")]
        public string PersonINN { get; set; }
    }
}