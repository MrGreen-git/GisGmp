using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    /// <summary>
    /// Документ, удостоверяющий личность
    /// </summary>
    [Serializable()]
    [XmlRoot("EsiaUserInfoPersonDocumentIdentity", Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.1.1")]
    public class EsiaUserInfoPersonDocumentIdentity
    {
        /// <summary>
        /// Предназначен только для сериализации/десериализации
        /// </summary>
        protected EsiaUserInfoPersonDocumentIdentity() { }

        public EsiaUserInfoPersonDocumentIdentity(
            EsiaUserInfoPersonDocumentIdentityCode Code,
            string Number
            )
        {
            this.Code = Code;
            this.Number = Number;
        }

        /// <summary>
        /// Код документа, удостоверяющего личность
        /// </summary>
        [XmlAttribute("code")]
        public EsiaUserInfoPersonDocumentIdentityCode Code { get; set; }

        /// <summary>
        /// Серия
        /// </summary>
        [XmlAttribute("series")]
        public string Series { get; set; }

        /// <summary>
        /// Номер [required]
        /// </summary>
        [XmlAttribute("number")]
        public string Number { get; set; }
    }
}