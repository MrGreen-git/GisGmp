using GisGmp.Common;
using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace GisGmp.Refund
{
    /// <summary>
    /// Получатель денежных средств
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/Refund/2.2.0")]
    public class RefundPayee : PayerType
    {
        /// <summary />
        protected RefundPayee() { }

        /// <summary />
        public RefundPayee(
            string payerIdentifier,
            string name,
            AccountType bankAccountNumber
            ) : base (payerIdentifier)
        {
            Name = name;
            BankAccountNumber = bankAccountNumber;
        }

        /// <summary>
        /// Номер счета получателя платежа
        /// </summary>
        public AccountType BankAccountNumber 
        {
            get => _BankAccountNumber;
            set => _BankAccountNumber = Validator.IsNull(value: value, name: nameof(BankAccountNumber));
        }

        AccountType _BankAccountNumber;

        /// <summary>
        /// Поле номер 3008: Номер лицевого счета получателя платежа.Заполняется только в случае, если документ исполняется вне банковской операцией на счета ТОФК, отличных от счета по учету поступлений
        /// </summary>
        public string PayeeAccount { get; set; } //TODO [type]


        /// <summary>
        /// Поле номер 8: Наименование получателя денежных средств Особенности заполнения: - для ЮЛ указывается наименование организации; - для ФЛ указывается фамилия, имя, отчество (при наличии); - для ИП указывается фамилия, имя, отчество (при наличии) ИП
        /// </summary>
        [XmlAttribute("name")]
        public string Name 
        {
            get => _Name;
            set => _Name = Validator.String(value: ref value, name: nameof(Name), required: true, min: 1, max: 160);
        }

        string _Name;

        /// <summary>
        /// Поле номер 3104: КБК.Заполняется в случае, если получателем платежа является контрагент, соответствующий лицевой счет которого открыт ТОФК или финансовой организацией
        /// </summary>
        [XmlIgnore]
        public string Kbk { get; set; }

        /// <summary />
        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlAttribute("kbk")]
        public string WrapperKbk { get => Kbk; set => Kbk = value; }


        /// <summary>
        /// Поле номер 3105: Код ОКТМО.Заполняется в случае перечисления денежных средств в бюджетную систему Российской Федерации
        /// </summary>
        [XmlIgnore]
        public OKTMOType Oktmo { get; set; }

        /// <summary />
        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlAttribute("oktmo")]
        public string WrapperOktmo { get => Oktmo; set => Oktmo = value; }
    }
}