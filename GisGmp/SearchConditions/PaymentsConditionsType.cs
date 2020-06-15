using GisGmp.Common;
using System;
using System.Xml.Serialization;

namespace GisGmp.SearchConditions
{
    /// <summary>
    /// Условия для получения информации по УИП
    /// </summary>
    [Serializable()]
    [XmlRoot("PaymentsConditionsType", Namespace = "http://roskazna.ru/gisgmp/xsd/SearchConditions/2.1.1")]
    public class PaymentsConditionsType
    {
        protected PaymentsConditionsType() { }

        public PaymentsConditionsType(string[] uip) => PaymentId = uip;
        /// <summary>
        /// УИП
        /// </summary>
        [XmlElement("PaymentId", Order = 1)]
        public string[] PaymentId { get; set; }
    }
}