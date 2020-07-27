using System;
using System.Text.RegularExpressions;

namespace GisGmp.Service
{
    public class AccountNum : IConvertToString
    {
        public string Value { get; }

        //TODO добавить проверку
        public AccountNum(string accountNum)
        {
            if (accountNum == null) throw new Exception("Номер счета не может иметь значение null");
            //if (!Regex.IsMatch(accountNum, @"^\w{20}$|^\d{25}$")) throw new Exception(@"УИН не соответствует шаблону ^\w{20}$|^\d{25}$");
            Value = accountNum;
        }

        public static implicit operator AccountNum(string accountNum) => new AccountNum(accountNum);

        public static implicit operator string(AccountNum accountNum) => accountNum.Value;
    }
}