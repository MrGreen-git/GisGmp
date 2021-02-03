using System;
using System.Text.RegularExpressions;

namespace GisGmp
{
    /// <summary>
    /// 
    /// </summary>
    public class RefundIdType : IConvertToString
    {
        /// <summary/>
        protected RefundIdType() { }

        /// <summary/>
        public string Value { get; }

        readonly string[] patterns = { }; // TODO [regex]

        /// <summary/>
        public RefundIdType(string uir)
        {
            if (uir is null) throw new Exception($"{nameof(RefundIdType)} не может иметь значение null");

            foreach (var pattern in patterns)
                if (!Regex.IsMatch(uir, pattern)) throw new Exception($"{nameof(RefundIdType)} не соответствует шаблону {pattern}");

            Value = uir;
        }

        /// <summary/>
        public override string ToString() => Value;

        /// <summary/>
        public static implicit operator RefundIdType(string uir) => new RefundIdType(uir);

        /// <summary>
        public static implicit operator string(RefundIdType uir) => uir?.Value;
    }
}