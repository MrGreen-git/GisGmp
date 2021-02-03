using GisGmp.Common;
using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace GisGmp.Services.ForcedAcknowledgement
{
    /// <summary>
    /// Запрос на проведение (отмену) принудительного квитирования/установление (отмену факта установления) извещению о приеме к исполнению распоряжения статуса "Услуга предоставлена"
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/forced-ackmowledgement/2.2.0")]
    [XmlRoot(Namespace = "urn://roskazna.ru/gisgmp/xsd/services/forced-ackmowledgement/2.2.0", IsNullable = false)]
    public class ForcedAcknowledgementRequest : RequestType
    {
        /// <summary/>
        protected ForcedAcknowledgementRequest() { }

        /// <summary/>
        public ForcedAcknowledgementRequest(RequestType config, AnnulmentReconcile annulmentReconcile, URNType originatorId = default)
            : base(config)
        {
            Item = annulmentReconcile;
            OriginatorId = originatorId;
        }

        /// <summary/>
        public ForcedAcknowledgementRequest(RequestType config, AnnulmentServiceProvided annulmentServiceProvided, URNType originatorId = default)
            : base(config)
        {
            Item = annulmentServiceProvided;
            OriginatorId = originatorId;
        }

        /// <summary/>
        public ForcedAcknowledgementRequest(RequestType config, Reconcile reconcile, URNType originatorId = default)
            : base(config)
        {
            Item = reconcile;
            OriginatorId = originatorId;
        }

        /// <summary/>
        public ForcedAcknowledgementRequest(RequestType config, ServiceProvided serviceProvided, URNType originatorId = default)
            : base(config)
        {
            Item = serviceProvided;
            OriginatorId = originatorId;
        }

        /// <remarks/>
        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlElement("AnnulmentReconcile", typeof(AnnulmentReconcile))]
        [XmlElement("AnnulmentServiceProvided", typeof(AnnulmentServiceProvided))]
        [XmlElement("Reconcile", typeof(Reconcile))]
        [XmlElement("ServiceProvided", typeof(ServiceProvided))]
        public object Item { get; set; }

        [XmlIgnore]
        public AnnulmentReconcile AnnulmentReconcile
        {
            get => Item?.GetType() == typeof(AnnulmentReconcile) ? (AnnulmentReconcile)Item : null;
            set => Item = value;
        }

        [XmlIgnore]
        public AnnulmentServiceProvided AnnulmentServiceProvided
        {
            get => Item?.GetType() == typeof(AnnulmentServiceProvided) ? (AnnulmentServiceProvided)Item : null;
            set => Item = value;
        }

        [XmlIgnore]
        public Reconcile Reconcile
        {
            get => Item?.GetType() == typeof(Reconcile) ? (Reconcile)Item : null;
            set => Item = value;
        }

        [XmlIgnore]
        public ServiceProvided ServiceProvided
        {
            get => Item?.GetType() == typeof(ServiceProvided) ? (ServiceProvided)Item : null;
            set => Item = value;
        }

        /// <remarks/>
        [XmlIgnore]
        public URNType OriginatorId { get; set; }


        /// <remarks/>
        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlAttribute("originatorId")]
        public string WrapperOriginatorId { get; set; }
    }
}