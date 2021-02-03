using GisGmp.Common;
using GisGmp.Package;
using GisGmp.Services.ImportCharges;

namespace GisGmp
{
    public partial class GisGmpBuilder
    {
        /// <summary/>
        public ImportChargesRequest CreateImportChargesRequest(ImportedChargeType[] importedChargeTypes)
        {
            return new ImportChargesRequest(
                config: RequestConfig,
                package: new ChargesPackage(
                    importedCharges: importedChargeTypes
                    )
                );
        }

        /// <summary/>
        public ImportChargesRequest CreateImportChargesRequest(ImportedChangeType[] importedChangeTypes)
        {
            return new ImportChargesRequest(
                config: RequestConfig,
                package: new ChargesPackage(
                    importedChanges: importedChangeTypes
                    )
                );
        }

        /// <summary/>
        public string ImportCharges(ImportedChargeType[] importedChargeTypes)
            => ReadyRequest(CreateImportChargesRequest(importedChargeTypes));

        /// <summary/>
        public string ImportCharges(ImportedChangeType[] importedChangeTypes)
            => ReadyRequest(CreateImportChargesRequest(importedChangeTypes));

        /// <summary/>
        public ImportChargesResponse CreateImportChargesResponse(ImportProtocolType[] importProtocol)
        {
            return new ImportChargesResponse(
                config: ResponseConfig,
                importProtocol: importProtocol
                );
        }
    }
}
