using GisGmp.NoticeCharge;
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ExportNotice
{
    /// <summary>
    /// Уведомления о начислении, уточнении или аннулировании начисления
    /// </summary>
    [Serializable()]
    [XmlRoot("NoticeCharge", Namespace = "urn://roskazna.ru/gisgmp/xsd/services/ExportNotice/2.1.1")]
    public class NoticeCharge : NoticeChargeType
    {
    }
}