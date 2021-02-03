using GisGmp.Common;
using GisGmp.Quittance;
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ExportNotice
{
    /// <summary>
    /// Уведомления о формировании квитанции
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/ExportNotice/2.2.0")]
    public class NoticeQuittance : QuittanceType
    {
        /// <summary />
        protected NoticeQuittance() { }

        public NoticeQuittance(SupplierBillIDType supplierBillID, DateTime creationDate, AcknowledgmentStatusType billStatus, PaymentIdType paymentId)
            : base(supplierBillID, creationDate, billStatus, paymentId) { }
    }
}