using System;
using System.Xml.Serialization;

namespace GisGmp.Package
{
    /// <summary>
    /// Идентификатор
    /// </summary>
    [Serializable()]
    [XmlRoot("ItemChoiceType3", Namespace = "http://roskazna.ru/gisgmp/xsd/Package/2.1.1")]
    public enum ItemChoiceType3
    {
        /// <summary>
        /// Идентификатор платежа
        /// </summary>
        PaymentId,

        /// <summary>
        /// Идентификатор возврата
        /// </summary>
        RefundId,

        /// <summary>
        /// Идентификатор начисления
        /// </summary>
        SupplierBillId,
    }
}