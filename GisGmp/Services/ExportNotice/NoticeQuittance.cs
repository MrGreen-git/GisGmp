using GisGmp.Quittance;
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ExportNotice
{
    /// <summary>
    /// Уведомления о формировании квитанции
    /// </summary>
    [Serializable()]
    [XmlRoot("NoticeQuittance", Namespace = "urn://roskazna.ru/gisgmp/xsd/services/ExportNotice/2.1.1")]
    public class NoticeQuittance : QuittanceType
    {
    }
}