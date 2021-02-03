using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace GisGmp.Common.Nsi
{
    /// <remarks/>
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Common-nsi/2.2.0")]
    public class PayeeNSIInfoType
    {
        /// <summary />
        protected PayeeNSIInfoType() { }

        /// <summary />
        public PayeeNSIInfoType(
            string name,
            string inn,
            string kpp, 
            string orgStatus,
            DateTime changeDate
            )
        {
            Name = name;
            Inn = inn;
            Kpp = kpp;
            OrgStatus = orgStatus;
            ChangeDate = changeDate;
        }

        /// <remarks/>
        [XmlIgnore]
        public KBKType[] KBKlist 
        {
            get => _KBKlist;
            set => _KBKlist = Validator.ArrayObj(value: value, name: nameof(KBKlist), required: false, min: 1, max: 10);
        }

        KBKType[] _KBKlist;

        [XmlArray("KBKlist")]
        [XmlArrayItem("KBK", IsNullable = false)]
        public string[] WrapperKBKlist { get => KBKlist?.ToArrayString(); set => KBKlist = value.ToArray<KBKType>(s => s); }


        /// <remarks/>
        [XmlArrayItem("OrgAccount", IsNullable = false)]
        public OrgAccount[] OrgAccountlist { get; set; }

        /// <remarks/>
        [XmlAttribute("name")]
        public string Name 
        {
            get => _Name;
            set => _Name = Validator.String(value: ref value, name: nameof(Name), required: true, min: 0, max: 160);
        }

        string _Name;


        /// <remarks/>
        [XmlIgnore]
        public INNType Inn 
        {
            get => _Inn;
            set => _Inn = Validator.IsNull(value: value, name: nameof(Inn)); 
        }

        INNType _Inn;

        /// <remarks/>
        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlAttribute("inn")]
        public string WrapperInn { get => Inn; set => Inn = value; }


        /// <remarks/>
        [XmlIgnore]
        public KPPType Kpp 
        {
            get => _Kpp;
            set => _Kpp = Validator.IsNull(value: value, name: nameof(Kpp));
        }

        KPPType _Kpp;

        /// <remarks/>
        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlAttribute("kpp")]
        public string WrapperKpp { get => Kpp; set => Kpp = value; }


        /// <remarks/>
        [XmlAttribute]
        public string kbkGlavaCode 
        {
            get => _kbkGlavaCode;
            set => _kbkGlavaCode = Validator.String(value: ref value, name: nameof(kbkGlavaCode), required: false, min: 0, max: 3);
        }

        string _kbkGlavaCode;


        /// <remarks/>
        [XmlAttribute]
        public string OrgStatus
        {
            get => _OrgStatus;
            set => _OrgStatus = Validator.String(value: ref value, name: nameof(OrgStatus), required: true, min: 0, max: 1);
        }

        string _OrgStatus;


        /// <remarks/>
        [XmlAttribute("changeDate")]
        public DateTime ChangeDate { get; set; }
    }
}