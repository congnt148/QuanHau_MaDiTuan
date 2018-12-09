using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA_KTLT
{
    public partial class Form1 : Form
    {

        #region Properties
        ChessBoardManager ChessBoard;
        #endregion
        public Form1()
        {
            InitializeComponent();
            ChessBoard = new ChessBoardManager(pnlChessBoart);
            ChessBoard.DrawChessBoard();
        }
        #region method
     
        #endregion

        #region Event
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có thật sự muốn thoát chương trình không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void tbxToaDoX_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if ((!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar)) ||  ((e.KeyChar < 49 || e.KeyChar >56) || tbxToaDoX.Text.Length == 1))
            //    e.Handled = true;
        }
        private void tbxToaDoY_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar != '1' && e.KeyChar != '2' && e.KeyChar != '3' && e.KeyChar != '4' && e.KeyChar != '5' && e.KeyChar != '6' && e.KeyChar != '7' && e.KeyChar != '8' && tbxToaDoX.Text.Length == 1)
            //    e.Handled = true;
        }

        #endregion

        private void tbxToaDoX_TextChanged(object sender, EventArgs e)
        {
            if (tbxToaDoX.Text.Length > 0 && tbxToaDoY.Text.Length > 0)
            {
                Button btn = new Button();



            }


        }
    }
}
