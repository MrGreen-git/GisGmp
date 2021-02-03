using GisGmp.Services.SubscriptionService;

namespace GisGmp
{
    public partial class GisGmpBuilder
    {
        /// <summary/>
        public SubscriptionServiceRequest CreateSubscriptionServiceRequest(bool exportSubscriptions)
        {
            return new SubscriptionServiceRequest(
                config: RequestConfig,
                exportSubscriptions: exportSubscriptions
                );
        }

        /// <summary/>
        public SubscriptionServiceRequest CreateSubscriptionServiceRequest(CreateSubscription createSubscription)
        {
            return new SubscriptionServiceRequest(
                config: RequestConfig,
                createSubscription: createSubscription
                );
        }

        /// <summary/>
        public string SubscriptionService(bool exportSubscriptions)
            => ReadyRequest(CreateSubscriptionServiceRequest(exportSubscriptions));

        /// <summary/>
        public string SubscriptionService(CreateSubscription createSubscription)
            => ReadyRequest(CreateSubscriptionServiceRequest(createSubscription));

        /// <summary/>
        public SubscriptionServiceResponse CreateSubscriptionServiceResponse(CreateSubscriptionResult[] createSubscriptionResult)
        {
            return new SubscriptionServiceResponse(
                config: ResponseConfig,
                createSubscriptionResult: createSubscriptionResult
                );
        }

        /// <summary/>
        public SubscriptionServiceResponse CreateSubscriptionServiceResponse(Subscriptions[] subscriptions)
        {
            return new SubscriptionServiceResponse(
                config: ResponseConfig,
                subscriptions: subscriptions
                );
        }
    }
}
