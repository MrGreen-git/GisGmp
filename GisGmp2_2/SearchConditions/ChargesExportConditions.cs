using System;
using System.Xml.Serialization;

namespace GisGmp.SearchConditions
{
    /// <remarks/>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/SearchConditions/2.2.0")]
    [XmlRoot(Namespace = "http://roskazna.ru/gisgmp/xsd/SearchConditions/2.2.0", IsNullable = false)]
    public class ChargesExportConditions : Conditions
    {
        protected ChargesExportConditions() { }

        private ChargesExportConditions(ExportChargesKind kind) => Kind = kind.ToString();
        public ChargesExportConditions(ExportChargesKind kind, ChargesConditionsType conditions) : this(kind) => Item = conditions;
        public ChargesExportConditions(ExportChargesKind kind, PayersConditionsType conditions) : this(kind) => Item = conditions;
        public ChargesExportConditions(ExportChargesKind kind, TimeConditionsType conditions) : this(kind) => Item = conditions;
    }
}