using GisGmp.Common;
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ExportPayments
{
    /// <summary>
    /// Ответ на запрос предоставления информации об уплате
    /// </summary>
    [Serializable()]
    [XmlRoot("ExportPaymentsResponse", Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-payments/2.1.1")]
    public class ExportPaymentsResponse : ResponseType
    {
        protected ExportPaymentsResponse() { }

        public ExportPaymentsResponse(ResponseType config, bool hasMore, PaymentInfoType[] paymentInfo = null)
            : base (config)
        {
            HasMore = hasMore;
            PaymentInfo = paymentInfo;           
        }

        /// <summary>
        /// Признак конца выборки: false - достигнут конец выборки; true - после последнего предоставленного элемента в выборке имеются другие.
        /// </summary>
        [XmlAttribute("hasMore")]
        public bool HasMore { get; set; }

        /// <summary>
        /// Извещение о приеме к исполнению распоряжения (платеж)
        /// </summary>
        [XmlElement("PaymentInfo", Order = 1)]
        public PaymentInfoType[] PaymentInfo { get; set; }
    }
}