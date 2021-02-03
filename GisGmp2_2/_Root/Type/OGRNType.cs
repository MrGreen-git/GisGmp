using System;
using System.Text.RegularExpressions;

namespace GisGmp
{
    /// <summary>
    /// ОГРН
    /// </summary>
    public class OGRNType : IConvertToString
    {
        /// <summary/>
        public string Value { get; }

        /// <summary/>
        public OGRNType(string ogrn) //TODO [regex]
        {
            if (ogrn is null) throw new Exception("ОГРН не может иметь значение null");
            if (!Regex.IsMatch(ogrn, @"^\d{13}$")) throw new Exception(@"ОГРН не соответствует шаблону ^\d{13}$");
            Value = ogrn;
        }

        /// <summary/>
        public static implicit operator OGRNType(string ogrn) => new OGRNType(ogrn);

        /// <summary>
        public static implicit operator string(OGRNType ogrn) => ogrn?.Value;
    }
}