using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatAndMouse.lib
{
    public class Position
    {

        public int Row { get; internal set; }
        public int Column { get; internal set; }

        public Position(int row, int column)
        {

            Row = row; Column = column;
        }


        public Position() 
        {
        
        
        
        }


    }
}
