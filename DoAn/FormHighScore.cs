using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn
{
    public partial class FormHighScore : Form
    {
        Dictionary<string, Point> tableHash;
        public FormHighScore(Dictionary<string, Point> Data)
        {
            InitializeComponent();
            tableHash = Data;
            List<int> win = new List<int>();
            List<string> name = new List<string>();

            foreach (var item in tableHash)
            {
                if (item.Key != "COMPUTER")
                {
                    win.Add(item.Value.X);
                    name.Add(item.Key);
                }
           
            }
            // Sắp xếp lại thứ hạng theo số lượt thắng giảm dần
            for (int i = 0; i < win.Count() - 1; i++)
            {
                for (int j = i + 1; j < win.Count(); j++)
                {
                    if (win[i] < win[j])
                    {
                        int temp1 = win[i];
                        win[i] = win[j];
                        win[j] = temp1;
                        string temp2 = name[i];
                        name[i] = name[j];
                        name[j] = temp2;
                    }
                }

            }
            for (int i = 0; i < name.Count(); i++)
            {
                txtHighScore.Text += string.Format("*{0,-12}", name[i]) + "\t\t" + tableHash[name[i]].X.ToString() + "\t" + tableHash[name[i]].Y.ToString();
                txtHighScore.Text += "\r\n";
            }
        }
    }
}
