using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfBomb
{
    public static class MathfUtility
    {
        public static int Base60(int target)
        {
            int result = target / 60;
            return result;
        }
    }
}
