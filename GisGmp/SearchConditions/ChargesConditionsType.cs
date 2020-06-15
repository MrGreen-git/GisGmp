﻿using GisGmp.Common;
using System;
using System.Xml.Serialization;

namespace GisGmp.SearchConditions
{
    /// <summary>
    /// Условия для получения информации по УИН с указанием дополнительных параметров (при необходимости)
    /// </summary>
    [Serializable()]
    [XmlRoot("ChargesConditionsType", Namespace = "http://roskazna.ru/gisgmp/xsd/SearchConditions/2.1.1")]
    public class ChargesConditionsType
    {
        protected ChargesConditionsType() { }

        public ChargesConditionsType(string[] supplierBillID) => SupplierBillID = supplierBillID;
        /// <summary>
        /// УИН
        /// </summary>
        [XmlElement("SupplierBillID", Order = 1)]
        public string[] SupplierBillID { get; set; }

        /// <summary>
        /// Временной интервал, за который запрашивается информация из ГИС ГМП
        /// </summary>
        [XmlElement("TimeInterval", Order = 2, Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.1.1")]
        public TimeIntervalType TimeInterval { get; set; }
    }
}
