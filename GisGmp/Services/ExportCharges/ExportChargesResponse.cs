using GisGmp.Common;
using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace GisGmp.Services.ExportCharges
{
    /// <summary>
    /// Ответ на запрос предоставления необходимой для уплаты информации (начисления)
    /// </summary>
    [Serializable()]
    [XmlRoot("ExportChargesResponse", Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-charges/2.1.1")]
    public class ExportChargesResponse : ResponseType
    {
        protected ExportChargesResponse() { }
       
        //TODO Проверить обязательные поля
        /// <summary />
        public ExportChargesResponse(ResponseType config, bool hasMore, ChargeInfo[] chargeInfo = null)
            : base(config)
        {
            HasMore = hasMore;
            ChargeInfo = chargeInfo;
        }

        /// <summary>
        /// Признак конца выборки: false - достигнут конец выборки; true - после последнего предоставленного элемента в выборке имеются другие [required]
        /// </summary>
        [XmlAttribute("hasMore")]
        public bool HasMore { get; set; }

        /// <summary>
        /// Признак необходимости направления повторного запроса. Присутствует в ответе, если для предоставления ответа на запроос потребовалось зайдействовать внешнюю систему и ответ от нее не был получен(внешняя система недоступна либо получено сообщение об ошибке)
        /// </summary>
        [XmlAttribute("needReRequest")]
        [DefaultValue(false)]
        public bool NeedReRequest { get; set; }

        /// <summary>
        /// Извещение о начислении (начисление)
        /// </summary>
        [XmlElement("ChargeInfo", Order = 1)]
        public ChargeInfo[] ChargeInfo { get; set; }
    }
}