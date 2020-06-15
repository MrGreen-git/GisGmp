using GisGmp.Common;
using GisGmp.Refund;
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ExportRefunds
{
    /// <summary>
    /// Информация о возврате денежных средств (возврат)
    /// </summary>
    [Serializable()]
    [XmlRoot("ExportRefundType", Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-refunds/2.1.1")]
    public class ExportRefundType : RefundType
    {
        /// <summary>
        /// Сведения о статусе начисления и основаниях его изменения
        /// </summary>
        [XmlElement("ChangeStatusInfo", Order = 1, Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.1.1")]
        public ChangeStatusInfo ChangeStatusInfo { get; set; }
    }
}