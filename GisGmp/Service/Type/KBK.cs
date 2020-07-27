using System;
using System.Text.RegularExpressions;

namespace GisGmp.Service
{
    public class KBK : IConvertToString
    {
        public string Value { get; }

        //TODO добавить проверку
        public KBK(string kbk)
        {
            if (kbk == null) throw new Exception("КБК не может иметь значение null");
            //if (!Regex.IsMatch(kbk, @"^\w{20}$|^\d{25}$")) throw new Exception(@"УИН не соответствует шаблону ^\w{20}$|^\d{25}$");
            Value = kbk;
        }

        public static implicit operator KBK(string kbk) => new KBK(kbk);

        public static implicit operator string(KBK kbk) => kbk.Value;
    }
}