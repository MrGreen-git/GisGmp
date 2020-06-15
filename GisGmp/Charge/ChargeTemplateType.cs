using GisGmp.Common;
using GisGmp.Organization;
using System;
using System.Xml.Serialization;

namespace GisGmp.Charge
{
    /// <summary>
    /// Данные шаблона формирования начисления
    /// </summary>
    [Serializable()]
    [XmlRoot("ChargeTemplateType", Namespace = "http://roskazna.ru/gisgmp/xsd/Charge/2.1.1")]
    public class ChargeTemplateType
    {
        #region Attribute     
        /// <summary>
        /// УИН
        /// </summary>
        [XmlAttribute("supplierBillID")]
        public string SupplierBillID { get; set; }

        /// <summary>
        /// Поле номер 4: Дата, а также сведения о периоде времени, в который осуществлено начисление, либо время начисления суммы денежных средств, подлежащих уплате
        /// </summary>
        [XmlAttribute("billDate")]
        public DateTime  BillDate { get; set; }

        /// <summary>
        /// Поле номер 1001: Дата, вплоть до которой актуально выставленное начисление
        /// </summary>
        [XmlAttribute("validUntil")]
        public DateTime ValidUntil { get; set; }

        /// <summary/>
        [XmlIgnore()]
        public bool ValidUntilSpecified { get; set; }

        /// <summary>
        /// Поле номер 7: Сумма начисления (в копейках) [required]
        /// </summary>
        [XmlAttribute("totalAmount")]
        public ulong TotalAmount { get; set; }

        /// <summary>
        /// Поле номер 24: Назначение платежа [required]
        /// </summary>
        [XmlAttribute("purpose")]
        public string Purpose { get; set; }

        /// <summary>
        /// Поле номер 104: КБК [required]
        /// </summary>
        [XmlAttribute("kbk")]
        public string KBK { get; set; }

        /// <summary>
        /// Поле номер 105: Код по ОКТМО, указываемый АН или ГАН в соответствии с НПА [required]
        /// </summary>
        [XmlAttribute("oktmo")]
        public string OKTMO { get; set; }

        /// <summary>
        /// Поле номер 37: Дата отсылки (вручения) плательщику документа с начислением в случае, если этот документ был отослан(вручен) получателем средств плательщику
        /// </summary>
        [XmlAttribute("deliveryDate")]
        public DateTime DeliveryDate { get; set; }

        /// <summary/>
        [XmlIgnore()]
        public bool DeliveryDateSpecified { get; set; }

        /// <summary>
        /// Поле номер 1010: Информация о нормативном правовом (правовом) акте, являющемся основанием для исчисления суммы денежных средств, подлежащих уплате
        /// </summary>
        [XmlAttribute("legalAct")]
        public string LegalAct { get; set; }

        /// <summary>
        /// Поле номер 19: Срок оплаты начисления в соответствии с нормативным правовым (правовым) актом
        /// </summary>
        [XmlAttribute("paymentTerm")]
        public DateTime PaymentTerm { get; set; }

        /// <summary/>
        [XmlIgnore()]
        public bool PaymentTermSpecified { get; set; }

        /// <summary>
        /// Поле номер 1002: Признак предварительного начисления
        /// </summary>
        [XmlAttribute("origin")]
        public string Origin { get; set; }
        #endregion

        #region Element
        /// <summary>
        /// Данные организации, являющейся получателем средств
        /// </summary>
        [XmlElement("Payee", Order = 1, Namespace = "http://roskazna.ru/gisgmp/xsd/Organization/2.1.1")]
        public Payee Payee { get; set; }

        /// <summary>
        /// Сведения о плательщике
        /// </summary>
        [XmlElement("Payer", Order = 2)]
        public ChargePayer Payer { get; set; }

        /// <summary>
        /// Дополнительные реквизиты платежа (допустимые значения статуса плательщика (атрибут status): 01… 13, 15…28)
        /// </summary>
        [XmlElement("BudgetIndex", Order = 3)]
        public BudgetIndexType BudgetIndex { get; set; }

        /// <summary>
        /// Дополнительные условия оплаты
        /// </summary>
        [XmlElement("DiscountFixed", typeof(DiscountFixed), Order = 4, Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.1.1")]
        [XmlElement("DiscountSize", typeof(DiscountSize), Order = 4, Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.1.1")]
        [XmlElement("MultiplierSize", typeof(MultiplierSize), Order = 4, Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.1.1")]
        public DiscountType Item { get; set; }

        /// <summary>
        /// Поле номер 202: Дополнительные поля начисления
        /// </summary>
        [XmlElement("AdditionalData", Order = 5, Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.1.1")]
        public AdditionalDataType[] AdditionalData { get; set; }
        #endregion
    }
}