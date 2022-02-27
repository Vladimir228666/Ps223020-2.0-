using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ps223020_2._0_.Test
{
    public class User
    {
        private int hp;
        private int hungry;
        private Transform transform;
        public User(int hp, int hungry, Transform transform)
        {
            this.hp = hp;
            this.hungry = hungry;
            this.transform = transform;
        }
    }
}
