using System;
using System.Xml.Serialization;

namespace GisGmp.Package
{
    /// <summary>
    /// Пакет содержащий импортируемые начисления
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/Package/2.2.0")]
    [XmlRoot(Namespace = "http://roskazna.ru/gisgmp/xsd/Package/2.2.0", IsNullable = false)]
    public class ChargesPackage : PackageType
    {
        /// <summary/>
        protected ChargesPackage() { }

        /// <summary/>
        public ChargesPackage(ImportedChargeType[] importedCharges) => ImportedCharges = importedCharges;

        /// <summary/>
        public ChargesPackage(ImportedChangeType[] importedChanges) => ImportedChanges = importedChanges;


        [XmlIgnore]
        public ImportedChargeType[] ImportedCharges
        {
            get => Items?.GetType() == typeof(ImportedChargeType[]) ? (ImportedChargeType[])Items : null;            
            set => Items = value;           
        }

        [XmlIgnore]
        public ImportedChangeType[] ImportedChanges
        {
            get => Items?.GetType() == typeof(ImportedChangeType[]) ? (ImportedChangeType[])Items : null;
            set => Items = value;
        }
    }
}