﻿using System;
using System.Threading;

namespace BilgeAdam.Service
{
    public class BilgeAdam : Data.Interface.IBilgeAdam
    {
        public static DateTime SendDate = new DateTime();
        public void MyName(string name, DateTime myDate)
        {
            var diff = (myDate - SendDate).TotalMilliseconds;
            Console.WriteLine(diff+ " "+myDate.ToShortDateString()+" - "+ name);

            new Thread(new ThreadStart(SendMessage)).Start();
     
        }

        public void Test1()
        {
            Console.WriteLine("Test1 ulker");
        }

        public void SendMessage()
        {
            SendDate = DateTime.UtcNow;
            Program.channel.MyName("ülker", SendDate);
        }


  
    }


}
