using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    /// <summary>
    /// Информация о сертификате ключа проверки ЭП
    /// </summary>
    [Serializable()]
    [XmlRoot("ImportCertificateEntryType", Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.1.1")]
    public class ImportCertificateEntryType
    {
        /// <summary>
        /// Реквизиты платежного документа
        /// </summary>
        protected ImportCertificateEntryType() { }

        public ImportCertificateEntryType(
            string Id,
            string Ownership
            )
        {
            this.Id = Id;
            this.Ownership = Ownership;
        }

        /// <summary>
        /// Уникальный в пределах запроса идентификатор описания сертификата используемый для поиска самого сертификата в элементе basic:AttachmentContentList запроса СМЭВ [required]
        /// </summary>
        [XmlAttribute("Id")]
        public string Id { get; set; }

        /// <summary>
        /// УРН владельца сертификата ключа проверки ЭП. [required]
        /// </summary>
        [XmlAttribute("ownership")]
        public string Ownership { get; set; }
    }
}
