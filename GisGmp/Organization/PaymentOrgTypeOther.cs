using System;
using System.Xml.Serialization;

namespace GisGmp.Organization
{
    /// <summary>
    /// Поле номер 2004: Признак иного способа проведения платежа. В случае приема в кассу получателя платежа наличных денежных средств от плательщика, тег должен быть заполнен значением «CASH».
    /// </summary>
    [Serializable()]
    [XmlRoot("PaymentOrgTypeOther", Namespace = "http://roskazna.ru/gisgmp/xsd/Organization/2.1.1")]
    public enum PaymentOrgTypeOther
    {
        /// <summary>
        /// Прием в кассу наличных денежных средств
        /// </summary>
        CASH,
    }
}
