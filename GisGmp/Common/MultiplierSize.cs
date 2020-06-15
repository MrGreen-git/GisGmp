using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    /// <summary>
    /// Условия оплаты с применением понижающего размер начисления коэффициента
    /// </summary>
    [Serializable()]
    [XmlRoot("MultiplierSize", Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.1.1")]
    public class MultiplierSize : DiscountType
    {
    }
}