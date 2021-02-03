using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace GisGmp.Services.ExportNSI
{
    /// <summary>
    /// Условия для предоставления нормативно-справочной информации
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-nsi/2.2.0")]
    public class NSIExportConditions
    {
        /// <summary />
        protected NSIExportConditions() { }

        /// <summary />
        public NSIExportConditions(OKTMOType oktmo) => Oktmo = oktmo;

        /// <summary />
        public NSIExportConditions(PayeeData payeeData) => PayeeData = payeeData;


        /// <summary>
        /// Служебное свойство
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlElement("PayeeData", typeof(PayeeData))]
        [XmlElement("oktmo", typeof(string))]
        public object Item   //TODO [multi] проверить типы
        {
            get => _Item;
            set => _Item = Validator.IsNull(value: value, name: nameof(Item));
        }

        object _Item;

        /// <summary>
        /// Код по ОКТМО организации, являющейся получателем средств
        /// </summary>
        [XmlIgnore]
        public OKTMOType Oktmo 
        {
            get => Item?.GetType() == typeof(string) ? (string)Item : null;
            set => Item = (value == null && Item?.GetType() != typeof(string)) ? Item : (string)value;
        }

        /// <summary>
        /// Данные для идентификации получателя средств
        /// </summary>
        [XmlIgnore]
        public PayeeData PayeeData
        {
            get => Item?.GetType() == typeof(PayeeData) ? (PayeeData)Item : null;
            set => Item = (value == null && Item?.GetType() == typeof(PayeeData)) ? Item : value;
        }
    }
}