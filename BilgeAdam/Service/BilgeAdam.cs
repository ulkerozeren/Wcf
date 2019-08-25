using System;

namespace BilgeAdam.Service
{
    public class BilgeAdam : Data.Interface.IBilgeAdam
    {
        public void MyName(string name)
        {
            Console.WriteLine(name);
            Data.Interface.IBilgeAdam channel = Helper.WcfHelper.Wcf<Data.Interface.IBilgeAdam>.Channel("http://10.11.202.63:145/Service1");

            channel.MyName("ulker");
         
        }

        public void Test1()
        {
            Console.WriteLine("Test1 ulker");
        }
    }
}
