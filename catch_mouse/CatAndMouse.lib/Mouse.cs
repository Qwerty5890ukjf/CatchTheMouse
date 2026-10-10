using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatAndMouse.lib
{
   public class Mouse : Player
    {

        public override bool IsVisible
        {
            get
            {
                int visible_in_moves = 2;
                int i = base.GetNumberOfMoves();
                // i==0 sollte machen, dass beim start mouse angezeigt wird, tut es aber nicht
                if ( i == 0 || i % visible_in_moves == 0 )
                {
                    return true;
                }
                return false;
            }
                
        }

        public Mouse(PlayingArea playingArea) : base(playingArea) 
        {

        }

        public override void Move()
        {

            Position position;

            do
            {
                MouseMove move = MouseMove.GetMove();

                position = new Position(Row + move.DeltaRow, Column + move.DeltaColumn);

            } while (_playingArea.IsValid(position) == false);

            Move(position);


            
        
        }




    }
}
