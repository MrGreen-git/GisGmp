using GisGmp.Common;
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ImportCertificates
{
    /// <summary>
    /// Ответ на запрос приема информации о сертификате ключа проверки электронной подписи
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/import-certificates/2.2.0")]
    [XmlRoot(Namespace = "urn://roskazna.ru/gisgmp/xsd/services/import-certificates/2.2.0", IsNullable = false)]
    public class ImportCertificateResponse : ResponseType
    {
        /// <summary/>
        protected ImportCertificateResponse() { }

        /// <summary>
        /// Ответ на запрос приема информации о сертификате ключа проверки электронной подписи
        /// </summary>
        /// <param name="config"></param>
        /// <param name="importProtocol">Результат обработки сущности в пакете | required: true, min: 1, max 100</param>
        public ImportCertificateResponse(ResponseType config, ImportProtocolType[] importProtocol)
            : base(config) => ImportProtocol = importProtocol;


        #region XmlElement
        /// <summary>
        /// Результат обработки сущности в пакете | required: true, min: 1, max 100
        /// </summary>
        [XmlElement("ImportProtocol")]
        public ImportProtocolType[] ImportProtocol 
        {
            get => _ImportProtocol;
            set => _ImportProtocol = Validator.ArrayObj(value: value, name: nameof(ImportProtocol), required: true, min: 1, max: 100);
        }

        ImportProtocolType[] _ImportProtocol;
        #endregion
    }
}