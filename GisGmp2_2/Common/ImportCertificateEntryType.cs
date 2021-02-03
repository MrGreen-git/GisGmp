using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    /// <remarks/>
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.2.0")]
    public class ImportCertificateEntryType
    {
        /// <summary />
        protected ImportCertificateEntryType() { }

        /// <summary />
        public ImportCertificateEntryType(string id, URNType ownership)
        {
            Id = id;
            Ownership = ownership;
        }


        /// <summary>
        /// Уникальный в пределах запроса идентификатор описания сертификата используемый для поиска самого сертификата в элементе basic:AttachmentContentList запроса СМЭВ
        /// </summary>
        [XmlAttribute(DataType = "IDREF")]
        public string Id 
        {
            get => _Id;
            set => _Id = Validator.String(value: ref value, name: nameof(Id), required: true, min: 0, max: 50);
        }

        string _Id;

        /// <summary>
        /// УРН владельца сертификата ключа проверки ЭП.
        /// </summary>
        [XmlIgnore]
        public URNType Ownership 
        {
            get => _Ownership; 
            set => _Ownership = value ?? throw new Exception($"{nameof(Ownership)} не может иметь значание null");
        }

        URNType _Ownership;

        /// <summary />
        [XmlAttribute("ownership")]
        public string WrapperOwnership { get => Ownership; set => Ownership = value; }
    }
}