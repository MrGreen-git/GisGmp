using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ExportPayments
{
    /// <summary>
    /// Факт квитирования или признак платежа
    /// </summary>
    [Serializable()]
    [XmlRoot("ItemChoiceType1", Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-payments/2.1.1")]
    public enum ItemChoiceType1
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