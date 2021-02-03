using GisGmp.Common;
using GisGmp.Quittance;
using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace GisGmp.Services.ForcedAcknowledgement
{
    /// <remarks/>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/forced-ackmowledgement/2.2.0")]
    [XmlRoot(Namespace = "urn://roskazna.ru/gisgmp/xsd/services/forced-ackmowledgement/2.2.0", IsNullable = false)]
    public class ForcedAcknowledgementResponse : ResponseType
    {
        /// <summary/>
        protected ForcedAcknowledgementResponse() { }

        /// <summary/>
        public ForcedAcknowledgementResponse(ResponseType config, bool[] done)
            : base(config) => Done = done;

        /// <summary/>
        public ForcedAcknowledgementResponse(ResponseType config, QuittanceType[] quittances)
            : base(config) => Quittance = quittances;

        /// <summary>
        /// Служебное свойство
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlElement("Done", typeof(bool))]
        [XmlElement("Quittance", typeof(QuittanceType))]
        public object[] Items
        {
            get => _Items;
            set => _Items = Validator.ArrayObj(value: value, name: nameof(Items), required: true, min: 1, max: 100);
        }

        object[] _Items;

        /// <summary />
        [XmlIgnore]
        public bool[] Done
        {
            get => Items?.GetType() == typeof(bool[]) ? Array.ConvertAll(Items, b => (bool)b) : null;
            set => Items = (value == null && Items?.GetType() != typeof(bool[])) ? Items : Array.ConvertAll(value, b => (object)b);  
        }

        /// <summary />
        [XmlIgnore]
        public QuittanceType[] Quittance
        {
            get => Items?.GetType() == typeof(QuittanceType[]) ? (QuittanceType[])Items : null;
            set => Items = (value == null && Items?.GetType() != typeof(QuittanceType[])) ? Items : value; 
        }
    }
}