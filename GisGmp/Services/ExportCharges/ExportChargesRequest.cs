using GisGmp.Common;
using GisGmp.SearchConditions;
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ExportCharges
{
    /// <summary>
    /// Запрос на предоставление необходимой для уплаты информации (начисления)
    /// </summary>
    [Serializable()]
    [XmlRoot("ExportChargesRequest", Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-charges/2.1.1")]
    public class ExportChargesRequest : ExportRequestType
    {
        protected ExportChargesRequest()
        {
        }

        public ExportChargesRequest(ExportRequestType config, ChargesExportConditions exportConditions)
            : base(config) => ChargesExportConditions = exportConditions;
             
        /// <summary>
        /// Признак предоставляемой информации
        /// </summary>
        [XmlAttribute("external")]
        public External External { get; set; }

        /// <summary />
        [XmlIgnore()]
        public bool ExternalSpecified { get; set; }

        /// <summary>
        /// Информация, подтверждающая аутентификацию плательщика (пользователя) в ЕСИА. Даннный блок заполняется при запросе по идентификатору плательщика на предоставление извещений о начислениях, администрируемых налоговыми органами Российской Федерации.
        /// </summary>
        [XmlElement("EsiaUserInfo", Order = 1)]
        public EsiaUserInfoType EsiaUserInfo { get; set; }

        /// <summary>
        /// Условия для предоставления необходимой для уплаты информации
        /// </summary>
        [XmlElement("ChargesExportConditions", Order = 2, Namespace = "http://roskazna.ru/gisgmp/xsd/SearchConditions/2.1.1")]
        public ChargesExportConditions ChargesExportConditions { get; set; }
    }
}
