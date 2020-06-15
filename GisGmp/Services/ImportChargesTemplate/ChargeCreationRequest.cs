using GisGmp.Charge;
using GisGmp.Common;
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ImportChargesTemplate
{
    /// <summary>
    /// Прием запроса на формирование необходимой для уплаты информации
    /// </summary>
    [Serializable()]
    [XmlRoot("ChargeCreationRequest", Namespace = "urn://roskazna.ru/gisgmp/xsd/services/import-chargestemplate/2.1.1")]
    public class ChargeCreationRequest : RequestType
    {
        protected ChargeCreationRequest() { }

        public ChargeCreationRequest(RequestType config, ChargeTemplateType chargeTemplate)
            : base(config) => ChargeTemplate = chargeTemplate;

        /// <summary>
        /// УРН участника косвенного взаимодействия, сформировавшего запрос
        /// </summary>
        [XmlAttribute()]
        public string originatorId { get; set; }

        /// <summary>
        /// Данные для формирования необходимой для уплаты информации
        /// </summary>
        [XmlElement("ChargeTemplate", Order = 1)]
        public ChargeTemplateType ChargeTemplate { get; set; }
    }
}
