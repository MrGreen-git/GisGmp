using GisGmp.Common;
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ImportCertificates
{
    /// <summary>
    /// Запрос на прием информации о сертификате ключа проверки электронной подписи
    /// </summary>
    [Serializable()]
    [XmlRoot("ImportCertificateRequest", Namespace = "urn://roskazna.ru/gisgmp/xsd/services/import-certificates/2.1.1")]
    public class ImportCertificateRequest : RequestType
    {
        protected ImportCertificateRequest() { }

        public ImportCertificateRequest(RequestType config, ImportCertificateEntryType[] Entries)
            :base(config) => RequestEntry = Entries;

        /// <summary>
        /// Информация о сертификате ключа проверки ЭП
        /// </summary>
        [XmlElement("RequestEntry", Order = 1)]
        public ImportCertificateEntryType[] RequestEntry { get; set; }
    }
}
