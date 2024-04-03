//AC1. Tipus avançats de dades en C#
namespace M03UF5AC1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Score> list = new List<Score>();
            string name = "";
            string mission = "";
            int score = 0;

            for (int i=0; i<10;)
            {
                Console.WriteLine("Enter player name: ");
                name = Console.ReadLine();
                Console.WriteLine("Enter mission name: ");
                mission = Console.ReadLine();
                Console.WriteLine("Enter score: ");
                score = Convert.ToInt32(Console.ReadLine());

                list.Add(Score.createScore(name, mission, score));
                i++;
                
               
            }

            List<Score> orderedList = Helper.generateUniqueRating(list);
            orderedList = Helper.orderer(orderedList);
            Helper.printScores(orderedList);
        }
    }
}