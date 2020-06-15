using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ExportPayments
{
    /// <summary>
    /// Сведения о возвратах денежных средств. Присутствует в ответе на запрос предоставления информации об уплате в случае осуществления возврата денежных средств
    /// </summary>
    [Serializable()]
    [XmlRoot("RefundInfoType", Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-payments/2.1.1")]
    public class RefundInfoType
    {
        /// <summary>
        /// Уникальный идентификатор извещения о возврате (УИВ)
        /// </summary>
        [XmlAttribute("refundId")]
        public string RefundId { get; set; }

        /// <summary>
        /// Сумма возврата
        /// </summary>
        [XmlAttribute("amount")]
        public ulong Amount { get; set; }
    }
}