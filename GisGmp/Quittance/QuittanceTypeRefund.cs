using System;
using System.Xml.Serialization;

namespace GisGmp.Quittance
{
    /// <summary>
    /// Сведения о возврате денежных средств. Присутствует в квитанции в случае осуществления возврата денежных средств по платежу, с которым сквитировано начисление
    /// </summary>
    [Serializable()]
    [XmlRoot("QuittanceTypeRefund", Namespace = "http://roskazna.ru/gisgmp/xsd/Quittance/2.1.1")]
    public class QuittanceTypeRefund
    {
        protected QuittanceTypeRefund() { }
        public QuittanceTypeRefund(
            string refundId,
            ulong amount
            )
        {
            RefundId = refundId;
            Amount = amount;
        }

        /// <summary>
        /// Уникальный идентификатор возврата (УИВ)
        /// </summary>
        [XmlAttribute("refundId")]
        public string RefundId { get; set; }

        /// <summary>
        /// Сумма возврата
        /// </summary>
        [XmlAttribute("amount")]
        public ulong Amount { get; set; }
    }
}