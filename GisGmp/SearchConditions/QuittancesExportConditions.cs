using System;
using System.Xml.Serialization;

namespace GisGmp.SearchConditions
{
    /// <summary>
    ///  Условия для предоставления информации о результатах квитирования
    /// </summary>
    [Serializable()]
    [XmlRoot("QuittancesExportConditions", Namespace = "http://roskazna.ru/gisgmp/xsd/SearchConditions/2.1.1")]
    public class QuittancesExportConditions : Conditions
    {
        protected QuittancesExportConditions() { }

        private QuittancesExportConditions(ExportQuittancesKind kind) => Kind = kind.ToString();
        public QuittancesExportConditions(ExportQuittancesKind kind, ChargesConditionsType conditions) : this(kind) => Item = conditions;       
        public QuittancesExportConditions(ExportQuittancesKind kind, TimeConditionsType conditions) : this(kind) => Item = conditions;
    }
}