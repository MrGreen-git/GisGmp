using System;
using System.Text.RegularExpressions;

namespace GisGmp
{
    /// <summary>
    /// ОКТМО
    /// </summary>
    public class OKTMOType : IConvertToString
    {
        /// <summary/>
        protected OKTMOType() { }

        /// <summary/>
        public string Value { get; }

        readonly string[] patterns = {  }; // TODO [regex]

        /// <summary/>
        public OKTMOType(string oktmo)
        {
            if (oktmo is null) throw new Exception($"{nameof(OKTMOType)} не может иметь значение null");

            foreach (var pattern in patterns)
                if (!Regex.IsMatch(oktmo, pattern)) throw new Exception($"{nameof(OKTMOType)} не соответствует шаблону {pattern}");

            Value = oktmo;
        }

        /// <summary/>
        public override string ToString() => Value;

        /// <summary/>
        public static implicit operator OKTMOType(string oktmo) => new OKTMOType(oktmo);

        /// <summary>
        public static implicit operator string(OKTMOType oktmo) => oktmo?.Value;
    }
}