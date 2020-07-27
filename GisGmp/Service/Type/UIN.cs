using System;
using System.Text.RegularExpressions;

namespace GisGmp.Service
{
    public class UIN : IConvertToString
    {
        public string Value { get; }

        public UIN(string uin)
        {
            if (uin == null) throw new Exception("УИН не может иметь значение null");
            if (!Regex.IsMatch(uin, @"^\w{20}$|^\d{25}$")) throw new Exception(@"УИН не соответствует шаблону ^\w{20}$|^\d{25}$");
            Value = uin;
        }

        public static implicit operator UIN(string uin) => new UIN(uin);

        public static implicit operator string(UIN uin) => uin.Value;
    }
}