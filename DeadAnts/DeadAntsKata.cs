using System;
using System.Linq;

namespace DeadAnts
{
    public class DeadAntsKata
    {
        public int GetDeadAntsCount(string ants)
        {
            if (ants == null || ants.Trim() == string.Empty)
            {
                return 0;
            }

            var bodies = ants.Replace("ant", "");

            var deadAntsCount = Math.Max(bodies.Trim().Count(x => x == 't'), Math.Max(bodies.Trim().Count(x => x == 'a'), bodies.Trim().Count(x => x == 'n')));

            return deadAntsCount;
        }
    }
}