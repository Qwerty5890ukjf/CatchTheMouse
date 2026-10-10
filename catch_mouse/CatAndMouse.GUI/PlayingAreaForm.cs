using CatAndMouse.lib;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CatAndMouse.GUI
{
    public partial class PlayingAreaForm : Form
    {
        private const int ROWS = 4;
        private const int COLUMNS = 4;

        private GameButton[,] _buttons;
        private FlowLayoutPanel flwPlayingArea;
        private Game _game;

        public PlayingAreaForm()
        {
            InitializeComponent();
          

            _game = new Game(ROWS, COLUMNS);

            _buttons = new GameButton[ROWS, COLUMNS];

           
            for (int i = 0; i < ROWS; i++)
            {
                for (int j = 0; j < COLUMNS; j++)
                {
                    GameButton gb = new GameButton(i, j);

                    gb.Width = 84;
                    gb.Height = 84;

                    gb.BackgroundImage = CatAndMouse.GUI.Resource.CTM;
                    gb.BackgroundImageLayout = ImageLayout.Zoom;

                


                    // gb.Click += new System.EventHandler(this.GameButton_Click);
                    gb.Click += GameButton_Click;
                    flwPlayingArea.Controls.Add(gb);

                    _buttons[i, j] = gb;
                }

                flwPlayingArea.SetFlowBreak(
                    _buttons[i, _buttons.GetLength(1) - 1],
                    true


             
                );
            }


            _buttons[_game.Mouse.Row, _game.Mouse.Column].Image = CatAndMouse.GUI.Resource.jerry;
             


            

        }
        

        private void GameButton_Click(object sender, EventArgs e)
        {
            //GameButton button = (GameButton)sender;

            //_game.Play(new Position(button.Row, button.Column));

            //UpdateBoard();

            //// Prüfung, ob Spiel zu Ende ist
            //if (_game.GameOver == true)
            //{
            //    button.BackgroundImage = CatAndMouse.GUI.Resource.tomcatchesjerry;
            //    return;

            GameButton clickedButton = (GameButton)sender;

            // Remember old positions
            Position oldCatPosition =
                new Position(_game.Cat.Row, _game.Cat.Column);

            Position oldMousePosition =
                new Position(_game.Mouse.Row, _game.Mouse.Column);

            // Make the move
            _game.Play(
                new Position(clickedButton.Row, clickedButton.Column)
            );

            // Redraw only changed positions
            UpdateButton(oldCatPosition.Row, oldCatPosition.Column);
            UpdateButton(oldMousePosition.Row, oldMousePosition.Column);

            UpdateButton(_game.Cat.Row, _game.Cat.Column);
            UpdateButton(_game.Mouse.Row, _game.Mouse.Column);

            if (_game.GameOver)
            {
                _buttons[_game.Cat.Row, _game.Cat.Column].BackgroundImage =
                    CatAndMouse.GUI.Resource.tomcatchesjerry;
            }
        }
        



        private void UpdateButton(int row, int column)
        {

            //for (int i = 0; i < ROWS; i++)
            //{
            //    for (int j = 0; j < COLUMNS; j++)
            //    {
            //        GameButton button = _buttons[i, j];


            //        button.BackgroundImage = CatAndMouse.GUI.Resource.CTM;


            //        if (button.Row == _game.Cat.Row &&
            //            button.Column == _game.Cat.Column)
            //        {
            //            button.BackgroundImage = CatAndMouse.GUI.Resource.tom;
            //        }


            //        if (button.Row == _game.Mouse.Row &&
            //            button.Column == _game.Mouse.Column &&
            //            _game.Mouse.IsVisible)
            //        {
            //            button.BackgroundImage = CatAndMouse.GUI.Resource.jerry;
            //        }

            //    }
            //}
            if (row < 0 || row >= ROWS ||
           column < 0 || column >= COLUMNS)
            {
                return;
            }

            GameButton button = _buttons[row, column];

            button.BackgroundImage = CatAndMouse.GUI.Resource.CTM;

            if (button.Row == _game.Cat.Row &&
                button.Column == _game.Cat.Column)
            {
                button.BackgroundImage = CatAndMouse.GUI.Resource.tom;
            }

            if (button.Row == _game.Mouse.Row &&
                button.Column == _game.Mouse.Column &&
                _game.Mouse.IsVisible)
            {
                button.BackgroundImage = CatAndMouse.GUI.Resource.jerry;
            }

        }






        private void InitializeComponent()
        {
            this.flwPlayingArea = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
             
            // flwPlayingArea
            
            this.flwPlayingArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flwPlayingArea.Location = new System.Drawing.Point(0, 0);
            this.flwPlayingArea.Name = "flwPlayingArea";
            this.flwPlayingArea.Size = new System.Drawing.Size(284, 261);
            this.flwPlayingArea.TabIndex = 0;
            // 
            // PlayingAreaForm
             
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.flwPlayingArea);
            this.Name = "PlayingAreaForm";
            this.ResumeLayout(false);

        }




    }
}


    
