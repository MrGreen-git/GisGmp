using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace GisGmp.SearchConditions
{
    /// <remarks/>
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/SearchConditions/2.2.0")]
    public class PaymentsConditionsType
    {
        /// <remarks/>
        protected PaymentsConditionsType() { }

        /// <remarks/>
        public PaymentsConditionsType(UIP[] uip) => PaymentId = uip;


        /// <summary>
        /// УИП, количество: 1-100
        /// </summary>  
        [XmlIgnore]
        public UIP[] PaymentId
        {
            get => _PaymentId;
            set => _PaymentId = Validator.ArrayObj(value: value, name: nameof(PaymentId), required: true, min: 1, max: 100);          
        }

        UIP[] _PaymentId;

        /// <summary/>
        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlElement("PaymentId")]
        public string[] WrapperPaymentId
        {
            get => PaymentId?.ToArrayString();
            set => PaymentId = value?.ToArray<UIP>(s => s);
        }
    }
}