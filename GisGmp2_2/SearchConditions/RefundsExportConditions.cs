using System;
using System.Xml.Serialization;

namespace GisGmp.SearchConditions
{
    /// <remarks/>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/SearchConditions/2.2.0")]
    [XmlRoot(Namespace = "http://roskazna.ru/gisgmp/xsd/SearchConditions/2.2.0", IsNullable = false)]
    public class RefundsExportConditions : Conditions
    {
        protected RefundsExportConditions() { }

        private RefundsExportConditions(ExportRefundsKind kind) => Kind = kind.ToString();

        public RefundsExportConditions(ExportRefundsKind kind, PayersConditionsType conditions) : this(kind) => Item = conditions;
        public RefundsExportConditions(ExportRefundsKind kind, PaymentsConditionsType conditions) : this(kind) => Item = conditions;
        public RefundsExportConditions(ExportRefundsKind kind, RefundsConditionsType conditions) : this(kind) => Item = conditions;
        public RefundsExportConditions(ExportRefundsKind kind, TimeConditionsType conditions) : this(kind) => Item = conditions;
    }
}