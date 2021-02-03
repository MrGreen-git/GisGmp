using GisGmp.Common;
using GisGmp.Organization;
using GisGmp.Package;
using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace GisGmp.Payment
{
    /// <remarks/>
    [XmlInclude(typeof(ImportedPaymentType))]
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Payment/2.2.0")]
    public class PaymentType : PaymentBaseType
    {
        /// <summary />
        protected PaymentType() { }

        /// <summary />
        public PaymentType(
            PaymentIdType paymentId, 
            DateTime paymentDate,
            PaymentOrgType paymentOrg,
            Payee payee,
            string purpose,
            ulong amount,
            TransKindType transKind
            ) : base(paymentOrg, payee, purpose, amount, transKind)
        {
            PaymentId = paymentId;
            PaymentDate = paymentDate;
        }

        /// <summary>
        /// Информация о частичном платеже
        /// </summary>
        public PartialPayt PartialPayt { get; set; }


        /// <summary>
        /// УИП, присвоенный участником, принявшим платеж
        /// </summary>
        [XmlIgnore]
        public PaymentIdType PaymentId 
        {
            get => _PaymentId;
            set => _PaymentId = Validator.IsNull(value: value, name: nameof(PaymentId)); 
        }

        PaymentIdType _PaymentId;

        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlAttribute("paymentId")]
        public string WrapperPaymentId { get => PaymentId; set => PaymentId = value; }


        /// <summary>
        /// Поле номер 2001: Дата приема к исполнению распоряжения плательщика
        /// </summary>
        [XmlAttribute("paymentDate")]
        public DateTime PaymentDate { get; set; }


        /// <summary>
        /// Поле номер 37: Дата отсылки(вручения) плательщику документа с начислением в случае, если этот документ был отослан(вручен) получателем средств плательщику
        /// </summary>
        [XmlIgnore]
        public DateTime? DeliveryDate { get; set; }

        /// <summary />
        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlAttribute("deliveryDate", DataType = "date")]
        public DateTime WrapperDeliveryDate
        {
            get => DeliveryDate.Value;
            set => DeliveryDate = value;
        }

        /// <remarks/>
        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlIgnore]
        public bool WrapperDeliveryDateSpecified { get => DeliveryDate.HasValue; }


        /// <summary>
        /// Поле номер 2002: Идентификатор учетной записи пользователя в ЕСИА
        /// </summary>
        [XmlAttribute]
        public string ESIA_ID 
        {
            get => _ESIA_ID;
            set => _ESIA_ID = Validator.String(value: ref value, name: nameof(ESIA_ID), required: false, min: 0, max: 255);
        }

        string _ESIA_ID;
    }
}