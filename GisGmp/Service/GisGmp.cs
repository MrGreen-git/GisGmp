using GisGmp.Common;
using System;
using System.Xml;

namespace GisGmp.Service
{
    public partial class GISGMP_Dll
    {
        public delegate string CallBackData(XmlDocument xmlData, string reference);

        public CallBackData CallBackReadyRequest { get; set; }
        public static string SenderIdentifier { get; set; }
        public static string SenderRole { get; set; }

        private string ReadyRequest(XmlDocument xmlData, string reference)
        {
            if (CallBackReadyRequest is null) throw new Exception("CallBackReadyRequest не может иметь значние null");
            return CallBackReadyRequest(xmlData, reference);
        }

        public RequestConfig RequestConfig()
        {
            return new RequestConfig(SenderIdentifier, SenderRole);
        }

    }

    public class RequestConfig : ExportRequestType
    {
        public RequestConfig(string senderIdentifier, string senderRole)
        {
            Id = $@"G_{Guid.NewGuid()}";
            SenderIdentifier = senderIdentifier;
            SenderRole = senderRole;
            Timestamp = DateTime.Now;

            //OriginatorId = "";
            Paging = new PagingType("1", "100");
        }
    }
}
