using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JankenGame
{
    internal class EnumHub
    {
        public enum Janken
        {
            Rock = 0,
            Scissors = 1,
            Paper = 2,
        }

        public enum JankenResult
        {
            Even = 0,
            Winning = 1,
            Losing = 2,
        }
    }
}
