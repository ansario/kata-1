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


            var map = new Dictionary<int, bool>();

            for(var i = 0; i < list.Length; i++)
            {

                bool seen;

                if (map.TryGetValue(list[i], out seen))
                {
                    return list[i];
                }

                map[list[i]] = true;
            }

            return -1;
        }
    }
}
