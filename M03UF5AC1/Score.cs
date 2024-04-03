using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace M03UF5AC1
{
    public class Score
    {
        protected string player;
        protected string mission;
        protected int scoring;

        public Score(string player, string mission, int scoring)
        {
            this.player = player;
            this.mission = mission;
            this.scoring = scoring;
        }

        public string Player
        {
            get { return player; }
            set { player = value; }
        }
        public string Mission
        {
            get { return mission; }
            set { mission = value; }
        }
        public int Scoring
        {
            get { return scoring; }
            set { scoring = value; }
        }

        public static Score createScore(string player, string mission, int scoring)
        {
            bool isCorrect = false;
            Regex reg1 = new Regex(@"[a-zA-Z]");
            List<String>greekAlph = new List<string> { "Alfa", "Beta", "Gamma", "Delta", "Epsilon", "Zeta", "Eta", "Theta", "Iota", "Kappa", "Lambda", "Mi", "Ni", "Ksi", "Omicron", "Pi", "Ro", "Sigma", "Tau", "Ipsilon", "Fi", "Khi", "Psi", "Omega" };
            foreach(string name in greekAlph)
            {
                if (mission.StartsWith(name)||mission.StartsWith(name.ToLower()))
                {
                    isCorrect = true;
                }
            }
            Regex reg2 = new Regex(@"[0-9]${3}");
            if (!reg2.IsMatch(mission)) isCorrect = false;

            if (!reg1.IsMatch(player)) isCorrect = false;           
            if (scoring > 500 || scoring < 0) isCorrect = false;

            if (isCorrect)
            {
                Console.WriteLine("Creat :)");
                return new Score(player, mission, scoring);

            }
            else
            {
                Console.WriteLine("No creat :(, torna a introduirlo");
            }           
            return null;
        }

        public int CompareTo(Score? other)
        {
            if (other == null) return 1;
            return this.Scoring.CompareTo(other.Scoring);
        }
    }
}
