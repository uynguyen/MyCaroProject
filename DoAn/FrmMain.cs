using CaroLogic;
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

namespace DoAn
{
    public partial class FrmMain : Form
    {
        Dictionary<string, Point> tableHash;
        private int mapSize = 30;

        private int buttonSize = 21;
        private Button[,] arrButton = null;
        private Label[,] arrLabel = null;
        private Game game = new Game();
        
        public FrmMain(string namePlayer1, string namePlayer2, Dictionary<string, Point> Data, int option)
        {
            InitializeComponent();
                
            game.option = option;
            tableHash = Data;
            game.player1.m_Name = namePlayer1;
            game.player2.m_Name = namePlayer2;
            if (tableHash.Count > 0)// Nếu trong danh sách đã tồn tại người chơi cũ thì
                // tiến hành kiểm tra xem người chơi X và Y có trong danh sách không
            {
                if (tableHash.ContainsKey(namePlayer1)) // Nếu đã tồn tại người chơi cũ
                {
                    game.player1.m_scoreWin = tableHash[namePlayer1].X;
                    game.player1.m_scoreLose = tableHash[namePlayer1].Y;
                }
                else//Nếu chưa tồn tại thì tạo người chơi mới và gán điểm thằng và thua bằng 0
                {
                    game.player1.m_scoreLose = game.player1.m_scoreWin = 0;
                    tableHash.Add(namePlayer1, new Point(0, 0));
                }
                if (tableHash.ContainsKey(namePlayer2))
                {
                    game.player2.m_scoreWin = tableHash[namePlayer2].X;
                    game.player2.m_scoreLose = tableHash[namePlayer2].Y;
                }
                else
                {
                    game.player2.m_scoreLose = game.player2.m_scoreWin = 0;
                    tableHash.Add(namePlayer2, new Point(0, 0));
                }
            }
                // Nếu danh sách rỗng thì tạo người chơi mới và gán số điểm thằng bằng số điểm thua bằng 0
            else
            {
                game.player1.m_scoreLose = game.player1.m_scoreWin = 0;
                tableHash.Add(namePlayer1, new Point(0, 0));
                game.player2.m_scoreLose = game.player2.m_scoreWin = 0;
                tableHash.Add(namePlayer2, new Point(0, 0));
            }
            
            displayNameAndScore();
            
            initArrayButton();

            initArrayLabel();

            game.Win += game_Win;

            // Chế độ chơi với máy
            if (game.option == 1)
            {
 
                game.computer += computerTurn;
            }
        

        }

        /// <summary>
        /// Hiển thị tên người chơi và số điểm lên màn hình chính
        /// </summary>
        private void displayNameAndScore()
        {
            lblPlayer1F2.Text = game.player1.m_Name;
            lblPlayer2F2.Text = game.player2.m_Name;

            lblScore1.Text = game.player1.m_scoreWin.ToString() + "    :    " + game.player1.m_scoreLose.ToString();
            lblScore2.Text = game.player2.m_scoreWin.ToString() + "    :    " + game.player2.m_scoreLose.ToString();
        }
        /// <summary>
        /// Tạo một ma trận các button 
        /// </summary>
        private void initArrayButton()
        {
            arrButton = new Button[mapSize, mapSize];

            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    arrButton[i, j] = new Button();
                    arrButton[i, j].Size = new Size(buttonSize, buttonSize);
                    arrButton[i, j].Location = new Point(342 + j * buttonSize, 40 + i * buttonSize);
                    arrButton[i, j].TabIndex = i * 30 + j;
                    arrButton[i, j].Tag = new Location() { Row = i, Col = j };
                    arrButton[i, j].Click += button_Click;
                    this.Controls.Add(arrButton[i, j]);
                }
            }
        }
        /// <summary>
        /// Tạo một ma trận các label 
        /// </summary>
        private void initArrayLabel()
        {
            arrLabel = new Label[mapSize, mapSize];
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    arrLabel[i, j] = new Label();
                }
            }
        }
        /// <summary>
        /// Xử lý khi xảy ra sự kiện có người chơi chiến thắng
        /// </summary>
        /// <param name="win"></param>
        private void game_Win(Game.Players win)
        {
            int x = (int)win;
            string nameTemp1 = update_Score(x);
            writeUpdateScore();
            MessageBox.Show("Player " + nameTemp1 + " Won !!!");
            resetGame();

        }
        private void computerTurn(int x, int y)
        {
            arrLabel[x, y].Size = arrButton[x,y].Size;
            arrLabel[x, y].Location = arrButton[x, y].Location;
            arrLabel[x, y].TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            arrLabel[x, y].BorderStyle = BorderStyle.Fixed3D;
            arrLabel[x, y].Font = new System.Drawing.Font("Mistral", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            arrLabel[x, y].Text = "O";
            arrLabel[x, y].ForeColor = System.Drawing.Color.Blue;

            arrButton[x, y].Hide(); // Ẩn đi button tại vị trí đánh
            this.Controls.Add(arrLabel[x, y]);// Và hiển thị label tương ứng người chơi hiện tại
        }
        /// <summary>
        /// Tăng số lượt thắng và thua của mỗi người chơi
        /// </summary>
        /// <param name="player"> Người chơi thắng ( 1 hoặc 2 )</param>
        /// <returns> Tên của người chơi thắng </returns>
        private string update_Score(int player)
        {
            string nameTemp1;
            if (player == 1)
            {
                nameTemp1 = lblPlayer1F2.Text;
                game.player1.m_scoreWin++;
                game.player2.m_scoreLose++;

            }
            else
            {
                nameTemp1 = lblPlayer2F2.Text;
                game.player1.m_scoreLose++;
                game.player2.m_scoreWin++;
            }
           // Cập nhật điểm vào cơ sở dữ liệu
            tableHash[game.player1.m_Name] = new Point(game.player1.m_scoreWin, game.player1.m_scoreLose);
            tableHash[game.player2.m_Name] = new Point(game.player2.m_scoreWin, game.player2.m_scoreLose);
            lblScore1.Text = game.player1.m_scoreWin.ToString() + "    :    " + game.player1.m_scoreLose.ToString();
            lblScore2.Text = game.player2.m_scoreWin.ToString() + "    :    " + game.player2.m_scoreLose.ToString();
            return nameTemp1;
        }

        void button_Click(object sender, EventArgs e)
        {
            Button button = ((Button)sender);

            Location l = (Location)button.Tag;

            arrLabel[l.Row, l.Col].Size = button.Size;
            arrLabel[l.Row, l.Col].Location = button.Location;
            arrLabel[l.Row, l.Col].TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            arrLabel[l.Row, l.Col].BorderStyle = BorderStyle.Fixed3D;
            arrLabel[l.Row, l.Col].Font = new System.Drawing.Font("Mistral", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            if (game.option == 0)
            {
                 if (game.CurrentPlayer == Game.Players.X)
                {
                    arrLabel[l.Row, l.Col].Text = "X";
                    arrLabel[l.Row, l.Col].ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    arrLabel[l.Row, l.Col].Text = "O";
                    arrLabel[l.Row, l.Col].ForeColor = System.Drawing.Color.Blue;
                }
                 button.Hide(); // Ẩn đi button tại vị trí đánh
                 this.Controls.Add(arrLabel[l.Row, l.Col]);// Và hiển thị label tương ứng người chơi hiện tại
                 game.player_Player_PlayAt(l.Row, l.Col);

            }
            else
            {
                arrLabel[l.Row, l.Col].Text = "X";
                arrLabel[l.Row, l.Col].ForeColor = System.Drawing.Color.Red;
                button.Hide(); // Ẩn đi button tại vị trí đánh
                this.Controls.Add(arrLabel[l.Row, l.Col]);// Và hiển thị label tương ứng người chơi hiện tại
                game.player_Computer_PlayAt(l.Row, l.Col);
            }

        }
        /// <summary>
        /// Tạo một màn chơi mới
        /// </summary>
        private void resetGame()
        {
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    if (arrButton[i, j].Visible == false)
                    {
                        arrButton[i, j].Show();
                        this.Controls.Remove(arrLabel[i, j]);
                        arrLabel[i, j] = new Label();
                    }
                }
            }
            game.SetMap();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult choose = MessageBox.Show("Do you want to save current inning ? ", "New",
                   MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (choose == DialogResult.Yes)
            {
                saveGame();
                resetGame();
            }
            if (choose == DialogResult.No)
            {
                resetGame();
            }
        }
        /// <summary>
        /// Cập nhật điểm số của người chơi vào cơ sở dữ liệu ( file "MyData.1212505")
        /// </summary>
        private void writeUpdateScore()
        {
            BinaryWriter bw;
            bw = new BinaryWriter(new FileStream("..//..//MyData.1212505", FileMode.Create));

            foreach (var item in tableHash)
            {
                bw.Write(item.Key);
                if (item.Key == game.player1.m_Name)
                {
                    bw.Write(game.player1.m_scoreWin);
                    bw.Write(game.player1.m_scoreLose);
                }
                else
                {
                    if (item.Key == game.player2.m_Name)
                    {
                        bw.Write(game.player2.m_scoreWin);
                        bw.Write(game.player2.m_scoreLose);
                    }
                    else
                    {
                        bw.Write(item.Value.X);
                        bw.Write(item.Value.Y);
                    }
                }
            }
            bw.Close();
        }
        /// <summary>
        /// Lưu màn chơi
        /// </summary>
        private void saveGame()
        {
            if (savefileDlg.ShowDialog() == DialogResult.OK)
            {
                BinaryWriter bw;
                Stream name = savefileDlg.OpenFile();
                bw = new BinaryWriter(name);
                game.saveGame(bw,game.option);
            }
            writeUpdateScore();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveGame();
            resetGame();
        }

        private void highScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmHighScore = new FormHighScore(tableHash);
            frmHighScore.ShowDialog();
        }

        private void signToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string temp;
            if ((int)game.CurrentPlayer == 1)
            {
                temp = game.player1.m_Name;
            }
            else
            {
                temp = game.player2.m_Name;
            }
            if (MessageBox.Show("Does player " + temp + " want to surrender and quit current inning ? ", "Surrender",
             MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                update_Score((int)game.CurrentPlayer - 1);
                resetGame();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            writeUpdateScore();
            DialogResult choose = MessageBox.Show("Do you want to save current inning ? ", "New",
                  MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (choose == DialogResult.Yes)
            {
                saveGame();
                Application.Restart();
            }
            if (choose == DialogResult.No)
            {
                Application.Restart();
            }

        }

        /// <summary>
        /// Cập nhật lại tên người chơi và số điểm tương ứng khi load màn chơi cũ
        /// </summary>
        private void loadNameAndScore()
        {
            

            game.player1.m_scoreWin = tableHash[game.player1.m_Name].X;
            game.player1.m_scoreLose = tableHash[game.player1.m_Name].Y;

            game.player2.m_scoreWin = tableHash[game.player2.m_Name].X;
            game.player2.m_scoreLose = tableHash[game.player2.m_Name].Y;
            displayNameAndScore();
         
           
        }

        /// <summary>
        /// Tạo lại Map khi load màn chơi cũ
        /// </summary>
        private void loadMap()
        {
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    if (arrButton[i, j].Visible == false)
                    {
                        arrButton[i, j].Show();
                        this.Controls.Remove(arrLabel[i, j]);
                        arrLabel[i, j] = new Label();
                    }
                }
            }

            int[,] arr = new int[mapSize, mapSize];
           
            resetGame();
            if (openfileDlg.ShowDialog() == DialogResult.OK)
            {
                BinaryReader br;
                Stream name = openfileDlg.OpenFile();
                br = new BinaryReader(name);
                game.loadGame(br, arr);
            }
            loadNameAndScore();
            // Hiển thị màn chơi cũ lên form
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    if (arr[i, j] != 0)
                    {
                        if (arr[i, j] == 1)
                        {
                            arrLabel[i, j].Text = "X";
                            arrLabel[i, j].ForeColor = System.Drawing.Color.Red;
                        }
                        else
                        {
                            arrLabel[i, j].Text = "O";
                            arrLabel[i, j].ForeColor = System.Drawing.Color.Blue;
                        }

                        arrLabel[i, j].Size = arrButton[i, j].Size;
                        arrLabel[i, j].Location = arrButton[i, j].Location;
                        arrLabel[i, j].TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        arrLabel[i, j].BorderStyle = BorderStyle.Fixed3D;
                        arrLabel[i, j].Font = new System.Drawing.Font("Mistral", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                        arrButton[i, j].Hide();
                        this.Controls.Add(arrLabel[i, j]);
                    }

                }
            }

            // Chế độ chơi với máy
            if (game.option == 1)
            {
                game.computer += computerTurn;
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult choose = MessageBox.Show("Do you want to save current inning ? ", "New",
                 MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (choose == DialogResult.Yes)
            {
                saveGame();
                loadMap();
            }
            if (choose == DialogResult.No)
            {
                loadMap();
            }
            if (choose != DialogResult.Cancel)
            {
                if ((int)game.CurrentPlayer == 1)
                {
                    MessageBox.Show("Player " + game.player1.m_Name + " go first!", "Turn",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Player " + game.player2.m_Name + " go first!", "Turn",
                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openfileDlg_FileOk(object sender, CancelEventArgs e)
        {

        }

      
    }
}
