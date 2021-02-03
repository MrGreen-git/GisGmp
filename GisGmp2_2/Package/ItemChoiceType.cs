using System;
using System.Xml.Serialization;

namespace GisGmp.Package
{
    /// <remarks/>
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Package/2.2.0", IncludeInSchema = false)]
    public enum ItemChoiceType
    {
        /// <remarks/>
        IncomeId,

        /// <remarks/>
        PaymentId,

        /// <remarks/>
        RefundId,

        /// <remarks/>
        SupplierBillId,
    }
}