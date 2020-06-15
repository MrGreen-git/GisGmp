using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ForcedAcknowledgement
{
    /// <summary>
    /// Отмена принудительного квитирования начисления с платежами
    /// </summary>
    [Serializable()]
    [XmlRoot("ReconcileType", Namespace = "urn://roskazna.ru/gisgmp/xsd/services/forced-ackmowledgement/2.1.1")]
    public class ReconcileType
    {
        protected ReconcileType() { }

        public ReconcileType(string[] paymentId) => Items = paymentId;

        // TODO Необходимо разобраться
        //public ReconcileType(bool[] paymentNotLoaded) => Items = paymentNotLoaded;

        /// <summary>
        /// УИН
        /// </summary>
        [XmlAttribute("supplierBillId")]
        public string SupplierBillId { get; set; }

        /// <summary>
        /// УИП / Появляется при квитировании с отсутствующим платежом
        /// </summary>
        [XmlElement("PaymentId", typeof(string), Order = 1)]
        [XmlElement("PaymentNotLoaded", typeof(bool), Order = 1)]
        public object[] Items { get; set; }
    }
}