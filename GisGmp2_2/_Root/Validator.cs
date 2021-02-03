using System;

namespace GisGmp
{
    static class Validator
    {
        public static string String(ref string value, string name, bool required, int min, int max) 
        {
            if (value is null)
            {
                if (required) throw new Exception($"{name} не может иметь значание null");
            }
            else
            {
                if (value.Length < min || value.Length > max) throw new Exception($"{name} допустимое кол-во символов {min}..{max}, текущее кол-во {value.Length}");
            }

            return value;
        }

        public static T IsNull<T>(T value, string name)
        { 
            return value != null ? value : throw new Exception($"{name} не может иметь значание null");
        }

        public static T[] ArrayObj<T>(T[] value, string name, bool required, int min, int max)
        {
            if (value is null)
            {
                if (required) throw new Exception($"{name} не может иметь значание null");
            }
            else
            {
                if (value.Length < min || value.Length > max) throw new Exception($"{name} допустимое кол-во элементов {min}..{max}, текущее кол-во {value.Length}");
                foreach (var item in value) if (item == null) throw new Exception($"{name} элемент не может иметь значение null");
            }

            return value;
        }
    }
}
