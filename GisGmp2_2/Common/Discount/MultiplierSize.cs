using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    /// <summary>
    /// Условия оплаты с применением понижающего размер начисления коэффициента
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.2.0")]
    [XmlRoot("MultiplierSize", Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.2.0", IsNullable = false)]
    public class MultiplierSize : DiscountType
    {
        //Поле номер 1008:  Коэффициент, понижающий размер начисления
        //Поле номер 1009: Срок действия учета коэффициента, понижающего размер начисления. Возможные значения:- дата окончания скидки в формате «ГГГГ-ММ-ДД»; - при отсутствии срока действия указывается значение «0».
    }
}