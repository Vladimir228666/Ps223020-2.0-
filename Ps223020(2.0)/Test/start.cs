using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ps223020_2._0_.Test
{
    public static class start
    {
        public static world myworld;
        public static void StartApp()
        {
            try
            {
                myworld = new world(x: 5000000.0F, y: 100.0F);
            }
            catch
            {
                Console.WriteLine("Что-то пошло не так");
            }
        }
        
        //public static void StartDay()
        //{
        //    bool isDay = false;
        //    int duration = myworld.getDurationDayandNight();
        //    checkEndDay();
        //}
    }
}
