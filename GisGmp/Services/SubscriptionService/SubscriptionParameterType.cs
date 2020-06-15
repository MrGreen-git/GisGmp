using System;
using System.Xml.Serialization;

namespace GisGmp.Services.SubscriptionService
{
    /// <summary>
    /// Перечень параметров, значения которых необходимо указать при оформлении подписки
    /// </summary>
    [Serializable()]
    [XmlRoot("SubscriptionParameterType", Namespace = "urn://roskazna.ru/gisgmp/xsd/services/SubscriptionService/2.1.1")]
    public class SubscriptionParameterType
    {
        /// <summary>
        /// Реквизиты платежного документа
        /// </summary>
        protected SubscriptionParameterType() { }

        public SubscriptionParameterType(
            string ParameterCode,
            string ParameterName,
            bool Required
            )
        {
            this.ParameterCode = ParameterCode;
            this.ParameterName = ParameterName;
            this.Required = Required;
        }

        /// <summary>
        /// Код параметра
        /// </summary>
        [XmlAttribute("parameterCode")]
        public string ParameterCode { get; set; }

        /// <summary>
        /// Наименование параметра
        /// </summary>
        [XmlAttribute("parameterName")]
        public string ParameterName { get; set; }

        /// <summary>
        /// Формат параметра
        /// </summary>
        [XmlAttribute("parameterPattern")]
        public string ParameterPattern { get; set; }

        /// <summary>
        /// Признак обязательности параметра: false - параметр необязательный; true - параметр обязательный.
        /// </summary>
        [XmlAttribute("required")]
        public bool Required { get; set; }

        /// <summary>
        /// Описание дополнительных ограничений для значений параметра
        /// </summary>
        [XmlAttribute("parameterDescription")]
        public string ParameterDescription { get; set; }
    }
}