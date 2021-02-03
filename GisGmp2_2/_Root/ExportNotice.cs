using GisGmp.Common;
using GisGmp.Services.ExportNotice;
using System;

namespace GisGmp
{
    public partial class GisGmpBuilder
    {
        /// <summary/>
        public ExportNoticeRequest CreateExportNoticeRequest(Services.ExportNotice.NoticeCharge[] noticeCharges, Destination destination)
        {
            return new ExportNoticeRequest(
                id: Id,
                timestamp: Timestamp,
                destination: destination,
                noticeCharge: noticeCharges
                );
        }

        /// <summary/>
        public ExportNoticeRequest CreateExportNoticeRequest(NoticePayment[] noticePayments, Destination destination)
        {
            return new ExportNoticeRequest(
                id: Id,
                timestamp: Timestamp,
                destination: destination,
                noticePayment: noticePayments
                );
        }

        /// <summary/>
        public ExportNoticeRequest CreateExportNoticeRequest(NoticeQuittance[] noticeQuittances, Destination destination)
        {
            return new ExportNoticeRequest(
                id: Id,
                timestamp: Timestamp,
                destination: destination,
                noticeQuittance: noticeQuittances
                );
        }

        /// <summary/>
        public string ExportNotice(Services.ExportNotice.NoticeCharge[] noticeCharges, Destination destination)
            => throw new NotImplementedException();

        /// <summary/>
        public string ExportNotice(NoticePayment[] noticePayments, Destination destination)
            => throw new NotImplementedException();

        /// <summary/>
        public string ExportNotice(NoticeQuittance[] noticeQuittances, Destination destination)
            => throw new NotImplementedException();


        /// <summary/>
        public ExportNoticeResponse CreateExportNoticeResponse(string routingCode, bool exportNoticeConfirmation)
        {
            return new ExportNoticeResponse(
                config: ResponseConfig,
                routingCode:  routingCode,
                exportNoticeConfirmation: exportNoticeConfirmation
                );           
        }
    }
}