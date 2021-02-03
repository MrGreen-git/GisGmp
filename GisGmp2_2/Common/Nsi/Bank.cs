using System;
using System.Xml.Serialization;

namespace GisGmp.Common.Nsi
{
    /// <remarks/>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/Common-nsi/2.2.0")]
    public class Bank
    {
        /// <summary />
        protected Bank() { }

        /// <summary />
        public Bank(string bik) => Bik = bik;

        /// <summary />
        public Bank(string bik, string correspondentBankAccount)
            : this(bik) => CorrespondentBankAccount = correspondentBankAccount;

        /// <remarks/>
        [XmlAttribute("bik")]
        public string Bik { get; set; }

        /// <remarks/>
        [XmlAttribute("correspondentBankAccount")]
        public string CorrespondentBankAccount { get; set; }
    }
}