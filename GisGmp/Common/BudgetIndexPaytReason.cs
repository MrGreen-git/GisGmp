using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    /// <summary>
    /// Показатель основания платежа - реквизит 106 Распоряжения
    /// </summary>
    [Serializable()]
    [XmlRoot("BudgetIndexPaytReason", Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.1.1")]
    public enum BudgetIndexPaytReason
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