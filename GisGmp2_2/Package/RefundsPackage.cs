using System;
using System.Xml.Serialization;

namespace GisGmp.Package
{
    /// <summary>
    /// Направляемое новое извещение о возврате
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/Package/2.2.0")]
    [XmlRoot(Namespace = "http://roskazna.ru/gisgmp/xsd/Package/2.2.0", IsNullable = false)]
    public class RefundsPackage : PackageType
    {
        /// <summary/>
        protected RefundsPackage() { }

        /// <summary/>
        public RefundsPackage(ImportedRefundType[] importedRefunds) => ImportedRefunds = importedRefunds;

        /// <summary/>
        public RefundsPackage(ImportedChangeType[] importedChanges) => ImportedChanges = importedChanges;

        [XmlIgnore]
        public ImportedRefundType[] ImportedRefunds
        {
            get => Items.GetType() == typeof(ImportedRefundType[]) ? (ImportedRefundType[])Items : null;
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