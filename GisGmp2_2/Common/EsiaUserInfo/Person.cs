using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    /// <remarks/>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.2.0")]
    public class Person
    {
        /// <summary />
        protected Person() { }

        /// <summary />
        public Person(DocumentIdentity documentIdentity, string snils, string personINN) 
        {
            DocumentIdentity = documentIdentity;
            Snils = snils;
            PersonINN = personINN;
        }

        /// <summary>
        /// Документ, удостоверяющий личность
        /// </summary>
        public DocumentIdentity DocumentIdentity { get; set; }

      
        /// <summary>
        /// СНИЛС физического лица, полученный из ЕСИА
        /// </summary>
        [XmlAttribute("snils")]
        public string Snils { get; set; }

        /// <summary>
        /// ИНН физического лица (гражданина РФ). Обязательно для заполнения, если физическое лицо - гражданин РФ
        /// </summary>
        [XmlAttribute("personINN")]
        public string PersonINN { get; set; }
    }
}