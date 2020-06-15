using GisGmp.Common;
using GisGmp.Package;
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ImportPayments
{
    /// <summary>
    /// Прием информации об уплате (информация из распоряжения плательщика)
    /// </summary>
    [Serializable()]
    [XmlRoot("ImportPaymentsRequest", Namespace = "urn://roskazna.ru/gisgmp/xsd/services/import-payments/2.1.1")]
    public class ImportPaymentsRequest : RequestType
    {
        protected ImportPaymentsRequest() { }
        public ImportPaymentsRequest(RequestType config, PaymentsPackage package)
            : base(config) => PaymentsPackage = package;

        /// <summary>
        /// Пакет, содержащий направляемые платежи
        /// </summary>
        [XmlElement("PaymentsPackage", Order = 1, Namespace = "http://roskazna.ru/gisgmp/xsd/Package/2.1.1")]
        public PaymentsPackage PaymentsPackage { get; set; }
    }
}
