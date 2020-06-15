using GisGmp.Common;
using GisGmp.Organization;
using GisGmp.Package;
using System;
using System.Xml.Serialization;

namespace GisGmp.Refund
{
    /// <summary>
    /// Базовый тип для возврата
    /// </summary>
    [Serializable()]
    [XmlRoot("RefundType", Namespace = "http://roskazna.ru/gisgmp/xsd/Refund/2.1.1")]
    public class RefundType
    {
        protected RefundType() { }

        public RefundType(
            string RefundId,
            DateTime RefundDocDate,
            BudgetLevel BudgetLevel,
            RefundPayer RefundPayer,
            RefundApplicationType RefundApplication,
            RefundBasisType RefundBasis,
            RefundPayee Payee
            )
        {
            this.RefundId = RefundId;
            this.RefundDocDate = RefundDocDate;
            this.BudgetLevel = BudgetLevel;
            this.RefundPayer = RefundPayer;
            this.RefundApplication = RefundApplication;
            this.RefundBasis = RefundBasis;
            this.RefundPayee = Payee;
        }
       
        /// <summary>
        /// Уникальный идентификатор извещения о возврате (УИВ) [required]
        /// </summary>
        [XmlAttribute("refundId")]
        public string RefundId { get; set; }

        /// <summary>
        /// Поле номер 3001: Дата и время формирования извещения о возврате
        /// </summary>
        [XmlAttribute("refundDocDate")]
        public DateTime RefundDocDate { get; set; }

        /// <summary>
        /// Поле номер 3002: Уровень бюджета.
        /// </summary>
        [XmlAttribute("budgetLevel")]
        public BudgetLevel BudgetLevel { get; set; }

        /// <summary>
        /// Поле номер 104: КБК.Для БУ в позициях с 18 по 20 указывается код по бюджетной классификации.Для АУ, ФГУП, ГУП, МУП в случаях, предусмотренных НПА, в позициях с 18 по 20 указывается код по бюджетной классификации. В случае отсутствия следует указывать значение «0».
        /// </summary>
        [XmlAttribute("kbk")]
        public string KBK { get; set; }

        /// <summary>
        /// Поле номер 105: Код ОКТМО.В случае отсутствия следует указывать значение «0».
        /// </summary>
        [XmlAttribute("oktmo")]
        public string OKTMO { get; set; }

        /// <summary>
        /// Сведения об организации, осуществляющей возврат денежных средств
        /// </summary>
        [XmlElement("RefundPayer", Order = 1, Namespace = "http://roskazna.ru/gisgmp/xsd/Organization/2.1.1")]
        public RefundPayer RefundPayer { get; set; }

        /// <summary>
        /// Данные заявки на возврат
        /// </summary>
        [XmlElement("RefundApplication", Order = 2)]
        public RefundApplicationType RefundApplication { get; set; }

        /// <summary>
        /// Реквизиты документа-основания для осуществления возврата
        /// </summary>
        [XmlElement("RefundBasis", Order = 3)]
        public RefundBasisType RefundBasis { get; set; }

        /// <summary>
        /// Получатель денежных средств
        /// </summary>
        [XmlElement("RefundPayee", Order = 4)]
        public RefundPayee RefundPayee { get; set; }

        /// <summary>
        /// Поле номер 202: Дополнительные поля
        /// </summary>
        [XmlElement("AdditionalData", Order = 5, Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.1.1")]
        public AdditionalDataType[] AdditionalData { get; set; }
    }
}
