using System.Collections.Generic;

namespace RecursionDojo
{
    public static class ListExtensions
    {
        public static int Pop(this List<int> list)
        {
            var first = list[0];
            list.Remove(first);
            return first;
        }
    }
}