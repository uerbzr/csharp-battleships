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
        private DateTime _dateCompleted;
        public Move(Game game, Guid playerid, int X, int Y)
        {
            _id = playerid;


        }
        public int X { get; set; } 
        public int Y { get; set; }

    }
}
