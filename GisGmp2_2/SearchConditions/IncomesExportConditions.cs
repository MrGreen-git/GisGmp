using System;
using System.Xml.Serialization;

namespace GisGmp.SearchConditions
{
    /// <remarks/>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/SearchConditions/2.2.0")]
    [XmlRoot(Namespace = "http://roskazna.ru/gisgmp/xsd/SearchConditions/2.2.0", IsNullable = false)]
    public class IncomesExportConditions : Conditions
    {
        protected IncomesExportConditions() { }

        private IncomesExportConditions(ExportIncomesKind kind) => Kind = kind.ToString();

        public IncomesExportConditions(ExportIncomesKind kind, ChargesConditionsType conditions) : this(kind) => Item = conditions;
        public IncomesExportConditions(ExportIncomesKind kind, PayersConditionsType conditions) : this(kind) => Item = conditions;
        public IncomesExportConditions(ExportIncomesKind kind, PaymentsConditionsType conditions) : this(kind) => Item = conditions;
        public IncomesExportConditions(ExportIncomesKind kind, TimeConditionsType conditions) : this(kind) => Item = conditions;
        public IncomesExportConditions(ExportIncomesKind kind, IncomesConditionsType conditions) : this(kind) => Item = conditions;
    }
}