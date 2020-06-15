using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ForcedAcknowledgement
{
    /// <summary>
    /// Выбор типа запроса
    /// </summary>
    [Serializable()]
    [XmlRoot("ItemChoiceType2", Namespace = "urn://roskazna.ru/gisgmp/xsd/services/forced-ackmowledgement/2.1.1")]
    public enum ItemChoiceType2
    {
        /// <summary>
        /// Отмена принудительного квитирования начисления с платежами
        /// </summary>
        AnnulmentReconcile,

        /// <summary>
        /// Отмена факта установления платежу признака "Услуга предоставлена"
        /// </summary>
        AnnulmentServiceProvided,

        /// <summary>
        /// Принудительное квитирование начисления с платежами
        /// </summary>
        Reconcile,

        /// <summary>
        /// Установление платежу признака "Услуга предоставлена"
        /// </summary>
        ServiceProvided,
    }
}