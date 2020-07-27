using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    /// <summary>
    /// Результат обработки сущности в пакете
    /// </summary>
    [Serializable()]
    [XmlRoot(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.1.1")]
    public class ImportProtocolType
    {
        protected ImportProtocolType() { }

        public ImportProtocolType(
            string EntityID,
            string Code,
            string Description
            )
        {
            this.EntityID = EntityID;
            this.Code = Code;
            this.Description = Description;
        }

        /// <summary>
        /// Идентификатор сущности в пакете
        /// </summary>
        [XmlAttribute("entityID")]
        public string EntityID { get; set; }

        /// <summary>
        /// Код результата обработки: 0 — если запрос успешно принят или код ошибки в случае отказа в приеме к обработке документа
        /// </summary>
        [XmlAttribute("code")]
        public string Code { get; set; }

        /// <summary>
        /// Описание результата обработки
        /// </summary>
        [XmlAttribute("description")]
        public string Description { get; set; }
    }
}