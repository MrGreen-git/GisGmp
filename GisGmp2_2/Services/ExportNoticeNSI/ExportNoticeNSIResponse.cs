using GisGmp.Common;
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ExportNoticeNSI
{
    /// <summary>
    /// Ответ на запрос предоставления из ГИС ГМП уведомлений о нормативно-справочной информации по подписке
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/ExportNoticeNSI/2.2.0")]
    [XmlRoot(Namespace = "urn://roskazna.ru/gisgmp/xsd/services/ExportNoticeNSI/2.2.0", IsNullable = false)]
    public class ExportNoticeNSIResponse : ResponseType
    {
        /// <summary/>
        protected ExportNoticeNSIResponse() { }

        /// <summary/>
        public ExportNoticeNSIResponse(ResponseType config, string routingCode, bool exportNoticeNSIConfirmation)
            : base(config)
        {
            RoutingCode = routingCode;
            ExportNoticeNSIConfirmation = exportNoticeNSIConfirmation;
        }

        /// <summary>
        /// Код маршрутизации участника
        /// </summary>
        public string RoutingCode { get; set; }

        /// <summary>
        /// Подтверждение приема сообщения с рассылкой уведомлений по подписке: true - сообщение принято; false - отказ в приеме сообщения
        /// </summary>
        public bool ExportNoticeNSIConfirmation { get; set; }
    }
}