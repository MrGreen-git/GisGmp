using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace GisGmp.Refund
{
    /// <summary>
    /// Данные заявки на возврат
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/Refund/2.2.0")]
    public class RefundApplication
    {
        /// <summary/>
        protected RefundApplication() { }

        /// <summary/>
        public RefundApplication(string appNum, DateTime appDate, PaymentIdType paymentIdType, int cashType, ulong amount, string purpose)
        {
            AppNum = appNum;
            AppDate = appDate;
            PaymentId = paymentIdType;
            CashType = cashType;
            Amount = amount;
            Purpose = purpose;
        }

        
        /// <summary>
        /// Поле номер 3: Номер, присвоенный организацией, формирующей Заявку на возврат в ТОФК
        /// </summary>
        [XmlAttribute("appNum")]
        public string AppNum 
        {
            get => _AppNum;
            set => _AppNum = Validator.String(value: ref value, name: nameof(AppNum), required: true, min: 1, max: 15);
        }

        string _AppNum;


        /// <summary>
        /// Поле номер 4: Дата, на которую сформирована Заявка на возврат в ТОФК
        /// </summary>
        [XmlAttribute("appDate", DataType = "date")]
        public DateTime AppDate { get; set; }

        
        /// <summary>
        /// Поле номер 2000: УИП платежа для возврата денежных средств
        /// </summary>
        [XmlIgnore]
        public PaymentIdType PaymentId
        {
            get => _PaymentId;
            set => _PaymentId = Validator.IsNull(value: value, name: nameof(PaymentId));
        }

        PaymentIdType _PaymentId;

        /// <summary/>
        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlAttribute("paymentId")]
        public string WrapperPaymentId { get => PaymentId; set => PaymentId = value; }


        /// <summary>
        /// Поле номер 3004: Вид средств для осуществления возврата
        /// </summary>
        [XmlAttribute("cashType")]
        public int CashType { get; set; } //TODO [enum]


        /// <summary>
        /// Поле номер 7: Сумма возврата в копейках
        /// </summary>
        [XmlAttribute("amount")]
        public ulong Amount { get; set; }
  
     
        /// <summary>
        /// Поле номер 24: Назначение платежа
        /// </summary>
        [XmlAttribute("purpose")]
        public string Purpose //TODO [regex]
        {
            get => _Purpose;
            set => _Purpose = Validator.String(value: ref value, name: nameof(Purpose), required: true, min: 0, max: 210);
        }

        string _Purpose;
    }
}