using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ExportPayments
{
    /// <remarks/>
    [Serializable]
    [XmlType(Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-payments/2.2.0", IncludeInSchema = false)]
    public enum ItemChoiceType
    {
        /// <summary>
        /// Обозначение у платежа статуса "Услуга предоставлена"
        /// </summary>
        ServiceProvided,

        /// <summary>
        /// УИН, с которым сквитирован платеж
        /// </summary>
        SupplierBillID,
    }
}