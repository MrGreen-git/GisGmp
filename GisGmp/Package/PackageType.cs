using System;
using System.Xml.Serialization;

namespace GisGmp.Package
{
    /// <summary>
    /// Базовый тип пакета
    /// </summary>
    [Serializable()]
    [XmlRoot("PackageType", Namespace = "http://roskazna.ru/gisgmp/xsd/Package/2.1.1")]
    public class PackageType
    {
        protected PackageType() { }

        protected PackageType(object[] Items)
        {
            //TODO добавить проверку типа
            this.Items = Items;
        }

        /// <summary>
        /// Типы пакетов
        /// </summary>
        [XmlElement("ImportedChange", typeof(ImportedChangeType), Order = 1)]
        [XmlElement("ImportedCharge", typeof(ImportedChargeType), Order = 1)]
        [XmlElement("ImportedPayment", typeof(ImportedPaymentType), Order = 1)]
        [XmlElement("ImportedRefund", typeof(ImportedRefundType), Order = 1)]
        public object[] Items { get; set; }
    }
}
