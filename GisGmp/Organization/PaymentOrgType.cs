using GisGmp.Common;
using System;
using System.Xml.Serialization;

namespace GisGmp.Organization
{
    /// <summary>
    /// Организация принявшая платеж
    /// </summary>
    [Serializable()]
    [XmlRoot("PaymentOrgType", Namespace = "http://roskazna.ru/gisgmp/xsd/Organization/2.1.1")]
    public class PaymentOrgType
    {
        /// <summary>
        /// Реквизиты платежного документа
        /// </summary>
        protected PaymentOrgType() { }

        public PaymentOrgType(string UFK) => Item = UFK;

        public PaymentOrgType(BankType Bank) => Item = Bank;

        public PaymentOrgType(PaymentOrgTypeOther Other) => Item = Other;

        /// <summary>
        /// Организация принявшая платеж
        /// </summary>
        [XmlElement("Bank", typeof(BankType), Order = 1)]
        [XmlElement("Other", typeof(PaymentOrgTypeOther), Order = 1)]
        [XmlElement("UFK", typeof(string), Order = 1)]
        public object Item { get; set; }
    }
}