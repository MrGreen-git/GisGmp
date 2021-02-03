using GisGmp.Common.Nsi;
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ExportNoticeNSI
{
    /// <summary>
    /// Уведомление об изменении нормативно-справочной информации
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/ExportNoticeNSI/2.2.0")]
    public class NoticeNSI
    {
        /// <summary />
        protected NoticeNSI() { }

        /// <summary />
        public NoticeNSI(string directoryCode, bool signAttachment)
        {
            DirectoryCode = directoryCode;
            SignAttachment = signAttachment;
        }

        /// <summary />
        public NoticeNSI(string directoryCode, bool signAttachment, PayeeNSIInfoType[] payeeNSIInfoType) 
            : this(directoryCode, signAttachment) => PayeeNSIInfoType = payeeNSIInfoType;

        /// <summary />
        public NoticeNSI(string directoryCode, bool signAttachment, oktmoNSIInfoType[] oktmoNSIInfoType)
            : this(directoryCode, signAttachment) => OktmoNSIInfoType = oktmoNSIInfoType;

        /// <summary>
        /// Нормативно-справочная информация об участнике-получателе средств/ Нормативно-справочная информация о коде по ОКТМО
        /// </summary>
        [XmlElement("PayeeNSIInfo", typeof(PayeeNSIInfoType))]
        [XmlElement("oktmoNSIInfo", typeof(oktmoNSIInfoType))]
        public object[] Items { get; set; }

        [XmlIgnore]
        public PayeeNSIInfoType[] PayeeNSIInfoType
        {
            get => Items?.GetType() == typeof(PayeeNSIInfoType[]) ? (PayeeNSIInfoType[])Items : null;
            set => Items = value;
        }

        [XmlIgnore]
        public oktmoNSIInfoType[] OktmoNSIInfoType
        {
            get => Items?.GetType() == typeof(oktmoNSIInfoType[]) ? (oktmoNSIInfoType[])Items : null;
            set => Items = value;
        }


        /// <summary>
        /// Код справочника
        /// </summary>
        [XmlAttribute("directoryCode")]
        public string DirectoryCode 
        {
            get => _DirectoryCode;
            set => _DirectoryCode = Validator.String(value: ref value, name: nameof(DirectoryCode), required: true, min: 0, max: 10);
        }

        string _DirectoryCode;


        /// <summary>
        /// Признак вложения
        /// </summary>
        [XmlAttribute("signAttachment")]
        public bool SignAttachment { get; set; }
    }
}