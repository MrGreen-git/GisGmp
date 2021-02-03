using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ExportNoticeNSI
{
    /// <summary>
    /// Предоставление из ГИС ГМП уведомлений о нормативно-справочной информации по подписке
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/ExportNoticeNSI/2.2.0")]
    [XmlRoot(Namespace = "urn://roskazna.ru/gisgmp/xsd/services/ExportNoticeNSI/2.2.0", IsNullable = false)]
    public class ExportNoticeNSIRequest
    {
        /// <summary/>
        protected ExportNoticeNSIRequest() { }

        /// <summary/>
        public ExportNoticeNSIRequest(string id, DateTime timestamp, Destination destination, NoticeNSI noticeNSI)
        {
            Id = id;
            Timestamp = timestamp;
            Destination = destination;
            NoticeNSI = noticeNSI;
        }

        /// <summary>
        /// Идентификаторы получателя уведомлений по подписке
        /// </summary>
        public Destination Destination 
        {
            get => _Destination;
            set => _Destination = Validator.IsNull(value: value, name: nameof(Destination));
        }

        Destination _Destination;


        /// <summary>
        /// Уведомление об изменении нормативно-справочной информации
        /// </summary>
        public NoticeNSI NoticeNSI 
        {
            get => _NoticeNSI;
            set => _NoticeNSI = Validator.IsNull(value: value, name: nameof(NoticeNSI));
        }

        NoticeNSI _NoticeNSI;


        /// <summary>
        /// Идентификатор запроса
        /// </summary>
        [XmlAttribute(DataType = "ID")]
        public string Id 
        {
            get => _Id;
            set => _Id = Validator.String(value: ref value, name: nameof(Id), required: true, min: 0, max: 50);
        }

        string _Id;


        /// <summary>
        /// Дата и время формирования сообщения
        /// </summary>
        [XmlAttribute("timestamp")]
        public DateTime Timestamp { get; set; }
    }
}