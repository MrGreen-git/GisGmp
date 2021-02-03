using GisGmp.Common;
using GisGmp.Package;
using GisGmp.Services.ImportPayments;

namespace GisGmp
{
    public partial class GisGmpBuilder
    {
        /// <summary/>
        public ImportPaymentsRequest CreateImportPaymentsRequest(ImportedPaymentType[] importedPaymentTypes)
        {
            return new ImportPaymentsRequest(
                config: RequestConfig,
                package: new PaymentsPackage(
                    importedPayments: importedPaymentTypes
                    )
                );
        }

        /// <summary/>
        public ImportPaymentsRequest CreateImportPaymentsRequest(ImportedChangeType[] importedChangeTypes)
        {
            return new ImportPaymentsRequest(
                config: RequestConfig,
                package: new PaymentsPackage(
                    importedChanges: importedChangeTypes
                    )
                );
        }

        /// <summary/>
        public string ImportPayments(ImportedPaymentType[] importedPaymentTypes)
            => ReadyRequest(CreateImportPaymentsRequest(importedPaymentTypes));

        /// <summary/>
        public string ImportPayments(ImportedChangeType[] importedChangeTypes)
            => ReadyRequest(CreateImportPaymentsRequest(importedChangeTypes));

        /// <summary/>
        public ImportPaymentsResponse CreateImportPaymentsResponse(ImportProtocolType[] importProtocol)
        {
            return new ImportPaymentsResponse(
                config: ResponseConfig,
                importProtocol: importProtocol
                );
        }
    }
}
