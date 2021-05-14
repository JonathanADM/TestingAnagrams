using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagrams
{
    public class ProbarAnagrams
    {
        public bool AreAnagrams(string s1, string s2)
        {
            if (s1 is null || s2 is null)
            {
                throw new ArgumentNullException();
            }

            string p1 = new string(s1.OrderBy(x => x).ToArray());
            string p2 = new string(s2.OrderBy(x => x).ToArray());

            if (p1 == p2)
            {
                return true;
            }
            return false;
        }

    }
}
