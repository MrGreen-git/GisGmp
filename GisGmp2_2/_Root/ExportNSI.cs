using GisGmp.Common;
using GisGmp.Common.Nsi;
using GisGmp.Services.ExportNSI;
using System;

namespace GisGmp
{
    public partial class GisGmpBuilder
    {
        /// <summary/>
        public ExportNSIRequest CreateExportNSIRequest(NSIExportConditions nSIExportConditions)
        {
            return new ExportNSIRequest(
                config: RequestConfig,
                originatorId: OriginatorId,
                nSIExportConditions: nSIExportConditions
                );
        }

        /// <summary/>
        public string ExportNSI(string originatorId, NSIExportConditions nSIExportConditions)
            => throw new NotImplementedException();

        /// <summary/>
        public ExportNSIResponse CreateExportNSIResponse(oktmoNSIInfoType oktmoNSIInfoType)
        {
            return new ExportNSIResponse(
                responseConfig: ResponseConfig,
                oktmoNSIInfoType: oktmoNSIInfoType
                );
        }

        /// <summary/>
        public ExportNSIResponse CreateExportNSIResponse(PayeeNSIInfoType payeeNSIInfoType)
        {
            return new ExportNSIResponse(
                responseConfig: ResponseConfig,
                payeeNSIInfoType: payeeNSIInfoType
                );
        }
    }
}