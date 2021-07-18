using System;
using System.Collections.Generic;
using System.Text;

namespace MyDesignPatterns.Singleton
{
    public class UpTimeClock
    {
        static UpTimeClock instance;

        private static object locker = new object();

        public UpTimeClock()
        {
            DateTime saveNow = DateTime.Now;
            Console.WriteLine("Service is working since:");
            Console.WriteLine(saveNow);

        }

        public static UpTimeClock GetUptimeClock()
        {

            if (instance == null)
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new UpTimeClock();
                    }
                }
            }


            return instance;
        }

    }
}
