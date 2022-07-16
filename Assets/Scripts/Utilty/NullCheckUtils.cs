using UnityEngine;

namespace RedPanda.Utils
{
    public static class NullCheckUtils
    {
        public static bool IsNull(this Object obj) => obj == null;
    }
}