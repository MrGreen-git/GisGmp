using System;
using System.Xml.Serialization;

namespace GisGmp.Package
{
    /// <summary>
    /// Пакет содержащий импортируемые возврата
    /// </summary>
    [Serializable()]
    [XmlRoot("RefundsPackage", Namespace = "http://roskazna.ru/gisgmp/xsd/Package/2.1.1")]
    public class RefundsPackage : PackageType
    {
        protected RefundsPackage() { }

        public RefundsPackage(ImportedRefundType[] importedRefunds) : base(importedRefunds) { }
        public RefundsPackage(ImportedChangeType[] importedChanges) : base(importedChanges) { }
    }
}
