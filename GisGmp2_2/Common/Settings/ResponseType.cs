using GisGmp.Services.ImportCharges;
using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    /// <summary>
    /// Основные параметры ответа на запрос
    /// </summary>
    [XmlInclude(typeof(ImportPackageResponseType))]
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.2.0")]
    public class ResponseType
    {
        /// <summary/>
        protected ResponseType() { }

        /// <summary/>
        public ResponseType(ResponseType response)
            : this(response.Id, response.RqId, response.RecipientIdentifier, response.Timestamp)
        {
        }

        /// <summary/>
        public ResponseType(string id, string rqId, URNType recipientIdentifier, DateTime timestamp)
        {
            Id = id;
            RqId = rqId;
            RecipientIdentifier = recipientIdentifier;
            Timestamp = timestamp;
        }


        /// <summary>
        /// Идентификатор ответа
        /// </summary>
        [XmlAttribute(DataType = "ID")]
        public string Id 
        {
            get => _Id;
            set => _Id = Validator.String(value: ref value, name: nameof(Id), required: true, min: 0, max: 50);
        }

        string _Id;


        /// <summary>
        /// Идентификатор запроса
        /// </summary>
        [XmlAttribute]
        public string RqId
        {
            get => _RqId;
            set => _RqId = Validator.String(value: ref value, name: nameof(RqId), required: true, min: 0, max: 50);
        }

        string _RqId;


        /// <summary>
        /// УРН участника получателя
        /// </summary>
        [XmlIgnore]
        public URNType RecipientIdentifier 
        {
            get => _RecipientIdentifier;
            set => _RecipientIdentifier = Validator.IsNull(value: value, name: nameof(RecipientIdentifier));
        }

        URNType _RecipientIdentifier;

        /// <summary />
        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlAttribute("recipientIdentifier")]
        public string WrapperRecipientIdentifier { get => RecipientIdentifier; set => RecipientIdentifier = value; }


        /// <summary>
        /// Дата и время формирования ответа
        /// </summary>
        [XmlAttribute("timestamp")]
        public DateTime Timestamp { get; set; }
    }
}