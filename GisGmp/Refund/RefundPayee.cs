using GisGmp.Common;
using System;
using System.Xml.Serialization;

namespace GisGmp.Refund
{
    /// <summary>
    /// Получатель денежных средств
    /// </summary>
    [Serializable()]
    [XmlRoot("RefundPayee", Namespace = "http://roskazna.ru/gisgmp/xsd/Refund/2.1.1")]
    public class RefundPayee : PayerType
    {
        /// <summary>
        /// Реквизиты платежного документа
        /// </summary>
        protected RefundPayee() { }

        public RefundPayee(
            string PayerIdentifier,
            string Name,
            AccountType BankAccountNumber
            ) : base(PayerIdentifier)
        {
            this.Name = Name;
            this.BankAccountNumber = BankAccountNumber;
        }
       
        /// <summary>
        /// Поле номер 16: Наименование получателя денежных средств Особенности заполнения:- для ЮЛ указывается наименование организации; - для ФЛ указывается фамилия, имя, отчество (при наличии);- для ИП указывается фамилия, имя, отчество (при наличии) ИП.
        /// </summary>
        [XmlAttribute("name")]
        public string Name { get; set; }

        /// <summary>
        /// Поле номер 3104: КБК.Заполняется в случае, если получателем платежа является контрагент, соответствующий лицевой счет которого открыт ТОФК или финансовой организацией
        /// </summary>
        [XmlAttribute("kbk")]
        public string KBK { get; set; }

        /// <summary>
        /// Поле номер 3105: Код ОКТМО.Заполняется в случае перечисления денежных средств в бюджетную систему Российской Федерации
                /// </summary>
        [XmlAttribute("oktmo")]
        public string OKTMO { get; set; }

        /// <summary>
        /// Номер банковского счета получателя платежа
        /// </summary>
        [XmlElement("BankAccountNumber", Order = 1)]
        public AccountType BankAccountNumber { get; set; }

        /// <summary>
        /// Поле номер 3007: Номер лицевого счета получателя платежа.Заполняется только в случае, если документ исполняется вне банковской операцией на счета ТОФК, отличных от счета по учету поступлений.
        /// </summary>
        [XmlElement("PayeeAccount", Order = 2)]
        public string PayeeAccount { get; set; }
    }
}
