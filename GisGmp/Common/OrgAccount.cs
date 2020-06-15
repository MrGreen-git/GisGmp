using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    /// <summary>
    /// Реквизиты счета организации
    /// </summary>
    [Serializable()]
    [XmlRoot("OrgAccount", Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.1.1")]
    public class OrgAccount : AccountType
    {
        /// <summary>
        /// Предназначен только для сериализации/десериализации
        /// </summary>
        protected OrgAccount() { }

        public OrgAccount(string AccountNumber, BankType Bank) : base(Bank, AccountNumber) { }
    }
}