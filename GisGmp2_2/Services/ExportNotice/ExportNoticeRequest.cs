using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace GisGmp.Services.ExportNotice
{
    /// <summary>
    /// Предоставление из ГИС ГМП уведомлений по подписке
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/ExportNotice/2.2.0")]
    [XmlRoot(Namespace = "urn://roskazna.ru/gisgmp/xsd/services/ExportNotice/2.2.0", IsNullable = false)]
    public class ExportNoticeRequest
    {
        /// <summary/>
        protected ExportNoticeRequest() { }

        /// <summary/>
        private ExportNoticeRequest(string id, DateTime timestamp, Destination destination)
        {
            Id = id;
            Timestamp = timestamp;
            Destination = destination;
        }

        /// <summary/>
        public ExportNoticeRequest(
            string id,
            DateTime timestamp,
            Destination destination,
            NoticeCharge[] noticeCharge
            ) : this(id, timestamp, destination) => NoticeCharge = noticeCharge;

        /// <summary/>
        public ExportNoticeRequest(
            string id,
            DateTime timestamp,
            Destination destination,
            NoticePayment[] noticePayment
            ) : this(id, timestamp, destination) => NoticePayment = noticePayment;

        /// <summary/>
        public ExportNoticeRequest(
            string id,
            DateTime timestamp,
            Destination destination,
            NoticeQuittance[] noticeQuittance
            ) : this(id, timestamp, destination) => NoticeQuittance = noticeQuittance;

        /// <summary>
        /// Идентификаторы получателя уведомлений по подписке
        /// </summary>
        public Destination Destination 
        {
            get => _Destination;
            set => _Destination = Validator.IsNull(value: value, name: nameof(Destination));
        }

        Destination _Destination;

        /// <summary/>
        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlElement("NoticeCharge", typeof(NoticeCharge))]
        [XmlElement("NoticePayment", typeof(NoticePayment))]
        [XmlElement("NoticeQuittance", typeof(NoticeQuittance))]
        public object[] Items
        {
            get => _Items;
            set => _Items = Validator.ArrayObj(value: value, name: nameof(Items), required: true, min: 1, max: 100);
        }  

        object[] _Items;

        /// <summary/>
        [XmlIgnore]
        public NoticeCharge[] NoticeCharge
        {
            get => Items?.GetType() == typeof(NoticeCharge[]) ? (NoticeCharge[])Items : null;
            set => Items = (value == null && Items?.GetType() != typeof(NoticeCharge[])) ? Items : value;
        }

        /// <summary/>
        [XmlIgnore]
        public NoticePayment[] NoticePayment
        {
            get => Items?.GetType() == typeof(NoticePayment[]) ? (NoticePayment[])Items : null;
            set => Items = (value == null && Items?.GetType() != typeof(NoticePayment[])) ? Items : value;
        }

        /// <summary/>
        [XmlIgnore]
        public NoticeQuittance[] NoticeQuittance
        {
            get => Items?.GetType() == typeof(NoticeQuittance[]) ? (NoticeQuittance[])Items : null;
            set => Items = (value == null && Items?.GetType() != typeof(NoticeQuittance[])) ? Items : value;
        }


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