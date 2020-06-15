using System;
using System.Xml.Serialization;

namespace GisGmp.Subscription
{
    //TODO изменить название различие в 1 символе
    /// <summary>
    /// Значение параметра (группы параметров) подписки
    /// </summary>
    [Serializable()]
    [XmlRoot("SubscriptionParametersType", Namespace = "http://roskazna.ru/gisgmp/xsd/Subscription/2.1.1")]
    public class SubscriptionParametersType
    {
        /// <summary>
        /// Реквизиты платежного документа
        /// </summary>
        protected SubscriptionParametersType() { }

        public SubscriptionParametersType(
            Status Status,
            string ParameterId,
            ParameterValue[] ParameterValue
            )
        {
            this.Status = Status;
            this.ParameterId = ParameterId;
            this.ParameterValue = ParameterValue;
        }

        /// <summary>
        /// Cтатус для обработки значения параметра (группы параметров). Возможные значения: 1-новое значение, 2-удаление значения [required]
        /// </summary>
        [XmlAttribute("Status")]
        public Status Status { get; set; }

        /// <summary>
        /// Идентификатор значения параметра (группы параметров) в пакете передаваемых значений [required]
        /// </summary>
        [XmlAttribute("parameterId")]
        public string ParameterId { get; set; }

        /// <summary>
        /// Значение параметра
        /// </summary>
        [XmlElement("ParameterValue", Order = 1)]
        public ParameterValue[] ParameterValue { get; set; }
    }
}
