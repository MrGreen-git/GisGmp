using GisGmp.Common;
using GisGmp.Payment;
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ExportNotice
{
    /// <summary>
    /// Уведомления о поступившем платеже, уточнении или аннулировании платежа
    /// </summary>
    [Serializable()]
    [XmlRoot("NoticePayment", Namespace = "urn://roskazna.ru/gisgmp/xsd/services/ExportNotice/2.1.1")]
    public class NoticePayment : PaymentType
    {
        /// <summary>
        /// Сведения о статусе
        /// </summary>
        [XmlElement("ChangeStatusInfo", Order = 1, Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.1.1")]
        public ChangeStatusInfo ChangeStatusInfo { get; set; }
    }
}