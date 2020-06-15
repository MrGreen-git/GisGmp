using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ExportQuittances
{
    /// <summary>
    /// Информация о сопоставлении начислений с платежами. Предоставляется только для запроса kind=ALLPOSSIBLE
    /// </summary>
    [Serializable()]
    [XmlRoot("PossibleDataType", Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-quittances/2.1.1")]
    public class PossibleDataType
    {
        /// <summary>
        /// Сумма, указанная в начислении
        /// </summary>
        [XmlAttribute("TotalAmount")]
        public ulong TotalAmount { get; set; }

        /// <summary/>
        [XmlIgnore()]
        public bool TotalAmountSpecified { get; set; }

        /// <summary>
        /// УИН, с которым сопоставлены платежи
        /// </summary>
        [XmlAttribute("supplierBillID")]
        public string SupplierBillID { get; set; }

        /// <summary>
        /// Результат сопоставления начисления с платежом
        /// </summary>
        [XmlElement("ComparisonResult", Order = 1)]
        public ComparisonResultType[] ComparisonResult { get; set; }
    }
}