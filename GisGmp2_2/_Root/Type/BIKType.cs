using System;
using System.Text.RegularExpressions;

namespace GisGmp
{
    /// <summary>
    /// БИК
    /// </summary>
    public class BIKType : IConvertToString
    {
        /// <summary/>
        public string Value { get; }

        /// <summary/>
        public BIKType(string bik)
        {
            if (bik is null) throw new Exception("БИК не может иметь значение null");
            if (!Regex.IsMatch(bik, @"^\d{9}$")) throw new Exception(@"БИК не соответствует шаблону ^\d{9}$");
            Value = bik;
        }

        /// <summary/>
        public static implicit operator BIKType(string bik) => new BIKType(bik);

        /// <summary>
        public static implicit operator string(BIKType bik) => bik?.Value;
    }
}