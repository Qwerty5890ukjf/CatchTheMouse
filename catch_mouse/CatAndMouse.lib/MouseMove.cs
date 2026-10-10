using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatAndMouse.lib
{
    internal class MouseMove
    {

      static private Random _random = new Random();

        static private MouseMove[] _allMoves;
        
        internal int  DeltaRow {  get; }
        internal int DeltaColumn { get; }


        static MouseMove()
        {
            _allMoves = new MouseMove[] {
            new MouseMove(0, -1),   // left 0
            new MouseMove(1, -1),   // diagonal left down 1
            new MouseMove(1, 0),    // down 2
            new MouseMove(1, 1),    // diagonal right down 3
            new MouseMove(0, 1),    // right 4
            new MouseMove(-1, 1),   // diagonal right up 5
            new MouseMove(-1, 0),   // up 6
            new MouseMove(-1, -1)   // diagonal left up 7
          };
            
        }
       
       

        private MouseMove(int deltaRow, int deltaColumn)
        {
            DeltaRow = deltaRow;

            DeltaColumn = deltaColumn;
        }


        
       

       static internal MouseMove GetMove()
        {
            MouseMove rndMove = _allMoves[_random.Next(_allMoves.Length)];

           return rndMove;


        }






    }
}
