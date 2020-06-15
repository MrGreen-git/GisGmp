using GisGmp.Common;
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ImportCharges
{
    [Serializable()]
    [XmlRoot("ImportChargesResponse", Namespace = "urn://roskazna.ru/gisgmp/xsd/services/import-charges/2.1.1")]
    public class ImportChargesResponse : ImportPackageResponseType
    {
        protected ImportChargesResponse() 
        {
        }

        public ImportChargesResponse(ResponseType config, ImportProtocolType[] importProtocol) 
            : base(config, importProtocol)
        {
        }
    }
}