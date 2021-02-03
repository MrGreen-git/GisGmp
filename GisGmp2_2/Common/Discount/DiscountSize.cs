using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    /// <summary>
    /// Условия оплаты со скидкой (процент)
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.2.0")]
    [XmlRoot("DiscountSize", Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.2.0", IsNullable = false)]
    public class DiscountSize : DiscountType
    {
        //Поле номер 1006: Процент скидки от суммы начисления
        //Поле номер 1007: Срок действия скидки. Возможные значения:- дата окончания скидки в формате «ГГГГ-ММ-ДД»; - при отсутствии срока действия указывается значение «0»
    }
}