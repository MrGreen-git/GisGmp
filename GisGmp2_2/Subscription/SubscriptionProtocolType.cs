using System;
using System.Xml.Serialization;

namespace GisGmp.Subscription
{
    /// <remarks/>
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Subscription/2.2.0")]
    public class SubscriptionProtocolType
    {
        /// <summary />
        protected SubscriptionProtocolType() { }

        /// <summary />
        public SubscriptionProtocolType(string code, string description)
        {
            Code = code;
            Description = description;
        }

        /// <summary />
        public SubscriptionProtocolType(string code, string description, string parameterId)
            : this(code, description) => ParameterId = parameterId;
        
        /// <summary>
        /// Идентификатор значения параметра (группы параметров) в пакете
        /// </summary>
        [XmlAttribute("parameterId", DataType = "ID")]
        public string ParameterId { get; set; }

        /// <summary>
        /// Код результата обработки: 0 — если значение параметра(группы параметров) успешно принято или код ошибки в случае отказа в приеме к обработке значения параметра(группы параметров)
        /// </summary>
        [XmlAttribute("code")]
        public string Code { get; set; }

        /// <summary>
        /// Описание результата обработки
        /// </summary>
        [XmlAttribute("description")]
        public string Description { get; set; }
    }
}