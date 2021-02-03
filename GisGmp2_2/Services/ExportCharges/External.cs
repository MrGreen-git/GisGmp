using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ExportCharges
{
    /// <summary>
    /// Признак предоставляемой информации
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-charges/2.2.0")]
    public enum External
    {
        /// <summary>
        /// предоставление информации, необходимой для уплаты денежных средств в бюджетную систему РФ, за исключением начислений, администрируемых налоговыми органами Российской Федерации
        /// </summary>
        [XmlEnum("0")]
        Item0,

        /// <summary>
        /// предоставление информации о начислениях, администрируемых налоговыми органами Российской Федерации
        /// </summary>
        [XmlEnum("1")]
        Item1,
    }
}