using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ForcedAcknowledgement
{
    /// <summary>
    /// Отмена принудительного квитирования начисления с платежами
    /// </summary>
    [Serializable()]
    [XmlRoot("AnnulmentReconcileType", Namespace = "urn://roskazna.ru/gisgmp/xsd/services/forced-ackmowledgement/2.1.1")]
    public class AnnulmentReconcileType
    {
        protected AnnulmentReconcileType() { }

        public AnnulmentReconcileType(string[] paymentId) => Items = paymentId;
        public AnnulmentReconcileType(bool[] paymentNotLoaded)
        {
            //TODO необходимо разобраться
        }

        /// <summary>
        /// УИП / Появляется при квитировании с отсутствующим платежом
        /// </summary>
        [XmlElement("PaymentId", typeof(string), Order = 1)]
        [XmlElement("PaymentNotLoaded", typeof(bool), Order = 1)]
        public object[] Items { get; set; }

        /// <summary>
        /// УИН
        /// </summary>
        [XmlAttribute("supplierBillId")]
        public string SupplierBillId { get; set; }
    }
}