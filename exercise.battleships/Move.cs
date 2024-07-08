using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.battleships
{
    public class Move
    {
        private Guid _id;
        public Move(Guid playerid, int X, int Y)
        {
            _id = playerid;

        }
    }
}
