using System.Collections.Generic;
using System.Linq;

namespace Kata1
{
    public class Solution
    {
        public int FindFirstDuplicate(int[] list)
        {
            if (list == null || !list.Any())
            {
                return -1;
            }

            var dict = new Dictionary<int, bool>();

            for(var i = 0; i < list.Length; i++)
            {

                if (dict.TryGetValue(list[i], out bool seen))
                {
                    return list[i];
                }

                dict[list[i]] = true;
            }

            return -1;
        }
    }
}
