using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace GisGmp.Services.ExportPayments
{
    /// <summary>
    /// Обозначение факта квитирования платежа с начисление либо признака у платежа "Услуга предоставлена"
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-payments/2.2.0")]
    public class AcknowledgmentInfo 
    {
        /// <summary />
        protected AcknowledgmentInfo() { }

        /// <summary />
        public AcknowledgmentInfo(string serviceProvided) => ServiceProvided = serviceProvided;

        /// <summary />
        public AcknowledgmentInfo(SupplierBillIDType supplierBillID) => SupplierBillID = supplierBillID;

        
        /// <summary>
        /// Служебное свойство
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlElement("ServiceProvided", typeof(string))]
        [XmlElement("SupplierBillID", typeof(string))]
        [XmlChoiceIdentifier("ItemElementName")]
        public string Item { get; set; }

        /// <summary>
        /// Служебное свойство
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlIgnore]
        public ItemChoiceType ItemElementName { get; set; }

        /// <summary>
        /// Обозначение у платежа статуса "Услуга предоставлена"
        /// </summary>
        [XmlIgnore]
        public string ServiceProvided
        {
            get => ItemElementName == ItemChoiceType.ServiceProvided ? Item : null;
            set
            {               
                Item = value;
                ItemElementName = ItemChoiceType.ServiceProvided;
            }
        }

        /// <summary>
        /// УИН, с которым сквитирован платеж
        /// </summary>
        [XmlIgnore]
        public SupplierBillIDType SupplierBillID
        {
            get => ItemElementName == ItemChoiceType.SupplierBillID ? Item : null;
            set
            {              
                Item = value;
                ItemElementName = ItemChoiceType.SupplierBillID;
            }
        }
    }
}