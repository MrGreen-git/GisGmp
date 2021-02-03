using GisGmp.Refund;
using System;
using System.Xml.Serialization;

namespace GisGmp.Package
{
    /// <remarks/>
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Package/2.2.0")]
    public class ImportedRefundType : RefundType
    {
        /// <summary />
        protected ImportedRefundType() { }

        /// <summary />
        public ImportedRefundType(string id) => Id = id;

        /// <summary />
        public ImportedRefundType(string id, string originatorId)
            : this(id) => OriginatorId = originatorId;

        /// <summary>
        /// УРН участника косвенного взаимодействия, сформировавшего запрос
        /// </summary>
        [XmlAttribute("originatorId")]
        public string OriginatorId { get; set; }

        /// <summary>
        /// Идентификатор возвтата в пакете
        /// </summary>
        [XmlAttribute(DataType = "ID")]
        public string Id { get; set; }
    }
}