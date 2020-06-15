using GisGmp.Common;
using GisGmp.Organization;
using GisGmp.Payment;
using System;
using System.Xml.Serialization;

namespace GisGmp.Package
{
    /// <summary>
    /// Направляемый новый платеж
    /// </summary>
    [Serializable()]
    [XmlRoot("ImportedPaymentType", Namespace = "http://roskazna.ru/gisgmp/xsd/Package/2.1.1")]
    public class ImportedPaymentType : PaymentType
    {
        /// <summary>
        /// Предназначен для работы сериализации/десериализации
        /// </summary>
        protected ImportedPaymentType(){ }

        public ImportedPaymentType(
            string Id,
            string PaymentId,
            string Purpose,
            ulong Amount,
            DateTime PaymentDate,
            TransKindType TransKind,
            PaymentOrgType PaymentOrg,
            Payee Payee
            ) : base 
            (
                PaymentId,
                Purpose,
                Amount,
                PaymentDate,
                TransKind,
                PaymentOrg,
                Payee
            )
        {
            this.Id = Id;
        }

        /// <summary>
        /// УРН участника косвенного взаимодействия, сформировавшего запрос
        /// </summary>
        [XmlAttribute("originatorId")]
        public string OriginatorId { get; set; }

        /// <summary>
        /// Идентификатор платежа в пакете
        /// </summary>
        [XmlAttribute("Id")]
        public string Id { get; set; }
    }
}