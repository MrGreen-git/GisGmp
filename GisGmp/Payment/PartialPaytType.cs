using GisGmp.Common;
using System;
using System.Xml.Serialization;

namespace GisGmp.Payment
{
    /// <summary>
    /// Информация о частичном платеже
    /// </summary>
    [Serializable()]
    [XmlRoot("PartialPaytType", Namespace = "http://roskazna.ru/gisgmp/xsd/Payment/2.1.1")]
    public class PartialPaytType
    {    
        /// <summary>
        /// Поле номер 39: Вид операции.Проставляется шифр исполняемого распоряжения.
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
        [XmlAttribute("sumResidualPayt")]
        public string SumResidualPayt { get; set; }

        /// <summary>
        /// Реквизиты платежного документа (по которому осуществляется частичное исполнение)
        /// </summary>
        [XmlElement("AccDoc", Order = 1)]
        public AccDocType AccDoc { get; set; }
    }
}