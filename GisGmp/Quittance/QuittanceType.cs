using GisGmp.Common;
using System;
using System.Xml.Serialization;

namespace GisGmp.Quittance
{
    /// <summary>
    /// Квитанция
    /// </summary>
    [Serializable()]
    [XmlRoot("QuittanceType", Namespace = "http://roskazna.ru/gisgmp/xsd/Quittance/2.1.1")]
    public class QuittanceType
    {
        protected QuittanceType() { }

        public QuittanceType(
            string supplierBillID,
            DateTime creationDate,
            AcknowledgmentStatusType billStatus,
            string paymentId
            )
        {
            SupplierBillID = supplierBillID;
            CreationDate = creationDate;
            BillStatus = billStatus;
            PaymentId = paymentId;
        }
       
        /// <summary>
        /// УИН
        /// </summary>
        [XmlAttribute("SupplierBillID")]
        public string SupplierBillID { get; set; }

        /// <summary>
        /// Сумма, указанная в начислении
        /// </summary>
        [XmlAttribute("totalAmount")]
        public ulong TotalAmount { get; set; }

        /// <summary/>
        [XmlIgnore()]
        public bool TotalAmountSpecified { get; set; }

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
        [XmlAttribute("balance")]
        public long Balance { get; set; }

        /// <summary/>
        [XmlIgnore()]
        public bool BalanceSpecified { get; set; }

        /// <summary>
        /// УИП, присвоенный участником, принявшим платеж
        /// </summary>
        [XmlAttribute("paymentId")]
        public string PaymentId { get; set; }

        /// <summary>
        /// Сумма, указанная в платеже
        /// </summary>
        [XmlAttribute("amountPayment")]
        public ulong AmountPayment { get; set; }

        /// <summary/>
        [XmlIgnore()]
        public bool AmountPaymentSpecified { get; set; }

        /// <summary>
        /// ИНН получателя средств (равен соответствующему значению из платежа). Присутствует в квитанции в случае несовпадения значения этого реквизита в платеже и начислении.
        /// </summary>
        [XmlAttribute("payeeINN")]
        public string PayeeINN { get; set; }

        /// <summary>
        /// КПП получателя средств (равен соответствующему значению из платежа). Присутствует в квитанции в случае несовпадения значения этого реквизита в платеже и начислении.
        /// </summary>
        [XmlAttribute("payeeKPP")]
        public string PayeeKPP { get; set; }

        /// <summary>
        /// КБК (равен соответствующему значению из платежа). Заполняется в случае несовпадения этого реквизита в данных платежа с данными начисления.
        /// </summary>
        [XmlAttribute("kbk")]
        public string KBK { get; set; }

        /// <summary>
        /// Код по ОКТМО (равен соответствующему значению из платежа). Присутствует в квитанции в случае несовпадения значения этого реквизита в платеже и начислении.
        /// </summary>
        [XmlAttribute("oktmo")]
        public string OKTMO { get; set; }

        /// <summary>
        /// Идентификатор плательщика (равен соответствующему значению из платежа). Присутствует в квитанции в случае несовпадения значения этого реквизита в платеже и начислении.
        /// </summary>
        [XmlAttribute("payerIdentifier")]
        public string PayerIdentifier { get; set; }

        /// <summary>
        /// Номер счета получателя средств (равен соответствующему значению из платежа). Присутствует в квитанции в случае несовпадения значения этого реквизита в платеже и начислении.
        /// </summary>
        [XmlAttribute("accountNumber")]
        public string AccountNumber { get; set; }

        /// <summary>
        /// БИК банка получателя средств (равен соответствующему значению из платежа). Присутствует в квитанции в случае несовпадения значения этого реквизита в платеже и начислении.
        /// </summary>
        [XmlAttribute("bik")]
        public string BIK { get; set; }

        /// <summary>
        /// Признак аннулирования квитанции: true - квитанция аннулирована; false - квитанция действующая
        /// </summary>
        [XmlAttribute("isRevoked")]
        public bool IsRevoked { get; set; }

        /// <summary/>
        [XmlIgnore()]
        public bool IsRevokedSpecified { get; set; }

        /// <summary>
        /// Дополнительные условия оплаты
        /// </summary>
        [XmlElement("DiscountFixed", typeof(DiscountFixed), Order = 1, Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.1.1")]
        [XmlElement("DiscountSize", typeof(DiscountSize), Order = 1, Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.1.1")]
        [XmlElement("MultiplierSize", typeof(MultiplierSize), Order = 1, Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.1.1")]
        public DiscountType Item { get; set; }

        /// <summary>
        /// Сведения о возврате денежных средств. Присутствует в квитанции в случае осуществления возврата денежных средств по платежу, с которым сквитировано начисление
        /// </summary>
        [XmlElement("Refund", Order = 2)]
        public QuittanceTypeRefund[] Refund { get; set; }
    }
}