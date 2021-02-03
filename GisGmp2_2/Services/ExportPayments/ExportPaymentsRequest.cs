using GisGmp.Common;
using GisGmp.SearchConditions;
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ExportPayments
{
    /// <summary>
    /// Запрос на предоставление информации об уплате
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-payments/2.2.0")]
    [XmlRoot(Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-payments/2.2.0", IsNullable = false)]
    public class ExportPaymentsRequest : ExportRequestType
    {
        /// <summary/>
        protected ExportPaymentsRequest() { }

        /// <summary>
        /// Запрос на предоставление информации об уплате
        /// </summary>
        /// <param name="config"></param>
        /// <param name="exportConditions">Условия для предоставления информации об уплате | required: true</param>
        public ExportPaymentsRequest(ExportRequestType config, PaymentsExportConditions exportConditions)
            : base(config) => PaymentsExportConditions = exportConditions;


        #region XmlElement
        /// <summary>
        /// Условия для предоставления информации об уплате | required: true
        /// </summary>
        [XmlElement("PaymentsExportConditions", Namespace = "http://roskazna.ru/gisgmp/xsd/SearchConditions/2.2.0")]
        public PaymentsExportConditions PaymentsExportConditions 
        {
            get => _PaymentsExportConditions;
            set => _PaymentsExportConditions = Validator.IsNull(value: value, name: nameof(PaymentsExportConditions));
        }

        PaymentsExportConditions _PaymentsExportConditions;
        #endregion
    }
}