using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    /// <summary>
    /// Перечень КБК
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.2.0")]
    [XmlRoot(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.2.0", IsNullable = false)]
    public class KBKlist
    {
        /// <summary>
        /// КБК
        /// </summary>
        [XmlElement("KBK")]
        public string[] KBK { get; set; }
    }
}