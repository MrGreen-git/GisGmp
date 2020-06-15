using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    /// <summary>
    /// Основные параметры запроса
    /// </summary>
    //[XmlInclude(typeof(ExportRequestType))]
    [Serializable()]
    [XmlRoot("RequestType", Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.1.1")]
    public abstract class RequestType
    {
        protected RequestType() { }

        public RequestType(RequestType request)
        {
            Id = request.Id;
            SenderIdentifier = request.SenderIdentifier;
            SenderRole = request.SenderRole;
            Timestamp = request.Timestamp;
        }

        public RequestType(string id, string senderIdentifier, string senderRole, DateTime timestamp)
        {
            Id = id;
            SenderIdentifier = senderIdentifier;
            SenderRole = senderRole;
            Timestamp = timestamp;
        }

        /// <summary>
        /// Идентификатор запроса
        /// </summary>
        [XmlAttribute("Id")]
        public string Id { get; set; }

        /// <summary>
        /// Дата и время формирования сообщения
        /// </summary>
        [XmlAttribute("timestamp")]
        public DateTime Timestamp { get; set; }

        /// <summary>
        /// УРН участника-отправителя сообщения
        /// </summary>
        [XmlAttribute("senderIdentifier")]
        public string SenderIdentifier { get; set; }

        /// <summary>
        /// Полномочие участника-отправителя сообщения
        /// </summary>
        [XmlAttribute("senderRole")]
        public string SenderRole { get; set; }
    }
}
