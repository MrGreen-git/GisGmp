using System;
using System.Xml.Serialization;

namespace GisGmp.SearchConditions
{
    /// <summary>
    /// Условия для получения извещений о начислениях
    /// </summary>
    [Serializable()]
    [XmlRoot("ChargesExportConditions", Namespace = "http://roskazna.ru/gisgmp/xsd/SearchConditions/2.1.1")]
    public class ChargesExportConditions : Conditions
    {
        protected ChargesExportConditions() { }

        private ChargesExportConditions(ExportChargesKind kind) => Kind = kind.ToString();
        public ChargesExportConditions(ExportChargesKind kind, ChargesConditionsType conditions) : this(kind) => Item = conditions;
        public ChargesExportConditions(ExportChargesKind kind, PayersConditionsType conditions) : this(kind) => Item = conditions;
        public ChargesExportConditions(ExportChargesKind kind, TimeConditionsType conditions) : this(kind) => Item = conditions;
    }
}