using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    /// <remarks/>
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.2.0")]
    [XmlRoot("AdditionalData", Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.2.0", IsNullable = false)]
    public class AdditionalDataType
    {
        /// <summary />
        protected AdditionalDataType() { }

        /// <summary />
        public AdditionalDataType(string name, string value) 
        {
            Name = name;
            Value = value;
        }

        
        /// <summary>
        /// Наименование поля
        /// </summary>
        public string Name 
        {
            get => _Name;
            set => _Name = Validator.String(value: ref value, name: nameof(Name), required: true, min: 1, max: 100);
        }

        string _Name;

        
        /// <summary>
        /// Значение поля
        /// </summary>
        public string Value 
        {
            get => _Value;
            set => _Value = Validator.String(value: ref value, name: nameof(Value), required: true, min: 1, max: 255);
        }

        string _Value;
    }
}