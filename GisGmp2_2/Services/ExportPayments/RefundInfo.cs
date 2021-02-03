using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ExportPayments
{
    /// <summary>
    /// Сведения о возвратах денежных средств. Присутствует в ответе на запрос предоставления информации об уплате в случае осуществления возврата денежных средств
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-payments/2.2.0")]
    public class RefundInfo
    {
        /// <summary />
        protected RefundInfo() { }

        /// <summary />
        public RefundInfo(string refundId, ulong amount)
        {
            RefundId = refundId;
            Amount = amount;
        }

        /// <summary>
        /// Уникальный идентификатор извещения о возврате (УИВ)
        /// </summary>
        [XmlAttribute("refundId")]
        public string RefundId { get; set; }  //TODO [type]

        /// <summary>
        /// Сумма возврата
        /// </summary>
        [XmlAttribute("amount")]
        public ulong Amount { get; set; }
    }
}