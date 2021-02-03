using GisGmp.Common;
using GisGmp.Organization;
using GisGmp.Package;
using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace GisGmp.Refund
{
    /// <summary>
    /// Базовый тип для возврата
    /// </summary>
    [XmlInclude(typeof(ImportedRefundType))]
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Refund/2.2.0")]
    public class RefundType
    {
        /// <summary />
        protected RefundType() { }

        /// <summary />
        public RefundType(
            string refundId, 
            DateTime refundDocDate, 
            BudgetLevel budgetLevel,
            RefundPayee refundPayee,
            RefundApplication refundApplication,
            RefundBasis refundBasis,
            RefundPayer refundPayer)
        {
            RefundId = refundId;
            RefundDocDate = refundDocDate;
            BudgetLevel = budgetLevel;
            RefundPayee = refundPayee;
            RefundApplication = refundApplication;
            RefundBasis = refundBasis;
            RefundPayer = refundPayer;
        }

        /// <summary>
        /// Сведения об организации, осуществляющей возврат денежных средств
        /// </summary>
        [XmlElement(Namespace = "http://roskazna.ru/gisgmp/xsd/Organization/2.2.0")]
        public RefundPayer RefundPayer 
        {
            get => _RefundPayer;
            set => _RefundPayer = Validator.IsNull(value: value, name: nameof(RefundPayer));
        }

        RefundPayer _RefundPayer;


        /// <summary>
        /// Данные заявки на возврат
        /// </summary>
        public RefundApplication RefundApplication
        {
            get => _RefundApplication;
            set => _RefundApplication = Validator.IsNull(value: value, name: nameof(RefundApplication));
        }

        RefundApplication _RefundApplication;


        /// <summary>
        /// Реквизиты документа-основания для осуществления возврата
        /// </summary>
        public RefundBasis RefundBasis 
        {
            get => _RefundBasis;
            set => _RefundBasis = Validator.IsNull(value: value, name: nameof(RefundBasis));
        }

        RefundBasis _RefundBasis;


        /// <summary>
        /// Получатель денежных средств
        /// </summary>
        public RefundPayee RefundPayee 
        {
            get => _RefundPayee;
            set => _RefundPayee = Validator.IsNull(value: value, name: nameof(RefundPayee)); 
        }

        RefundPayee _RefundPayee;

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
        /// Уникальный идентификатор извещения о возврате (УИВ)
        /// </summary>
        [XmlIgnore]
        public RefundIdType RefundId 
        {
            get => _RefundId;
            set => _RefundId = Validator.IsNull(value: value, name: nameof(RefundId));
        }

        RefundIdType _RefundId;

        /// <summary />
        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlAttribute("refundId")]
        public string WrapperRefundId { get => RefundId; set => RefundId = value; }


        /// <summary>
        /// Поле номер 3001: Дата и время формирования извещения о возврате
        /// </summary>
        [XmlAttribute("refundDocDate")]
        public DateTime RefundDocDate { get; set; }

        /// <summary>
        /// Поле номер 3002: Уровень бюджета
        /// </summary>
        [XmlAttribute("budgetLevel")]
        public BudgetLevel BudgetLevel 
        {
            get => _BudgetLevel;
            set => _BudgetLevel = Validator.IsNull(value: value, name: nameof(BudgetLevel));
        }

        BudgetLevel _BudgetLevel;

        /// <summary>
        /// Поле номер 104: КБК. Для БУ в позициях с 18 по 20 указывается код по бюджетной классификации.Для АУ, ФГУП, ГУП, МУП в случаях, предусмотренных НПА, в позициях с 18 по 20 указывается код по бюджетной классификации. В случае отсутствия следует указывать значение «0»
        /// </summary>
        [XmlIgnore]
        public KBKType Kbk { get; set; }

        /// <summary />
        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlAttribute("kbk")]
        public string WrapperKbk { get => Kbk; set => Kbk = value; }


        /// <summary>
        /// Поле номер 105: Код ОКТМО. В случае отсутствия следует указывать значение «0»
        /// </summary>
        [XmlIgnore]
        public OKTMOType Oktmo { get; set; }

        /// <summary />
        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlAttribute("oktmo")]
        public string WrapperOktmo { get => Oktmo; set => Oktmo = value; }
    }
}