using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ExportCharges
{
    /// <summary>
    ///  Признак предоставляемой информации
    /// </summary>
    [Serializable()]
    [XmlRoot("External", Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-charges/2.1.1")]
    public enum External
    {
        /// <summary>
        /// Предоставление информации, необходимой для уплаты денежных средств в бюджетную систему РФ, за исключением начислений, администрируемых налоговыми органами Российской Федерации
        /// </summary>
        [XmlEnum("0")]
        Item0,

        /// <summary>
        /// Предоставление информации о начислениях, администрируемых налоговыми органами Российской Федерации
        /// </summary>
        [XmlEnum("1")]
        Item1,
    }
}