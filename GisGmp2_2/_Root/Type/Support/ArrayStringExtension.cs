using System;

namespace GisGmp
{
    public static class ArrayStringExtension
    {
        public static T[] ToArray<T>(this string[] items, Func<string, T> algoritm) where T : IConvertToString
        {
            if (items is null) return null;

            T[] array = new T[items.Length];

            foreach (var (item, index) in items.WithIndex())
                array[index] = algoritm(item);

            return array;
        }
    }
}