using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CatAndMouse.lib
{
    public abstract class Player
    {
        private int _moveCounter;
        private static Random _random = new Random(); 
        
       private Position Position { get; }
        protected PlayingArea _playingArea {  get;  }
        public int Row 
        {
            get
            {
                return Position.Row;
            }
        }
       public int Column 
        { 
            get
            {
                return Position.Column;
            }
        }
        virtual public bool IsVisible { get; } = true;



        protected Player(PlayingArea playingArea)
        { 
            _playingArea = playingArea;
            Position = new Position(
            _random.Next(playingArea.Rows),
            _random.Next(playingArea.Columns));
        }

        protected Player()
        {
        }

        public void Move(Position position)
        {

           IncreaseMoveCounter();
         
            Position.Row = position.Row;
            Position.Column = position.Column;
        }

        public virtual void Move()
        {
            Move(new Position(_random.Next(_playingArea.Rows), _random.Next(_playingArea.Columns)));
         

        }

        virtual internal int GetNumberOfMoves()
        {
            return _moveCounter;
        }

        virtual protected int IncreaseMoveCounter()

        {
            return _moveCounter ++; 
        }
        




    }
}
