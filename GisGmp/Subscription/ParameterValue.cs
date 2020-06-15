using System;
using System.Xml.Serialization;

namespace GisGmp.Subscription
{
    /// <summary>
    /// Значение параметра подписки
    /// </summary>
    [Serializable()]
    [XmlRoot("ParameterValue", Namespace = "http://roskazna.ru/gisgmp/xsd/Subscription/2.1.1")]
    public class ParameterValue
    {
        /// <summary>
        /// Код параметра
        /// </summary>
        [XmlAttribute("parameterCode")]
        public string ParameterCode { get; set; }

        /// <summary>
        /// Значение параметра подписки
        /// </summary>
        [XmlText()]
        public string Value { get; set; }
    }
}
