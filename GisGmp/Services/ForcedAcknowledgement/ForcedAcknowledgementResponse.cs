using GisGmp.Common;
using GisGmp.Quittance;
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ForcedAcknowledgement
{
    /// <summary>
    /// Ответ на запрос на проведение (отмену) принудительного квитирования/установление (отмену факта установления) извещению о приеме к исполнению распоряжения статуса "Услуга предоставлена"
    /// </summary>
    [Serializable()]
    [XmlRoot("ForcedAcknowledgementResponse", Namespace = "urn://roskazna.ru/gisgmp/xsd/services/forced-ackmowledgement/2.1.1")]
    public class ForcedAcknowledgementResponse : ResponseType
    {
        protected ForcedAcknowledgementResponse() { }

        public ForcedAcknowledgementResponse(ResponseType config, QuittanceType[] quittance)
            : base(config) => Items = quittance;
             
        // TODO Разобраться
        //public ForcedAcknowledgementResponse(bool[] done) => Items = (bool[])done;

        /// <summary>
        /// Результат принудительного квитирования (квитанция) Done - Присутствует в случае успешного выполнения следующих операций: - Отмена принудительного квитирования начисления с платежами; - Установление платежу признака "Услуга  предоставлена"; - Отмена факта установления платежу признака "Услуга предоставлена".
        /// </summary>
        [XmlElement("Done", typeof(bool), Order = 1)]
        [XmlElement("Quittance", typeof(QuittanceType), Order = 1)]
        public object[] Items { get; set; }
    }
}