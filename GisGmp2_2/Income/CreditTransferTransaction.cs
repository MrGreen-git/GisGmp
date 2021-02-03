using System;
using System.Xml.Serialization;

namespace GisGmp.Income
{
    /// <summary>
    /// Поле номер 4010: Дополнительная информация, указанная в реестре принятых к исполнению распоряжений.Заполняется только для документа "Платежное поручение на общую сумму с реестром" (ED108)
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/Income/2.2.0")]
    public class CreditTransferTransaction
    {
        /// <summary>
        /// Поле номер 4004: Номер записи в реестре
        /// </summary>
        [XmlAttribute("transactionID")]
        public string TransactionID { get; set; }

        /// <summary>
        /// Поле номер 4005: Уникальный присваиваемый номер операции
        /// </summary>
        [XmlAttribute("operationID")]
        public string OperationID { get; set; }

        /// <summary>
        /// Поле номер 4006: Адрес физического лица - плательщика
        /// </summary>
        [XmlAttribute("payerAddress")]
        public string payerAddress { get; set; }

        /// <summary>
        /// Поле номер 4007: Идентификатор лица, чья обязанность по уплате денежных средств исполняется
        /// </summary>
        [XmlAttribute("beneficiaryIdentifier")]
        public string BeneficiaryIdentifier { get; set; }

        /// <summary>
        /// Поле номер 4008: Лицо, чья обязанность по уплате денежных средств исполняется
        /// </summary>
        [XmlAttribute("beneficiaryName")]
        public string BeneficiaryName { get; set; }

        /// <summary>
        /// Поле номер 4009: Адрес физического лица, чья обязанность по уплате денежных средств исполняется
        /// </summary>
        [XmlAttribute("beneficiaryAddress")]
        public string BeneficiaryAddress { get; set; }
    }
}