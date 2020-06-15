using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    /// <summary>
    /// Параметры ответа на запрос
    /// </summary>
    [Serializable()]
    [XmlRoot("ImportPackageResponseType", Namespace = "urn://roskazna.ru/gisgmp/xsd/services/import-charges/2.1.1")]
    public class ImportPackageResponseType : ResponseType
    {
        protected ImportPackageResponseType()
        {
        }

        public ImportPackageResponseType(ResponseType configResponse, ImportProtocolType[] importProtocol)
            : base(configResponse) => ImportProtocol = importProtocol;
          
        /// <summary>
        /// Результат обработки сущности в пакете
        /// </summary>
        [XmlElement("ImportProtocol")]
        public ImportProtocolType[] ImportProtocol { get; set; }
    }
}