using GisGmp.Common;
using GisGmp.Organization;
using GisGmp.Package;
using System;
using System.Xml.Serialization;

namespace GisGmp.Payment
{
    /// <summary>
    /// Базовый тип платежа
    /// </summary>
    [Serializable()]
    [XmlRoot("PaymentType", Namespace = "http://roskazna.ru/gisgmp/xsd/Payment/2.1.1")]
    public class PaymentType
    {
        /// <summary>
        /// Предназначен для работы сериализации/десериализации
        /// </summary>
        protected PaymentType() { }

        public PaymentType(
            string PaymentId,
            string Purpose,
            ulong Amount,
            DateTime PaymentDate,
            TransKindType TransKind,
            PaymentOrgType PaymentOrg,
            Payee Payee
            )
        {
            this.PaymentId = PaymentId;
            this.Purpose = Purpose;
            this.Amount = Amount;
            this.PaymentDate = PaymentDate;
            this.TransKind = TransKind;
            this.PaymentOrg = PaymentOrg;
            this.Payee = Payee;
        }

        #region Attribute
        /// <summary>
        /// УИП, присвоенный участником, принявшим платеж
        /// </summary>
        [XmlAttribute("paymentId")]
        public string PaymentId { get; set; }

        /// <summary>
        /// Поле номер 1000: УИН
        /// </summary>
        [XmlAttribute("supplierBillID")]
        public string SupplierBillID { get; set; }

        /// <summary>
        /// Поле номер 24: Назначение платежа
        /// </summary>
        [XmlAttribute("purpose")]
        public string Purpose { get; set; }

        /// <summary>
        /// Поле номер 7: Сумма платежа в копейках
        /// </summary>
        [XmlAttribute("amount")]
        public ulong Amount { get; set; }

        /// <summary>
        /// Поле номер 2001: Дата приема к исполнению распоряжения плательщика
        /// </summary>
        [XmlAttribute("paymentDate")]
        public DateTime PaymentDate { get; set; }

        /// <summary>
        /// Поле номер 62: Дата поступления распоряжения в банк плательщика.Обязательно для заполнения в случае поступления распоряжения в кредитную организацию
        /// </summary>
        [XmlAttribute("receiptDate")]
        public DateTime ReceiptDate { get; set; }

        /// <summary/>
        [XmlIgnore()]
        public bool ReceiptDateSpecified { get; set; }

        /// <summary>
        /// Поле номер 104: КБК.Обязательно, если расчетный счет получателя средств открыт не на балансовом счете «40302»
        /// </summary>
        [XmlAttribute("kbk")]
        public string KBK { get; set; }

        /// <summary>
        /// Поле номер 105: Код ОКТМО, указанный в распоряжении о переводе денежных средств.В случае отсутствия следует указывать значение «0». Обязательно, если расчетный счет получателя средств открыт не на балансовом счете «40302»
        /// </summary>
        [XmlAttribute("oktmo")]
        public string OKTMO { get; set; }

        /// <summary>
        /// Поле номер 37: Дата отсылки(вручения) плательщику документа с начислением в случае, если этот документ был отослан(вручен) получателем средств плательщику
        /// </summary>
        [XmlAttribute("deliveryDate")]
        public DateTime DeliveryDate { get; set; }

        /// <summary/>
        [XmlIgnore()]
        public bool DeliveryDateSpecified { get; set; }

        /// <summary>
        /// Поле номер 2002: Идентификатор учетной записи пользователя в ЕСИА
        /// </summary>
        [XmlAttribute("ESIA_ID")]
        public string ESIA_ID { get; set; }

        /// <summary>
        /// Поле номер 18: Вид операции.Указывается шифр платежного документа.
        /// </summary>
        [XmlAttribute("transKind")]
        public TransKindType TransKind { get; set; }
        #endregion

        #region Element
        /// <summary>
        /// Данные организации, принявшей платеж
        /// </summary>
        [XmlElement("PaymentOrg", Order = 1)]
        public PaymentOrgType PaymentOrg { get; set; }

        /// <summary>
        ///  Информация о плательщике
        /// </summary>
        [XmlElement("Payer", Order = 2)]
        public PaymentPayer Payer { get; set; }

        /// <summary>
        /// Сведения о получателе средств
        /// </summary>
        [XmlElement("Payee", Order = 3, Namespace = "http://roskazna.ru/gisgmp/xsd/Organization/2.1.1")]
        public Payee Payee { get; set; }

        /// <summary>
        /// Реквизиты платежа 101, 106-109, предусмотренные приказом Минфина России от 12 ноября 2013 г. №107н
        /// </summary>
        [XmlElement("BudgetIndex", Order = 4)]
        public BudgetIndexType BudgetIndex { get; set; }

        /// <summary>
        /// Реквизиты платежного документа
        /// </summary>
        [XmlElement("AccDoc", Order = 5)]
        public AccDocType AccDoc { get; set; }

        /// <summary>
        /// Информация о частичном платеже
        /// </summary>
        [XmlElement("PartialPayt", Order = 6)]
        public PartialPaytType PartialPayt { get; set; }

        /// <summary>
        /// Поле номер 202: Дополнительные поля
        /// </summary>
        [XmlElement("AdditionalData", Order = 7, Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.1.1")]
        public AdditionalDataType[] AdditionalData { get; set; }
        #endregion
    }
}