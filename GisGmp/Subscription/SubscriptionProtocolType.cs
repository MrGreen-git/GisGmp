using System;
using System.Xml.Serialization;

namespace GisGmp.Subscription
{
    /// <summary>
    /// Идентификатор значения параметра (группы параметров) в пакете
    /// </summary>
    [Serializable()]
    [XmlRoot("SubscriptionProtocolType", Namespace = "http://roskazna.ru/gisgmp/xsd/Subscription/2.1.1")]
    public class SubscriptionProtocolType
    {
        /// <summary>
        /// Идентификатор параметра
        /// </summary>
        [XmlAttribute("parameterId")]
        public string ParameterId { get; set; }

        /// <summary>
        /// Код результата обработки: 0 — если значение параметра(группы параметров) успешно принято или код ошибки в случае отказа в приеме к обработке значения параметра(группы параметров) [required]
        /// </summary>
        [XmlAttribute("code")]
        public string Code { get; set; }

        /// <summary>
        /// Описание результата обработки [required]
        /// </summary>
        [XmlAttribute("description")]
        public string Description { get; set; }
    }
}