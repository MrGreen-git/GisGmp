using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    /// <remarks/>
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.2.0")]
    public class ImportProtocolType
    {
        /// <summary />
        protected ImportProtocolType() { }

        /// <summary />
        public ImportProtocolType(string entityID, string code, string description)
        {
            EntityID = entityID;
            Code = code;
            Description = description;
        }
      
        /// <summary>
        /// Идентификатор сущности в пакете
        /// </summary>
        [XmlAttribute("entityID", DataType = "ID")]
        public string EntityID 
        {
            get => _EntityID;
            set => _EntityID = Validator.String(value: ref value, name: nameof(EntityID), required: true, min: 0, max: 50);
        }

        string _EntityID;

        /// <summary>
        /// Код результата обработки: 0 — если запрос успешно принят или код ошибки в случае отказа в приеме к обработке документа
        /// </summary>
        [XmlAttribute("code")]
        public string Code 
        {
            get => _Code;
            set => _Code = Validator.String(value: ref value, name: nameof(Code), required: true, min: 0, max: 32);
        }

        string _Code;
    
        /// <summary>
        /// Описание результата обработки
        /// </summary>
        [XmlAttribute("description")]
        public string Description 
        {
            get => _Description;
            set => _Description = Validator.String(value: ref value, name: nameof(Description), required: true, min: 0, max: 255);          
        }

        string _Description;
    }
}