using System;
using System.Xml.Serialization;

namespace GisGmp.Package
{
    /// <summary>
    /// Пакет содержащий импортируемые начисления
    /// </summary>
    [Serializable()]
    [XmlRoot("ChargesPackage", Namespace = "http://roskazna.ru/gisgmp/xsd/Package/2.1.1")]
    public class ChargesPackage : PackageType
    {
        protected ChargesPackage() { }

        public ChargesPackage(ImportedChargeType[] importedCharges) : base(importedCharges) { }
        public ChargesPackage(ImportedChangeType[] importedChanges) : base(importedChanges) { }
    }
}
