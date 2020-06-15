using GisGmp.Organization;
using GisGmp.Refund;
using System;
using System.Xml.Serialization;

namespace GisGmp.Package
{
    /// <summary>
    /// Направляемый новый возврат
    /// </summary>
    [Serializable()]
    [XmlRoot("ImportedRefundType", Namespace = "http://roskazna.ru/gisgmp/xsd/Package/2.1.1")]
    public class ImportedRefundType : RefundType
    {
        /// <summary>
        /// Предназначен для работы сериализации/десериализации
        /// </summary>
        protected ImportedRefundType() { }

        public ImportedRefundType(
            string Id,
            string RefundId,
            DateTime RefundDocDate,
            BudgetLevel BudgetLevel,
            RefundPayer RefundPayer,
            RefundApplicationType RefundApplication,
            RefundBasisType RefundBasis,
            RefundPayee RefundPayee
            ) : base (
                RefundId,
                RefundDocDate,
                BudgetLevel,
                RefundPayer,
                RefundApplication,
                RefundBasis,
                RefundPayee
                )
        {
            this.Id = Id;
        }
            

        /// <summary>
        /// УРН участника косвенного взаимодействия, сформировавшего запрос [required]
        /// </summary>
        [XmlAttribute("originatorId")]
        public string OriginatorId { get; set; }

        /// <summary>
        /// Идентификатор возвтата в пакете
        /// </summary>
        [XmlAttribute("Id")]
        public string Id { get; set; }
    }
}
