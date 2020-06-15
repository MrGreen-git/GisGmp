using GisGmp.Common;
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ForcedAcknowledgement
{
    /// <summary>
    /// Запрос на проведение (отмену) принудительного квитирования/установление (отмену факта установления) извещению о приеме к исполнению распоряжения статуса "Услуга предоставлена"
    /// </summary>
    [Serializable()]
    [XmlRoot("ForcedAcknowledgementRequest", Namespace = "urn://roskazna.ru/gisgmp/xsd/services/forced-ackmowledgement/2.1.1")]
    public class ForcedAcknowledgementRequest : RequestType
    {
        protected ForcedAcknowledgementRequest() { }

        public ForcedAcknowledgementRequest(RequestType config, AnnulmentReconcileType annulmentReconcile)
            : base(config) => Item = annulmentReconcile;
        public ForcedAcknowledgementRequest(RequestType config, AnnulmentServiceProvidedType annulmentServiceProvided) 
            : base(config) => Item = annulmentServiceProvided;
        public ForcedAcknowledgementRequest(RequestType config, ReconcileType reconcile)
            : base(config) => Item = reconcile;
        public ForcedAcknowledgementRequest(RequestType config, ServiceProvidedType serviceProvided)
            : base(config) => Item = serviceProvided;
        
        /// <summary>
        /// УРН участника косвенного взаимодействия, сформировавшего запрос
        /// </summary>
        [XmlAttribute("originatorId")]
        public string OriginatorId { get; set; }

        /// <summary>
        /// Тип запроса
        /// </summary>
        [XmlElement("AnnulmentReconcile", typeof(AnnulmentReconcileType), Order = 1)]
        [XmlElement("AnnulmentServiceProvided", typeof(AnnulmentServiceProvidedType), Order = 1)]
        [XmlElement("Reconcile", typeof(ReconcileType), Order = 1)]
        [XmlElement("ServiceProvided", typeof(ServiceProvidedType), Order =1)]
        // [XmlChoiceIdentifier("ItemElementName")]
        public object Item { get; set; }

        ///// <summary/>
        //[XmlIgnore()]
        //public ItemChoiceType2 ItemElementName { get; set; }
    }
}
