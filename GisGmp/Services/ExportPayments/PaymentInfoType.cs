using GisGmp.Common;
using GisGmp.Payment;
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ExportPayments
{
    /// <summary>
    /// Извещение о приеме к исполнению распоряжения (платеж)
    /// </summary>
    [Serializable()]
    [XmlRoot("PaymentInfoType", Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-payments/2.1.1")]
    public class PaymentInfoType : PaymentType
    {
        /// <summary>
        /// Обозначение факта квитирования платежа с начисление либо признака у платежа "Услуга предоставлена"
        /// </summary>
        [XmlElement("AcknowledgmentInfo", Order = 1)]
        public AcknowledgmentInfoType AcknowledgmentInfo { get; set; }

        /// <summary>
        /// Сведения о возвратах денежных средств. Присутствует в ответе на запрос предоставления информации об уплате в случае осуществления возврата денежных средств
        /// </summary>
        [XmlElement("RefundInfo", Order = 2)]
        public RefundInfoType[] RefundInfo { get; set; }

        /// <summary>
        /// Сведения о статусе платежа и основаниях его изменения
        /// </summary>
        [XmlElement("ChangeStatusInfo", Order = 3, Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.1.1")]
        public ChangeStatusInfo ChangeStatusInfo { get; set; }
    }
}