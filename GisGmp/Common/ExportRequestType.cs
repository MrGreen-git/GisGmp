using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    /// <summary>
    /// Запрос на предоставление информации об уплате
    /// </summary>
    [Serializable()]
    [XmlRoot("ExportRequestType", Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.1.1")]
    public abstract class ExportRequestType : RequestType
    {
        protected ExportRequestType()
        {
        }

        public ExportRequestType(ExportRequestType exportRequest)
            : base(exportRequest.Id, exportRequest.SenderIdentifier, exportRequest.SenderRole, exportRequest.Timestamp)
        {
            OriginatorId = exportRequest.OriginatorId;
            Paging = exportRequest.Paging;
        }

        //TODO переписать
        //public ExportRequestType(RequestType request, string originatorId, PagingType paging)
        //    : base(request.Id, request.SenderIdentifier, request.SenderRole, request.Timestamp)
        //{
        //    OriginatorId = originatorId;
        //    Paging = paging;
        //}

        //public ExportRequestType(string originatorId, PagingType paging, string id, string senderIdentifier, string senderRole, DateTime timestamp)
        //    : base(id, senderIdentifier, senderRole, timestamp)
        //{
        //    OriginatorId = originatorId;
        //    Paging = paging;
        //}


        /// <summary>
        /// УРН участника косвенного взаимодействия, сформировавшего запрос
        /// </summary>
        [XmlAttribute("originatorId")]
        public string OriginatorId { get; set; }

        /// <summary>
        /// Параметры постраничного предоставления из ГИС ГМП информации (при больших объемах предоставляемых данных)
        /// </summary>
        [XmlElement(Order = 1)]
        public PagingType Paging { get; set; }    
    }
}
