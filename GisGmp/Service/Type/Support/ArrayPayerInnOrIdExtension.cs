using GisGmp.SearchConditions;
using System;

namespace GisGmp.Service
{
    public static class ArrayPayerInnOrIdExtension
    {
        public static ItemsChoiceType[] ToArrayType(this IPayerInnOrId[] items)
        {
            ItemsChoiceType[] array = new ItemsChoiceType[items.Length];

            foreach (var (item, index) in items.WithIndex())
            {
                if (item is PayerInn) array[index] = ItemsChoiceType.PayerInn;
                else if (item is PayerId) array[index] = ItemsChoiceType.PayerIdentifier;
                else throw new Exception("Непредвиденный тип");
            }
            return array;
        }

        public static string[] ToArrayString(this IPayerInnOrId[] items)
        {
            string[] array = new string[items.Length];

            foreach (var (item, index) in items.WithIndex())
            {
                if (item is PayerInn payerInn) array[index] = payerInn;
                else if (item is PayerId payerId) array[index] = payerId;
                else throw new Exception("Непредвиденный тип");
            }
            return array;
        }      
    }
}