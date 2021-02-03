using GisGmp.Common;
using GisGmp.Services.ImportCertificates;

namespace GisGmp
{
    public partial class GisGmpBuilder
    {
        /// <summary>
        /// Запрос на прием информации о сертификате ключа проверки электронной подписи
        /// </summary>
        /// <param name="certificateEntries">Информация о сертификате ключа проверки электронной подписи | required: true, min: 1, max: 100</param>
        /// <returns>CreateImportCertificateRequest -> ObjectRequest | ImportCertificate -> IdMessageSMEV</returns>
        public ImportCertificateRequest CreateImportCertificateRequest(ImportCertificateEntryType[] certificateEntries)
        {
            return new ImportCertificateRequest(
                config: RequestConfig,
                entries: certificateEntries
                );
        }


        /// <inheritdoc cref="CreateImportCertificateRequest(ImportCertificateEntryType[])"/>
        public string ImportCertificate(ImportCertificateEntryType[] certificateEntries)
            => ReadyRequest(CreateImportCertificateRequest(certificateEntries));


        /// <summary>
        /// Ответ на запрос приема информации о сертификате ключа проверки электронной подписи
        /// </summary>
        /// <param name="importProtocol">Результат обработки сущности в пакете | required: true, min: 1, max 100</param>
        /// <returns></returns>
        public ImportCertificateResponse CreateImportCertificateResponse(ImportProtocolType[] importProtocol)
        {
            return new ImportCertificateResponse(
                config: ResponseConfig,
                importProtocol: importProtocol
                );
        }        
    }
}