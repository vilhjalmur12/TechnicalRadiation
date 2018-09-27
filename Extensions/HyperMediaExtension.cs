using System.Collections.Generic;
using System.Dynamic;

namespace TechnicalRadiation.Extensions
{
    public static class HyperMediaExtension
    {
        public static void addReference<T>(this ExpandoObject item, string key, T value) => item.TryAdd(key, value);
    }
}