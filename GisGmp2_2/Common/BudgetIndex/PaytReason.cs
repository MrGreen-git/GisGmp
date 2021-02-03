using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    /// <summary>
    /// Поле номер 106: Показатель основания платежа - реквизит 106 Распоряжения
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.2.0")]
    public enum PaytReason
    {
        /// <remarks/>
        ТП,

        /// <remarks/>
        ЗД,

        /// <remarks/>
        БФ,

        /// <remarks/>
        ТР,

        /// <remarks/>
        РС,

        /// <remarks/>
        ОТ,

        /// <remarks/>
        РТ,

        /// <remarks/>
        ПБ,

        /// <remarks/>
        ПР,

        /// <remarks/>
        АП,

        /// <remarks/>
        АР,

        /// <remarks/>
        ИН,

        /// <remarks/>
        ТЛ,

        /// <remarks/>
        ЗТ,

        /// <remarks/>
        ДЕ,

        /// <remarks/>
        ПО,

        /// <remarks/>
        КТ,

        /// <remarks/>
        ИД,

        /// <remarks/>
        ИП,

        /// <remarks/>
        ТУ,

        /// <remarks/>
        БД,

        /// <remarks/>
        КП,

        /// <remarks/>
        ВУ,

        /// <remarks/>
        ДК,

        /// <remarks/>
        ПК,

        /// <remarks/>
        КК,

        /// <remarks/>
        ТК,

        /// <remarks/>
        ПД,

        /// <remarks/>
        КВ,

        /// <remarks/>
        [XmlEnum("00")]
        Item00,

        /// <remarks/>
        [XmlEnum("0")]
        Item0,
    }
}