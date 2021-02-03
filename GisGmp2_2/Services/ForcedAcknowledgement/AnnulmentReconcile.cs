using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace GisGmp.Services.ForcedAcknowledgement
{
    /// <remarks/>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/forced-ackmowledgement/2.2.0")]
    public class AnnulmentReconcile
    {
        /// <summary />
        protected AnnulmentReconcile() { }

        /// <summary />
        public AnnulmentReconcile(SupplierBillIDType supplierBillId, PaymentIdType[] paymentId)
        {
            SupplierBillId = supplierBillId;
            PaymentId = paymentId;
        }

        /// <summary />
        public AnnulmentReconcile(SupplierBillIDType supplierBillId, bool[] paymentNotLoaded)
        {
            SupplierBillId = supplierBillId;
            PaymentNotLoaded = paymentNotLoaded;
        }

        /// <remarks/>
        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlElement("PaymentId", typeof(string))]
        [XmlElement("PaymentNotLoaded", typeof(bool))]
        public object[] Items { get; set; }  //TODO [multi]

        /// <summary />
        [XmlIgnore]
        public PaymentIdType[] PaymentId
        {
            get => Items?.GetType() == typeof(PaymentIdType[]) ? (PaymentIdType[])Items : null;
            set => Items = (value == null && Items?.GetType() != typeof(PaymentIdType[])) ? Items : value; 
        }
            
        [XmlIgnore]
        public bool[] PaymentNotLoaded
        {
            get => Items?.GetType() == typeof(bool[]) ? Array.ConvertAll(Items, b => (bool)b) : null;
            set => Items = (value == null && Items?.GetType() != typeof(bool[])) ? Items : Array.ConvertAll(value, b => (object)b);
        }


        /// <remarks/>
        [XmlIgnore]
        public SupplierBillIDType SupplierBillId { get; set; }


        /// <remarks/>
        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlAttribute("supplierBillId")]
        public string WrapperSupplierBillId { get => SupplierBillId; set => SupplierBillId = value; }
    }
}