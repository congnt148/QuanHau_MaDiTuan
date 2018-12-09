using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA_KTLT
{
    public class ChessBoardManager
    {
        #region Properties
        private Panel chessBoard;
        public Panel ChessBoard
        {
            get
            {
                return chessBoard;
            }

            set
            {
                chessBoard = value;
            }
        }
        #endregion
        #region Initialize
        public ChessBoardManager(Panel _chessBoard)
        {
            this.ChessBoard = _chessBoard;
        }
        #endregion
        #region Method
        public void DrawChessBoard()
        {
            Button oldButton = new Button()
            {
                Width = 0,
                Height = 0,
                Location = new Point(0, 0),
                BackColor = Color.Yellow,
                
            };
            for (int i = 0; i < Cons.CHESS_BOARD_HEIGHT; ++i)
            {
                for (int j = 0; j < Cons.CHESS_BOARD_WIDTH; ++j)
                {
                    Button btn = new Button()
                    {
                        Width = Cons.CHESS_WIDTH,
                        Height = Cons.CHESS_HEIGHT,
                        Location = new Point(oldButton.Location.X + oldButton.Width, oldButton.Location.Y)
                    };
                    if ((i + j) % 2 != 0)
                    {
                        btn.BackColor = Color.Orange;
                        //btn.Text = i.ToString() + j.ToString();
                    }
                    else
                    {
                        btn.BackColor = Color.Blue;
                        //btn.Text = i.ToString() + j.ToString();
                    }
                    btn.BackgroundImageLayout = ImageLayout.Stretch;
                    btn.Click += btn_Click;
                    ChessBoard.Controls.Add(btn);
                    oldButton = btn;
                }
                oldButton.Width = 0;
                oldButton.Height = 0;
                oldButton.Location = new Point(0, oldButton.Location.Y + Cons.CHESS_HEIGHT);
            }
        }
        #endregion
        #region Event
        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackgroundImage = Image.FromFile(Application.StartupPath + "\\Resources\\chess.png");
        }
        #endregion


    }
}
