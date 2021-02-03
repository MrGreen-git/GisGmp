using System;

namespace GisGmp
{
    public class UIR : IConvertToString
    {
        public string Value { get; }

        //TODO [?]
        public UIR(string uir)
        {
            if (uir is null) throw new Exception("УИП не может иметь значение null");
            //if (!Regex.IsMatch(uip, @"^\w{20}$|^\d{25}$")) throw new Exception(@"УИН не соответствует шаблону ^\w{20}$|^\d{25}$");
            Value = uir;
        }

        public static implicit operator UIR(string uir) => new UIR(uir);

        public static implicit operator string(UIR uir) => uir.Value;
    }
}