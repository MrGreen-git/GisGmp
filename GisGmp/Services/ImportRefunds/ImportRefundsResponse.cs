using GisGmp.Common;
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ImportRefunds
{
    [Serializable()]
    [XmlRoot("ImportRefundsResponse", Namespace = "urn://roskazna.ru/gisgmp/xsd/services/import-refunds/2.1.1")]
    public class ImportRefundsResponse : ImportPackageResponseType
    {
        protected ImportRefundsResponse() 
        {
        }
  
        public ImportRefundsResponse(ResponseType config, ImportProtocolType[] importProtocol)
            : base(config, importProtocol)
        {
        }
    }
}
