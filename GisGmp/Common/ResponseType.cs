using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    /// <summary>
    /// Основные параметры ответа на запрос
    /// </summary>
    [Serializable()]
    [XmlRoot("ResponseType", Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.1.1")]
    public abstract class ResponseType
    {
        protected ResponseType() { }

        public ResponseType(ResponseType response)
        {
            Id = response.Id;
            RqId = response.RqId;
            RecipientIdentifier = response.RecipientIdentifier;
            Timestamp = response.Timestamp;
        }

        /// <summary>
        /// Идентификатор ответа
        /// </summary>
        [XmlAttribute("Id")]
        public string Id { get; set; }

        /// <summary>
        /// Идентификатор запроса [required]
        /// </summary>
        [XmlAttribute("RqId")]
        public string RqId { get; set; }

        /// <summary>
        /// УРН участника получателя
        /// </summary>
        [XmlAttribute("recipientIdentifier")]
        public string RecipientIdentifier { get; set; }

        /// <summary>
        /// Дата и время формирования ответа
        /// </summary>
        [XmlAttribute("timestamp")]
        public DateTime Timestamp { get; set; }
    }
}