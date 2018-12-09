using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA_KTLT
{
    public partial class Form1 : Form
    {
        #region Properties
        ChessBoardManager ChessBoard;
        #endregion
        #region method
        public Form1()
        {
            InitializeComponent();
            loadForm();
        }
        private void loadForm()
        {
            rbtDatQuanHau.Checked = true;
            ChessBoard = new ChessBoardManager(pnlChessBoart);
            ChessBoard.DrawChessBoard(8);
        }
        public void KhightDat(int[,] kt, int n)
        {
            ChessBoard.Khight(kt, n);
        }
        #endregion
        #region Event
        private void btnInfo_Click(object sender, EventArgs e)
        {
            frmInfo frm = new frmInfo();
            frm.ShowDialog();
        }
        private void rbtDatQuanHau_CheckedChanged(object sender, EventArgs e)
        {
            lwvData.Items.Clear();
            if (rbtDatQuanHau.Checked == true)
            {
                tbxKT1.Enabled = true;
                tbxToaDoX.Enabled = false;
                tbxToaDoY.Enabled = false;

            }
        }
        private void rbtMaDiTuan_CheckedChanged(object sender, EventArgs e)
        {
            lwvData.Items.Clear();
            if (rbtMaDiTuan.Checked == true)
            {
                tbxKT1.Enabled = true;
                tbxToaDoX.Enabled = true;
                tbxToaDoY.Enabled = true;
                pnlChessBoart.Controls.Clear();
                tbxKT1.Text = "5";
                tbxKT2.Text = tbxKT1.Text;
                ChessBoard = new ChessBoardManager(pnlChessBoart);
                ChessBoard.DrawChessBoard(Int32.Parse(tbxKT1.Text));
            }
        }
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
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar) || (Char.IsDigit(e.KeyChar) && tbxToaDoX.Text.Length > 0))
            {
                e.Handled = true;
            }
        }
        private void tbxToaDoY_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar) || (Char.IsDigit(e.KeyChar) && tbxToaDoY.Text.Length > 0))
            {
                e.Handled = true;
            }
        }
        private void tbxToaDoX_TextChanged(object sender, EventArgs e)
        {
            if (tbxToaDoX.Text.Length > 0 && tbxToaDoY.Text.Length > 0)
            {
                ChessBoard.Knight(tbxToaDoX.Text, tbxToaDoY.Text, true);
            }
            if (tbxToaDoX.Text.Length > 0 && tbxToaDoY.Text.Length == 0 || tbxToaDoX.Text.Length == 0 && tbxToaDoY.Text.Length > 0)
            {
                ChessBoard.ClearKnight();
            }
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (rbtDatQuanHau.Checked == true)
            {
                Queen que = new Queen(lwvData, Int32.Parse(tbxKT1.Text));
                que.ThucThi();
                foreach (ListViewItem item in que.ListViewLen.Items)
                {
                    string trr = item.SubItems[1].ToString();
                    ChessBoard.Queen(trr, Int32.Parse(tbxKT1.Text));
                }
            }
            if (rbtMaDiTuan.Checked == true)
            {
                if (tbxToaDoX.Text.Length > 0 && tbxToaDoY.Text.Length > 0)
                {
                    Knight kni = new Knight(lwvData, Int32.Parse(tbxKT1.Text), Int32.Parse(tbxToaDoX.Text), Int32.Parse(tbxToaDoY.Text));
                    kni.ThucThi();
                    foreach (ListViewItem item in kni.Lv.Items)
                    {
                        string trr = item.SubItems[1].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Bạn phải nhập đầy đủ tọa độ X và tọa độ Y.");
                }
            }
        }
        private void tbxToaDoY_TextChanged(object sender, EventArgs e)
        {
            if (tbxToaDoY.Text.Length > 0 && tbxToaDoY.Text.Length > 0)
            {
                ChessBoard.Knight(tbxToaDoX.Text, tbxToaDoY.Text, true);
            }
            if (tbxToaDoX.Text.Length > 0 && tbxToaDoY.Text.Length == 0 || tbxToaDoX.Text.Length == 0 && tbxToaDoY.Text.Length > 0)
            {
                ChessBoard.ClearKnight();
            }
        }
        private void tbxKT1_TextChanged(object sender, EventArgs e)
        {
            if (tbxKT1.Text.Length == 0)
            {
                pnlChessBoart.Controls.Clear();
            }
            else
            {
                tbxKT2.Text = tbxKT1.Text;
            }
        }
        private void tbxKT1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            pnlChessBoart.Controls.Clear();
            lwvData.Items.Clear();
            tbxToaDoX.Text = "";
            tbxToaDoY.Text = "";
            if (Int32.Parse(tbxKT2.Text) < 4)
            {
                if (rbtDatQuanHau.Checked == true)
                    MessageBox.Show("Đối với giải thuật đặt N Quân Hậu lên bàn cở chỉ có thể khởi tạo bàn cờ lớn hơn hoặc bằng 4");
                if (rbtMaDiTuan.Checked == true)
                    MessageBox.Show("Đối với giải thuật 'Tìm Đường Đi Cho Quân Mã' chỉ có thể khởi tạo bàn cờ lớn hơn hoặc bằng 5");
                tbxKT1.Text = Cons.SoQuanCoMIN.ToString();
                tbxKT2.Text = tbxKT1.Text;
                ChessBoard = new ChessBoardManager(pnlChessBoart);
                ChessBoard.DrawChessBoard(Int32.Parse(tbxKT1.Text));
            }
            else
            {
                tbxKT2.Text = tbxKT1.Text;
                ChessBoard = new ChessBoardManager(pnlChessBoart);
                ChessBoard.DrawChessBoard(Int32.Parse(tbxKT1.Text));
            }
        }
        private void lwvData_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rbtDatQuanHau.Checked == true)
            {
                ListView lvs = sender as ListView;
                if (lvs.SelectedItems.Count > 0)
                {
                    string str = lwvData.SelectedItems[0].SubItems[1].ToString();
                    ChessBoard.Queen(str, Int32.Parse(tbxKT1.Text));
                }
            }
            else
            {
                ListView lvs = sender as ListView;
                if (lvs.SelectedItems.Count > 0)
                {
                    for (int i = 1; i <= lvs.SelectedItems.Count; ++i)
                    {
                        string valu = lwvData.SelectedItems[0].SubItems[0].Text.ToString();
                        string str = lwvData.SelectedItems[0].SubItems[1].ToString();
                        ChessBoard.DatKnight(valu, str, Int32.Parse(tbxKT1.Text));
                    }
                }
            }
        }
        #endregion
     
    }
}
