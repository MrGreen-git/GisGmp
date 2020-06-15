using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    /// <summary>
    /// Сведения о статусе и основаниях изменения
    /// </summary>
    [Serializable()]
    [XmlRoot("ChangeStatus", Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.1.1")]
    public class ChangeStatus : ChangeStatusType
    {
    }
}
