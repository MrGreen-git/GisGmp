using GisGmp.Common;
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ExportRefunds
{
    /// <summary>
    /// Ответ на запрос предоставления информации о возврате
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-refunds/2.2.0")]
    [XmlRoot(Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-refunds/2.2.0", IsNullable = false)]
    public class ExportRefundsResponse : ResponseType
    {
        /// <summary />
        protected ExportRefundsResponse() { }

        /// <summary />
        public ExportRefundsResponse(ResponseType config, bool hasMore)
            : base(config) => HasMore = hasMore;
          
        /// <summary />
        public ExportRefundsResponse(ResponseType config, bool hasMore, Refund[] refund = null)
            : this(config, hasMore) => Refund = refund;
        
        /// <summary>
        /// Информация о возврате денежных средств (возврат)
        /// </summary>
        [XmlElement("Refund")]
        public Refund[] Refund 
        {
            get => _Refund;
            set => _Refund = Validator.ArrayObj(value: value, name: nameof(Refund), required: false, min: 0, max: 100);
        }

        Refund[] _Refund;

        /// <summary>
        /// Признак конца выборки: false - достигнут конец выборки; true - после последнего предоставленного элемента в выборке имеются другие.
        /// </summary>
        [XmlAttribute("hasMore")]
        public bool HasMore { get; set; }
    }
}