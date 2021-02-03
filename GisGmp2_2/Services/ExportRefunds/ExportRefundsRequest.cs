using GisGmp.Common;
using GisGmp.SearchConditions;
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ExportRefunds
{
    /// <summary>
    /// Запрос на предоставление информации о возврате
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-refunds/2.2.0")]
    [XmlRoot(Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-refunds/2.2.0", IsNullable = false)]
    public class ExportRefundsRequest : ExportRequestType
    {
        /// <summary/>
        protected ExportRefundsRequest() { }

        /// <summary/>
        public ExportRefundsRequest(ExportRequestType config, RefundsExportConditions exportConditions)
            : base(config) => RefundsExportConditions = exportConditions;

        /// <summary>
        /// Условия для предоставления информации о возврате
        /// </summary>
        [XmlElement(Namespace = "http://roskazna.ru/gisgmp/xsd/SearchConditions/2.2.0")]
        public RefundsExportConditions RefundsExportConditions 
        {
            get => _RefundsExportConditions;
            set => _RefundsExportConditions = Validator.IsNull(value: value, name: nameof(RefundsExportConditions));
        }

        RefundsExportConditions _RefundsExportConditions;
    }
}