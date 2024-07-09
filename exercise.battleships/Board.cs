using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.battleships
{
    public class Board
    {        
        public Board()
        {
            
        }
        public Guid Id { get; set; } = new Guid();
    

        public List<Move> History { get; set; } = new List<Move>();



    }
}
