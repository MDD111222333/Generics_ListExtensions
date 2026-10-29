using System.Collections.Generic;

namespace Generics_ListExtensions
{
    public static class ListExtensions
    {
        public static void Swap<T>(this List<T> list, int i, int j)
        {
            T temp = list[i];
            list[i] = list[j];
            list[j] = temp;
        }

        public static bool IsEmpty<T>(this List<T> list)
        {
            return list.Count == 0;
        }
    }
}