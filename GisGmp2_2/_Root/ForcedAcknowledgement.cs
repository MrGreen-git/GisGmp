using GisGmp.Quittance;
using GisGmp.Services.ForcedAcknowledgement;

namespace GisGmp
{
    public partial class GisGmpBuilder
    {
        /// <summary/>
        public ForcedAcknowledgementRequest CreateForcedAcknowledgementRequest(AnnulmentReconcile annulmentReconcile)           
        {
            return new ForcedAcknowledgementRequest(
                    config: RequestConfig,
                    originatorId: OriginatorId,
                    annulmentReconcile: annulmentReconcile
                );
        }
    
        /// <summary/>
        public ForcedAcknowledgementRequest CreateForcedAcknowledgementRequest(AnnulmentServiceProvided annulmentServiceProvided)
        {
            return new ForcedAcknowledgementRequest(
                    config: RequestConfig,
                    originatorId: OriginatorId,
                    annulmentServiceProvided: annulmentServiceProvided
                );            
        }
      
        /// <summary/>
        public ForcedAcknowledgementRequest CreateForcedAcknowledgementRequest(Reconcile reconcile)
        {
            return new ForcedAcknowledgementRequest(
                    config: RequestConfig,
                    originatorId: OriginatorId,
                    reconcile: reconcile
                );
        }
      
        /// <summary/>
        public ForcedAcknowledgementRequest CreateForcedAcknowledgementRequest(ServiceProvided serviceProvided)
        {
            return new ForcedAcknowledgementRequest(
                    config: RequestConfig,
                    originatorId: OriginatorId,
                    serviceProvided: serviceProvided
                );
        }

        /// <summary/>
        public string ForcedAcknowledgement(AnnulmentReconcile annulmentReconcile)
            => ReadyRequest(CreateForcedAcknowledgementRequest(annulmentReconcile));

        /// <summary/>
        public string ForcedAcknowledgement(AnnulmentServiceProvided annulmentServiceProvided)
            => ReadyRequest(CreateForcedAcknowledgementRequest(annulmentServiceProvided));

        /// <summary/>
        public string ForcedAcknowledgement(Reconcile reconcile)
            => ReadyRequest(CreateForcedAcknowledgementRequest(reconcile));

        /// <summary/>
        public string ForcedAcknowledgement(ServiceProvided serviceProvided)
            => ReadyRequest(CreateForcedAcknowledgementRequest(serviceProvided));

        /// <summary/>
        public ForcedAcknowledgementResponse CreateForcedAcknowledgementResponse(bool[] done)
        {
            return new ForcedAcknowledgementResponse(
                config: ResponseConfig,
                done: done
                );
        }

        /// <summary/>
        public ForcedAcknowledgementResponse CreateForcedAcknowledgementResponse(QuittanceType[] quittances)
        {
            return new ForcedAcknowledgementResponse(
                config: ResponseConfig,
                quittances: quittances
                );
        }
    }
}