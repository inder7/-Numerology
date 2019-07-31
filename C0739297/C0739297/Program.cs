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
            Gematrio run = new Gematrio();
            run.Run();
            Console.ReadKey();
        }
    }

    class Gematrio
    {
        string name;
        public void Run()
        {
            Console.WriteLine("I will tell you future!! Please Enter your name..");
            name = Console.ReadLine();
            Console.WriteLine("!!!!!!Lets get started!!!!!!!");
            this.RunGematrriaCalculation(name);
        }
        public void RunGematrriaCalculation(string name)
        {
            int sum = 0;
            foreach (char i in name)
            {
                sum += this.ReturnGematriaValueOfLetter(i);
            }
            Console.WriteLine("aggregate function " + sum);



            this.SecondSum(sum);


        }
        public int ReturnGematriaValueOfLetter(char i)
        {
            string temp;
            temp = i.ToString().ToUpper();
            Dictionary<String, int> Gematria = new Dictionary<String, int>()
            {
            {"A",1},
            {"B", 2},
            {"C",3},
            {"D",4},
            {"E", 5},
            {"F",6},
            {"G",7},
            {"H",8},
            {"I",9},
            {"J",1},
            {"K", 2},
            {"L",3},
            {"M",4},
            {"N", 5},
            {"O",6},
            {"P",7},
            {"Q", 8},
            {"R",9},
            {"S",1},
            {"T", 2},
            {"U",3},
            {"V",4},
            {"W", 5},
            {"X",6},
            {"Y",7},
            {"Z", 8}

              };
            Console.WriteLine(" key value is  " + temp + " is:");
            Console.WriteLine(Gematria[temp]);
            return Gematria[temp];

        }

        public void SecondSum(int temp2)
        {



            int sum = 0;
            while (temp2 > 0)
            {
                sum = sum + temp2 % 10;
                temp2 = temp2 / 10;
            }
            Console.WriteLine(" Fianl sum  : " + sum);
        }
    }
}