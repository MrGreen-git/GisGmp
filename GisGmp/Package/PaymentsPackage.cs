using System;
using System.Xml.Serialization;

namespace GisGmp.Package
{
    /// <summary>
    /// Пакет, содержащий направляемые платежи
    /// </summary>
    [Serializable()]
    [XmlRoot("PaymentsPackage", Namespace = "http://roskazna.ru/gisgmp/xsd/Package/2.1.1")]
    public class PaymentsPackage : PackageType
    {
        protected PaymentsPackage() { }

        public PaymentsPackage(ImportedPaymentType[] importedPayments) : base(importedPayments) { }
        public PaymentsPackage(ImportedChangeType[] importedChanges) : base(importedChanges) { }
    }
}
