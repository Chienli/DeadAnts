using System.Linq;

namespace DeadAnts
{
    public class DeadAntsKata
    {
        public int GetDeadAntsCount(string ants)
        {
            var bodies = ants.Replace("ant", "");

            var deadAntsCount = bodies.Trim().Count(x => x == 'a');

            return deadAntsCount;
        }
    }
}