using GisGmp.Common;
using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace GisGmp.Services.ExportNSI
{
    /// <summary>
    /// Запрос на предоставление из ГИС ГМП нормативно-справочной информации
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-nsi/2.2.0")]
    [XmlRoot(Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-nsi/2.2.0", IsNullable = false)]
    public class ExportNSIRequest : RequestType
    {
        /// <summary/>
        protected ExportNSIRequest() { }

        /// <summary/>
        public ExportNSIRequest(RequestType config, NSIExportConditions nSIExportConditions)
            : base(config) => NSIExportConditions = nSIExportConditions;

        /// <summary/>
        public ExportNSIRequest(RequestType config, NSIExportConditions nSIExportConditions, URNType originatorId)
            : this(config, nSIExportConditions) => OriginatorId = originatorId;

        /// <summary>
        /// Условия для предоставления нормативно-справочной информации
        /// </summary>
        public NSIExportConditions NSIExportConditions 
        {
            get => _NSIExportConditions;
            set => _NSIExportConditions = Validator.IsNull(value: value, name: nameof(NSIExportConditions));
        }

        NSIExportConditions _NSIExportConditions;

        /// <summary>
        /// УРН участника косвенного взаимодействия, сформировавшего запрос
        /// </summary>
        [XmlIgnore]
        public URNType OriginatorId { get; set; }

        /// <summary />
        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlAttribute("originatorId")]
        public string WrapperOriginatorId { get => OriginatorId; set => OriginatorId = value; }
    }
}