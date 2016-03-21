using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static SweepstakesManagement.SystemString;
using static SweepstakesManagement.SystemArrayString;

namespace SweepstakesManagement
{
    class Program
    {
        static void Main(string[] args)
        {

            //SystemString systemString = new SystemString();
            //EmptyString = "This is a string";
            //systemString.ToString();
            //Console.WriteLine(EmptyString);
            //systemString.Insert(0, "YO! ");
            //Console.WriteLine(EmptyString);
            //systemString.Remove(0, 4);
            //Console.WriteLine(EmptyString);
            //int length = systemString.Lenght();
            //Console.WriteLine(length);

            //SystemArrayString systemArrayString = new SystemArrayString();
            //CharArray = new char[6] {'S', 't', 'r', 'i', 'n', 'g'};
            //foreach (char s in CharArray)
            //{
            //    Console.WriteLine(s);
            //}
            //string str = systemArrayString.ToString();
            //Console.WriteLine(str);

            //systemArrayString.Insert(5, "zzzz");
            //foreach (char s in CharArray)
            //{
            //    Console.Write(s);
            //}
            //Console.WriteLine();
            //systemArrayString.Remove2(2,1);
            //foreach (char s in CharArray)
            //{
            //    Console.Write(s);
            //}
            //Console.WriteLine();

            //SystemLinkedListString linkedList = new SystemLinkedListString();
            //linkedList.CreateLinkedList();
            //linkedList.DisplayList();
            //linkedList.Insert(3,"z");
            //linkedList.DisplayList();
            //linkedList.RemoveNodeByValue('z');
            //linkedList.DisplayList();
            //linkedList.Remove(1,3);
            //linkedList.DisplayList();

            Sweepstakes sweepstakes = new Sweepstakes("name");
            sweepstakes.DisplaySweepStakesMenu();



            //Console.WriteLine("Y or N");
            //string userinput = Console.ReadLine();

            //Sweepstakes sweepstakes = new Sweepstakes();
            //while (userinput == "y")
            //{
            //    UserInput contestantinfo = new UserInput();
            //    string name = contestantinfo.CollectUserName();
            //    string phonenumber = contestantinfo.CollectUserPhoneNumber();

            //    Contestant contestant = new Contestant(name, phonenumber);
            //    sweepstakes.RegisterContestant(contestant);
            //    Console.WriteLine("another?");
            //    userinput = Console.ReadLine();
            //    Console.Clear();
            //}


            //Contestant winner = sweepstakes.PickWinner();
            //Console.WriteLine(winner);






            Console.ReadKey();
        }
    }
}
