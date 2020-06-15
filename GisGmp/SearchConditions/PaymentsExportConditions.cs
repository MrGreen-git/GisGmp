using System;
using System.Xml.Serialization;

namespace GisGmp.SearchConditions
{
    /// <summary>
    /// Условия для предоставления информации об уплате
    /// </summary>
    [Serializable()]
    [XmlRoot("PaymentsExportConditions", Namespace = "http://roskazna.ru/gisgmp/xsd/SearchConditions/2.1.1")]
    public class PaymentsExportConditions : Conditions
    {
        protected PaymentsExportConditions() { }

        private PaymentsExportConditions(ExportPaymentsKind kind) => Kind = kind.ToString();
        public PaymentsExportConditions(ExportPaymentsKind kind, ChargesConditionsType conditions) : this(kind) => Item = conditions;
        public PaymentsExportConditions(ExportPaymentsKind kind, PayersConditionsType conditions) : this(kind) => Item = conditions;
        public PaymentsExportConditions(ExportPaymentsKind kind, PaymentsConditionsType conditions) : this(kind) => Item = conditions;
        public PaymentsExportConditions(ExportPaymentsKind kind, TimeConditionsType conditions) : this(kind) => Item = conditions;
    }
}