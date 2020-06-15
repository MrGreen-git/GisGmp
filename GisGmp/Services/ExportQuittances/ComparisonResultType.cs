using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ExportQuittances
{
    /// <summary>
    /// Результат сопоставления начисления с платежом
    /// </summary>
    [Serializable()]
    [XmlRoot("ComparisonResultType", Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-quittances/2.1.1")]
    public class ComparisonResultType
    {
        /// <summary>
        /// УИП, с которым сопоставлено начисление
        /// </summary>
        [XmlAttribute("paymentId")]
        public string PaymentId { get; set; }

        /// <summary>
        /// Вес сопоставления начисления с платежом
        /// </summary>
        [XmlAttribute("comparisonWeight")]
        public ulong ComparisonWeight { get; set; }

        /// <summary>
        /// Дата сопоставления
        /// </summary>
        [XmlAttribute("comparisonDate")]
        public DateTime ComparisonDate { get; set; }

        /// <summary/>
        [XmlIgnore()]
        public bool ComparisonDateSpecified { get; set; }

        /// <summary>
        /// Сумма, указанная в платеже
        /// </summary>
        [XmlAttribute("amountPayment")]
        public ulong AmountPayment { get; set; }

        /// <summary/>
        [XmlIgnore()]
        public bool AmountPaymentSpecified { get; set; }

        /// <summary>
        /// КБК, указанный в платеже. Присутствует в результате сопоставления в случае несовпадения значений этого реквизита в данных платежа и начисления.
        /// </summary>
        [XmlAttribute("kbk")]
        public string KBK { get; set; }

        /// <summary>
        /// Код по ОКТМО, указанный в платеже. Присутствует в результате сопоставления в случае несовпадения значений этого реквизита в данных платежа и начисления.
        /// </summary>
        [XmlAttribute("oktmo")]
        public string OKTMO { get; set; }

        /// <summary>
        /// Номер счета получателя средств, указанный в платеже. Присутствует в результате сопоставления в случае несовпадения значений этого реквизита в данных платежа и начисления.
        /// </summary>
        [XmlAttribute("accountNumber")]
        public string AccountNumber { get; set; }

        /// <summary>
        /// БИК банка получателя средств, указанный в платеже. Присутствует в результате сопоставления в случае несовпадения значений этого реквизита в данных платежа и начисления.
        /// </summary>
        [XmlAttribute("bik")]
        public string BIK { get; set; }
    }
}