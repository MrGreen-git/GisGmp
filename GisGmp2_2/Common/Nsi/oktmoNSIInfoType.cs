using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace GisGmp.Common.Nsi
{
    /// <remarks/>
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Common-nsi/2.2.0")]
    public class oktmoNSIInfoType
    {
        /// <summary />
        protected oktmoNSIInfoType() { }

        /// <summary />
        public oktmoNSIInfoType(string name, OKTMOType oktmo, string status, DateTime changeDate) 
        {
            Name = name;
            Oktmo = oktmo;
            Status = status;
            ChangeDate = changeDate;
        }

        /// <remarks/>
        [XmlAttribute("name")]
        public string Name 
        {
            get => _Name;
            set => _Name = Validator.String(value: ref value, name: nameof(Name), required: true, min: 0, max: 500); 
        }

        string _Name;


        /// <remarks/>
        [XmlIgnore]
        public OKTMOType Oktmo 
        {
            get => _Oktmo;
            set => _Oktmo = Validator.IsNull(value: value, name: nameof(Oktmo));
        }

        OKTMOType _Oktmo;

        /// <remarks/>
        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlAttribute("oktmo")]
        public string WrapperOktmo { get => Oktmo; set => Oktmo = value; }


        /// <remarks/>
        [XmlAttribute("status")]
        public string Status 
        {
            get => _Status;
            set => _Status = Validator.String(value: ref value, name: nameof(Status), required: true, min: 0, max: 1);
        }

        string _Status;

        /// <remarks/>
        [XmlAttribute("changeDate")]
        public DateTime ChangeDate { get; set; }
    }
}