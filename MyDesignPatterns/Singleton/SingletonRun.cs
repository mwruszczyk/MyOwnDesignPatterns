using System;
using System.Collections.Generic;
using System.Text;

namespace MyDesignPatterns.Singleton
{
    class SingletonRun
    {
        public SingletonRun()
        {
            UpTimeClock u1 = UpTimeClock.GetUptimeClock();
            UpTimeClock u2 = UpTimeClock.GetUptimeClock();
            Console.ReadKey();
        }
    }
}
