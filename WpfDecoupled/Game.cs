using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfDecoupled
{
    class Game
    {
        private int x = 0;
        public void buttonClick()
        {
            x++;
            
        }
        public int getX()
        {

            return x;
        }
    }
}
