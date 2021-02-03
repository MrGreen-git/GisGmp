using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    /// <remarks/
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.2.0")]
    public class AccDocType
    {
        /// <summary>
        protected AccDocType() { }

        /// <summary>
        public AccDocType(DateTime accDocDate)
        {
            AccDocDate = accDocDate;
        }

        /// <summary>
        /// Поле номер 3. Для частичного платежа поле номер 40: Номер платежного документа
        /// </summary>
        [XmlAttribute("accDocNo")]
        public string AccDocNo { get; set; }

        /// <remarks/>
        [XmlAttribute("accDocDate", DataType = "date")]
        public DateTime AccDocDate { get; set; }
    }
}