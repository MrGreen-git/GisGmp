using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    /// <summary>
    /// Описание реквизитов казначейского счета или банковского счета, открытого кредитной организации в ПБР
    /// </summary>
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.2.0")]
    public class AccountType
    {
        /// <summary/>
        protected AccountType() { }

        /// <summary/>
        public AccountType(BankType bank) => Bank = bank;
              
        /// <summary/>
        public AccountType(BankType bank, AccountNumType accountNumber = null)
            : this(bank) => AccountNumber = accountNumber;
        

        /// <summary>
        /// Данные ТОФК, структурного подразделения кредитной организации или подразделения Банка России, в котором открыт счет
        /// </summary>
        public BankType Bank 
        {
            get => _Bank;
            set => _Bank = Validator.IsNull(value: value, name: nameof(Bank));
        }

        BankType _Bank;


        /// <summary>
        /// Поле номер 17: Номер казначейского счета или номер счета получателя средств в банке получателя
        /// </summary>
        [XmlIgnore]
        public AccountNumType AccountNumber { get; set; }

        /// <summary/>
        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlAttribute("accountNumber")]
        public string WrapperAccountNumber { get => AccountNumber; set => AccountNumber = value; }
    }
}