using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ExportPayments
{
    /// <summary>
    /// Обозначение факта квитирования платежа с начисление либо признака у платежа "Услуга предоставлена"
    /// </summary>
    [Serializable()]
    [XmlRoot("AcknowledgmentInfoType", Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-payments/2.1.1")]
    public class AcknowledgmentInfoType
    {
        /// <summary>
        /// Факт квитирования или признак платежа
        /// </summary>
        [XmlElement("ServiceProvided", typeof(string), Order = 1)]
        [XmlElement("SupplierBillID", typeof(string), Order = 1)]
        [XmlChoiceIdentifier("ItemElementName")]
        public string Item { get; set; }

        /// <summary/>
        [XmlIgnore()]
        public ItemChoiceType1 ItemElementName { get; set; }
    }
}