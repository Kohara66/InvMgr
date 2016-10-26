using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory
{
    public partial class InvMgr : Form
    {
        public InvMgr()
        {
            InitializeComponent();
        }

        SortedList<string, int> prefList = new SortedList<string, int>();

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPAdd_Click(object sender, EventArgs e)
        {
            int prefQty = Convert.ToInt32(numPW.Value);
            prefList.Add(cboxWidget.Text, prefQty);
            string strprefList = string.Join(",", prefList);
        }

        private void btnPClear_Click(object sender, EventArgs e)
        {
            prefList.Clear();
        }

        private void varprefOrder(object sender, EventArgs e)
        {
            string keyName = "";
            foreach (KeyValuePair<string,int> prefKVP in prefList)
            {
                keyName = prefKVP.Key;
                if (keyName == "Widget 1")
                {
                    numW1.Value = prefKVP.Value;
                }
                else if (keyName == "Widget 2")
                {
                    numW2.Value = prefKVP.Value;
                }
                else if (keyName == "Widget 3")
                {
                    numW3.Value = prefKVP.Value;
                }
                else if (keyName == "Widget 4")
                {
                    numW4.Value = prefKVP.Value;
                }
                else if (keyName == "Widget 5")
                {
                    numW5.Value = prefKVP.Value;
                }
                else if (keyName == "Widget 6")
                {
                    numW6.Value = prefKVP.Value;
                }
                else if (keyName == "Widget 7")
                {
                    numW7.Value = prefKVP.Value;
                }
                else if (keyName == "Widget 8")
                {
                    numW8.Value = prefKVP.Value;
                }
                else if (keyName == "Widget 9")
                {
                    numW9.Value = prefKVP.Value;
                }
                else if (keyName == "Widget 10")
                {
                    numW10.Value = prefKVP.Value;
                }
            }
        }
    }
}
