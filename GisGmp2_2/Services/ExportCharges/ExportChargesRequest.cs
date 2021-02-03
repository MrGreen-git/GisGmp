using GisGmp.Common;
using GisGmp.SearchConditions;
using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace GisGmp.Services.ExportCharges
{
    /// <summary>
    /// Запрос на предоставление необходимой для уплаты информации (начисления)
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-charges/2.2.0")]
    [XmlRoot(Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-charges/2.2.0", IsNullable = false)]
    public class ExportChargesRequest : ExportRequestType
    {
        /// <summary />
        protected ExportChargesRequest() { }

        /// <summary>
        /// Запрос на предоставление необходимой для уплаты информации (начисления)
        /// </summary>
        /// <param name="config"></param>
        /// <param name="exportConditions">Условия для предоставления необходимой для уплаты информации | requred: true</param>
        public ExportChargesRequest(ExportRequestType config, ChargesExportConditions exportConditions)
            : base(config) => ChargesExportConditions = exportConditions;

        /// <summary>
        /// Запрос на предоставление необходимой для уплаты информации (начисления)
        /// </summary>
        /// <param name="config"></param>
        /// <param name="exportConditions">Условия для предоставления необходимой для уплаты информации | requred: true</param>
        /// <param name="esiaUserInfo">Информация, подтверждающая аутентификацию плательщика (пользователя) в ЕСИА | requred: false</param>
        /// <param name="external">Признак предоставляемой информации | requred: false</param>
        public ExportChargesRequest(ExportRequestType config, ChargesExportConditions exportConditions, EsiaUserInfoType esiaUserInfo = default, External? external = default)
            : this (config, exportConditions)
        {
            EsiaUserInfo = esiaUserInfo;
            External = external;
        }


        #region XmlAttribute
        /// <summary>
        /// <para>Признак предоставляемой информации</para>
        /// <para>required: false</para>
        /// </summary>
        [XmlIgnore]
        public External? External { get; set; }

        /// <summary />
        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlAttribute("external")]
        public External WrapperExternal { get => External.Value; set => External = value; }

        /// <summary />
        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlIgnore]
        public bool WrapperExternalSpecified { get => External.HasValue; }
        #endregion


        #region XmlElement
        /// <summary>
        /// <para>Информация, подтверждающая аутентификацию плательщика (пользователя) в ЕСИА.</para>
        /// <para>Даннный блок заполняется при запросе по идентификатору плательщика на предоставление извещений о начислениях, администрируемых налоговыми органами Российской Федерации.</para>
        /// <para>requred: false</para>
        /// </summary>
        [XmlElement("EsiaUserInfo")]
        public EsiaUserInfoType EsiaUserInfo { get; set; }


        /// <summary>
        /// <para>Условия для предоставления необходимой для уплаты информации</para>
        /// <para>requred: true</para>
        /// </summary>
        [XmlElement("ChargesExportConditions", Namespace = "http://roskazna.ru/gisgmp/xsd/SearchConditions/2.2.0")]
        public ChargesExportConditions ChargesExportConditions 
        {
            get => _ChargesExportConditions;
            set => _ChargesExportConditions = Validator.IsNull(value: value, name: nameof(ChargesExportConditions));
        }

        ChargesExportConditions _ChargesExportConditions;
        #endregion
    }
}

