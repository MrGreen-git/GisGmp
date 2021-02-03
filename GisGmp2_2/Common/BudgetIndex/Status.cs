using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    /// <summary>
    /// Поле номер 101: Статус плательщика - реквизит 101 Распоряжения
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.2.0")]
    public enum Status
    {
        /// <remarks/>
        [XmlEnum("01")]
        Item01,

        /// <remarks/>
        [XmlEnum("02")]
        Item02,

        /// <remarks/>
        [XmlEnum("03")]
        Item03,

        /// <remarks/>
        [XmlEnum("04")]
        Item04,

        /// <remarks/>
        [XmlEnum("05")]
        Item05,

        /// <remarks/>
        [XmlEnum("06")]
        Item06,

        /// <remarks/>
        [XmlEnum("07")]
        Item07,

        /// <remarks/>
        [XmlEnum("08")]
        Item08,

        /// <remarks/>
        [XmlEnum("09")]
        Item09,

        /// <remarks/>
        [XmlEnum("10")]
        Item10,

        /// <remarks/>
        [XmlEnum("11")]
        Item11,

        /// <remarks/>
        [XmlEnum("12")]
        Item12,

        /// <remarks/>
        [XmlEnum("13")]
        Item13,

        /// <remarks/>
        [XmlEnum("14")]
        Item14,

        /// <remarks/>
        [XmlEnum("15")]
        Item15,

        /// <remarks/>
        [XmlEnum("16")]
        Item16,

        /// <remarks/>
        [XmlEnum("17")]
        Item17,

        /// <remarks/>
        [XmlEnum("18")]
        Item18,

        /// <remarks/>
        [XmlEnum("19")]
        Item19,

        /// <remarks/>
        [XmlEnum("20")]
        Item20,

        /// <remarks/>
        [XmlEnum("21")]
        Item21,

        /// <remarks/>
        [XmlEnum("22")]
        Item22,

        /// <remarks/>
        [XmlEnum("23")]
        Item23,

        /// <remarks/>
        [XmlEnum("24")]
        Item24,

        /// <remarks/>
        [XmlEnum("25")]
        Item25,

        /// <remarks/>
        [XmlEnum("26")]
        Item26,

        /// <remarks/>
        [XmlEnum("27")]
        Item27,

        /// <remarks/>
        [XmlEnum("28")]
        Item28,
    }
}