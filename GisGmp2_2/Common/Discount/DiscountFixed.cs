using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    /// <summary>
    /// Условия оплаты с фиксированной суммой скидки
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.2.0")]
    [XmlRoot("DiscountFixed", Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.2.0", IsNullable = false)]
    public class DiscountFixed : DiscountType
    {
        //Поле номер 1004:  скидки от полной суммы начисления
        //Поле номер 1005:  Срок действия скидки. Возможные значения:- дата окончания скидки в формате «ГГГГ-ММ-ДД»; - при отсутствии срока действия указывается значение «0».
    }
}