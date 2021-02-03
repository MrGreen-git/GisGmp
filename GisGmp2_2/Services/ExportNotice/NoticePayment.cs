using GisGmp.Common;
using GisGmp.Organization;
using GisGmp.Payment;
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ExportNotice
{
    /// <summary>
    /// Уведомления о поступившем платеже, уточнении или аннулировании платежа
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/ExportNotice/2.2.0")]
    public class NoticePayment : PaymentType
    {
        /// <summary />
        protected NoticePayment() { }

        /// <summary />
        public NoticePayment(
            ChangeStatusInfo changeStatusInfo,
            PaymentIdType paymentId,
            DateTime paymentDate,
            PaymentOrgType paymentOrg,
            Payee payee,
            string purpose,
            ulong amount,
            TransKindType transKind)
            : base(paymentId, paymentDate, paymentOrg, payee, purpose, amount, transKind) => ChangeStatusInfo = changeStatusInfo;


        /// <summary>
        /// Сведения о статусе платежа и основаниях его изменения
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