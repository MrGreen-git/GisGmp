using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    /// <summary>
    /// Данные пользователя, полученные информационной системой Участника из ЕСИА
    /// </summary>
    [Serializable()]
    [XmlRoot("EsiaUserInfoType", Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.1.1")]
    public class EsiaUserInfoType
    {
        /// <summary>
        /// Предназначен только для сериализации/десериализации
        /// </summary>
        protected EsiaUserInfoType() { }

        public EsiaUserInfoType(
            string UserId,
            object Item
            )
        {
            this.UserId = UserId;
            this.Item = Item;
        }

        /// <summary>
        /// Уникальный идентификатор учетной записи пользователя в системе ЕСИА [required]
        /// </summary>
        [XmlAttribute("userId")]
        public string UserId { get; set; }

        /// <summary>
        /// Уникальный идентификатор сессии пользователя в системе ЕСИА
        /// </summary>
        [XmlAttribute("sessionIndex")]
        public string SessionIndex { get; set; }

        /// <summary>
        /// Дата и время открытия сессии пользователя в системе ЕСИА
        /// </summary>
        [XmlAttribute("sessionDate")]
        public DateTime SessionDate { get; set; }

        /// <summary/>
        [XmlIgnore()]
        public bool SessionDateSpecified { get; set; }

        /// <summary>
        /// ИП / ФЛ
        /// </summary>
        [XmlElement("IndividualBusiness", typeof(EsiaUserInfoIndividualBusiness), Order = 1)]
        [XmlElement("Person", typeof(EsiaUserInfoPerson), Order = 1)]
        public object Item { get; set; }    
    }
}