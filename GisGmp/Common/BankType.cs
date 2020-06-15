using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    /// <summary>
    /// Данные банка
    /// </summary>
    [Serializable()]
    [XmlRoot("BankType", Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.1.1")]
    public class BankType
    {
        private BankType() { }

        public BankType(string BIK)
        {
            this.BIK = BIK;
        }
        /// <summary>
        /// Поле номер 13 для получателя средств. Поле номер 10 для организации, принявшей платеж: Наименование структурного подразделения кредитной организации или подразделения Банка России, в котором открыт счет.
        /// </summary>
        [XmlAttribute("name")]
        public string Name { get; set; }

        /// <summary>
        /// Поле номер 14 для получателя средств. Поле номер 11 для организации, принявшей платеж: БИК структурного подразделения кредитной организации или подразделения Банка России, в котором открыт счет [required]
        /// </summary>
        [XmlAttribute("bik")]
        public string BIK { get; set; }

        /// <summary>
        /// Поле номер 15 для получателя средств. Поле номер 12 для организации, принявшей платеж: Номер корреспондентского счета кредитной организации, открытый в подразделении Банка России.
        /// </summary>
        [XmlAttribute("correspondentBankAccount")]
        public string CorrespondentBankAccount { get; set; }
    }
}