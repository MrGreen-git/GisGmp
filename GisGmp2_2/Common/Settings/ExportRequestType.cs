using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    /// <remarks/>
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.2.0")]
    public class ExportRequestType : RequestType
    {
        /// <remarks/>
        protected ExportRequestType() { }

        /// <remarks/>
        public ExportRequestType(ExportRequestType exportRequest)
            : this(exportRequest, exportRequest.OriginatorId, exportRequest.Paging)
        { 
        }

        /// <remarks/>
        public ExportRequestType(RequestType request, URNType originatorId, PagingType paging)
            : base(request)
        {
            OriginatorId = originatorId;
            Paging = paging;
        }

        /// <remarks/>
        public ExportRequestType(string id, URNType senderIdentifier, string senderRole, DateTime timestamp, URNType originatorId, PagingType paging)
            : base(id, senderIdentifier, senderRole, timestamp)
        {
            OriginatorId = originatorId;
            Paging = paging;
        }

        
        /// <summary>
        /// Параметры постраничного предоставления из ГИС ГМП информации (при больших объемах предоставляемых данных)
        /// </summary>
        public PagingType Paging { get; set; }

        /// <summary>
        /// УРН участника косвенного взаимодействия, сформировавшего запрос
        /// </summary>
        [XmlIgnore]
        public URNType OriginatorId { get; set; }

        /// <summary />
        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlAttribute("originatorId")]
        public string WrapperOriginatorId { get => OriginatorId; set => OriginatorId = value; }
    }
}