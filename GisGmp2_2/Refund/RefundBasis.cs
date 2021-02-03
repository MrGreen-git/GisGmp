using System;
using System.Xml.Serialization;

namespace GisGmp.Refund
{
    /// <summary>
    /// Реквизиты документа-основания для осуществления возврата
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/Refund/2.2.0")]
    public class RefundBasis
    {
        /// <summary/>
        protected RefundBasis() { }

        /// <summary/>
        public RefundBasis(string docKind, string docNumber, DateTime docDate)
        {
            DocKind = docKind;
            DocNumber = docNumber;
            DocDate = docDate;
        }

        /// <summary/>
        //protected RefundBasis() { }
        /// <summary>
        /// Поле номер 3005: Вид документа-основания для осуществления возврата для осуществления возврата
        /// </summary>
        [XmlAttribute("docKind")]
        public string DocKind 
        {
            get => _DocKind;
            set => _DocKind = Validator.String(value: ref value, name: nameof(DocKind), required: true, min: 1, max: 160);
        }

        string _DocKind;


        /// <summary>
        /// Поле номер 3006: Номер документа-основания для осуществления возврата
        /// </summary>
        [XmlAttribute("docNumber")]
        public string DocNumber
        {
            get => _DocNumber;
            set => _DocNumber = Validator.String(value: ref value, name: nameof(DocNumber), required: true, min: 1, max: 160);
        }

        string _DocNumber;


        /// <summary>
        /// Поле номер 3007: Дата документа-основания для осуществления возврата
        /// </summary>
        [XmlAttribute("docDate", DataType = "date")]
        public DateTime DocDate { get; set; }
    }
}