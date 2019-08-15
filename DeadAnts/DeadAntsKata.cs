using System;
using System.Linq;

namespace DeadAnts
{
    public class DeadAntsKata
    {
        public int GetDeadAntsCount(string ants)
        {
            var bodies = ants.Replace("ant", "");

            var deadAntsCount = Math.Max(bodies.Trim().Count(x => x == 't'), Math.Max(bodies.Trim().Count(x => x == 'a'), bodies.Trim().Count(x => x == 'n')));

            return deadAntsCount;
        }
    }
}