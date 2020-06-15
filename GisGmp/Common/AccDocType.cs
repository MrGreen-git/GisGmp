using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    /// <summary>
    /// Реквизиты платежного документа
    /// </summary>
    [Serializable()]
    [XmlRoot("AccDocType", Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.1.1")]
    public class AccDocType
    {
        /// <summary>
        /// Предназначен только для сериализации/десериализации
        /// </summary>
        protected AccDocType() { }

        public AccDocType(DateTime AccDocDate)
        {
            this.AccDocDate = AccDocDate;
        }

        /// <summary>
        /// Поле номер 3. Для частичного платежа поле номер 40: Номер платежного документа
        /// </summary>
        [XmlAttribute("accDocNo")]
        public string AccDocNo { get; set; }

        /// <summary>
        /// Поле номер 4. Для частичного платежа поле номер 41: Дата платежного документа
        /// </summary>
        [XmlAttribute("accDocDate")]
        public DateTime AccDocDate { get; set; }
    }
}