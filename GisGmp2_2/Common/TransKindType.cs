using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    /// <remarks/>
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.2.0")]
    public enum TransKindType
    {
        /// <remarks/>
        [XmlEnum("01")]
        Item01,

        /// <remarks/>
        [XmlEnum("06")]
        Item06,

        /// <remarks/>
        [XmlEnum("16")]
        Item16,
    }
}