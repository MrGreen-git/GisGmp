using GisGmp.Charge;
using GisGmp.Common;
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ImportChargesTemplate
{
    /// <summary>
    /// Ответ на запрос формирования необходимой для уплаты информации
    /// </summary>
    [Serializable()]
    [XmlRoot("ChargeCreationResponse", Namespace = "urn://roskazna.ru/gisgmp/xsd/services/import-chargestemplate/2.1.1")]
    public class ChargeCreationResponse : ResponseType
    {
        protected ChargeCreationResponse() 
        { 
        }

        public ChargeCreationResponse(ResponseType config, ChargeType charge)
            : base(config) => Charge = charge;      

        /// <summary>
        /// Предварительное начисление, сформированное ГИС ГМП по запросу участника.
        /// </summary>
        [XmlElement("Charge", Order = 1)]
        public ChargeType Charge { get; set; }
    }
}