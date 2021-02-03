using System;
using System.Xml.Serialization;

namespace GisGmp.Package
{
    /// <summary>
    /// Пакет, содержащий направляемые зачисления
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/Package/2.2.0")]
    [XmlRoot(Namespace = "http://roskazna.ru/gisgmp/xsd/Package/2.2.0", IsNullable = false)]
    public class IncomesPackage : PackageType
    {
    }
}