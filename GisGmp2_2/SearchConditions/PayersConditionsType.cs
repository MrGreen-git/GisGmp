using GisGmp.Common;
using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace GisGmp.SearchConditions
{
    /// <remarks/>
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/SearchConditions/2.2.0")]
    public class PayersConditionsType
    {
        /// <summary>
        protected PayersConditionsType() { }

        /// <summary>
        public PayersConditionsType(string[] items, ItemsChoiceType[] itemsElementName)
        {
            Items = items;
            ItemsElementName = itemsElementName;
        }

        /// <summary>
        public PayersConditionsType(string[] items, ItemsChoiceType[] itemsElementName, TimeIntervalType timeInterval = null, KBKType[] kbklist = null)
            : this(items, itemsElementName)
        {
            TimeInterval = timeInterval;
            KBKlist = kbklist;
        }

        /// <summary>
        /// Идентификатор плательщика; ИНН юридического лица
        /// </summary>
        [XmlElement("PayerIdentifier", typeof(string))]
        [XmlElement("PayerInn", typeof(string))]
        [XmlChoiceIdentifier("ItemsElementName")]
        public string[] Items { get; set; }

        /// <remarks/>
        [XmlElement("ItemsElementName")]
        [XmlIgnore]
        public ItemsChoiceType[] ItemsElementName { get; set; }

        /// <summary>
        /// Временной интервал, за который запрашивается информация из ГИС ГМП
        /// </summary>      
        [XmlElement(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.2.0")]
        public TimeIntervalType TimeInterval { get; set; }


        /// <summary>
        /// Перечень КБК
        /// </summary>
        [XmlIgnore]
        public KBKType[] KBKlist 
        {
            get => _KBKlist; 
            set => _KBKlist = Validator.ArrayObj(value: value, name: nameof(KBKlist), required: false, min: 1, max: 10);
        }

        KBKType[] _KBKlist;

        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlArray(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.2.0")]
        [XmlArrayItem("KBK", IsNullable = false)]
        public string[] WrapperKBKlist 
        {
            get => KBKlist?.ToArrayString();
            set => KBKlist = value?.ToArray<KBKType>(s => s); 
        }
    }
}