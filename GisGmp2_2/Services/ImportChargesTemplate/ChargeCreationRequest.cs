using GisGmp.Charge;
using GisGmp.Common;
using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace GisGmp.Services.ImportChargesTemplate
{
    /// <remarks/>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/import-chargestemplate/2.2.0")]
    [XmlRoot(Namespace = "urn://roskazna.ru/gisgmp/xsd/services/import-chargestemplate/2.2.0", IsNullable = false)]
    public class ChargeCreationRequest : RequestType
    {
        /// <remarks/>
        protected ChargeCreationRequest() { }

        /// <remarks/>
        public ChargeCreationRequest(RequestType config, ChargeTemplateType chargeTemplate)
            : base(config) => ChargeTemplate = chargeTemplate;

        /// <remarks/>
        public ChargeCreationRequest(RequestType config, ChargeTemplateType chargeTemplate, URNType originatorId)
            : this(config, chargeTemplate) => OriginatorId = originatorId;

        /// <remarks/>
        public ChargeTemplateType ChargeTemplate 
        {
            get => _ChargeTemplate;
            set => _ChargeTemplate = Validator.IsNull(value: value, nameof(ChargeTemplate)); 
        }

        ChargeTemplateType _ChargeTemplate;

        /// <remarks/>
        [XmlIgnore]
        public URNType OriginatorId { get; set; }

        /// <remarks/>
        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlAttribute("originatorId")]
        public string WrapperOriginatorId { get; set; }
    }
}
