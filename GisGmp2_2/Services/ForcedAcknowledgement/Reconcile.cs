using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace GisGmp.Services.ForcedAcknowledgement
{
    /// <remarks/>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/forced-ackmowledgement/2.2.0")]
    public class Reconcile
    {
        /// <summary />
        protected Reconcile() { }

        /// <summary />
        public Reconcile(SupplierBillIDType supplierBillId, PaymentIdType[] paymentId)
        {
            SupplierBillId = supplierBillId;
            PaymentId = paymentId;
        }

        /// <summary />
        public Reconcile(SupplierBillIDType supplierBillId, bool[] paymentNotLoaded)
        {
            SupplierBillId = supplierBillId;
            PaymentNotLoaded = paymentNotLoaded;
        }

        /// <remarks/>
        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlElement("PaymentId", typeof(string))]
        [XmlElement("PaymentNotLoaded", typeof(bool))]
        public object[] Items { get; set; }

        [XmlIgnore]
        public PaymentIdType[] PaymentId
        {
            get => null;
            set => Items = value.ToArrayString();
        }

        [XmlIgnore]
        public bool[] PaymentNotLoaded
        {
            get => null;
            set => Items = null;
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