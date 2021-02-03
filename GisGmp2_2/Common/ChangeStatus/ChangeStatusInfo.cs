using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    /// <remarks/>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.2.0")]
    [XmlRoot(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.2.0", IsNullable = false)]
    public class ChangeStatusInfo : ChangeStatusType
    {
        /// <remarks/>
        protected ChangeStatusInfo() { }

        /// <remarks/>
        public ChangeStatusInfo(string meaning) => Meaning = meaning;
    }
}