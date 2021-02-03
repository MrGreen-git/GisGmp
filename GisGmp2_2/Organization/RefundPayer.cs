using System;
using System.Xml.Serialization;

namespace GisGmp.Organization
{
    /// <remarks/>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/Organization/2.2.0")]
    [XmlRoot(Namespace = "http://roskazna.ru/gisgmp/xsd/Organization/2.2.0", IsNullable = false)]
    public class RefundPayer : OrganizationType
    {
        /// <summary/>
        protected RefundPayer() { }

        /// <summary/>
        public RefundPayer(string codeUBP, string name, INNType inn, KPPType kpp)
            : base(name, inn, kpp) => CodeUBP = codeUBP;

        /// <summary/>
        public RefundPayer(string codeUBP, string name, INNType inn, KPPType kpp, OGRNType ogrn) 
            : base(name, inn, kpp, ogrn) => CodeUBP = codeUBP;
        

        /// <summary/>
        [XmlAttribute("codeUBP")]
        public string CodeUBP 
        {
            get => _CodeUBP;
            set => _CodeUBP = Validator.IsNull(value: value, name: nameof(CodeUBP));
        }

        string _CodeUBP;
    }
}