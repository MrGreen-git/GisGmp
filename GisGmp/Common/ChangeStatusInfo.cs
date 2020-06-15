using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    /// <summary>
    /// Сведения о статусе
    /// </summary>
    [Serializable()]
    [XmlRoot("ChangeStatusInfo", Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.1.1")]
    public class ChangeStatusInfo : ChangeStatusType
    {
    }
}