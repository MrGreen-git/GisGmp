using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    /// <summary>
    /// Физическое лицо
    /// </summary>
    [Serializable()]
    [XmlRoot("EsiaUserInfoPerson", Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.1.1")]
    public class EsiaUserInfoPerson
    {
        /// <summary>
        /// Предназначен только для сериализации/десериализации
        /// </summary>
        protected EsiaUserInfoPerson() { }

        public EsiaUserInfoPerson(
            string SNILS,
            string PersonINN
            )
        {
            this.SNILS = SNILS;
            this.PersonINN = PersonINN;
        }

        /// <summary>
        /// СНИЛС физического лица, полученный из ЕСИА [required]
        /// </summary>
        [XmlAttribute("snils")]
        public string SNILS { get; set; }

        /// <summary>
        /// ИНН физического лица (гражданина РФ).Обязательно для заполнения, если физическое лицо - гражданин РФ
        /// </summary>
        [XmlAttribute("personINN")]
        public string PersonINN { get; set; }

        /// <summary>
        /// Документ, удостоверяющий личность
        /// </summary>
        [XmlElement("DocumentIdentity", Order = 1)]
        public EsiaUserInfoPersonDocumentIdentity DocumentIdentity { get; set; }        
    }
}