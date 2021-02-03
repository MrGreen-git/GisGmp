using GisGmp.Common;
using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace GisGmp.NoticeCharge
{
    /// <summary>
    /// Данные уведомления о начислении
    /// </summary>
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/NoticeCharge/2.2.0")]
    public class NoticeChargeType
    {
        /// <summary />
        protected NoticeChargeType() { }

        /// <summary />
        public NoticeChargeType(
            SupplierBillIDType supplierBillID,
            DateTime billDate,
            ulong totalAmount,
            string purpose,
            KBKType kbk,
            string name,
            NoticeChargeTypePayer payer,
            ChangeStatusInfo changeStatusInfo
            )
        {
            SupplierBillID = supplierBillID;
            BillDate = billDate;
            TotalAmount = totalAmount;
            Purpose = purpose;
            Kbk = kbk;
            Name = name;
            Payer = payer;
            ChangeStatusInfo = changeStatusInfo;
        }

        /// <summary>
        /// Сведения о плательщике
        /// </summary>
        public NoticeChargeTypePayer Payer 
        {
            get => _Payer;
            set => _Payer = Validator.IsNull(value: value, name: nameof(Payer)); 
        }

        NoticeChargeTypePayer _Payer;

        /// <remarks/>
        [XmlElement(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.2.0")]
        public ChangeStatusInfo ChangeStatusInfo 
        {
            get => _ChangeStatusInfo;
            set => _ChangeStatusInfo = Validator.IsNull(value: value, name: nameof(ChangeStatusInfo));
        }

        ChangeStatusInfo _ChangeStatusInfo;


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
        /// УИН
        /// </summary>
        [XmlIgnore]
        public SupplierBillIDType SupplierBillID { get; set; }

        /// <summary />
        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlAttribute("supplierBillID")]
        public string WrapperSupplierBillID { get => SupplierBillID; set => SupplierBillID = value; }


        /// <summary>
        /// Дата и время начисления суммы денежных средств, подлежащих уплате
        /// </summary>
        [XmlAttribute("billDate")]
        public DateTime BillDate { get; set; }

        /// <summary>
        /// Дата, вплоть до которой актуально выставленное начисление
        /// </summary>
        [XmlIgnore]
        public DateTime? ValidUntil { get; set; }

        /// <summary />
        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlAttribute("validUntil", DataType = "date")]
        public DateTime WrapperValidUntil { get => ValidUntil.Value; set => ValidUntil = value; }

        /// <remarks/>
        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlIgnore]
        public bool WrapperValidUntilSpecified { get => ValidUntil.HasValue; }


        /// <summary>
        /// Сумма начисления (в копейках)
        /// </summary>
        [XmlAttribute("totalAmount")]
        public ulong TotalAmount { get; set; }

        /// <summary>
        /// Назначение платежа
        /// </summary>
        [XmlAttribute("purpose")]
        public string Purpose 
        {
            get => _Purpose;
            set => _Purpose = Validator.String(value: ref value, name: nameof(Purpose), required: true, min: 0, max: 210);
        }

        string _Purpose;


        /// <summary>
        /// КБК
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
        /// Наименование организации, являющейся получателем средств
        /// </summary>
        [XmlAttribute("name")]
        public string Name 
        {
            get => _Name;
            set => _Name = Validator.String(value: ref value, name: nameof(Name), required: true, min: 0, max: 160);
        }

        string _Name;
    }
}