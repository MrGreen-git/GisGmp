using GisGmp.Charge;
using GisGmp.Common;
using GisGmp.Organization;
using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace GisGmp.Package
{
    /// <remarks/>
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Package/2.2.0")]
    public class ImportedChargeType : ChargeType
    {
        /// <summary />
        protected ImportedChargeType() { }

        /// <summary />
        public ImportedChargeType(
            string id,
            SupplierBillIDType supplierBillID,
            DateTime billDate,
            ulong totalAmount,
            string purpose,
            KBKType kbk,
            OKTMOType oktmo,
            Payee payee,
            ChargePayer payer,
            BudgetIndexType budgetIndex
            ) : base(supplierBillID, billDate, totalAmount, purpose, kbk, oktmo, payee, payer, budgetIndex)
            => Id = id;       

        /// <summary />
        //public ImportedChargeType(string id, URNType originatorId)
        //    : this(id) => OriginatorId = originatorId;
        

        /// <summary>
        /// УРН участника косвенного взаимодействия, сформировавшего запрос
        /// </summary>
        [XmlIgnore]
        public URNType OriginatorId { get; set; }

        /// <summary />
        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlAttribute("originatorId")]
        public string WrapperOriginatorId { get => OriginatorId; set => OriginatorId = value; }


        /// <summary>
        /// Идентификатор начисления в пакете
        /// </summary>
        [XmlAttribute(DataType = "ID")]
        public string Id 
        {
            get => _Id;
            set => _Id = Validator.String(value: ref value, name: nameof(Id), required: true, min: 0, max: 50); 
        }

        string _Id;
    }
}