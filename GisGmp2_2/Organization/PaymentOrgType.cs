using GisGmp.Common;
using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace GisGmp.Organization
{
    /// <summary />
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Organization/2.2.0")]
    public class PaymentOrgType //TODO [?]
    { 
        /// <summary />
        protected PaymentOrgType() { }

        /// <summary />
        public PaymentOrgType(BankType bank) => Bank = bank;

        /// <summary />
        public PaymentOrgType(PaymentOrgTypeOther paymentOrg) => PaymentOrg = paymentOrg;

        /// <summary />
        public PaymentOrgType(string ufk) => UFK = ufk;


        /// <summary />
        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlElement("Bank", typeof(BankType))]
        [XmlElement("Other", typeof(PaymentOrgTypeOther))]
        [XmlElement("UFK", typeof(string))]
        public object Item { get; set; } //TODO [multi enum]

        /// <summary />
        [XmlIgnore]
        public BankType Bank
        {
            get => Item.GetType() == typeof(BankType) ? (BankType)Item : null;
            set => Item = (value == null && value.GetType() != typeof(BankType)) ? Item : value;
        }

        /// <summary />
        [XmlIgnore]
        public PaymentOrgTypeOther PaymentOrg
        {
            get => Item.GetType() == typeof(PaymentOrgTypeOther) ? (PaymentOrgTypeOther)Item : PaymentOrgTypeOther.CASH;
            set => Item = value;
        }

        /// <summary />
        [XmlIgnore]
        public string UFK
        {
            get => Item.GetType() == typeof(string) ? (string)Item : null;
            set => Item = (value == null && value.GetType() != typeof(string)) ? Item : value;
        }
    }
}