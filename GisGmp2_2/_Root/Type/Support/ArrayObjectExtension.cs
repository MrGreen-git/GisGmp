namespace GisGmp
{
    public static class ArrayObjectExtension
    {
        public static string[] ToArrayString<T>(this T[] items) where T : IConvertToString
        {
            if (items is null) return null;

            string[] array = new string[items.Length];

            foreach (var (item, index) in items.WithIndex())
                array[index] = item?.Value;

            return array;
        }

        public static T[] Add<T>(this T[] items, T item) => items.Add(new T[] { item });

        public static T[] Add<T>(this T[] items, T[] array)
        {
            T[] newArray = new T[items.Length + array.Length];

            int ind1 = 0, ind2 = 0;
            while (ind1 < items.Length) newArray[ind1] = items[ind1++];
            while (ind2 < array.Length) newArray[ind1++] = array[ind2++];

            return newArray;
        }
    }
}