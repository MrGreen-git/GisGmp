using System;

namespace GisGmp
{
    public class UIP : IConvertToString
    {
        public string Value { get; }

        //TODO [?]
        public UIP(string uip)
        {
            if (uip is null) throw new Exception("УИП не может иметь значение null");
            //if (!Regex.IsMatch(uip, @"^\w{20}$|^\d{25}$")) throw new Exception(@"УИН не соответствует шаблону ^\w{20}$|^\d{25}$");
            Value = uip;
        }

        public override string ToString() => Value;

        public static implicit operator UIP(string uip) => new UIP(uip);

        public static implicit operator string(UIP uip) => uip.Value;
    }
}