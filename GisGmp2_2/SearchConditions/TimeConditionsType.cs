using GisGmp.Common;
using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace GisGmp.SearchConditions
{
    /// <remarks/>
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/SearchConditions/2.2.0")]
    public class TimeConditionsType
    {
        /// <summary>
        protected TimeConditionsType() { }

        /// <summary>
        public TimeConditionsType(TimeIntervalType timeInterval) => TimeInterval = timeInterval;
                   
        /// <summary>
        public TimeConditionsType(TimeIntervalType timeInterval, Beneficiary[] beneficiary = null, KBKType[] kbkList = null)
            : this(timeInterval)
        {
            Beneficiary = beneficiary;
            KBKlist = kbkList;
        }


        /// <remarks/>
        [XmlElement(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.2.0")]
        public TimeIntervalType TimeInterval 
        {
            get => _TimeInterval;
            set => _TimeInterval = Validator.IsNull(value: value, name: nameof(TimeInterval));
        }

        TimeIntervalType _TimeInterval;

        /// <summary>
        /// Идентификация получателя средств, количество: null, 1-10
        /// </summary>
        [XmlElement("Beneficiary")]
        public Beneficiary[] Beneficiary
        {
            get => _Beneficiary;
            set => _Beneficiary = Validator.ArrayObj(value: value, name: nameof(Beneficiary), required: false, min: 1, max: 10);          
        }

        Beneficiary[] _Beneficiary;


        /// <summary>
        /// Перечень КБК, количество: null, 1-10
        /// </summary>   
        [XmlIgnore]
        public KBKType[] KBKlist
        {
            get => _KBKlist;
            set => _KBKlist = Validator.ArrayObj(value: value, name: nameof(KBKlist), required: false, min: 1, max: 10);
        }

        KBKType[] _KBKlist;

        /// <summary/>
        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlArray("KBKlist", Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.2.0")]
        [XmlArrayItem("KBK", IsNullable = false)]
        public string[] WrapperKBKlist
        {
            get => KBKlist?.ToArrayString();
            set { KBKlist = value?.ToArray<KBKType>(s => s); }
        }
    }
}