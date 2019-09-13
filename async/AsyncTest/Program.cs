using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncTest
{
    class Program
    {
        static void Main(string[] args)
        {
            OtherClass f = new OtherClass();
            //Making a Orange Juice
            Task<Juice> juice = f.DoTheJuice();
            Console.WriteLine("Smashing the Oranges yet");
            Task<Beef> beef = f.DoTheBeef();
            Console.WriteLine("The beef is on the fire yet!");
            Task.WaitAll(beef, juice);
            Console.WriteLine("The dinner is done!");
            Console.ReadLine();
        }

        //private async Task<Juice> DoTheJuice()
        //{
        //    Console.WriteLine("Preparing juice..");
        //    await Task.Run(() => Thread.Sleep(4000)); /*Preparing());*/
        //    //Juice juice =
        //    Console.WriteLine("Outing..");
        //    return new Juice();
        //}

        private static Juice Preparing()
        {
            Console.WriteLine("It's the next step...");
            Thread.Sleep(4000);
            Console.WriteLine("Juice OK!");
            return new Juice();
        }
    }
}
