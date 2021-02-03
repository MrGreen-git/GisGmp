using System;
using System.Xml.Serialization;

namespace GisGmp.SearchConditions
{
    /// <remarks/>
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/SearchConditions/2.2.0")]
    public class RefundsConditionsType
    {
        /// <summary/>
        protected RefundsConditionsType() { }

        /// <summary/>
        public RefundsConditionsType(UIR[] uir) => RefundId = uir;

     
        /// <summary>
        /// УИВ, количество: 1-100
        /// </summary>  
        [XmlIgnore]
        public UIR[] RefundId
        {
            get => _RefundId;
            set => Validator.ArrayObj(value: value, name: nameof(RefundId), required: true, min: 1, max: 100);
        }

        UIR[] _RefundId;
        
        /// <summary/>
        [XmlElement("RefundId")]
        public string[] WrapperRefundId
        {
            get => RefundId?.ToArrayString();
            set => RefundId = value?.ToArray<UIR>(s => s);
        }
    }
}