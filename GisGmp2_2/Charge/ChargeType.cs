using GisGmp.Common;
using GisGmp.Organization;
using GisGmp.Package;
using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace GisGmp.Charge
{
    /// <summary>
    /// Данные нового начисления
    /// </summary>
    [XmlInclude(typeof(ImportedChargeType))]
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Charge/2.2.0")]
    public class ChargeType
    {
        /// <summary />
        protected ChargeType() { }

        /// <summary />
        public ChargeType(
            SupplierBillIDType supplierBillID,
            DateTime billDate,
            ulong totalAmount,
            string purpose,
            KBKType kbk,
            OKTMOType oktmo,
            Payee payee,
            ChargePayer payer,
            BudgetIndexType budgetIndex
            ) 
        {
            SupplierBillID = supplierBillID;
            BillDate = billDate;
            TotalAmount = totalAmount;
            Purpose = purpose;
            Kbk = kbk;
            Oktmo = oktmo;
            Payee = payee;
            Payer = payer;
            BudgetIndex = budgetIndex;
        }

       
        /// <summary>
        /// Поле номер 1003: Идентификаторы начислений, на основании которых выставлено данное начисление
        /// </summary>
        [XmlIgnore]
        public SupplierBillIDType[] LinkedChargesIdentifiers 
        {
            get => _LinkedChargesIdentifiers;
            set => _LinkedChargesIdentifiers = Validator.ArrayObj(value: value, name: nameof(LinkedChargesIdentifiers), required: false, min: 1, max: 10);
        }

        SupplierBillIDType[] _LinkedChargesIdentifiers;

        /// <summary />
        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlArray("LinkedChargesIdentifiers")]
        [XmlArrayItem("SupplierBillID", IsNullable = false)]
        public string[] WrapperLinkedChargesIdentifiers 
        { 
            get => LinkedChargesIdentifiers?.ToArrayString(); 
            set => LinkedChargesIdentifiers = value?.ToArray<SupplierBillIDType>(s => s); 
        }
       

        /// <summary>
        /// Данные организации, являющейся получателем средств
        /// </summary>
        [XmlElement(Namespace = "http://roskazna.ru/gisgmp/xsd/Organization/2.2.0")]
        public Payee Payee 
        {
            get => _Payee;
            set => _Payee = value ?? throw new Exception($"{nameof(Payee)} не может иметь значание null");            
        }

        Payee _Payee;


        /// <remarks/>
        public ChargePayer Payer { get; set; }

        
        /// <summary>
        /// Дополнительные реквизиты платежа, предусмотренные приказом Минфина России от 12 ноября 2013 г. №107н
        /// </summary>
        public BudgetIndexType BudgetIndex 
        {
            get => _BudgetIndex; 
            set => _BudgetIndex = value ?? throw new Exception($"{nameof(BudgetIndex)} не может иметь значание null");
        }

        BudgetIndexType _BudgetIndex;


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
        /// Поле номер 202: Дополнительные поля начисления
        /// </summary>
        [XmlElement("AdditionalData", Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.2.0")]
        public AdditionalDataType[] AdditionalData 
        {
            get => _AdditionalData;
            set => _AdditionalData = Validator.ArrayObj(value: value, name: nameof(AdditionalData), required: false, min: 0, max: 10);
        }

        AdditionalDataType[] _AdditionalData;


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

        /// <summary />
        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlAttribute("supplierBillID")]
        public string WrapperSupplierBillID { get => SupplierBillID; set => SupplierBillID = value; }


        /// <summary>
        /// Поле номер 4: Дата, а также сведения о периоде времени, в который осуществлено начисление, либо время начисления суммы денежных средств, подлежащих уплате
        /// </summary>
        [XmlAttribute("billDate")]
        public DateTime BillDate { get; set; }


        /// <summary>
        /// Поле номер 1001: Дата, вплоть до которой актуально выставленное начисление
        /// </summary>
        [XmlIgnore]
        public DateTime? ValidUntil { get; set; }

        /// <summary />
        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlAttribute("validUntil", DataType = "date")]
        public DateTime WrapperValidUntil
        {
            get => ValidUntil.Value;
            set => ValidUntil = value;
        }

        /// <remarks/>
        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlIgnore]
        public bool WrapperValidUntilSpecified { get => ValidUntil.HasValue; }

             
        /// <summary>
        /// Поле номер 7: Сумма начисления (в копейках)
        /// </summary>
        [XmlAttribute("totalAmount")]
        public ulong TotalAmount { get; set; }

      
        /// <summary>
        /// Поле номер 24: Назначение платежа
        /// </summary>
        [XmlAttribute("purpose")]
        public string Purpose 
        {
            get => _Purpose;
            set => _Purpose = Validator.String(value: ref value, name: nameof(Purpose), required: true, min: 1, max: 210);
        }

        string _Purpose;


        /// <summary>
        /// Поле номер 104: КБК
        /// </summary>
        [XmlIgnore]
        public KBKType Kbk 
        {
            get => _Kbk; 
            set => _Kbk = value ?? throw new Exception($"{nameof(Kbk)} не может иметь значание null");
        }

        KBKType _Kbk;

        /// <summary />
        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlAttribute("kbk")]
        public string WrapperKbk { get => Kbk; set => Kbk = value; }


        /// <summary>
        /// Поле номер 105: Код по ОКТМО, указываемый АН или ГАН в соответствии с НПА
        /// </summary>
        [XmlIgnore]
        public OKTMOType Oktmo 
        {
            get => _Oktmo; 
            set => _Oktmo = value ?? throw new Exception($"{nameof(Oktmo)} не может иметь значание null");
        }

        OKTMOType _Oktmo;

        /// <summary />
        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlAttribute("oktmo")]
        public string WrapperOktmo { get => Oktmo; set => Oktmo = value; }


        /// <summary>
        /// Поле номер 37: Дата отсылки (вручения) плательщику документа с начислением в случае, если этот документ был отослан(вручен) получателем средств плательщику
        /// </summary>
        [XmlIgnore]
        public DateTime? DeliveryDate { get; set; }

        /// <summary />
        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlAttribute("deliveryDate", DataType = "date")]
        public DateTime WrapperDeliveryDate
        {
            get => DeliveryDate.Value;
            set => DeliveryDate = value;
        }

        /// <remarks/>
        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlIgnore]
        public bool WrapperDeliveryDateSpecified { get => DeliveryDate.HasValue; }


        /// <summary>
        /// Поле номер 1010: Информация о нормативном правовом (правовом) акте, являющемся основанием для исчисления суммы денежных средств, подлежащих уплате
        /// </summary>
        [XmlAttribute("legalAct")]
        public string LegalAct 
        {
            get => _LegalAct;
            set => _LegalAct = Validator.String(value: ref value, name: nameof(LegalAct), required: false, min: 0, max: 255);
        }

        string _LegalAct;


        /// <summary>
        /// Поле номер 19: Срок оплаты начисления в соответствии с нормативным правовым (правовым) актом
        /// </summary>
        [XmlIgnore]
        public DateTime? PaymentTerm { get; set; }

        /// <summary />
        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlAttribute("paymentTerm", DataType = "date")]
        public DateTime WrapperPaymentTerm
        {
            get => PaymentTerm.Value;
            set => PaymentTerm = value;
        }

        /// <summary />
        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlIgnore]
        public bool WrapperPaymentTermSpecified { get => PaymentTerm.HasValue; }


        /// <summary>
        /// Поле номер 1002: Признак предварительного начисления
        /// </summary>
        [XmlAttribute("origin")]
        public string Origin { get; set; } //TODO [?]


        /// <summary>
        /// Поле номер 1011: Количество дней от даты начисления, подлежащей уплате плательщиком, по истечении которых необходимо повторно предоставлять уведомление о начислении по подписке в случае, если оно не оплачено или сумма платежей меньше суммы к оплате, указанной в начислении
        /// </summary>
        [XmlAttribute("noticeTerm", DataType = "integer")]
        public string NoticeTerm { get; set; } //TODO [?]
    }
}