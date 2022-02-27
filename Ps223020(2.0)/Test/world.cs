using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ps223020_2._0_.Test
{
    public class world
    {
        public world(float x, float y, float z)
        {
            if (z < 1000000.0F) sizeX = z;
            if (x < 1000000.0F) sizeX = x;
            else throw new ArgumentOutOfRangeException();
            if (y < 1000000.0F) sizeY = y;
            //gcarrot = new GCarrot(hpRecovery: 50);
            for (int i = 0;i < 500; i++) 
            {
                gcarrot.Add(new GCarrot(hpRecovery: 50));
            }

            user = new User(hp: 20, hungry: 20, transform: new Transform(x: 0, y: 0, z: 80);
        }
        //public void OneCarrot() 
        //{
        //    OneCarrot = new GCarrot;
        //}
        private float sizeX;
        private float sizeY;
        //private GCarrot gcarrot;
        //private GCarrot gcarrot2;
        private List<GCarrot> gcarrot;
        private int gcarrotCount;
        private User user;
        //        private int durationDayandNight = 30;
        //        public int getDurationDayandNight() 
        //        {
        //            return durationDayandNight;
        //        }

        //        public void SetDurationDayandNight(int newValue)
        //        {

        //            durationDayandNight = newValue;
        //        }
    }
}
