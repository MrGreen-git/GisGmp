using GisGmp.Common;
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ImportCertificates
{
    /// <summary>
    /// Ответ на запрос приема информации о сертификате ключа проверки электронной подписи
    /// </summary>
    [Serializable()]
    [XmlRoot("ImportCertificateResponse", Namespace = "urn://roskazna.ru/gisgmp/xsd/services/import-certificates/2.1.1")]
    public class ImportCertificateResponse : ImportPackageResponseType
    {
        protected ImportCertificateResponse() { }

        public ImportCertificateResponse(ResponseType config, ImportProtocolType[] importProtocol)           
            : base(config, importProtocol)
        { 
        }
    }
}