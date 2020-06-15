using GisGmp.Common;
using GisGmp.Quittance;
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ExportQuittances
{
    /// <summary>
    /// Ответ на запрос предоставления информации о результатах квитирования
    /// </summary>
    [Serializable()]
    [XmlRoot("ExportQuittancesResponse", Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-quittances/2.1.1", IsNullable = false)]
    public class ExportQuittancesResponse : ResponseType
    {
        protected ExportQuittancesResponse() { }

        public ExportQuittancesResponse(ResponseType config, bool hasMore, QuittanceType[] quittance = null)
            : base(config)
        {
            HasMore = hasMore;
            Quittance = quittance;           
        }

        /// <summary>
        /// Признак конца выборки: false - достигнут конец выборки; true - после последнего предоставленного элемента в выборке имеются другие.
        /// </summary>
        [XmlAttribute("hasMore")]
        public bool HasMore { get; set; }

        /// <summary>
        /// Результат квитирования (квитанция)
        /// </summary>
        [XmlElement("Quittance", Order = 1)]
        public QuittanceType[] Quittance { get; set; }

        /// <summary>
        /// Информация о сопоставлении начислений с платежами. Предоставляется только для запроса kind=ALLPOSSIBLE
        /// </summary>
        [XmlElement("PossibleData", Order = 2)]
        public PossibleDataType[] PossibleData { get; set; }
    }
}