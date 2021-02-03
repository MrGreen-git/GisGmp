using GisGmp.Common;
using GisGmp.Organization;
using GisGmp.Payment;
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ExportPayments
{
    /// <summary>
    /// Извещение о приеме к исполнению распоряжения (платеж)
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-payments/2.2.0")]
    public class PaymentInfo : PaymentType
    {
        /// <summary />
        protected PaymentInfo() { }

        /// <summary />
        public PaymentInfo(
            ChangeStatusInfo changeStatusInfo,
            PaymentIdType paymentId,
            DateTime paymentDate,
            PaymentOrgType paymentOrg,
            Payee payee,
            string purpose,
            ulong amount,
            TransKindType transKind
            )
            : base(paymentId, paymentDate, paymentOrg, payee, purpose, amount, transKind) 
            => ChangeStatusInfo = changeStatusInfo;
        
        /// <summary>
        /// Обозначение факта квитирования платежа с начисление либо признака у платежа "Услуга предоставлена"
        /// </summary>
        public AcknowledgmentInfo AcknowledgmentInfo { get; set; }

        /// <summary>
        /// Сведения о возвратах денежных средств. Присутствует в ответе на запрос предоставления информации об уплате в случае осуществления возврата денежных средств
        /// </summary>
        [XmlElement("RefundInfo")]
        public RefundInfo[] RefundInfo 
        {
            get => _RefundInfo;
            set => _RefundInfo = Validator.ArrayObj(value: value, name: nameof(RefundInfo), required: false, min: 0, max: 20);
        }

        RefundInfo[] _RefundInfo;

        /// <summary>
        /// Сведения о статусе платежа и основаниях его изменения
        /// </summary>
        [XmlElement(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.2.0")]
        public ChangeStatusInfo ChangeStatusInfo 
        {
            get => _ChangeStatusInfo;
            set => _ChangeStatusInfo = Validator.IsNull(value: value, name: nameof(ChangeStatusInfo));
        }

        ChangeStatusInfo _ChangeStatusInfo;
    }
}