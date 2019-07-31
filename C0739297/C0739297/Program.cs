using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0739297
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
        public static Dictionary<string, int> LetterValue = new Dictionary<string, int>()
{
{"A",1},
{"B",2 },
{"C",3},
{"D",4},
{"E",5},
{"F",6},
{"G",7},
{"H",8 },
{"I",9},
{"J",1},
{"K",2 },
{"L",3},
{"M",4},
{"N",5},
{"O",6},
{"P",7 },
{"Q",8},
{"R",9},
{"S",1 },
{"T",2},
{"U",3 },
{"V",4},
{"W",5},
{"X",6},
{"Y",7},
{"Z",8}


};
        String name;
        public void Run()
        {

            Console.WriteLine(" I will tell you your future! -- What is your Name?");
            name = Console.ReadLine();
            Console.WriteLine("{0} --- That's the best your parent can come up with??", name);
            Console.WriteLine("never mind, let's get started ..");

            Console.WriteLine(this.RunGematriaCalculation(name));

        }

        public int RunGematriaCalculation(string thename)
        {
            int GematriaValue = 0;
            int total = 0;


            foreach (char letter in thename)
            {
                GematriaValue = this.ReturnGematriaValueofLetter(letter.ToString());
                total += GematriaValue;

            }
            return total;

        }
        public int ReturnGematriaValueofLetter(string letter)
        {
            return LetterValue[letter.ToUpper()];
        }
    }
    class playground
    {
        public void Run()
        {
            Dictionary<string, int> LetterValue = new Dictionary<string, int>()

{ {"A",1 },
{"B",2 },
{"C",3},
{"D",4},
{"E",5},
{"F",6},
{"G",7},
{"H",8 },
{"I",9},
{"J",1},
{"K",2 },
{"L",3},
{"M",4},
{"N",5},
{"O",6},
{"P",7 },
{"Q",8},
{"R",9},
{"S",1 },
{"T",2},
{"U",3 },
{"V",4},
{"W",5},
{"X",6},
{"Y",7},
{"Z",8}

};
            int temp = LetterValue["B"];
            Console.WriteLine(temp);
        }

    }


}