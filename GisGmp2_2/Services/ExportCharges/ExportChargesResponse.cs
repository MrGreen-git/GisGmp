using GisGmp.Common;
using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace GisGmp.Services.ExportCharges
{
    /// <summary>
    /// Ответ на запрос предоставления необходимой для уплаты информации (начисления)
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-charges/2.2.0")]
    [XmlRoot(Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-charges/2.2.0", IsNullable = false)]
    public class ExportChargesResponse : ResponseType
    {
        /// <summary />
        protected ExportChargesResponse() { }

        /// <summary>
        /// Ответ на запрос предоставления необходимой для уплаты информации (начисления)
        /// </summary>
        /// <param name="config"></param>
        /// <param name="hasMore">Признак окончания выборки</param>
        public ExportChargesResponse(ResponseType config, bool hasMore)
            : base(config) => HasMore = hasMore;

        /// <summary>
        /// Ответ на запрос предоставления необходимой для уплаты информации (начисления)
        /// </summary>
        /// <param name="config"></param>
        /// <param name="hasMore">Признак окончания выборки | required: true</param>
        /// <param name="chargeInfo">Извещение о начислении | required: false, min: 0, max: 100</param>
        /// <param name="needReRequest">Признак необходимости направления повторного запроса | required: false</param>
        public ExportChargesResponse(ResponseType config, bool hasMore, ChargeInfo[] chargeInfo = default, bool? needReRequest = default)
            : this(config, hasMore)
        {
            ChargeInfo = chargeInfo;
            NeedReRequest = needReRequest;
        }

        #region XmlAttribute
        /// <summary>
        /// <para>Признак конца выборки:</para>
        /// <para>false - достигнут конец выборки;</para>
        /// <para>true - после последнего предоставленного элемента в выборке имеются другие.</para>
        /// <para>required: true</para>
        /// </summary>
        [XmlAttribute("hasMore")]
        public bool HasMore { get; set; }


        /// <summary>
        /// <para>Признак необходимости направления повторного запроса.</para>
        /// <para>Присутствует в ответе, если для предоставления ответа на запроос потребовалось зайдействовать внешнюю систему и ответ от нее не был получен(внешняя система недоступна либо получено сообщение об ошибке)</para>
        /// <para>required: false</para>
        /// </summary>
        [XmlIgnore]
        public bool? NeedReRequest { get; set; }

        /// <summary />
        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlAttribute("needReRequest")]
        public bool WrapperNeedReRequest { get => NeedReRequest.Value; set => NeedReRequest = value; }

        /// <summary />
        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlIgnore]
        public bool WrapperNeedReRequestSpecified { get => NeedReRequest.HasValue; }
        #endregion


        #region XmlElement
        /// <summary>
        /// <para>Извещение о начислении (начисление)</para>
        /// <para>required: false, min: 0, max: 100</para>
        /// </summary>
        [XmlElement("ChargeInfo")]
        public ChargeInfo[] ChargeInfo 
        {
            get => _ChargeInfo;
            set => _ChargeInfo = Validator.ArrayObj(value: value, name: nameof(ChargeInfo), required: false, min: 0, max: 100);
        }

        ChargeInfo[] _ChargeInfo;
        #endregion
    }
}