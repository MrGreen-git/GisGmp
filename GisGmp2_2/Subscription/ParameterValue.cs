using System;
using System.Xml.Serialization;

namespace GisGmp.Subscription
{
    /// <summary>
    /// Значение параметра
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/Subscription/2.2.0")]
    public class ParameterValue
    {
        /// <summary />
        protected ParameterValue() { }

        /// <summary />
        public ParameterValue(string parameterCode, string value)
        {
            ParameterCode = parameterCode;
            Value = value;
        }

        /// <summary>
        /// Код параметра подписки
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