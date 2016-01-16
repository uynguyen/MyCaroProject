using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DoAn;
using System.Runtime.InteropServices;
namespace DoAn
{
    public partial class FormLogin : Form
    {
        private Dictionary<string, Point> tableHashData;// Xử dụng class Point để biểu diễn số trận thắng (X) và số trận thua (Y)
        string name1 = null, name2 = null;
        int option = 0;
        public FormLogin()
        {
            InitializeComponent();
            initHashTable();
            cmbNamePlayer1.Enabled = false;
            cmbNamePlayer2.Enabled = false;
        }

        /// <summary>
        /// Đọc file "MyData.1212505" và lưu vào tableHashData, thông báo những người chơi cũ trước đó
        /// </summary>
        public void initHashTable()
        {
            tableHashData = new Dictionary<string, Point>();
            BinaryReader br;
            try
            {
                br = new BinaryReader(new FileStream("..//..//MyData.1212505", FileMode.Open));

            }
            catch (Exception)
            {
                br = new BinaryReader(new FileStream("..//..//MyData.1212505", FileMode.Create));
            }

            string temp1;
            Point temp2 = new Point();

            while (br.PeekChar() > 0)
            {
                temp1 = br.ReadString();
                temp2.X = br.ReadInt32();
                temp2.Y = br.ReadInt32();
                tableHashData.Add(temp1, temp2);

            }
            br.Close();

            // Hiển thị tên những người chơi cũ vào các combo box tên tương ứng
            if (tableHashData.Count > 0)
            {
                foreach (string item in tableHashData.Keys)
                {
                    if (item != "COMPUTER")
                    {
                        cmbNamePlayer1.Items.AddRange(new object[] { item });
                        cmbNamePlayer2.Items.AddRange(new object[] { item });
                    }
                }
            }

        }

        private void btnStartF1_Click(object sender, EventArgs e)
        {
            name1 = cmbNamePlayer1.Text;
            name2 = cmbNamePlayer2.Text;

            if (string.IsNullOrEmpty(cmbNamePlayer1.Text) || string.IsNullOrEmpty(cmbNamePlayer2.Text))
            {
                MessageBox.Show("You must create a new Player or choose an old Player!!!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                Form frmMain = new FrmMain(name1, name2, tableHashData, option);
                this.Hide();
                frmMain.ShowDialog();
                this.Close();
            }
        }

        private void rdbOption_CheckedChanged(object sender, EventArgs e)
        {
            cmbNamePlayer2.Enabled = false;
            cmbNamePlayer2.Text = "COMPUTER";
            cmbNamePlayer1.Enabled = true;
            option = 1;
        }

        private void rdbOption2_CheckedChanged(object sender, EventArgs e)
        {
            cmbNamePlayer2.Enabled = true;
            cmbNamePlayer2.Text = "";
            cmbNamePlayer1.Enabled = true;
            cmbNamePlayer1.Text = "";
            option = 0;
        }

     

    }
}
