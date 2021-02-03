using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    /// <remarks/>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.2.0")]
    public class DocumentIdentity
    {
        /// <summary />
        protected DocumentIdentity() { }

        /// <summary />
        public DocumentIdentity(Code code, string number)
        {
            Code = code;
            Number = number;
        }

        /// <summary>
        /// Код документа, удостоверяющего личность
        /// </summary>
        [XmlAttribute("code")]
        public Code Code { get; set; }

        /// <summary>
        /// Серия
        /// </summary>
        [XmlAttribute("series")]
        public string Series { get; set; }

        /// <summary>
        /// Номер
        /// </summary>
        [XmlAttribute("number")]
        public string Number { get; set; }
    }
}