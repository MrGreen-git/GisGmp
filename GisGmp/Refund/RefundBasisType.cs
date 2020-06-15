using System;
using System.Xml.Serialization;

namespace GisGmp.Refund
{
    /// <summary>
    /// Реквизиты документа-основания для осуществления возврата
    /// </summary>
    [Serializable()]
    [XmlRoot("RefundBasisType", Namespace = "http://roskazna.ru/gisgmp/xsd/Refund/2.1.1")]
    public class RefundBasisType
    {
        /// <summary>
        /// Предназначен только для сериализации/десериализации
        /// </summary>
        protected RefundBasisType() { }

        public RefundBasisType(
            string DocKind,
            string DocNumber,
            DateTime DocDate
            )
        {
            this.DocKind = DocKind;
            this.DocNumber = DocNumber;
            this.DocDate = DocDate;
        }

        /// <summary>
        /// Поле номер 3005: Вид документа-основания для осуществления возврата для осуществления возврата [required]
        /// </summary>
        [XmlAttribute("docKind")]
        public string DocKind { get; set; }

        /// <summary>
        /// Поле номер 3006: Номер документа-основания для осуществления возврата [required]
        /// </summary>
        [XmlAttribute("docNumber")]
        public string DocNumber { get; set; }

        /// <summary>
        /// Поле номер 3007: Дата документа-основания для осуществления возврата
        /// </summary>
        [XmlAttribute("docDate")]
        public DateTime DocDate { get; set; }
    }
}