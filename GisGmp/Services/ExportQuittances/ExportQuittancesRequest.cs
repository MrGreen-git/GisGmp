using GisGmp.Common;
using GisGmp.SearchConditions;
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ExportQuittances
{
    /// <summary>
    /// Запрос на предоставление информации о результатах квитирования
    /// </summary>
    [Serializable()]
    [XmlRoot("ExportQuittancesRequest", Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-quittances/2.1.1")]
    public class ExportQuittancesRequest : ExportRequestType
    {
        protected ExportQuittancesRequest() { }

        public ExportQuittancesRequest(ExportRequestType config, QuittancesExportConditions exportConditions) 
            : base(config) => QuittancesExportConditions = exportConditions;

        /// <summary>
        /// Условия для предоставления информации о результатах квитирования
        /// </summary>
        [XmlElement("QuittancesExportConditions", Order = 1, Namespace = "http://roskazna.ru/gisgmp/xsd/SearchConditions/2.1.1")]
        public QuittancesExportConditions QuittancesExportConditions { get; set; }
    }
}
