using CatAndMouse.lib;
using System;
using System.Windows.Forms;

namespace CatAndMouse.GUI
{
    internal class GameButton : Button
    {

        
            public int Row { get; set; }
            public int Column { get; set; }

            public GameButton(int row, int column)
            {
                Row = row;
                Column = column;
            }
        

    }
}