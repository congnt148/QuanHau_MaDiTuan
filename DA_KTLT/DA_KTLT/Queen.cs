using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace DA_KTLT
{
    class Queen
    {
        private int n;
        private int[] kt;  
        private ListView listViewLen;
        public Queen(ListView lv, int _n)
        {
            this.ListViewLen = lv;
            this.N = _n;
        }        
        int dem = 1;
        public void khoiTao(int n)
        {
            kt = new int[n+1];
        }
        public ListView ListViewLen
        {
            get
            {
                return listViewLen;
            }

            set
            {
                listViewLen = value;
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
        public void addListView(int[] sls, int n)
        {
            string str = "";
            for (int i = 1; i <= n; ++i)
            {
                str += sls[i].ToString() + " ";               
            }
            str.Trim();
            ListViewItem item = new ListViewItem();
            item.Text = dem.ToString();
            item.SubItems.Add(str);
            this.ListViewLen.Items.Add(item);            
            dem++;
        }    
        #region Demo1
        public bool okDeMo(int I, int J)
        {
            for (int k = 1; k < I; ++k)
            {
                if (kt[k] == J || Math.Abs(k - I) == Math.Abs(kt[k] - J))
                {
                    return false;
                }
            }
            return true;   
        }
        public void TryDemo(int i, int n)
        {

            for (int j = 1; j <= n; ++j)
            {
                if (okDeMo(i, j))
                {
                    kt[i] = j;
                    if (i == n)
                        addListView(kt,n);
                    TryDemo(i + 1, n);            
                }
            }
        }
        public void ThucThi()
        {
            int valuesI = this.N;
            khoiTao(valuesI);
            TryDemo(1, valuesI);
       
        }
        #endregion
    }
}
