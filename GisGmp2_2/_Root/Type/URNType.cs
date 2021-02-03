using System;
using System.Text.RegularExpressions;

namespace GisGmp
{
    /// <summary>
    /// УРН
    /// </summary>
    public class URNType : IConvertToString
    {
        /// <summary/>
        protected URNType() { }

        /// <summary/>
        public string Value { get; }

        readonly string[] patterns = {  }; //TODO [regex] 

        /// <summary/>
        public URNType(string urn)
        {
            if (urn is null) throw new Exception($"{nameof(URNType)} не может иметь значение null");

            foreach (var pattern in patterns)
                if (!Regex.IsMatch(urn, pattern)) throw new Exception($"{nameof(URNType)} не соответствует шаблону {pattern}");

            Value = urn;
        }

        /// <summary/>
        public override string ToString() => Value;

        /// <summary/>
        public static implicit operator URNType(string urn) => new URNType(urn);

        /// <summary>
        public static implicit operator string(URNType urn) => urn?.Value;
    }
}