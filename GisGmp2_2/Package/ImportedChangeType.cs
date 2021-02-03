using GisGmp.Common;
using System;
using System.Xml.Serialization;

namespace GisGmp.Package
{
    /// <remarks/>
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Package/2.2.0")]
    public class ImportedChangeType
    {
        /// <summary>
        /// Идентификатор зачисления; Идентификатор платежа; Идентификатор возврата; Идентификатор начисления
        /// </summary>
        [XmlElement("IncomeId", typeof(string))]
        [XmlElement("PaymentId", typeof(string))]
        [XmlElement("RefundId", typeof(string))]
        [XmlElement("SupplierBillId", typeof(string))]
        [XmlChoiceIdentifier("ItemElementName")]
        public string Item { get; set; }

        /// <remarks/>
        [XmlIgnore]
        public ItemChoiceType ItemElementName { get; set; }

        /// <summary>
        /// Изменяемые поля
        /// </summary>
        [XmlElement("Change")]
        public ChangeType[] Change { get; set; }

        /// <remarks/>
        [XmlElement(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.2.0")]
        public ChangeStatus ChangeStatus { get; set; }

        /// <summary>
        /// УРН участника косвенного взаимодействия, сформировавшего запрос
        /// </summary>
        [XmlAttribute("originatorId")]
        public string OriginatorId { get; set; }

        /// <summary>
        /// Идентификатор изменяемого извещения в пакете
        /// </summary>
        [XmlAttribute(DataType = "ID")]
        public string Id { get; set; }
    }
}