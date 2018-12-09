using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
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
        List<Button> list = new List<Button>();
        #endregion
        #region Initialize
        public ChessBoardManager(Panel _chessBoard)
        {
            this.ChessBoard = _chessBoard;
        }
        #endregion
        #region Method       
        public void DrawChessBoard(int n)
        {
            int chess_Width = 560 / n;
            Button oldButton = new Button()
            {
                Width = 0,
                Height = 0,
                Location = new Point(0, 0),
                BackColor = Color.Yellow,
            };
            for (int i = 1; i <= n; ++i)
            {
                for (int j = 1; j <= n + 1; ++j)
                {
                    Button btn = new Button()
                    {
                        Width = chess_Width,
                        Height = chess_Width,
                        Location = new Point(oldButton.Location.X + oldButton.Width, oldButton.Location.Y)
                    };
                    if ((i + j) % 2 != 0)
                    {
                        btn.BackColor = Color.Orange;
                    }
                    else
                    {
                        btn.BackColor = Color.Blue;
                    }
                    list.Add(btn);
                    btn.Name = i.ToString() + "_" + j.ToString();
                    btn.Font = new Font("Arial", 20, FontStyle.Bold);
                    btn.BackgroundImageLayout = ImageLayout.Stretch;
                    btn.Click += btn_Click;
                    ChessBoard.Controls.Add(btn);
                    oldButton = btn;
                }
                oldButton.Width = 0;
                oldButton.Height = 0;
                oldButton.Location = new Point(0, oldButton.Location.Y + chess_Width);
            }
        }
        public void Knight(string x, string y, bool trangTrai)
        {
            foreach (Button btn in list)
            {
                if (btn.Name == x.ToString() + "_" + y.ToString())
                {
                    if (trangTrai == true)
                    {
                        btn.BackgroundImage = Image.FromFile(Application.StartupPath + "\\Resources\\chess.png");
                    }
                    else
                    {
                        btn.BackgroundImage = null;
                    }
                }
            }
        }
        public void ClearKnight()
        {
            foreach (Button btn in list)
            {
                        btn.BackgroundImage = null;
            }
        }
        public void Queen(string str, int n)
        {
            foreach (Button item in list)
            {
                item.BackgroundImage = null;
            }
            foreach (Button item in list)
            {
                string[] s;
                s = str.Split(' ', '}', '{');
                for (int j = 1; j <= n; ++j)
                {
                    if (item.Name == j.ToString() + "_" + s[j + 1].ToString())
                    {
                        item.BackgroundImage = Image.FromFile(Application.StartupPath + "\\Resources\\queen.png");
                        Thread.Sleep(1);
                        Application.DoEvents();
                        break;
                    }
                }
            }
        }
        public void DatKnight(string values, string str, int dem)
        {
            string[] tex = str.Split('}','{',')','(');
            for (int i = 1; i <= dem*dem; ++i)
            {
                foreach (Button item in list)
                {
                    if (item.Name == tex[i*2])
                    {
                        item.BackgroundImage = Image.FromFile(Application.StartupPath + "\\Resources\\chess.png");
                        item.Text = i.ToString();
                     
                        item.ForeColor = Color.White;
                        break;
                    }
                }



            }
            foreach (Button item in list)
            {
                
                //if (item.Name == tex[i+3]+"_"+tex[i + 5])
                //{
                //    item.BackgroundImage = Image.FromFile(Application.StartupPath + "\\Resources\\chess.png");
                //    item.Text = tex[i + 1];
                //    item.ForeColor = Color.White;
                //    i += 7;
                //}
            }
        }
        public void Khight(int[,] ka, int n)
        {
            foreach (Button item in list)
            {
                item.BackgroundImage = null;
            }
            foreach (Button item in list)
            {
                for (int i = 1; i <= n; ++i)
                {
                    for (int j = 1; j <= n; ++j)
                    {
                        if (ka[i, j] != 0)
                        {
                            item.BackgroundImage = Image.FromFile(Application.StartupPath + "\\Resources\\chess.png");                     
                        }
                        else
                        {
                            item.BackgroundImage = null;
                        }
                    }
                }                               
           }                       
        }
        #endregion
        #region Event
        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.BackgroundImage != null)
            {
                btn.BackgroundImage = null;
            }
            else
            {
                btn.BackgroundImage = Image.FromFile(Application.StartupPath + "\\Resources\\chess.png");
            }
        }
        #endregion

    }
}
