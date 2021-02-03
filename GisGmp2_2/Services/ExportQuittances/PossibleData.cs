using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace GisGmp.Services.ExportQuittances
{
    /// <summary>
    /// Информация о сопоставлении начислений с платежами. Предоставляется только для запроса kind=ALLPOSSIBLE
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-quittances/2.2.0")]
    public class PossibleData
    {
        /// <summary />
        protected PossibleData() { }

        /// <summary />
        public PossibleData(SupplierBillIDType supplierBillID, ComparisonResult[] comparisonResult)
        {
            SupplierBillID = supplierBillID;
            ComparisonResult = comparisonResult;
        }

        /// <summary>
        /// Результат сопоставления начисления с платежом
        /// </summary>
        [XmlElement("ComparisonResult")]
        public ComparisonResult[] ComparisonResult 
        {
            get => _ComparisonResult;
            set => _ComparisonResult = Validator.ArrayObj(value: value, name: nameof(ComparisonResult), required: true, min: 1, max: 100);
        }

        ComparisonResult[] _ComparisonResult;


        /// <summary>
        /// УИН, с которым сопоставлены платежи
        /// </summary>
        [XmlIgnore]
        public SupplierBillIDType SupplierBillID { get; set; }

        /// <summary />
        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlAttribute("supplierBillID")]
        public string WrapperSupplierBillID { get => SupplierBillID; set => SupplierBillID = value; }


        /// <summary>
        /// Сумма, указанная в начислении
        /// </summary>
        [XmlIgnore]
        public ulong? TotalAmount { get; set; }

        /// <summary />
        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlAttribute("totalAmount")]
        public ulong WrapperTotalAmount { get => TotalAmount.Value; set => TotalAmount = value; }

        /// <summary />
        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlIgnore]
        public bool WrapperTotalAmountSpecified { get => TotalAmount.HasValue; }
    }
}