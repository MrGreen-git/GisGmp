﻿using System;
using System.Xml.Serialization;

namespace GisGmp.SearchConditions
{
    /// <remarks/>
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/SearchConditions/2.2.0", IncludeInSchema = false)]
    public enum ItemChoiceType
    {
        /// <remarks/>
        ChargesConditions,

        /// <remarks/>
        IncomesConditions,

        /// <remarks/>
        PayersConditions,

        /// <remarks/>
        PaymentsConditions,

        /// <remarks/>
        RefundsConditions,

        /// <remarks/>
        TimeConditions,
    }
}