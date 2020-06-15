using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    /// <summary>
    /// Условия оплаты со скидкой (процент)
    /// </summary>
    [Serializable()]
    [XmlRoot("DiscountSize", Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.1.1")]
    public class DiscountSize : DiscountType
    {
    }
}