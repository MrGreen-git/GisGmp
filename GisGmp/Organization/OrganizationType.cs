using System;
using System.Xml.Serialization;

namespace GisGmp.Organization
{
    /// <summary>
    /// Данные организации
    /// </summary>
    [Serializable()]
    [XmlRoot("OrganizationType", Namespace = "http://roskazna.ru/gisgmp/xsd/Organization/2.1.1")]
    public class OrganizationType
    {
        /// <summary>
        /// Предназначен для работы сериализации/десериализации
        /// </summary>
        protected OrganizationType() { }

        public OrganizationType(
            string Name,
            string Inn,
            string Kpp
            )
        {
            this.Name = Name;
            this.Inn = Inn;
            this.Kpp = Kpp;
        }
      
        /// <summary>
        /// Поле номер 16: Наименование организации [required]
        /// </summary>
        [XmlAttribute("name")]
        public string Name { get; set; }

        /// <summary>
        /// Поле номер 61: ИНН организации [required]
        /// </summary>
        [XmlAttribute("inn")]
        public string Inn { get; set; }

        /// <summary>
        /// Поле номер 103: КПП организации
        /// </summary>
        [XmlAttribute("kpp")]
        public string Kpp { get; set; }

        /// <summary>
        /// Поле номер 200: ОГРН организации
        /// </summary>
        [XmlAttribute("ogrn")]
        public string Ogrn { get; set; }
    }
}