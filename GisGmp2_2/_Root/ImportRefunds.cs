using GisGmp.Common;
using GisGmp.Package;
using GisGmp.Services.ImportRefunds;

namespace GisGmp
{
    public partial class GisGmpBuilder
    {
        /// <summary/>
        public ImportRefundsRequest CreateImportRefundsRequest(ImportedRefundType[] importedRefundTypes)
        {
            return new ImportRefundsRequest(
                config: RequestConfig,
                package: new RefundsPackage(
                    importedRefunds: importedRefundTypes
                    )
                );
        }

        /// <summary/>
        public ImportRefundsRequest CreateImportRefundsRequest(ImportedChangeType[] importedChangeTypes)
        {
            return new ImportRefundsRequest(
                config: RequestConfig,
                package: new RefundsPackage(
                    importedChanges: importedChangeTypes
                    )
                );
        }

        /// <summary/>
        public string ImportRefunds(ImportedRefundType[] importedRefundTypes)
            => ReadyRequest(CreateImportRefundsRequest(importedRefundTypes));

        /// <summary/>
        public string ImportRefunds(ImportedChangeType[] importedChangeTypes)
            => ReadyRequest(CreateImportRefundsRequest(importedChangeTypes));

        /// <summary/>
        public ImportRefundsResponse CreateImportRefundsResponse(ImportProtocolType[] importProtocol)
        {
            return new ImportRefundsResponse(
                config: ResponseConfig,
                importProtocol: importProtocol
                );
        }
    }
}
