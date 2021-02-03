using GisGmp.Common;
using GisGmp.Organization;
using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace GisGmp.Charge
{
    /// <summary>
    /// Данные шаблона формирования начисления
    /// </summary>
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Charge/2.2.0")]
    public class ChargeTemplateType
    {
        /// <summary />
        protected ChargeTemplateType() { }

        /// <summary />
        public ChargeTemplateType(
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
        /// Данные организации, являющейся получателем средств
        /// </summary>
        [XmlElement(Namespace = "http://roskazna.ru/gisgmp/xsd/Organization/2.2.0")]
        public Payee Payee 
        {
            get => _Payee;
            set => _Payee = Validator.IsNull(value: value, name: nameof(Payee));
        }

        Payee _Payee;


        /// <summary>
        /// Сведения о плательщике
        /// </summary>
        public ChargePayer Payer 
        {
            get => _Payer;
            set => _Payer = Validator.IsNull(value: value, name: nameof(Payer));
        }

        ChargePayer _Payer;


        /// <summary>
        /// Дополнительные реквизиты платежа, предусмотренные приказом Минфина России от 12 ноября 2013 г. №107н
        /// </summary>
        public BudgetIndexType BudgetIndex 
        {
            get => _BudgetIndex;
            set => _BudgetIndex = Validator.IsNull(value: value, name: nameof(BudgetIndex)); 
        }

        BudgetIndexType _BudgetIndex;

        /// <summary>
        /// Дополнительные условия оплаты
        /// </summary>
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
        public SupplierBillIDType SupplierBillID { get; set; }

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
        [XmlAttribute("validUntil", DataType = "date")]
        public DateTime ValidUntil { get; set; }

        /// <remarks/>
        [XmlIgnore]
        public bool ValidUntilSpecified { get; set; }

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
            set => _Purpose = Validator.String(value: ref value, name: nameof(Purpose), required: true, min: 0, max: 210);
        }

        string _Purpose;

        /// <summary>
        /// Поле номер 104: КБК
        /// </summary>
        [XmlIgnore]
        public KBKType Kbk 
        {
            get => _Kbk;
            set => _Kbk = Validator.IsNull(value: value, name: nameof(Kbk));
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
        public OKTMOType Oktmo { get; set; }

        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlAttribute("oktmo")]
        public string WrapperOktmo { get => Oktmo; set => Oktmo = value; }


        /// <summary>
        /// Поле номер 37: Дата отсылки (вручения) плательщику документа с начислением в случае, если этот документ был отослан(вручен) получателем средств плательщику
        /// </summary>
        [XmlAttribute("deliveryDate", DataType = "date")]
        public DateTime DeliveryDate { get; set; }

        /// <remarks/>
        [XmlIgnore]
        public bool DeliveryDateSpecified { get; set; }


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
        [XmlAttribute("paymentTerm", DataType = "date")]
        public DateTime PaymentTerm { get; set; }

        /// <remarks/>
        [XmlIgnore]
        public bool PaymentTermSpecified { get; set; }

        /// <summary>
        /// Поле номер 1002: Признак предварительного начисления
        /// </summary>
        [XmlAttribute("origin")]
        public string Origin { get; set; }
    }
}