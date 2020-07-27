using GisGmp.Common;
using System;
using System.Xml.Serialization;

namespace GisGmp.SearchConditions
{
    /// <summary>
    /// Условия для получения информации по идентификатору плательщика с указанием дополнительных параметров(при необходимости)
    /// </summary>
    [Serializable()]
    [XmlRoot("PayersConditionsType", Namespace = "http://roskazna.ru/gisgmp/xsd/SearchConditions/2.1.1")]
    public class PayersConditionsType
    {
        protected PayersConditionsType() { }

        public PayersConditionsType(string[] items, ItemsChoiceType[] itemsElementName, TimeIntervalType timeInterval = null, string[] kbklist = null)
        {
            Items = items;
            ItemsElementName = itemsElementName;
            TimeInterval = timeInterval;
            KBKlist = kbklist;
        }

        /// <summary>
        /// Идентификатор плательщика [maxOccurs="100"]
        /// </summary>
        [XmlElement("PayerIdentifier", typeof(string), Order = 1)]
        [XmlElement("PayerInn", typeof(string), Order = 1)]
        [XmlChoiceIdentifier("ItemsElementName")]
        public string[] Items { get; set; }

        /// <summary/>
        [XmlIgnore()]
        public ItemsChoiceType[] ItemsElementName { get; set; }

        /// <summary>
        /// Временной интервал, за который запрашивается информация из ГИС ГМП [maxOccurs="0"]
        /// </summary>
        [XmlElement("TimeInterval", Order = 2, Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.1.1")]
        public TimeIntervalType TimeInterval { get; set; }

        /// <summary>
        /// Перечень КБК [minOccurs="0"]
        /// </summary>
        [XmlArray(Order = 3, Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.1.1")]
        [XmlArrayItem("KBK", IsNullable = false)]
        public string[] KBKlist { get; set; }
    }
}