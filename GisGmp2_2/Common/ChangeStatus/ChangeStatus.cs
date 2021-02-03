using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    /// <summary>
    /// Сведения о статусе и основаниях изменения
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.2.0")]
    [XmlRoot(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.2.0", IsNullable = false)]
    public class ChangeStatus : ChangeStatusType
    {
    }
}