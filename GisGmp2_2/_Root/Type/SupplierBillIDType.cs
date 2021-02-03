using System;
using System.Text.RegularExpressions;

namespace GisGmp
{
    /// <summary>
    /// УИН
    /// </summary>
    public class SupplierBillIDType : IConvertToString
    {
        /// <summary/>
        protected SupplierBillIDType() { }

        /// <summary/>
        public string Value { get; }

        readonly string[] patterns = { @"^\w{20}$|^\d{25}$" }; 

        /// <summary>
        public SupplierBillIDType(string uin)
        {
            if (uin is null) throw new Exception($"{nameof(SupplierBillIDType)} не может иметь значение null");

            foreach (var pattern in patterns)
                if (!Regex.IsMatch(uin, pattern)) throw new Exception($"{nameof(SupplierBillIDType)} не соответствует шаблону {pattern}");

            Value = uin;
        }

        /// <summary/>
        public override string ToString() => Value;

        /// <summary/>
        public static implicit operator SupplierBillIDType(string uin) => new SupplierBillIDType(uin);

        /// <summary/>
        public static implicit operator string(SupplierBillIDType uin) => uin?.Value;
    }
}