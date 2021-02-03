using System;
using System.Xml.Serialization;

namespace GisGmp.SearchConditions
{
    /// <remarks/>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/SearchConditions/2.2.0")]
    [XmlRoot(Namespace = "http://roskazna.ru/gisgmp/xsd/SearchConditions/2.2.0", IsNullable = false)]
    public class PaymentsExportConditions : Conditions
    {
        /// <remarks/>
        protected PaymentsExportConditions() { }
        
        /// <remarks/>
        private PaymentsExportConditions(ExportPaymentsKind kind) => Kind = kind.ToString();
        /// <remarks/>
        public PaymentsExportConditions(ExportPaymentsKind kind, ChargesConditionsType conditions) : this(kind) => Item = conditions;
        /// <remarks/>
        public PaymentsExportConditions(ExportPaymentsKind kind, PayersConditionsType conditions) : this(kind) => Item = conditions;
        /// <remarks/>
        public PaymentsExportConditions(ExportPaymentsKind kind, PaymentsConditionsType conditions) : this(kind) => Item = conditions;
        /// <remarks/>
        public PaymentsExportConditions(ExportPaymentsKind kind, TimeConditionsType conditions) : this(kind) => Item = conditions;
    }
}