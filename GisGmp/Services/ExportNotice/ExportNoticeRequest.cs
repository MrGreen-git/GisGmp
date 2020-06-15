using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ExportNotice
{
    /// <summary>
    /// Предоставление из ГИС ГМП уведомлений по подписке
    /// </summary>
    [Serializable()]
    [XmlRoot("ExportNoticeRequest", Namespace = "urn://roskazna.ru/gisgmp/xsd/services/ExportNotice/2.1.1")]
    public class ExportNoticeRequest
    {
        protected ExportNoticeRequest() { }

        private ExportNoticeRequest(string id, DateTime timestamp, Destination destination)
        {
            Id = id;
            Timestamp = timestamp;
            Destination = destination;
        }

        public ExportNoticeRequest(
            string id,
            DateTime timestamp,
            Destination destination,
            NoticeCharge[] noticeCharge
            ) : this(id, timestamp, destination) => Items = noticeCharge;

        public ExportNoticeRequest(
            string id,
            DateTime timestamp,
            Destination destination,
            NoticePayment[] noticePayment
            ) : this(id, timestamp, destination) => Items = noticePayment;

        public ExportNoticeRequest(
            string id,
            DateTime timestamp,
            Destination destination,
            NoticeQuittance[] noticeQuittance
            ) : this(id, timestamp, destination) => Items = noticeQuittance;

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
        /// Идентификаторы получателя уведомлений по подписке
        /// </summary>
        [XmlElement("Destination", Order = 1)]
        public Destination Destination { get; set; }

        /// <summary>
        /// Тип уведомления
        /// </summary>
        [XmlElement("NoticeCharge", typeof(NoticeCharge), Order = 2)]
        [XmlElement("NoticePayment", typeof(NoticePayment), Order = 2)]
        [XmlElement("NoticeQuittance", typeof(NoticeQuittance), Order = 2)]
        public object[] Items { get; set; }
    }
}
