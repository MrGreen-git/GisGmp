using System;

namespace GisGmp.Service
{
    public static class ArrayObjectExtension
    {
        public static string[] ToArrayString<T>(this T[] items) where T : IConvertToString
        {
            string[] array = new string[items.Length];

            foreach (var (item, index) in items.WithIndex())
                array[index] = item.Value;

            return array;
        }

        public static T[] Add<T>(this T[] items, T item) => items.Add(new T[] { item });

        public static T[] Add<T>(this T[] items, T[] array)
        {
            T[] newArray = new T[items.Length + array.Length];

            int ind1 = 0, ind2 = 0;
            for (; ind1 < items.Length;) newArray[ind1] = items[ind1++];
            for (; ind2 < array.Length;) newArray[ind1++] = array[ind2++];

            return newArray;
        }
    }
}