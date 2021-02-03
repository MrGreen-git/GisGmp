using GisGmp.Charge;
using GisGmp.Common;
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ImportChargesTemplate
{
    /// <remarks/>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/import-chargestemplate/2.2.0")]
    [XmlRoot(Namespace = "urn://roskazna.ru/gisgmp/xsd/services/import-chargestemplate/2.2.0", IsNullable = false)]
    public class ChargeCreationResponse : ResponseType
    {
        /// <summary/>
        protected ChargeCreationResponse() { }

        /// <summary/>
        public ChargeCreationResponse(ResponseType config, ChargeType charge)
            : base(config) => Charge = charge;

        /// <remarks/>
        public ChargeType Charge 
        {
            get => _Charge;
            set => _Charge = Validator.IsNull(value: value, name: nameof(Charge));
        }

        ChargeType _Charge;
    }
}