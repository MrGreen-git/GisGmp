using System;

namespace GisGmp.Service
{
    public class INN : IConvertToString
    {
        public string Value { get; }

        //TODO добавить проверку
        public INN(string inn)
        {
            if (inn == null) throw new Exception("ИНН не может иметь значение null");
            //if (!Regex.IsMatch(inn, @"^\w{20}$|^\d{25}$")) throw new Exception(@"УИН не соответствует шаблону ^\w{20}$|^\d{25}$");
            Value = inn;
        }

        public static implicit operator INN(string inn) => new INN(inn);

        public static implicit operator string(INN inn) => inn.Value;
    }
}