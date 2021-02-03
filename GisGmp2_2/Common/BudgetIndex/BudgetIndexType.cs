using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    /// <summary>
    /// Дополнительные реквизиты платежа, предусмотренные приказом Минфина России от 12 ноября 2013 г. №107н
    /// </summary>
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.2.0")]
    public class BudgetIndexType
    {
        /// <summary />
        protected BudgetIndexType() { }

        /// <summary />
        public BudgetIndexType(Status status, PaytReason paytReason, string taxPeriod, string taxDocNumber, string taxDocDate)
        {
            Status = status;
            PaytReason = paytReason;
            TaxPeriod = taxPeriod;
            TaxDocNumber = taxDocNumber;
            TaxDocDate = taxDocDate;
        }

        /// <summary>
        /// Поле номер 101: Статус плательщика - реквизит 101 Распоряжения
        /// </summary>
        [XmlAttribute("status")]
        public Status Status { get; set; }


        /// <summary>
        /// Поле номер 106: Показатель основания платежа - реквизит 106 Распоряжения
        /// </summary>
        [XmlAttribute("paytReason")]
        public PaytReason PaytReason { get; set; }


        /// <summary>
        /// Поле номер 107: Показатель налогового периода или код таможенного органа, осуществляющего в соответствии с законодательством РФ функции по выработке государственной политики и нормативному регулированию, контролю и надзору в области таможенного дела – реквизит 107 Распоряжения.
        /// </summary>
        [XmlAttribute("taxPeriod")]
        public string TaxPeriod //TODO [?]
        {
            get => _TaxPeriod;
            set => _TaxPeriod = Validator.String(value: ref value, name: nameof(TaxPeriod), required: true, min: 1, max: 10);
        }

        string _TaxPeriod;


        /// <summary>
        /// Поле номер 108: Показатель номера документа - реквизит 108 Распоряжения
        /// </summary>
        [XmlAttribute("taxDocNumber")]
        public string TaxDocNumber 
        {
            get => _TaxDocNumber;
            set => _TaxDocNumber = Validator.String(value: ref value, name: nameof(TaxDocNumber), required: true, min: 1, max: 15);
        }

        string _TaxDocNumber;


        /// <summary>
        /// Поле номер 109: Показатель даты документа - реквизит 109 Распоряжения
        /// </summary>
        [XmlAttribute("taxDocDate")]
        public string TaxDocDate //TODO [?]
        {
            get => _TaxDocDate;
            set => _TaxDocDate = Validator.String(value: ref value, name: nameof(TaxDocDate), required: true, min: 1, max: 10);
        }

        string _TaxDocDate;
    }
}