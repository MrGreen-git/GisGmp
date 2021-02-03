using GisGmp.Common;
using System;
using System.Xml;

namespace GisGmp
{
    /// <summary/>
    public delegate string CallBackData(XmlDocument xmlData, string reference);

    public partial class GisGmpBuilder
    {      
        /// <summary/>
        public CallBackData CallBackReadyRequest { get; set; }

        #region Test
        /// <summary/>
        public bool TestEnable { get; set; }
        /// <summary/>

        string _Test_Id;
        /// <summary/>
        public string Test_Id
        {
            get => _Test_Id ?? throw new Exception($"Не присвоено значение свойству {nameof(Test_Id)}");
            set => _Test_Id = value;
        }

        DateTime? _Test_Timestamp;
        /// <summary/>
        public DateTime Test_Timestamp
        {
            get => _Test_Timestamp ?? throw new Exception($"Не присвоено значение свойству {nameof(Test_Timestamp)}");
            set => _Test_Timestamp = value;
        }
        #endregion

        #region ExportRequestConfig
        #region RequestConfig
        /// <summary/>
        private string Id 
        { 
            get => TestEnable ? Test_Id : $@"G_{Guid.NewGuid()}";            
        }
        /// <summary/>
        private DateTime Timestamp
        {
            get => TestEnable ? Test_Timestamp : DateTime.Now;           
        }

        string _SenderIdentifier;
        /// <summary/>
        public URNType SenderIdentifier
        {
            get => _SenderIdentifier ?? throw new Exception($"Не присвоено значение свойству {nameof(SenderIdentifier)}");
            set => _SenderIdentifier = value;
        }

        string _SenderRole;
        /// <summary/>
        public string SenderRole 
        { 
            get => _SenderRole ?? throw new Exception($"Не присвоено значение свойству {nameof(SenderRole)}");
            set => _SenderRole = value;
        }
        #endregion

        int? _PageNumber; 
        /// <summary/>
        public int PageNumber 
        {
            get => _PageNumber ?? throw new Exception($"Не присвоено значение свойству {nameof(PageNumber)}");   
            set => _PageNumber = value;                
        }

        int? _PageLength;
        /// <summary/>
        public int PageLength
        {
            get => _PageLength ?? throw new Exception($"Не присвоено значение свойству {nameof(PageLength)}");
            set => _PageLength = value;
        }

        /// <summary/>
        public URNType OriginatorId { get; set; }
        #endregion

        #region ResponseRequest

        string _RqId;
        /// <summary/>
        public string RqId
        {
            get => _RqId ?? throw new Exception($"Не присвоено значение свойству {nameof(RqId)}");
            set => _RqId = value;
        }

        string _RecipientIdentifier;
        /// <summary/>
        public URNType RecipientIdentifier
        {
            get => _RecipientIdentifier ?? throw new Exception($"Не присвоено значение свойству {nameof(RecipientIdentifier)}");
            set => _RecipientIdentifier = value;
        }
        #endregion

        /// <summary/>
        private RequestType RequestConfig
        {
            get => new RequestType(
                id: Id,
                senderIdentifier: SenderIdentifier,
                senderRole: SenderRole,
                timestamp: Timestamp
                );
        }

        /// <summary/>
        private ExportRequestType ExportRequestConfig
        {           
            get => new ExportRequestType(
                request: RequestConfig,
                originatorId: OriginatorId,
                paging: new PagingType(PageNumber.ToString(), PageLength.ToString())
                );          
        }

        /// <summary/>
        private ResponseType ResponseConfig
        {
            get =>  new ResponseType(
                id: Id,
                rqId: RqId,
                recipientIdentifier: RecipientIdentifier,
                timestamp: Timestamp
                );
        }

        private string ReadyRequest<T>(T request) where T : RequestType
        {
            Validator.IsNull(value: CallBackReadyRequest, name: nameof(CallBackReadyRequest));
            return CallBackReadyRequest(SerializerObject(request, true), request.Id);
        }
    }
}