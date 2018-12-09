using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace DA_KTLT
{
    class Knight
    {
        private int[] strA = { -2, -2, -1, 1, 2, 2, 1, -1 };
        private int[] strB = { -1, 1, 2, 2, 1, -1, -2, -2 };
        private int n;
        private int[,] kq;
        public bool flag = false;
        private int vti;
        private int vtj;
        private ListView lv;
        int dem = 0;
        int thutu = 1;
        public ListView Lv
        {
            get
            {
                return lv;
            }

            set
            {
                lv = value;
            }
        }
        public int N
        {
            get
            {
                return n;
            }

            set
            {
                n = value;
            }
        }
        public int Vti
        {
            get
            {
                return vti;
            }

            set
            {
                vti = value;
            }
        }
        public int Vtj
        {
            get
            {
                return vtj;
            }

            set
            {
                vtj = value;
            }
        }
        public Knight(ListView _lv, int _n, int _vti, int _vtj)
        {
            this.Lv = _lv;
            this.N = _n;
            this.Vti = _vti;
            this.Vtj = _vtj;
        }
        public void khoiTao(int n)
        {
            kq = new int[n + 1, n + 1];
            for (int I = 1; I <= n; ++I)
            {
                for (int J = 1; J <= n; ++J)
                {
                    kq[I, J] = 0;
                }
            }
        }
        public bool Dat(int i, int j, int n)
        {
            int x_t;
            int y_t;
            for (int k = 0; k <= 7; ++k)
            {
                x_t = i + strA[k];
                y_t = j + strB[k];
                if (0 < x_t && x_t <= n * n && 0 < y_t && y_t <= n * n && kq[x_t, y_t] == 0)
                {
                    return true;
                }
            }
            return false;
        }
        public void addListView(int n, int[,] value)
        {
            int dem = 1;
            ListViewItem item = new ListViewItem();
            item.Text = thutu.ToString();
            string valus = "";

            for (int k = 1; k <= n * n; ++k)
            {
                for (int i = 1; i <= n; ++i)
                {
                    for (int j = 1; j <= n; ++j)
                    {
                        if (dem == value[i, j])
                        {
                            valus += dem+"(" + i.ToString() + "_" + j.ToString() + ") ";
                            dem++;
                            break;
                        }
                    }
                }
            }

            item.SubItems.Add(valus);
            this.Lv.Items.Add(item);
            thutu++;
            dem = 0;
            flag = true;
        }
        public void Try(int i, int j, int n)
        {
            dem++;
            kq[i, j] = dem;
            if (dem == n * n)
            {
                addListView(n, kq);
                // return;
            }
            for (int k = 0; k < 8; ++k)
            {
                int x_t = i + strA[k];
                int y_t = j + strB[k];
                    if (0 < x_t && x_t <= n && 0 < y_t && y_t <= n && kq[x_t, y_t] == 0)
                {
                    Try(x_t, y_t, n);
                }
            }
            dem--;
            kq[i, j] = 0;
        }
        public void ThucThi()
        {
            khoiTao(this.N);
            Try(this.Vti, this.Vtj, this.N);
            if (flag == false)
            {
                MessageBox.Show("Không có lời giải cho quân mã này");
            }
        }
    }
}

