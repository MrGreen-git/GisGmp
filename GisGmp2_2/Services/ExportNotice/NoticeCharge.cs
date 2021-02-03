using GisGmp.Common;
using GisGmp.NoticeCharge;
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ExportNotice
{
    /// <summary>
    /// Уведомления о начислении, уточнении или аннулировании начисления
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/ExportNotice/2.2.0")]
    public class NoticeCharge : NoticeChargeType
    {
        /// <summary />
        protected NoticeCharge() { }

        /// <summary />
        public NoticeCharge(
            SupplierBillIDType supplierBillID,
            DateTime billDate,
            ulong totalAmount,
            string purpose,
            KBKType kbk,
            string name,
            NoticeChargeTypePayer payer,
            ChangeStatusInfo changeStatusInfo
            ) : base(supplierBillID, billDate, totalAmount, purpose, kbk, name, payer, changeStatusInfo) { }      
    }
}