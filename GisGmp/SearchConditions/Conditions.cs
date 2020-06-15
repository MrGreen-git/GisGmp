using System;
using System.Xml.Serialization;

namespace GisGmp.SearchConditions
{
    /// <summary>
    /// Базовый класс фильтра
    /// </summary>
    [Serializable()]
    [XmlRoot(Namespace = "http://roskazna.ru/gisgmp/xsd/SearchConditions/2.1.1")]
    public abstract class Conditions
    {
        /// <summary>
        /// Тип запроса на предоставление информации
        /// </summary>
        [XmlAttribute("kind")]
        public string Kind { get; set; }

        //TODO Проверить и лишнее в закоммиченное удалить
        /// <summary>
        /// Условия для получения информации
        /// </summary>
        [XmlElement("ChargesConditions", typeof(ChargesConditionsType), Order = 1)]
        [XmlElement("PayersConditions", typeof(PayersConditionsType), Order = 1)]
        [XmlElement("PaymentsConditions", typeof(PaymentsConditionsType), Order = 1)]
        [XmlElement("RefundsConditions", typeof(RefundsConditionsType), Order = 1)]
        [XmlElement("TimeConditions", typeof(TimeConditionsType), Order = 1)]
        //[XmlChoiceIdentifier("ItemElementName")]
        public object Item { get; set; }

        ///// <summary/>
        //[XmlIgnore()]
        //public ItemChoiceType ItemElementName { get; set; }
    }
}