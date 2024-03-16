using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ruleta
{
    internal class Ruleta
    {
        private Random rnd;

        public Ruleta()
        {
            rnd = new Random();
        }

        public int GirarRuleta()
        {
            return rnd.Next(0, 37);
        }
    }
}
