using GisGmp.Common;
using GisGmp.Quittance;
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ExportQuittances
{
    /// <summary>
    /// Ответ на запрос предоставления информации об уплате 
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-quittances/2.2.0")]
    [XmlRoot(Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-quittances/2.2.0", IsNullable = false)]
    public class ExportQuittancesResponse : ResponseType
    {
        /// <summary/>
        protected ExportQuittancesResponse() { }

        /// <summary>
        /// Ответ на запрос предоставления информации об уплате 
        /// </summary>
        /// <param name="config"></param>
        /// <param name="hasMore"></param>
        public ExportQuittancesResponse(ResponseType config, bool hasMore)
            : base(config) => HasMore = hasMore;


        /// <summary>
        /// Ответ на запрос предоставления информации об уплате 
        /// </summary>
        /// <param name="config"></param>
        /// <param name="hasMore"></param>
        /// <param name="quittance">Результат квитирования (квитанция) | required: false, min: 0, max: 100</param>
        /// <param name="possibleData"></param>
        public ExportQuittancesResponse(ResponseType config, bool hasMore, QuittanceType[] quittance = default, PossibleData[] possibleData = default)
            : this(config, hasMore)
        {
            Quittance = quittance;
            PossibleData = possibleData;
        }


        #region XmlAttribute
        /// <summary>
        /// <para>Признак окончания выборки</para>                            
        /// </summary>
        [XmlAttribute("hasMore")]
        public bool HasMore { get; set; }
        #endregion


        #region XmlElement
        /// <summary>
        /// <para>Результат квитирования (квитанция)</para>
        /// <para>required: false, min: 0, max: 100</para>
        /// </summary>
        [XmlElement("Quittance")]
        public QuittanceType[] Quittance 
        {
            get => _Quittance;
            set => _Quittance = Validator.ArrayObj(value: value, name: nameof(Quittance), required: false, min: 0, max: 100);
        }

        QuittanceType[] _Quittance;


        /// <summary>
        /// <para>Дополнительные сведения об извещениях о приеме к исполнению распоряжений, которые несквитированы с извещением о начислении, но сопоставлены с ним по нескольким реквизитам квитирования</para>
        /// <para>required: false, min: 0, max: 100</para>
        /// </summary>
        [XmlElement("PossibleData")]
        public PossibleData[] PossibleData
        {
            get => _PossibleData;
            set => _PossibleData = Validator.ArrayObj(value: value, name: nameof(PossibleData), required: false, min: 0, max: 100);
        }

        PossibleData[] _PossibleData;
        #endregion
    }
}