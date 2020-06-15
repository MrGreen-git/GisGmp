using GisGmp.Charge;
using GisGmp.Common;
using GisGmp.Organization;
using System;
using System.Xml.Serialization;

namespace GisGmp.Services.ExportCharges
{
    /// <summary>
    /// Извещение о начислении (начисление)
    /// </summary>
    [Serializable()]
    [XmlRoot("ChargeInfo", Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-charges/2.1.1")]
    public class ChargeInfo : ChargeType
    {
        protected ChargeInfo() { }

        public ChargeInfo(
            long amountToPay,
            ChangeStatusInfo changeStatusInfo,
            string supplierBillID,
            DateTime billDate,
            ulong totalAmount,
            string purpose,
            string kbk,
            string oktmo,
            Payee payee,
            ChargePayer payer,
            BudgetIndexType budgetIndex
            ) : base(supplierBillID, billDate, totalAmount, purpose, kbk, oktmo, payee, payer, budgetIndex)
        {
            AmountToPay = amountToPay;
            ChangeStatusInfo = changeStatusInfo;
        }

        /// <summary>
        /// Остаток суммы подлежащей оплате, указанной в начислении (в копейках). При переплате начисления принимает отрицательное значение; при полной оплате — значение «0».
        /// </summary>
        [XmlAttribute("amountToPay")]
        public long AmountToPay { get; set; }

        /// <summary>
        /// Статус присвоенный начислению при создании квитанции
        /// </summary>
        [XmlAttribute("acknowledgmentStatus")]
        public AcknowledgmentStatusType AcknowledgmentStatus { get; set; }

        /// <summary/>
        [XmlIgnore()]
        public bool AcknowledgmentStatusSpecified { get; set; }

        /// <summary>
        /// Сведения о статусе начисления и основаниях его изменения
        /// </summary>
        [XmlElement("ChangeStatusInfo", Order = 1, Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.1.1")]
        public ChangeStatusInfo ChangeStatusInfo { get; set; }
    }
}