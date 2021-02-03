using System;
using System.Xml.Serialization;

namespace GisGmp.SearchConditions
{
    /// <remarks/>
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/SearchConditions/2.2.0")]
    public abstract class Conditions
    {
        /// <remarks/>
        [XmlElement("ChargesConditions", typeof(ChargesConditionsType))]
        [XmlElement("IncomesConditions", typeof(IncomesConditionsType))]
        [XmlElement("PayersConditions", typeof(PayersConditionsType))]
        [XmlElement("PaymentsConditions", typeof(PaymentsConditionsType))]
        [XmlElement("RefundsConditions", typeof(RefundsConditionsType))]
        [XmlElement("TimeConditions", typeof(TimeConditionsType))]
        public object Item { get; set; }

        /// <summary>
        /// Тип запроса на предоставление информации
        /// </summary>
        [XmlAttribute("kind")]
        public string Kind { get; set; }
    }
}