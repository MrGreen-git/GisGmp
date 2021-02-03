using GisGmp.Common;
using GisGmp.Common.Nsi;
using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace GisGmp.Services.ExportNSI
{
    /// <summary>
    /// Ответ на запрос предоставления из ГИС ГМП нормативно-справочной информации
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-nsi/2.2.0")]
    [XmlRoot(Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-nsi/2.2.0", IsNullable = false)]
    public class ExportNSIResponse : ResponseType
    {
        /// <summary/>
        protected ExportNSIResponse() { }

        /// <summary/>
        public ExportNSIResponse(ResponseType responseConfig, PayeeNSIInfoType payeeNSIInfoType)
            : base(responseConfig) => PayeeNSIInfoType = payeeNSIInfoType;

        /// <summary/>
        public ExportNSIResponse(ResponseType responseConfig, oktmoNSIInfoType oktmoNSIInfoType)
            : base(responseConfig) => OktmoNSIInfoType = oktmoNSIInfoType;


        /// <summary>
        /// Служебное поле
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlElement("PayeeNSIInfo", typeof(PayeeNSIInfoType))]
        [XmlElement("oktmoNSIInfo", typeof(oktmoNSIInfoType))]
        public object Item //TODO [multi] добавить проверку типов
        {
            get => _Item;
            set => _Item = Validator.IsNull(value: value, name: nameof(Item)); 
        }

        object _Item;

        /// <summary>
        /// Нормативно-справочная информация об участнике - получателе средств [исключает OktmoNSIInfoType]
        /// </summary>
        [XmlIgnore]
        public PayeeNSIInfoType PayeeNSIInfoType
        {
            get => Item?.GetType() == typeof(PayeeNSIInfoType) ? (PayeeNSIInfoType)Item : null;
            set => Item = (value == null && Item?.GetType() != typeof(PayeeNSIInfoType)) ? Item : value;
        }

        /// <summary>
        /// Нормативно-справочная информация о коде по ОКТМО [исключает PayeeNSIInfoType]
        /// </summary>
        [XmlIgnore]
        public oktmoNSIInfoType OktmoNSIInfoType
        {
            get => Item?.GetType() == typeof(oktmoNSIInfoType) ? (oktmoNSIInfoType)Item : null;
            set => Item = (value == null && Item?.GetType() != typeof(oktmoNSIInfoType)) ? Item : value;
        }
    }
}