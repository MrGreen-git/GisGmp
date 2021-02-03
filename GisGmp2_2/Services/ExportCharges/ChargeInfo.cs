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
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-charges/2.2.0")]
    public class ChargeInfo : ChargeType
    {
        /// <summary />
        protected ChargeInfo() { }

        /// <summary />
        public ChargeInfo(
            long amountToPay, 
            ChangeStatusInfo changeStatusInfo,
            SupplierBillIDType supplierBillID,
            DateTime billDate,
            ulong totalAmount,
            string purpose,
            KBKType kbk,
            OKTMOType oktmo,
            Payee payee,
            ChargePayer payer,
            BudgetIndexType budgetIndex)
            : base (supplierBillID, billDate, totalAmount, purpose, kbk, oktmo, payee, payer, budgetIndex)
        {
            AmountToPay = amountToPay;
            ChangeStatusInfo = changeStatusInfo;
        }
      
        /// <summary>
        /// Сведения о статусе начисления и основаниях его изменения
        /// </summary>
        [XmlElement(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.2.0")]
        public ChangeStatusInfo ChangeStatusInfo { get; set; }

        /// <summary>
        /// Остаток суммы подлежащей оплате, указанной в начислении (в копейках). При переплате начисления принимает отрицательное значение; при полной оплате — значение «0»
        /// </summary>
        [XmlAttribute("amountToPay")]
        public long AmountToPay { get; set; }

        [XmlIgnore]
        AcknowledgmentStatusType _AcknowledgmentStatus;

        /// <summary>
        /// Статус присвоенный начислению при создании квитанции
        /// </summary>
        [XmlAttribute("acknowledgmentStatus")]
        public AcknowledgmentStatusType AcknowledgmentStatus 
        {
            get => _AcknowledgmentStatus;
            set
            {
                _AcknowledgmentStatus = value;
                AcknowledgmentStatusSpecified = value != default;
            }
        }

        /// <remarks/>
        [XmlIgnore]
        public bool AcknowledgmentStatusSpecified { get; set; }
    }
}