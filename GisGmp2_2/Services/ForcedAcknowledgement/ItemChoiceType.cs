using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ForcedAcknowledgement
{
    /// <remarks/>
    [Serializable]
    [XmlType(Namespace = "urn://roskazna.ru/gisgmp/xsd/services/forced-ackmowledgement/2.2.0", IncludeInSchema = false)]
    public enum ItemChoiceType
    {
        /// <remarks/>
        AnnulmentReconcile,

        /// <remarks/>
        AnnulmentServiceProvided,

        /// <remarks/>
        Reconcile,

        /// <remarks/>
        ServiceProvided,
    }
}