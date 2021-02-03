using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    /// <remarks/>
    [XmlInclude(typeof(ExportRequestType))]
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.2.0")]
    public class RequestType
    {
        /// <remarks/>
        protected RequestType() { }

        /// <remarks/>
        public RequestType(RequestType request)
            : this(request.Id, request.SenderIdentifier, request.SenderRole, request.Timestamp)
        {
        }

        /// <remarks/>
        public RequestType(string id, URNType senderIdentifier, string senderRole, DateTime timestamp)
        {
            Id = id;
            SenderIdentifier = senderIdentifier;
            SenderRole = senderRole;
            Timestamp = timestamp;
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
        /// Дата и время формирования запроса
        /// </summary>
        [XmlAttribute("timestamp")]
        public DateTime Timestamp { get; set; }

        /// <summary>
        /// УРН участника-отправителя запроса
        /// </summary>
        [XmlIgnore]
        public URNType SenderIdentifier 
        {
            get => _SenderIdentifier;
            set => _SenderIdentifier = Validator.IsNull(value: value, name: nameof(SenderIdentifier));
        }

        URNType _SenderIdentifier;

        /// <summary />
        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlAttribute("senderIdentifier")]
        public string WrapperSenderIdentifier { get => SenderIdentifier; set => SenderIdentifier = value; }


        /// <summary>
        /// Полномочие участника-отправителя сообщения, с которым происходит обращение к ГИС ГМП
        /// </summary>
        [XmlAttribute("senderRole")]
        public string SenderRole 
        {
            get => _SenderRole;
            set => _SenderRole = Validator.String(value: ref value, name: nameof(SenderRole), required: true, min: 1, max: 10);
        }

        string _SenderRole;
    }
}