using System;
using System.Xml.Serialization;

namespace GisGmp.Income
{
    /// <summary>
    /// Поле номер 4002: Обозначение электронного сообщения в унифицированных форматах электронных банковских сообщений Банка России,на основании которого сформировано зачисление
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/Income/2.2.0")]
    public enum EdCode
    {
        /// <remarks/>
        ED101,

        /// <remarks/>
        ED104,

        /// <remarks/>
        ED105,

        /// <remarks/>
        ED108,

        /// <remarks/>
        ED701,
    }
}