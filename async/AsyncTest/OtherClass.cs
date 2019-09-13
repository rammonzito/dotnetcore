using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncTest
{
    public class OtherClass
    {
        public async Task<Juice> DoTheJuice()
        {
            Console.WriteLine("Preparing juice..");
            await Task.Run(() => {
                Thread.Sleep(5000);
                //for (int i = 0; i < 5; i++)
                //{

                //}
            }); 
            Console.WriteLine("Outing Juice..");
            return new Juice();
        }
        public Task<Beef> DoTheBeef()
        {
            Console.WriteLine("Preparing beef..");

            Task<Beef> beef = Task<Beef>.Factory.StartNew(() =>
            {
                //Thread.Sleep(5000);
                for (int i = 0; i < 1000000000; i++)
                {
                    throw new Exception();
                }
                return new Beef();
            });


            //await Task.Run(() => {
            //    for (int i = 0; i < 1000000; i++)
            //    {

            //    }
            //}); 

            Console.WriteLine("Outing Beef..");
            return beef;
        }

        //public Task<Juice> MethodJuice() {
        //    return DoTheJuice();
        //}
    }
}
