using GisGmp.Common;
using GisGmp.Package;
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ImportRefunds
{
    /// <summary>
    /// Прием информации о возврате
    /// </summary>
    [Serializable()]
    [XmlRoot("ImportRefundsRequest", Namespace = "urn://roskazna.ru/gisgmp/xsd/services/import-refunds/2.1.1")]
    public class ImportRefundsRequest : RequestType
    {
        protected ImportRefundsRequest() { }
        public ImportRefundsRequest(RequestType config, RefundsPackage package)
            : base(config) => RefundsPackage = package;

        /// <summary>
        /// Пакет содержащий импортируемые возврата
        /// </summary>
        [XmlElement("RefundsPackage", Order = 1, Namespace = "http://roskazna.ru/gisgmp/xsd/Package/2.1.1")]
        public RefundsPackage RefundsPackage { get; set; }
    }
}
