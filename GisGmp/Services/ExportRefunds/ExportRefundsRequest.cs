using GisGmp.Common;
using GisGmp.SearchConditions;
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ExportRefunds
{
    /// <summary>
    /// Запрос на предоставление информации о возврате
    /// </summary>
    [Serializable()]
    [XmlRoot("ExportRefundsRequest", Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-refunds/2.1.1")]
    public class ExportRefundsRequest : ExportRequestType
    {
        protected ExportRefundsRequest() { }

        public ExportRefundsRequest(ExportRequestType config, RefundsExportConditions exportConditions)
            : base(config) => RefundsExportConditions = exportConditions;

        /// <summary>
        /// Условия для предоставления информации о возврате
        /// </summary>
        [XmlElement("RefundsExportConditions", Order = 1, Namespace = "http://roskazna.ru/gisgmp/xsd/SearchConditions/2.1.1")]
        public RefundsExportConditions RefundsExportConditions { get; set; }
    }
}
