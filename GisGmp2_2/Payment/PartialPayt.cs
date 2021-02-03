using GisGmp.Common;
using System;
using System.Xml.Serialization;

namespace GisGmp.Payment
{
    /// <summary>
    /// Информация о частичном платеже
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/Payment/2.2.0")]
    public class PartialPayt
    {
        /// <summary />
        protected PartialPayt() { }

        /// <summary />
        public PartialPayt(AccDocType accDoc, TransKindType transKind)
        {
            AccDoc = accDoc;
            TransKind = transKind;
        }
       

        /// <summary>
        /// Реквизиты платежного документа (по которому осуществляется частичное исполнение)
        /// </summary>
        public AccDocType AccDoc { get; set; }

        /// <summary>
        /// Поле номер 39: Вид операции.Проставляется шифр исполняемого распоряжения.Возможные значения: 01 – платежное поручение; 06 – инкассовое поручение; 16 – платежный ордер.
        /// </summary>
        [XmlAttribute("transKind")]
        public TransKindType TransKind { get; set; }

        /// <summary>
        /// Поле номер 38: Номер частичного платежа
        /// </summary>
        [XmlAttribute("paytNo")]
        public string PaytNo { get; set; }

        /// <summary>
        /// Поле номер 70: Содержание операции
        /// </summary>
        [XmlAttribute("transContent")]
        public string TransContent { get; set; }

        /// <summary>
        /// Поле номер 42: Сумма остатка платежа
        /// </summary>
        [XmlAttribute("sumResidualPayt", DataType = "integer")]
        public string SumResidualPayt { get; set; }
    }
}