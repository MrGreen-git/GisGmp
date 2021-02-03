using GisGmp.Common;
using GisGmp.Package;
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ImportCharges
{
    /// <remarks/>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/import-charges/2.2.0")]
    [XmlRoot(Namespace = "urn://roskazna.ru/gisgmp/xsd/services/import-charges/2.2.0", IsNullable = false)]
    public class ImportChargesRequest : RequestType
    {
        /// <summary>
        /// Служебный конструктор (для десериализации)
        /// </summary>
        protected ImportChargesRequest() { }

        /// <summary />
        public ImportChargesRequest(RequestType config, ChargesPackage package)
            : base(config) => ChargesPackage = package;

        /// <summary>
        /// Пакет, содержащий импортируемые начисления
        /// </summary>
        [XmlElement(Namespace = "http://roskazna.ru/gisgmp/xsd/Package/2.2.0")]
        public ChargesPackage ChargesPackage 
        {
            get => _ChargesPackage;
            set => _ChargesPackage = Validator.IsNull(value: value, name: nameof(ChargesPackage));
        }

        ChargesPackage _ChargesPackage;
    }
}