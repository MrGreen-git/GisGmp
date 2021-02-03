using System;
using System.Text.RegularExpressions;

namespace GisGmp
{
    /// <summary>
    /// КБК
    /// </summary>
    public class KBKType : IConvertToString
    {
        /// <summary />
        protected KBKType() { }

        /// <summary />
        public string Value { get; }

        readonly string[] patterns = {  }; // TODO [regex]

        /// <summary />
        public KBKType(string kbk)
        {
            if (kbk is null) throw new Exception($"{nameof(KBKType)} не может иметь значение null");

            foreach (var pattern in patterns)
                if (!Regex.IsMatch(kbk, pattern)) throw new Exception($"{nameof(KBKType)} не соответствует шаблону {pattern}");

            Value = kbk;
        }

        /// <summary/>
        public override string ToString() => Value;

        /// <summary />
        public static implicit operator KBKType(string kbk) => new KBKType(kbk);

        /// <summary />
        public static implicit operator string(KBKType kbk) => kbk?.Value;
    }
}