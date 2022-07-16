using System.Collections.Generic;
using System.Linq;

namespace RedPanda.Utils
{
    public static class DictionaryUtils
    {
        public static Dictionary<TKey, TValue> SortByKeyAscending<TKey, TValue>(this Dictionary<TKey, TValue> dictionary) => dictionary.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
        public static Dictionary<TKey, TValue> SortByKeyDescending<TKey, TValue>(this Dictionary<TKey, TValue> dictionary) => dictionary.OrderByDescending(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
        public static Dictionary<TKey, TValue> SortByValueAscending<TKey, TValue>(this Dictionary<TKey, TValue> dictionary) => dictionary.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
        public static Dictionary<TKey, TValue> SortByValueDescending<TKey, TValue>(this Dictionary<TKey, TValue> dictionary) => dictionary.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
    }
}