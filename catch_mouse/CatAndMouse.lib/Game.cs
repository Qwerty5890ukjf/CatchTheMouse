using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatAndMouse.lib
{
    public class Game
    {

        public Player Mouse { get; }

      

        public Player Cat { get; }

        public bool GameOver 
        {
            get
            {
                 if((Cat.Row == Mouse.Row) && (Cat.Column == Mouse.Column)  )
                {
                    return true;
                }
                 return false;
            }
        }

        private PlayingArea _playingArea;
        public Game(int rows,  int columns)
        {

            _playingArea = new PlayingArea(rows, columns);

            Cat = new Cat(_playingArea);
            Mouse = new Mouse(_playingArea);


        }

        public void Play(Position catPosition)
        {
            Mouse.Move();

            Cat.Move(catPosition);

            if (GameOver == true)
            {
                return;
            }


        }



    }
}
