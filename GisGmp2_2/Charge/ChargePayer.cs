using GisGmp.Common;
using System;
using System.Xml.Serialization;

namespace GisGmp.Charge
{
    /// <summary>
    /// Сведения о плательщике
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/Charge/2.2.0")]
    [XmlRoot(Namespace = "http://roskazna.ru/gisgmp/xsd/Charge/2.2.0", IsNullable = false)]
    public class ChargePayer : PayerType
    {
        /// <summary />
        protected ChargePayer() { }

        /// <summary />
        public ChargePayer(string payerIdentifier, string payerName)
            : base(payerIdentifier) => PayerName = payerName;
        
        /// <summary>
        /// Поле номер 8: Плательщик
        /// </summary>
        [XmlAttribute("payerName")]
        public string PayerName 
        {
            get => _PayerName;
            set => _PayerName = Validator.String(value: ref value, name: nameof(PayerName), required: true, min: 0, max: 160);
        }

        string _PayerName;

        /// <summary>
        /// Поле номер 1201: Дополнительный идентификатор плательщика
        /// </summary>
        [XmlAttribute("additionalPayerIdentifier")]
        public string AdditionalPayerIdentifier { get; set; }
    }
}