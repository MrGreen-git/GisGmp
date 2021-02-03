using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace GisGmp.Quittance
{
    /// <summary>
    /// Сведения о возврате денежных средств. Присутствует в квитанции в случае осуществления возврата денежных средств по платежу, с которым сквитировано начисление
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/Quittance/2.2.0")]
    public class Refund
    {
        /// <summary />
        protected Refund() { }

        /// <summary />
        public Refund(RefundIdType refundId, ulong amount)
        {
            RefundId = refundId;
            Amount = amount;
        }

        /// <summary>
        /// Уникальный идентификатор возврата (УИВ)
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
        /// Сумма возврата
        /// </summary>
        [XmlAttribute("amount")]
        public ulong Amount { get; set; }
    }
}
