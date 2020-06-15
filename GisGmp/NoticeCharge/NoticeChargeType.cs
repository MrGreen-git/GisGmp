using GisGmp.Common;
using System;
using System.Xml.Serialization;

namespace GisGmp.NoticeCharge
{
    /// <summary>
    /// Данные уведомления о начислении
    /// </summary>
    [Serializable()]
    [XmlRoot("NoticeChargeType", Namespace = "http://roskazna.ru/gisgmp/xsd/NoticeCharge/2.1.1")]
    public class NoticeChargeType
    {
        #region Attribute
        /// <summary>
        /// УИН
        /// </summary>
        [XmlAttribute("supplierBillID")]
        public string SupplierBillID { get; set; }

        /// <summary>
        /// Дата и время начисления суммы денежных средств, подлежащих уплате
        /// </summary>
        [XmlAttribute("billDate")]
        public DateTime BillDate { get; set; }

        /// <summary>
        /// Дата, вплоть до которой актуально выставленное начисление
        /// </summary>
        [XmlAttribute("validUntil")]
        public DateTime ValidUntil { get; set; }

        /// <summary/>
        [XmlIgnore()]
        public bool ValidUntilSpecified { get; set; }

        /// <summary>
        /// Сумма начисления (в копейках) [required]
        /// </summary>
        [XmlAttribute("totalAmount")]
        public ulong TotalAmount { get; set; }

        /// <summary>
        /// Назначение платежа [required]
        /// </summary>
        [XmlAttribute("purpose")]
        public string Purpose { get; set; }

        /// <summary>
        /// КБК [required]
        /// </summary>
        [XmlAttribute("kbk")]
        public string KBK { get; set; }

        /// <summary>
        /// Наименование организации, являющейся получателем средств []
        /// </summary>
        [XmlAttribute("name")]
        public string Name { get; set; }
        #endregion

        #region Element
        /// <summary>
        /// Сведения о плательщике
        /// </summary>
        [XmlElement("Payer", Order = 1)]
        public NoticeChargePayer Payer { get; set; }

        /// <summary>
        /// Сведения о статусе
        /// </summary>
        [XmlElement("ChangeStatusInfo", Order = 2, Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.1.1")]
        public ChangeStatusInfo ChangeStatusInfo { get; set; }

        /// <summary>
        /// Дополнительные условия оплаты
        /// </summary>
        [XmlElement("DiscountFixed", typeof(DiscountFixed), Order = 3, Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.1.1")]
        [XmlElement("DiscountSize", typeof(DiscountSize), Order = 3, Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.1.1")]
        [XmlElement("MultiplierSize", typeof(MultiplierSize), Order = 3, Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.1.1")]
        public DiscountType Item { get; set; }
        #endregion
    }
}