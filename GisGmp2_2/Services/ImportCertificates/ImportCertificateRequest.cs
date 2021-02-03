using GisGmp.Common;
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ImportCertificates
{
    /// <summary>
    /// Запрос на прием информации о сертификате ключа проверки электронной подписи
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/import-certificates/2.2.0")]
    [XmlRoot(Namespace = "urn://roskazna.ru/gisgmp/xsd/services/import-certificates/2.2.0", IsNullable = false)]
    public class ImportCertificateRequest : RequestType
    {
        /// <summary />
        protected ImportCertificateRequest() { }

        /// <summary>
        /// Запрос на прием информации о сертификате ключа проверки электронной подписи
        /// </summary>
        /// <param name="config"></param>
        /// <param name="entries">Информация о сертификате ключа проверки электронной подписи | required: true, min: 1, max: 100</param>
        public ImportCertificateRequest(RequestType config, ImportCertificateEntryType[] entries)
            : base(config) => RequestEntry = entries;


        #region XmlElement
        /// <summary>
        /// Информация о сертификате ключа проверки электронной подписи | required: true, min: 1, max: 100
        /// </summary>
        [XmlElement("RequestEntry")]
        public ImportCertificateEntryType[] RequestEntry 
        {
            get => _RequestEntry;
            set => _RequestEntry = Validator.ArrayObj(value: value, name: nameof(RequestEntry), required: true, min: 1, max: 100);
        }

        ImportCertificateEntryType[] _RequestEntry;
        #endregion
    }
}