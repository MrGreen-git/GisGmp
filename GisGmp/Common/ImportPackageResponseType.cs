using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    /// <summary>
    /// Параметры ответа на запрос
    /// </summary>
    [Serializable()]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.1.1")]
    public class ImportPackageResponseType : ResponseType
    {

        protected ImportPackageResponseType()
        {
        }

        public ImportPackageResponseType(ResponseType configResponse, ImportProtocolType[] importProtocol)
            : base(configResponse) => ImportProtocol = importProtocol;

        /// <remarks/>
        [XmlElement("ImportProtocol")]
        public ImportProtocolType[] ImportProtocol { get; set; }       
    }
}