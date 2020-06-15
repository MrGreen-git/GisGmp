using System;
using System.Xml.Serialization;

namespace GisGmp.SearchConditions
{
    /// <summary>
    /// Условия для получения информации по уникальному идентификатору возврата (УИВ)
    /// </summary>
    [Serializable()]
    [XmlRoot("RefundsConditionsType", Namespace = "http://roskazna.ru/gisgmp/xsd/SearchConditions/2.1.1")]
    public class RefundsConditionsType
    {
        protected RefundsConditionsType() { }

        public RefundsConditionsType(string[] uir) => RefundId = uir;
        /// <summary>
        /// УИВ
        /// </summary>
        [XmlElement("RefundId", Order = 1)]
        public string[] RefundId { get; set; }
    }
}