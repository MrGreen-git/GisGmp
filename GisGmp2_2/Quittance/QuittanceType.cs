using GisGmp.Common;
using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace GisGmp.Quittance
{
    /// <summary>
    /// Квитанция
    /// </summary>
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Quittance/2.2.0")]
    public class QuittanceType
    {
        /// <summary />
        protected QuittanceType() { }

        /// <summary />
        public QuittanceType(SupplierBillIDType supplierBillID, DateTime creationDate, AcknowledgmentStatusType billStatus, PaymentIdType paymentId)
        {
            SupplierBillID = supplierBillID;
            CreationDate = creationDate;
            BillStatus = billStatus;
            PaymentId = paymentId;
        }

        /// <summary>
        /// Дополнительные условия оплаты
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlElement("DiscountFixed", typeof(DiscountFixed), Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.2.0")]
        [XmlElement("DiscountSize", typeof(DiscountSize), Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.2.0")]
        [XmlElement("MultiplierSize", typeof(MultiplierSize), Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.2.0")]
        public DiscountType Item { get; set; }

        [XmlIgnore]
        public DiscountFixed DiscountFixed
        {
            get => Item?.GetType() == typeof(DiscountFixed) ? (DiscountFixed)Item : null;
            set => Item = (value is null && Item.GetType() != typeof(DiscountFixed)) ? Item : value;
        }

        [XmlIgnore]
        public DiscountSize DiscountSize
        {
            get => Item?.GetType() == typeof(DiscountSize) ? (DiscountSize)Item : null;
            set => Item = (value is null && Item.GetType() != typeof(DiscountSize)) ? Item : value;
        }

        [XmlIgnore]
        public MultiplierSize MultiplierSize
        {
            get => Item?.GetType() == typeof(MultiplierSize) ? (MultiplierSize)Item : null;
            set => Item = (value is null && Item.GetType() != typeof(MultiplierSize)) ? Item : value;
        }


        /// <summary>
        /// Сведения о возврате денежных средств. Присутствует в квитанции в случае осуществления возврата денежных средств по платежу, с которым сквитировано начисление
        /// </summary>
        [XmlElement("Refund")]
        public Refund[] Refund 
        {
            get => _Refund;
            set => _Refund = Validator.ArrayObj(value: value, name: nameof(Refund), required: false, min: 0, max: 20);
        }

        Refund[] _Refund;


        /// <summary>
        /// УИН
        /// </summary>
        [XmlIgnore]
        public SupplierBillIDType SupplierBillID 
        {
            get => _SupplierBillID;
            set => _SupplierBillID = Validator.IsNull(value: value, name: nameof(SupplierBillID));
        }

        SupplierBillIDType _SupplierBillID;

        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlAttribute("supplierBillID")]
        public string WrapperSupplierBillID { get => SupplierBillID; set => SupplierBillID = value; }


        /// <summary>
        /// Сумма, указанная в начислении
        /// </summary>
        [XmlIgnore]
        public ulong? TotalAmount { get; set; }

        /// <summary />
        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlAttribute("totalAmount")]
        public ulong WrapperTotalAmount { get => TotalAmount.Value; set => TotalAmount = value; }

        /// <summary />
        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlIgnore]
        public bool WrapperTotalAmountSpecified { get => TotalAmount.HasValue; }

        /// <summary>
        /// Дата квитирования (создания квитанции)
        /// </summary>
        [XmlAttribute("creationDate")]
        public DateTime CreationDate { get; set; }

        /// <summary>
        /// Статус, присвоенный начислению при создании квитанции
        /// </summary>
        [XmlAttribute("billStatus")]
        public AcknowledgmentStatusType BillStatus { get; set; }

        /// <summary>
        /// Разность между суммой, указанной в начислении и суммой платежей с учетом возвратов. Целое число, показывающее сумму в копейках. Отрицательное значение информирует о переплате.
        /// </summary>
        [XmlIgnore]
        public long? Balance { get; set; }

        /// <summary />
        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlAttribute("balance")]
        public long WrapperBalance { get => Balance.Value; set => Balance = value; }

        /// <summary />
        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlIgnore]
        public bool WrapperBalanceSpecified { get => Balance.HasValue; }


        /// <summary>
        /// УИП, присвоенный участником, принявшим платеж
        /// </summary>
        [XmlIgnore]
        public PaymentIdType PaymentId 
        {
            get => _PaymentId;
            set => _PaymentId = Validator.IsNull(value: value, name: nameof(PaymentId));
        }

        PaymentIdType _PaymentId;

        /// <summary />
        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlAttribute("paymentId")]
        public string WrapperPaymentId { get => PaymentId; set => PaymentId = value; }


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
        /// ИНН получателя средств (равен соответствующему значению из платежа). Присутствует в квитанции в случае несовпадения значения этого реквизита в платеже и начислении.
        /// </summary>
        [XmlIgnore]
        public INNType PayeeINN { get; set; }

        /// <summary />
        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlAttribute("payeeINN")]
        public string WrapperPayeeINN { get => PayeeINN; set => PayeeINN = value; }


        /// <summary>
        /// КПП получателя средств (равен соответствующему значению из платежа). Присутствует в квитанции в случае несовпадения значения этого реквизита в платеже и начислении.
        /// </summary>
        [XmlIgnore]
        public KPPType PayeeKPP { get; set; }

        /// <summary />
        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlAttribute("payeeKPP")]
        public string WrapperPayeeKPP { get => PayeeKPP; set => PayeeKPP = value; }


        /// <summary>
        /// КБК (равен соответствующему значению из платежа). Заполняется в случае несовпадения этого реквизита в данных платежа с данными начисления.
        /// </summary>
        [XmlIgnore]
        public KBKType Kbk { get; set; }

        /// <summary />
        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlAttribute("kbk")]
        public string WrapperKbk { get => Kbk; set => Kbk = value; }


        /// <summary>
        /// Код по ОКТМО (равен соответствующему значению из платежа). Присутствует в квитанции в случае несовпадения значения этого реквизита в платеже и начислении.
        /// </summary>
        [XmlIgnore]
        public OKTMOType Oktmo { get; set; }

        /// <summary />
        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlAttribute("oktmo")]
        public string WrapperOktmo { get => Oktmo; set => Oktmo = value; }


        /// <summary>
        /// Идентификатор плательщика (равен соответствующему значению из платежа). Присутствует в квитанции в случае несовпадения значения этого реквизита в платеже и начислении.
        /// </summary>
        [XmlAttribute("payerIdentifier")]
        public string PayerIdentifier 
        {
            get => _PayerIdentifier;
            set => _PayerIdentifier = Validator.String(value: ref value, name: nameof(PayerIdentifier), required: false, min: 1, max: 22);
        }

        string _PayerIdentifier;

        /// <summary>
        /// Номер счета получателя средств (равен соответствующему значению из платежа). Присутствует в квитанции в случае несовпадения значения этого реквизита в платеже и начислении.
        /// </summary>
        [XmlIgnore]
        public AccountNumType AccountNumber { get; set; }

        /// <summary />
        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlAttribute("accountNumber")]
        public string WrapperAccountNumber { get => AccountNumber; set => AccountNumber = value; }


        /// <summary>
        /// БИК банка получателя средств (равен соответствующему значению из платежа). Присутствует в квитанции в случае несовпадения значения этого реквизита в платеже и начислении.
        /// </summary>
        [XmlIgnore]
        public BIKType Bik { get; set; }

        /// <summary />
        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlAttribute("bik")]
        public string WrapperBik { get => Bik; set => Bik = value; }


        /// <summary>
        /// Признак аннулирования квитанции: true - квитанция аннулирована; false - квитанция действующая
        /// </summary>        
        [XmlIgnore]
        public bool? IsRevoked { get; set; }

        /// <summary />
        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlAttribute("isRevoked")]
        public bool WrapperIsRevoked { get => IsRevoked.Value; set => IsRevoked = value; }

        /// <summary />
        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlIgnore]
        public bool WrapperIsRevokedSpecified { get => IsRevoked.HasValue; }
    }
}