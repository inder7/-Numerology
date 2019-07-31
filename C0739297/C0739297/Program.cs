using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c0739297
{
    class Program
    {
        static void Main(string[] args)
        {
            new Gematria().Run();
        }
    }

    class Gematria
    {
        Dictionary<string, int> LetterValue = new Dictionary<string, int>()
            {
                {"A",1 },
                {"B",1 },
                {"C",1 },


            };
        string name;
        public void Run()
        {
            Console.WriteLine("I will tell your future! -- What is your name?");
            name = Console.ReadLine();
            Console.WriteLine("{0} -- that's the best your parents could come up with??", name);
            Console.WriteLine("Never mind, let's get started....");

            this.RunGematriaCalculation(name);

        }

        public void RunGematriaCalculation(string thename)
        {
            foreach (char letter in thename)
            {
                Console.WriteLine(letter);
                this.RunGematriaVlaueofLetter(letter);
            }
        }

        public void RunGematriaVlaueofLetter(char letter)
        {
            int temp = LetterValue["B"];
            Console.WriteLine(temp);
        }

    }

    class PlayGround
    {
        public void Run()
        {
            Dictionary<string, int> LetterValue = new Dictionary<string, int>()
            {
                {"A",1 },
                {"B",2 },
                {"C",3 },
                {"D",4 },
                {"E",5 },
                {"F",6 },
                {"G",7 },
                {"H",8 },
                {"I",9 },
                {"J",10 },
                {"K",11 },
                {"L",12 },
                {"M",13 },
                {"N",14 },
                {"O",15 },
                {"P",16 },
                {"Q",17 },
                {"R",18 },
                {"S",19 },
                {"T",20 },
                {"U",21 },
                {"V",22 },
                {"W",23 },
                {"X",24 },
                {"Y",25 },
                {"Z",26 },


            };
            int temp = LetterValue["B"];
            Console.WriteLine(temp);
        }
    }

}
