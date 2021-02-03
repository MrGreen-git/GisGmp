using System;
using System.Text.RegularExpressions;

namespace GisGmp
{
    /// <summary>
    /// ИНН юр. лица
    /// </summary>
    public class INNType : IConvertToString
    {
        /// <summary/>
        protected INNType() { }

        /// <summary/>
        public string Value { get; }

        readonly string[] patterns = { @"^\d{10}$" }; //TODO [regex] 

        /// <summary/>
        public INNType(string inn)
        {
            if (inn is null) throw new Exception($"{nameof(INNType)} не может иметь значение null"); 

            foreach(var pattern in patterns)
                if (!Regex.IsMatch(inn, pattern)) throw new Exception($"{nameof(INNType)} не соответствует шаблону {pattern}");
                
            Value = inn;
        }

        /// <summary/>
        public override string ToString() => Value;

        /// <summary/>
        public static implicit operator INNType(string inn) => new INNType(inn);

        /// <summary>
        public static implicit operator string(INNType inn) => inn?.Value;       
    }
}