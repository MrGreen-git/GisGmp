using System;
using System.Xml.Serialization;

namespace GisGmp.SearchConditions
{
    /// <remarks/>
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/SearchConditions/2.2.0")]
    public class IncomesConditionsType
    {
        /// <summary>
        /// УИЗ
        /// </summary>
        [XmlElement("IncomeId")]
        public string[] IncomeId { get; set; }
    }
}