using System;
using System.Xml.Serialization;

namespace GisGmp.Refund
{
    /// <summary>
    /// Данные заявки на возврат
    /// </summary>
    [Serializable()]
    [XmlRoot("RefundApplicationType", Namespace = "http://roskazna.ru/gisgmp/xsd/Refund/2.1.1")]
    public class RefundApplicationType
    {
        /// <summary>
        /// Предназначен только для сериализации/десериализации
        /// </summary>
        protected RefundApplicationType() { }

        public RefundApplicationType(
            string AppNum,
            DateTime AppDate,
            string PaymentId,
            int CashType,
            ulong Amount,
            string Purpose
            )
        {
            this.AppNum = AppNum;
            this.AppDate = AppDate;
            this.PaymentId = PaymentId;
            this.CashType = CashType;
            this.Amount = Amount;
            this.Purpose = Purpose;
        }

        /// <summary>
        /// Поле номер 3: Номер, присвоенный организацией, формирующей Заявку на возврат в ТОФК [required]
        /// </summary>
        [XmlAttribute("appNum")]
        public string AppNum { get; set; }

        /// <summary>
        /// Поле номер 4: Дата, на которую сформирована Заявка на возврат в ТОФК [required]
        /// </summary>
        [XmlAttribute(AttributeName = "appDate", DataType = "date")]
        public DateTime AppDate { get; set; }

        /// <summary>
        /// Поле номер 2000: УИП платежа для возврата денежных средств [required]
        /// </summary>
        [XmlAttribute("paymentId")]
        public string PaymentId { get; set; }

        /// <summary>
        /// Поле номер 3004: Вид средств для осуществления возврата.
        /// </summary>
        [XmlAttribute("CashType")]
        public int CashType { get; set; }

        /// <summary>
        /// Поле номер 7: Сумма возврата в копейках
        /// </summary>
        [XmlAttribute("Amount")]
        public ulong Amount { get; set; }

        /// <summary>
        /// Поле номер 24: Назначение платежа [required]
        /// </summary>
        [XmlAttribute("purpose")]
        public string Purpose { get; set; }
    }
}