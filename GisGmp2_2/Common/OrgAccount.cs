using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    /// <remarks/>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.2.0")]
    [XmlRoot(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.2.0", IsNullable = false)]
    public class OrgAccount : AccountType
    {
        /// <summary/>
        protected OrgAccount() { }

        /// <summary/>
        public OrgAccount(BankType bank)
            : base(bank) { }

        /// <summary/>
        public OrgAccount(BankType bank, AccountNumType accountNumber = null)
            : base(bank, accountNumber) { }
    }
}