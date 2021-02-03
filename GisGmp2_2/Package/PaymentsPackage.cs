using System;
using System.Xml.Serialization;

namespace GisGmp.Package
{
    /// <summary>
    /// Пакет, содержащий направляемые платежи
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/Package/2.2.0")]
    [XmlRoot(Namespace = "http://roskazna.ru/gisgmp/xsd/Package/2.2.0", IsNullable = false)]
    public class PaymentsPackage : PackageType
    {
        /// <summary/>
        protected PaymentsPackage() { }

        /// <summary/>
        public PaymentsPackage(ImportedPaymentType[] importedPayments) => ImportedPayments = importedPayments;
        /// <summary/>
        public PaymentsPackage(ImportedChangeType[] importedChanges) => ImportedChanges = importedChanges;

        [XmlIgnore]
        public ImportedPaymentType[] ImportedPayments
        {
            get => Items.GetType() == typeof(ImportedPaymentType[]) ? (ImportedPaymentType[])Items : null;
            set => Items = value;
        }

        [XmlIgnore]
        public ImportedChangeType[] ImportedChanges
        {
            get => Items.GetType() == typeof(ImportedChangeType[]) ? (ImportedChangeType[])Items : null;
            set => Items = value;
        }
    }
}