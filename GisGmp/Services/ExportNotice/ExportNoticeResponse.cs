using GisGmp.Common;
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ExportNotice
{
    /// <summary>
    /// Ответ на запрос предоставления из ГИС ГМП уведомлений по подписке
    /// </summary>
    [Serializable()]
    [XmlRoot("ExportNoticeResponse", Namespace = "urn://roskazna.ru/gisgmp/xsd/services/ExportNotice/2.1.1")]
    public class ExportNoticeResponse : ResponseType
    {
        protected ExportNoticeResponse() { }

        //TODO проверить обязательные поля
        public ExportNoticeResponse(ResponseType config, string routingCode, bool exportNoticeConfirmation)
            : base(config)
        {
            RoutingCode = routingCode;
            ExportNoticeConfirmation = exportNoticeConfirmation;
        }

        /// <summary>
        /// Код маршрутизации участника
        /// </summary>
        [XmlElement("RoutingCode", Order = 1)]
        public string RoutingCode { get; set; }

        /// <summary>
        /// Подтверждение приема сообщения с рассылкой уведомлений по подписке: true - сообщение принято; false - отказ в приеме сообщения
        /// </summary>
        [XmlElement("ExportNoticeConfirmation", Order = 2)]
        public bool ExportNoticeConfirmation { get; set; }
    }
}