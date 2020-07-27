using System;

namespace GisGmp.Service
{
    public class PayerId : IConvertToString, IPayerInnOrId
    {
        public string Value { get; }

        //TODO добавить проверку
        public PayerId(string payerId)
        {
            if (payerId == null) throw new Exception("Id не может иметь значение null");
            //if (!Regex.IsMatch(payerId, @"^\w{20}$|^\d{25}$")) throw new Exception(@"УИН не соответствует шаблону ^\w{20}$|^\d{25}$");
            Value = payerId;
        }

        public static implicit operator PayerId(string payerId) => new PayerId(payerId);

        public static implicit operator string(PayerId payerId) => payerId.Value;
    }
}