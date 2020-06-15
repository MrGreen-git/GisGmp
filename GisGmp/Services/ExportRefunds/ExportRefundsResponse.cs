using GisGmp.Common;
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ExportRefunds
{
    /// <summary>
    /// Ответ на запрос предоставления информации о возврате
    /// </summary>
    [Serializable()]
    [XmlRoot("ExportRefundsResponse", Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-refunds/2.1.1")]
    public class ExportRefundsResponse : ResponseType
    {
        protected ExportRefundsResponse() { }

        public ExportRefundsResponse(ResponseType config, bool hasMore, ExportRefundType[] refund = null)
            : base(config)
        {
            HasMore = hasMore;
            Refund = refund;          
        }

        /// <summary>
        /// Признак конца выборки: false - достигнут конец выборки; true - после последнего предоставленного элемента в выборке имеются другие.
        /// </summary>
        [XmlAttribute("hasMore")]
        public bool HasMore { get; set; }

        /// <summary>
        /// Информация о возврате денежных средств (возврат)
        /// </summary>
        [XmlElement("Refund", Order = 1)]
        public ExportRefundType[] Refund { get; set; }
    }
}