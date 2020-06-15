using GisGmp.Common;
using GisGmp.SearchConditions;
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ExportPayments
{
    /// <summary>
    /// Запрос на предоставление информации об уплате
    /// </summary>
    [Serializable()]
    [XmlRoot("ExportPaymentsRequest", Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-payments/2.1.1")]
    public class ExportPaymentsRequest : ExportRequestType
    {
        protected ExportPaymentsRequest() { }

        public ExportPaymentsRequest(ExportRequestType config, PaymentsExportConditions exportConditions)
            : base(config) => PaymentsExportConditions = exportConditions;
        
        /// <summary>
        /// Условия для предоставления информации об уплате
        /// </summary>
        [XmlElement("PaymentsExportConditions", Order = 1, Namespace = "http://roskazna.ru/gisgmp/xsd/SearchConditions/2.1.1")]
        public PaymentsExportConditions PaymentsExportConditions { get; set; }
    }
}
