using System;
using System.Xml.Serialization;

namespace GisGmp.Services.SubscriptionService
{
    /// <remarks/>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/SubscriptionService/2.2.0")]
    public class SubscriptionParameter
    {
        /// <summary />
        protected SubscriptionParameter() { }

        /// <summary />
        public SubscriptionParameter(string parameterCode, string parameterName, bool required)
        {
            ParameterCode = parameterCode;
            ParameterName = parameterName;
            Required = required;
        }

        /// <summary />
        public SubscriptionParameter(string parameterCode, string parameterName, bool required, string parameterPattern)
            : this(parameterCode, parameterName, required) => ParameterPattern = parameterPattern;

        /// <remarks/>
        [XmlAttribute("parameterCode")]
        public string ParameterCode { get; set; } //TODO [?]
       
        /// <remarks/>
        [XmlAttribute("parameterName")]
        public string ParameterName 
        {
            get => _ParameterName;
            set => _ParameterName = Validator.String(value: ref value, name: nameof(ParameterName), required: true, min: 0, max: 50);
        }

        string _ParameterName;
      
        /// <remarks/>
        [XmlAttribute("parameterPattern")]
        public string ParameterPattern 
        {
            get => _ParameterPattern;
            set => _ParameterPattern = Validator.String(value: ref value, name: nameof(ParameterPattern), required: false, min: 0, max: 2000);
        }

        string _ParameterPattern;

        /// <remarks/>
        [XmlAttribute("required")]
        public bool Required { get; set; }
      
        /// <remarks/>
        [XmlAttribute("parameterDescription")]
        public string ParameterDescription 
        {
            get => _ParameterDescription;
            set => _ParameterDescription = Validator.String(value: ref value, name: nameof(ParameterDescription), required: false, min: 0, max: 2000);
        }

        string _ParameterDescription;
    }
}