using System;
using System.Xml.Serialization;

namespace GisGmp.Common.Nsi
{
    /// <remarks/>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/Common-nsi/2.2.0")]
    public class OrgAccount
    {
        /// <summary />
        protected OrgAccount() { }

        /// <summary />
        public OrgAccount(string accountNumber, Bank bank)
        {
            AccountNumber = accountNumber;
            Bank = bank;
        }

        /// <remarks/>
        public Bank Bank { get; set; }

        /// <remarks/>
        [XmlAttribute("accountNumber")]
        public string AccountNumber { get; set; }
    }
}