using GisGmp.Common;
using System;
using System.Xml.Serialization;

namespace GisGmp.Package
{
    /// <summary>
    /// Направляемые изменения в ранее загруженные извещения
    /// </summary>
    [Serializable()]
    [XmlRoot("ImportedChangeType", Namespace = "http://roskazna.ru/gisgmp/xsd/Package/2.1.1")]
    public class ImportedChangeType
    {
        /// <summary>
        /// УРН участника косвенного взаимодействия, сформировавшего запрос
        /// </summary>
        [XmlAttribute("originatorId")]
        public string OriginatorId { get; set; }

        /// <summary>
        /// Идентификатор изменяемого извещения в пакете [required]
        /// </summary>
        [XmlAttribute("Id")]
        public string Id { get; set; }

        /// <summary>
        /// Идентификатор
        /// </summary>
        [XmlElement("PaymentId", typeof(string), Order = 1)]
        [XmlElement("RefundId", typeof(string), Order = 1)]
        [XmlElement("SupplierBillId", typeof(string), Order = 1)]
        [XmlChoiceIdentifier("ItemElementName")]
        public string Item { get; set; }

        /// <summary/>
        [XmlIgnore()]
        public ItemChoiceType3 ItemElementName { get; set; }

        /// <summary>
        /// Изменяемые поля
        /// </summary>
        [XmlElement("Change", Order = 2)]
        public ChangeType[] Change { get; set; }

        /// <summary>
        /// Сведения о статусе и основаниях изменения
        /// </summary>
        [XmlElement("ChangeStatus", Order = 3, Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.1.1")]
        public ChangeStatus ChangeStatus { get; set; }       
    }
}
