using System;
using System.ComponentModel;
using System.Xml;
using System.Xml.Serialization;

namespace GisGmp.Organization
{
    /// <summary>
    /// Данные организации
    /// </summary>
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Organization/2.2.0")]
    public class OrganizationType
    {
        /// <summary/>
        protected OrganizationType() { }

        /// <summary/>
        public OrganizationType(string name, INNType inn, KPPType kpp)
        {
            Name = name;
            Inn = inn;
            Kpp = kpp;
        }

        /// <summary/>
        public OrganizationType(string name, INNType inn, KPPType kpp, OGRNType ogrn = null)
            : this(name, inn, kpp) => Ogrn = ogrn;

        /// <summary/>
        public OrganizationType(OrganizationType organization)
            : this (organization.Name, organization.Inn, organization.Kpp, organization.Ogrn)
        {
        }

                       
        /// <summary>
        /// Поле номер 16: Наименование организации
        /// </summary>
        [XmlAttribute("name")]
        public string Name //TODO [regex]
        {            
            get => _Name;
            set => _Name = Validator.String(value: ref value, name: nameof(Name), required: true, min: 0, max: 160);                                                  
        }

        string _Name;

        
        /// <summary>
        /// Поле номер 61: ИНН организации
        /// </summary>
        [XmlIgnore]
        public INNType Inn 
        {
            get => _Inn;
            set => _Inn = Validator.IsNull(value: value, name: nameof(Inn));
        }

        INNType _Inn;

        /// <summary>
        /// Служебное поле
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlAttribute("inn")]
        public string WrapperInn { get => Inn; set => Inn = value; }

        
        /// <summary>
        /// Поле номер 103: КПП организации
        /// </summary>
        [XmlIgnore]
        public KPPType Kpp 
        {
            get => _Kpp; 
            set => _Kpp = Validator.IsNull(value: value, name: nameof(Kpp));
        }

        KPPType _Kpp;

        /// <summary/>
        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlAttribute("kpp")]
        public string WrapperKpp { get => Kpp; set => Kpp = value; }


        /// <summary>
        /// Поле номер 200: ОГРН организации
        /// </summary>
        [XmlIgnore]
        public OGRNType Ogrn { get; set; }

        /// <summary/>
        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlAttribute("ogrn")]
        public string WrapperOgrn { get => Ogrn; set => Ogrn = value; }
    }
}