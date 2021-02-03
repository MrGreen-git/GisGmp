using GisGmp.Payment;
using System;
using System.Xml.Serialization;

namespace GisGmp.Package
{
    /// <remarks/>
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Package/2.2.0")]
    public class ImportedPaymentType : PaymentType
    {
        /// <summary />
        protected ImportedPaymentType() { }

        /// <summary />
        public ImportedPaymentType(string id) => Id = id;

        /// <summary />
        public ImportedPaymentType(string id, string originatorId)
            : this(id) => OriginatorId = originatorId;

        /// <summary>
        /// УРН участника косвенного взаимодействия, сформировавшего запрос
        /// </summary>
        [XmlAttribute("originatorId")]
        public string OriginatorId { get; set; }

        /// <summary>
        /// Идентификатор платежа в пакете
        /// </summary>
        [XmlAttribute(DataType = "ID")]
        public string Id { get; set; }
    }
}