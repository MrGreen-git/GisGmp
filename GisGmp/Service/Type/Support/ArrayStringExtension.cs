using System;

namespace GisGmp.Service
{
    public static class ArrayStringExtension
    {
        public static T[] ToArray<T>(this string[] items, Func<string, T> algoritm) where T : IConvertToString
        {
            T[] array = new T[items.Length];

            foreach (var (item, index) in items.WithIndex())           
                array[index] = algoritm(item);
            
            return array;
        }
    }
}