using System;
using System.Text.RegularExpressions;

namespace GisGmp
{
    /// <summary>
    /// Номер счета
    /// </summary>
    public class AccountNumType : IConvertToString
    {
        /// <summary/>
        public string Value { get; }

        /// <summary/>
        public AccountNumType(string accountNum)
        {
            if (accountNum is null) throw new Exception("Номер счета не может иметь значение null");
            if (!Regex.IsMatch(accountNum, @"^\d{20}$")) throw new Exception(@"Номер счета не соответствует шаблону ^\d{20}$");
            Value = accountNum;
        }

        /// <summary/>
        public static implicit operator AccountNumType(string accountNum) => new AccountNumType(accountNum);

        /// <summary/>
        public static implicit operator string(AccountNumType accountNum) => accountNum?.Value;
    }
}