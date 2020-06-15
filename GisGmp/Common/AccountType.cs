using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    /// <summary>
    /// Описание счета организации / банка
    /// </summary>
    [Serializable()]
    [XmlRoot("AccountType", Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.1.1")]
    public class AccountType
    {
        /// <summary>
        /// Предназначен только для сериализации/десериализации
        /// </summary>
        protected AccountType() { }

        public AccountType(
            BankType Bank,
            string AccountNumber = null          
            )
        {
            this.Bank = Bank;
            //TODO Странно проверить
            if(AccountNumber != null) this.AccountNumber = AccountNumber;     
        }
    
        /// <summary>
        /// Поле номер 17:Номер банковского счета
        /// </summary>
        [XmlAttribute("accountNumber")]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Данные банка, в котором открыт счет
        /// </summary>
        [XmlElement("Bank", Order = 1)]
        public BankType Bank { get; set; }
    }
}