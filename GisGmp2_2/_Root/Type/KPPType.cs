using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace GisGmp
{
    /// <summary>
    /// КПП юр. лица
    /// </summary>
    public class KPPType : IConvertToString
    {
        /// <summary/>
        public string Value { get; }

        /// <summary/>
        public KPPType(string kpp) //TODO [regex]
        {
            if (kpp is null) throw new Exception("КПП не может иметь значение null");
            if (!Regex.IsMatch(kpp, @"^\d{9}$")) throw new Exception(@"КПП не соответствует шаблону ^\d{9}$");
            Value = kpp;
        }

        /// <summary/>
        public static implicit operator KPPType(string kpp) => new KPPType(kpp);

        /// <summary>
        public static implicit operator string(KPPType kpp) => kpp?.Value;
    }
}
