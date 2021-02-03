using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace GisGmp.Services.ExportQuittances
{
    /// <summary>
    /// Результат сопоставления начисления с платежом
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-quittances/2.2.0")]
    public class ComparisonResult
    {
        /// <summary />
        protected ComparisonResult() { }

        /// <summary>
        public ComparisonResult(PaymentIdType paymentId, ulong comparisonWeight)
        {
            PaymentId = paymentId;
            ComparisonWeight = comparisonWeight;
        }

        /// <summary>
        /// УИП, с которым сопоставлено начисление
        /// </summary>
        [XmlIgnore]
        public PaymentIdType PaymentId 
        {
            get => _PaymentId;
            set => _PaymentId = Validator.IsNull(value: value, name: nameof(PaymentId));
        }

        PaymentIdType _PaymentId;

        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlAttribute("paymentId")]
        public string WrapperPaymentId { get => PaymentId; set => PaymentId = value; }


        /// <summary>
        /// Вес сопоставления начисления с платежом
        /// </summary>
        [XmlAttribute("comparisonWeight")]
        public ulong ComparisonWeight { get; set; }

        /// <summary>
        /// Дата сопоставления
        /// </summary>
        [XmlIgnore]
        public DateTime? ComparisonDate { get; set; }

        /// <summary />
        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlAttribute("comparisonDate")]
        public DateTime WrapperComparisonDate { get => ComparisonDate.Value; set => ComparisonDate = value; }

        /// <summary />
        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlIgnore]
        public bool WrapperComparisonDateSpecified { get => ComparisonDate.HasValue; }


        /// <summary>
        /// Сумма, указанная в платеже
        /// </summary>
        [XmlIgnore]
        public ulong? AmountPayment { get; set; }

        /// <summary />
        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlAttribute("amountPayment")]
        public ulong WrapperAmountPayment { get => AmountPayment.Value; set => AmountPayment = value; }

        /// <summary />
        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlIgnore]
        public bool WrapperAmountPaymentSpecified { get => AmountPayment.HasValue; }


        /// <summary>
        /// КБК, указанный в платеже. Присутствует в результате сопоставления в случае несовпадения значений этого реквизита в данных платежа и начисления
        /// </summary>
        [XmlIgnore]
        public KBKType Kbk { get; set; }

        /// <summary />
        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlAttribute("kbk")]
        public string WrapperKbk { get => Kbk; set => Kbk = value; }


        /// <summary>
        /// Код по ОКТМО, указанный в платеже. Присутствует в результате сопоставления в случае несовпадения значений этого реквизита в данных платежа и начисления
        /// </summary>
        [XmlIgnore]
        public OKTMOType Oktmo { get; set; }

        /// <summary />
        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlAttribute("oktmo")]
        public string WrapperOktmo { get => Oktmo; set => Oktmo = value; }


        /// <summary>
        /// Номер счета получателя средств, указанный в платеже. Присутствует в результате сопоставления в случае несовпадения значений этого реквизита в данных платежа и начисления
        /// </summary>
        [XmlIgnore]
        public AccountNumType AccountNumber { get; set; }

        /// <summary />
        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlAttribute("accountNumber")]
        public string WrapperAccountNumber { get => AccountNumber; set => AccountNumber = value; }


        /// <summary>
        /// БИК банка получателя средств, указанный в платеже. Присутствует в результате сопоставления в случае несовпадения значений этого реквизита в данных платежа и начисления.
        /// </summary>
        [XmlIgnore]
        public BIKType Bik { get; set; }

        /// <summary />
        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlAttribute("bik")]
        public string WrapperBik { get => Bik; set => Bik = value; }
    }
}