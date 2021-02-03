using System;
using System.Xml.Serialization;

namespace GisGmp.Organization
{
    /// <remarks/>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/Organization/2.2.0")]
    public enum PaymentOrgTypeOther
    {
        /// <remarks/>
        CASH,
    }
}