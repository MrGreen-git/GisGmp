using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    /// <summary>
    /// Перечень КБК
    /// </summary>
    [Serializable()]
    [XmlRoot("KBKlist", Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.1.1")]
    public class KBKlist
    {
        /// <summary>
        /// КБК
        /// </summary>
        [XmlElement("KBK")]
        public string[] KBK { get; set; }
    }
}