using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ps223020_2._0_.Test
{
    public class world
    {
        public world(float x, float y)
        {
            sizeX = x;
            sizeY = y;
        }
        public float sizeX;
        public float sizeY;
        private int durationDayandNight = 30;
        public int getDurationDayandNight() 
        {
            return durationDayandNight;
        }

        public void SetDurationDayandNight(int newValue)
        {

            durationDayandNight = newValue;
        }
    }
}
