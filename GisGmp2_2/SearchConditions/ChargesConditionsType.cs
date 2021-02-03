using GisGmp.Common;
using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace GisGmp.SearchConditions
{
    /// <remarks/>
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/SearchConditions/2.2.0")]
    public class ChargesConditionsType
    {
        /// <summary/>
        protected ChargesConditionsType() { }

        /// <summary/>
        public ChargesConditionsType(SupplierBillIDType[] supplierBillID) => SupplierBillID = supplierBillID;

        /// <summary/>
        public ChargesConditionsType(SupplierBillIDType[] supplierBillID, TimeIntervalType timeInterval = null)
            : this(supplierBillID) => TimeInterval = timeInterval;
       

        /// <summary>
        /// УИН
        /// </summary>
        [XmlIgnore]
        public SupplierBillIDType[] SupplierBillID
        {
            get => _SupplierBillID;
            set => _SupplierBillID = Validator.ArrayObj(value: value, name: nameof(SupplierBillID), required: true, min: 1, max: 100);
        }

        SupplierBillIDType[] _SupplierBillID;

        /// <summary/>
        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlElement("SupplierBillID")]
        public string[] WrapperSupplierBillID
        {
            get => SupplierBillID?.ToArrayString();
            set => SupplierBillID = value?.ToArray<SupplierBillIDType>(s => s);
        }

        /// <summary>
        /// Временной интервал, за который запрашивается информация из ГИС ГМП
        /// </summary>
        [XmlElement(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.2.0")]
        public TimeIntervalType TimeInterval { get; set; }
    }
}