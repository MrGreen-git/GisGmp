using GisGmp.Common;
using GisGmp.Organization;
using GisGmp.Refund;
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ExportRefunds
{
    /// <summary>
    /// Информация о возврате денежных средств (возврат)
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-refunds/2.2.0")]
    public class Refund : RefundType
    {
        /// <summary />
        protected Refund() { }

        /// <summary />
        public Refund(
            ChangeStatusInfo changeStatusInfo,
            string refundId,
            DateTime refundDocDate,
            BudgetLevel budgetLevel,
            RefundPayee refundPayee,
            RefundApplication refundApplication,
            RefundBasis refundBasis,
            RefundPayer refundPayer
            ) : base(refundId, refundDocDate, budgetLevel, refundPayee, refundApplication, refundBasis, refundPayer) 
            => ChangeStatusInfo = changeStatusInfo;

        /// <summary>
        /// Сведения о статусе начисления и основаниях его изменения
        /// </summary>
        [XmlElement(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.2.0")]
        public ChangeStatusInfo ChangeStatusInfo 
        {
            get => _ChangeStatusInfo;
            set => _ChangeStatusInfo = Validator.IsNull(value: value, name: nameof(ChangeStatusInfo));
        }

        ChangeStatusInfo _ChangeStatusInfo;
    }
}