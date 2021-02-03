using GisGmp.Common;
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ExportPayments
{
    /// <summary>
    /// Ответ на запрос предоставления информации об уплате
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-payments/2.2.0")]
    [XmlRoot(Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-payments/2.2.0", IsNullable = false)]
    public class ExportPaymentsResponse : ResponseType
    {
        /// <summary/>
        protected ExportPaymentsResponse() { }

        /// <summary>
        /// Ответ на запрос предоставления информации об уплате
        /// </summary>
        /// <param name="config"></param>
        /// <param name="hasMore"></param>
        public ExportPaymentsResponse(ResponseType config, bool hasMore)
            : base(config) => HasMore = hasMore;

        /// <summary>
        /// Ответ на запрос предоставления информации об уплате
        /// </summary>
        /// <param name="config"></param>
        /// <param name="hasMore">Признак конца выборки | required: true</param>
        /// <param name="paymentInfo">Извещение о приеме к исполнению распоряжения (платеж) | required: false, min: 0, max: 100</param>
        public ExportPaymentsResponse(ResponseType config, bool hasMore, PaymentInfo[] paymentInfo)
            : this(config, hasMore) => PaymentInfo = paymentInfo;


        #region XmlAttribute
        /// <summary>
        /// <para>Признак конца выборки:</para>
        /// <para>false - достигнут конец выборки;</para>
        /// <para>true - после последнего предоставленного элемента в выборке имеются другие.</para>
        /// <para>required: true</para>  
        /// </summary>
        [XmlAttribute("hasMore")]
        public bool HasMore { get; set; }
        #endregion


        #region XmlElement
        /// <summary>
        /// <para>Извещение о приеме к исполнению распоряжения (платеж)</para>
        /// <para>required: false, min: 0, max: 100</para>
        /// </summary>
        [XmlElement("PaymentInfo")]
        public PaymentInfo[] PaymentInfo 
        {
            get => _PaymentInfo;
            set => _PaymentInfo = Validator.ArrayObj(value: value, name: nameof(PaymentInfo), required: false, min: 1, max: 100);
        }

        PaymentInfo[] _PaymentInfo;
        #endregion
    }
}