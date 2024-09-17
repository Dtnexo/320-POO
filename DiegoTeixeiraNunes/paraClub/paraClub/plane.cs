using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paraClub
{
    internal class plane
    {
        int x;
        int y;
        private string[] view =
        {
            @" _                         ",
            @"| \                        ",
            @"|  \       ______          ",
            @"--- \_____/  |_|_\____  |  ",
            @"  \_______ --------- __>-} ",
            @"        \_____|_____/   |  "
        };
      public plane(string[] body, int coordoneex, int coordoneey)
        {
            view = body;
            x = coordoneex;
            y = coordoneey;
        }
        public void Move()
        {
            x++;
            Thread.Sleep(100);
        }
    }
}

