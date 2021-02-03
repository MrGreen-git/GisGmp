using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace GisGmp.Package
{
    /// <remarks/>
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Package/2.2.0")]
    public class PackageType
    {
        /// <summary>
        /// Направляемые изменения в ранее загруженные извещения; Направляемое новое начисление; Направляемое новое зачисление; Направляемое новое зачисление; Направляемый новый возврат
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlElement("ImportedChange", typeof(ImportedChangeType))]
        [XmlElement("ImportedCharge", typeof(ImportedChargeType))]
        [XmlElement("ImportedIncome", typeof(ImportedIncomeType))]
        [XmlElement("ImportedPayment", typeof(ImportedPaymentType))]
        [XmlElement("ImportedRefund", typeof(ImportedRefundType))]
        public object[] Items 
        {
            get => _Items;
            set
            {
                switch (value)
                {
                    case ImportedChangeType[] _: break;
                    case ImportedChargeType[] _: break;
                    case ImportedIncomeType[] _: break;
                    case ImportedPaymentType[] _: break;
                    case ImportedRefundType[] _: break;
                    default: throw new Exception("Недопустимый тип");
                }

                _Items = Validator.ArrayObj(value: value, name: nameof(Items), required: true, min: 1, max: 100);
            }
        }

        object[] _Items;
    }
}