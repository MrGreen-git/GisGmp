using GisGmp.Income;
using System;
using System.Xml.Serialization;

namespace GisGmp.Package
{
    /// <remarks/>
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Package/2.2.0")]
    public class ImportedIncomeType : IncomeType
    {
        /// <summary />
        protected ImportedIncomeType() { }

        /// <summary />
        public ImportedIncomeType(string id) => Id = id;

        /// <summary />
        public ImportedIncomeType(string id, string originatorId)
            : this(id) => OriginatorId = originatorId;

        /// <remarks/>
        [XmlAttribute("originatorId")]
        public string OriginatorId { get; set; }

        /// <remarks/>
        [XmlAttribute(DataType = "ID")]
        public string Id { get; set; }
    }
}