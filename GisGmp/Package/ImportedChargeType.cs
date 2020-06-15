using GisGmp.Charge;
using GisGmp.Common;
using GisGmp.Organization;
using System;
using System.Xml.Serialization;

namespace GisGmp.Package
{
    /// <summary>
    /// Направляемые изменения в ранее загруженные извещения
    /// </summary>
    [Serializable()]
    [XmlRoot("ImportedChargeType", Namespace = "http://roskazna.ru/gisgmp/xsd/Package/2.1.1")]
    public class ImportedChargeType : ChargeType
    {
        /// <summary>
        /// Предназначен для работы сериализации/десериализации
        /// </summary>
        protected ImportedChargeType() { }
        
        public ImportedChargeType(
            string Id,
            string SupplierBillID,
            DateTime BillDate,
            ulong TotalAmount,
            string Purpose,
            string KBK,
            string OKTMO,
            Payee Payee,
            ChargePayer Payer,
            BudgetIndexType BudgetIndex
            ) : base(
                SupplierBillID,
                BillDate,
                TotalAmount,
                Purpose,
                KBK,
                OKTMO,
                Payee,
                Payer,
                BudgetIndex
                )
        {
            this.Id = Id;
        }

        /// <summary>
        /// УРН участника косвенного взаимодействия, сформировавшего запрос
        /// </summary>
        [XmlAttribute("originatorId")]
        public string OriginatorId { get; set; }

        /// <summary>
        /// Идентификатор начисления в пакете [required]
        /// </summary>
        [XmlAttribute("Id")]
        public string Id { get; set; }
    }

}