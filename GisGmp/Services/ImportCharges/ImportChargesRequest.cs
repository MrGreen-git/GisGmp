using GisGmp.Common;
using GisGmp.Package;
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ImportCharges
{
    /// <summary>
    /// Прием необходимой для уплаты информации (начисления)
    /// </summary>
    [Serializable()]
    [XmlRoot("ImportChargesRequest", Namespace = "urn://roskazna.ru/gisgmp/xsd/services/import-charges/2.1.1")]
    public class ImportChargesRequest : RequestType
    {
        protected ImportChargesRequest() { }

        public ImportChargesRequest(RequestType config, ChargesPackage package)
            : base(config) => ChargesPackage = package;

        /// <summary>
        /// Пакет содержащий импортируемые начисления
        /// </summary>
        [XmlElement("ChargesPackage", Order = 1, Namespace = "http://roskazna.ru/gisgmp/xsd/Package/2.1.1")]
        public ChargesPackage ChargesPackage { get; set; }
    }
}
