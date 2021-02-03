using GisGmp.Services.ExportNoticeNSI;
using System;

namespace GisGmp
{
    public partial class GisGmpBuilder
    {
        /// <summary/>
        public ExportNoticeNSIRequest CreateExportNoticeNSIRequest(Destination destination, NoticeNSI noticeNSI)
        {
            return new ExportNoticeNSIRequest(
                id: Id,
                timestamp: Timestamp,
                destination: destination,
                noticeNSI: noticeNSI
                );
        }

        /// <summary/>
        public string ExportNoticeNSI(Destination destination, NoticeNSI noticeNSI)
            => throw new NotImplementedException();

        /// <summary/>
        public ExportNoticeNSIResponse CreateExportNoticeNSIResponse(string routingCode, bool exportNoticeNSIConfirmation)
        {
            return new ExportNoticeNSIResponse(
                config: ResponseConfig,
                routingCode: routingCode,
                exportNoticeNSIConfirmation: exportNoticeNSIConfirmation
                );
        }
    }
}
