using GisGmp.Common;
using GisGmp.Income;
using GisGmp.Organization;
using GisGmp.Package;
using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace GisGmp.Payment
{
    /// <summary>
    /// Базовый тип для платежа
    /// </summary>
    [XmlInclude(typeof(PaymentType))]
    [XmlInclude(typeof(ImportedPaymentType))]
    [XmlInclude(typeof(IncomeType))]
    [XmlInclude(typeof(ImportedIncomeType))]
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Payment/2.2.0")]
    public class PaymentBaseType
    {
        /// <summary />
        protected PaymentBaseType() { }

        /// <summary />
        public PaymentBaseType(
            PaymentOrgType paymentOrg,
            Payee payee,
            string purpose,
            ulong amount,
            TransKindType transKind
            ) 
        {
            PaymentOrg = paymentOrg;
            Payee = payee;
            Purpose = purpose;
            Amount = amount;
            TransKind = transKind; 
        }

        /// <summary>
        /// Данные организации, принявшей платеж
        /// </summary>
        public PaymentOrgType PaymentOrg 
        {
            get => _PaymentOrg;
            set => _PaymentOrg = Validator.IsNull(value: value, name: nameof(PaymentOrg));
        }

        PaymentOrgType _PaymentOrg;


        /// <summary>
        /// Поле номер 2006: Сведения о плательщике
        /// </summary>
        public PaymentPayer Payer { get; set; }


        /// <summary>
        /// Сведения о получателе средств
        /// </summary>
        [XmlElement(Namespace = "http://roskazna.ru/gisgmp/xsd/Organization/2.2.0")]
        public Payee Payee 
        {
            get => _Payee;
            set => _Payee = Validator.IsNull(value: value, name: nameof(Payee));
        }

        Payee _Payee;


        /// <summary>
        /// Поле номер 2007: Реквизиты платежа 101, 106-109, предусмотренные приказом Минфина России от 12 ноября 2013г. №107н
        /// </summary>
        public BudgetIndexType BudgetIndex { get; set; }


        /// <summary>
        /// Поле номер 2008: Реквизиты платежного документа
        /// </summary>
        public AccDocType AccDoc { get; set; }


        /// <summary>
        /// Поле номер 202: Дополнительные поля
        /// </summary>
        [XmlElement("AdditionalData", Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.2.0")]
        public AdditionalDataType[] AdditionalData 
        {
            get => _AdditionalData;
            set => _AdditionalData = Validator.ArrayObj(value: value, name: nameof(AdditionalData), required: false, min: 0, max: 10);
        }

        AdditionalDataType[] _AdditionalData;


        /// <summary>
        /// Поле номер 1000: УИН
        /// </summary>        
        [XmlIgnore]
        public SupplierBillIDType SupplierBillID { get; set; }

        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlAttribute("supplierBillID")]
        public string WrapperSupplierBillID { get => SupplierBillID; set => SupplierBillID = value; }


        /// <summary>
        /// Поле номер 24: Назначение платежа
        /// </summary>
        [XmlAttribute("purpose")]
        public string Purpose 
        {
            get => _Purpose;
            set => _Purpose = Validator.String(value: ref value, name: nameof(Purpose), required: false, min: 0, max: 210);
        }

        string _Purpose;


        /// <summary>
        /// Поле номер 7: Сумма платежа в копейках
        /// </summary>
        [XmlAttribute("amount")]
        public ulong Amount { get; set; }


        /// <summary>
        /// Поле номер 62: Дата поступления распоряжения в банк плательщика.Обязательно для заполнения в случае поступления распоряжения в кредитную организацию
        /// </summary>
        [XmlIgnore]
        public DateTime? ReceiptDate { get; set; }

        /// <summary />
        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlAttribute("receiptDate", DataType = "date")]
        public DateTime WrapperReceiptDate { get => ReceiptDate.Value; set => ReceiptDate = value; }

        /// <summary />
        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlIgnore]
        public bool WrapperReceiptDateSpecified { get => ReceiptDate.HasValue; }



        /// <summary>
        /// Поле номер 104: КБК.
        /// </summary>
        [XmlIgnore]
        public KBKType Kbk { get; set; }

        /// <summary />
        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlAttribute("kbk")]
        public string WrapperKbk { get => Kbk; set => Kbk = value; }


        /// <summary>
        /// Поле номер 105: Код ОКТМО, указанный в распоряжении о переводе денежных средств.
        /// </summary>
        [XmlIgnore]
        public OKTMOType Oktmo { get; set; }

        /// <summary />
        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlAttribute("oktmo")]
        public string WrapperOktmo { get => Oktmo; set => Oktmo = value; }


        /// <summary>
        /// Поле номер 18: Вид операции.Указывается шифр платежного документа.
        /// </summary>
        [XmlAttribute("transKind")]
        public TransKindType TransKind { get; set; }
    }
}