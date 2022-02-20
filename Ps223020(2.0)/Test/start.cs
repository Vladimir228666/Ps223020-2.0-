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
            myworld = new world(x: 50.0F, y: 100.0F);
        }
        
        public static void StartDay()
        {
            bool isDay = false;
            int duration = myworld.getDurationDayandNight();
            checkEndDay();
        }
    }
}
