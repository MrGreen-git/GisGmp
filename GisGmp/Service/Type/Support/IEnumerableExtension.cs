﻿using System.Collections.Generic;
using System.Linq;

namespace GisGmp.Service
{
    public static class IEnumerableExtension
    {
        public static IEnumerable<(T item, int index)> WithIndex<T>(this IEnumerable<T> source)
        {
            return source.Select((item, index) => (item, index));
        }
    }
}