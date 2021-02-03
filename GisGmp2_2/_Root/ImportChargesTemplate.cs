using GisGmp.Charge;
using GisGmp.Services.ImportChargesTemplate;

namespace GisGmp
{
    /// <summary/>
    public partial class GisGmpBuilder
    {
        /// <summary/>
        public ChargeCreationRequest CreateImportChargesTemplateRequest(ChargeTemplateType chargeTemplateType)
        {
            return new ChargeCreationRequest(
                config: RequestConfig,
                chargeTemplate: chargeTemplateType
                );
        }

        /// <summary/>
        public string ImportChargesTemplate(ChargeTemplateType chargeTemplateType)
            => ReadyRequest(CreateImportChargesTemplateRequest(chargeTemplateType));

        /// <summary/>
        public ChargeCreationResponse CreateImportChargesTemplateResponse(ChargeType charge)
        {
            return new ChargeCreationResponse(
                config: ResponseConfig,
                charge: charge
                );
        }
    }
}
