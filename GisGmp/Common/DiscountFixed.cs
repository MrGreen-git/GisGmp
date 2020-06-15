using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    /// <summary>
    /// Условия оплаты с фиксированной суммой скидки
    /// </summary>
    [Serializable()]
    [XmlRoot("DiscountFixed", Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.1.1")]
    public class DiscountFixed : DiscountType
    {
    }
}