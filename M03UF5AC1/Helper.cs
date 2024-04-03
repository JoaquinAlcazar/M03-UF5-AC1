using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M03UF5AC1
{
    public class Helper
    {
        public static List<Score> generateUniqueRating(List<Score> lista)
        {
            var scores = from s in lista
                         group s by new { s.Player, s.Mission } into g
                         select new Score(
                             g.Key.Player,
                             g.Key.Mission,
                             g.Max(x => x.Scoring));
            return scores.ToList();
        }

        public static List<Score> orderer(List<Score> lista){
            var scores = from s in lista
                         orderby s.Scoring descending
                         select s;
            return scores.ToList();
        }

        public static void printScores(List<Score> lista)
        {
            int rank = 1;
            foreach (Score s in lista)
            {
                Console.WriteLine($"Rank #{rank}\n" +
                    $"Player: {s.Player}\n" +
                    $"Mission: {s.Mission}\n" +
                    $"Score: {s.Scoring}\n");
                rank++;
            }
        }

    }
}
