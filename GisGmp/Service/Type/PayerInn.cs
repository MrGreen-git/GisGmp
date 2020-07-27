using System;

namespace GisGmp.Service
{
    public class PayerInn : IConvertToString, IPayerInnOrId
    {
        public string Value { get; }

        //TODO добавить проверку
        public PayerInn(string payerInn)
        {
            if (payerInn == null) throw new Exception("ИНН не может иметь значение null");
            //if (!Regex.IsMatch(payerInn, @"^\w{20}$|^\d{25}$")) throw new Exception(@"УИН не соответствует шаблону ^\w{20}$|^\d{25}$");
            Value = payerInn;
        }

        public static implicit operator PayerInn(string payerInn) => new PayerInn(payerInn);

        public static implicit operator string(PayerInn payerInn) => payerInn.Value;
    }
}