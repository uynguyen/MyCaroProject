using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CaroLogic
{
    public delegate void WinHanlder(CaroLogic.Game.Players win);
    public delegate void Computer(int x, int y);
    public class Game
    {
        public event WinHanlder Win;
        public event Computer computer;

        public Player player1, player2;

        public int option;// Chế độ chơi ( 0: 2 người chơi, 1: chơi với máy)
        private int[,] map;
        public enum Players { X = 1, O = 2 };
        private Players currentPlayer;
        private int mapWidth, mapHeight;
        public Players CurrentPlayer { get { return currentPlayer; } }// Người chơi hiện tại
        public int MapWidth { get { return mapWidth; } }
        public int MapHeight { get { return mapHeight; } }


        public Game(int mapwidth = 30, int mapheight = 30, Players firstPlayer = Players.X)
        {
            mapWidth = mapwidth;
            mapHeight = mapheight;
            currentPlayer = firstPlayer;
            map = new int[mapHeight, mapWidth];
            SetMap();
            player1 = new Player();
            player2 = new Player();
        }
        /// <summary>
        /// Thiết lập mặc định ban đầu cho bản đồ: Tất cả các phần từ đều mang giá trị 0
        /// </summary>
        public void SetMap()
        {
            for (int i = 0; i < mapHeight; i++)
                for (int j = 0; j < mapWidth; j++)
                {
                    map[i, j] = 0;
                }

        }
        /// <summary>
        /// Kiểm tra xem cột thứ b đã đủ 5 quân chưa
        /// </summary>
        /// <param name="a">Vị trí dòng tại ô được đánh</param>
        /// <param name="b">Vị trí cột tại ô được đánh</param>
        /// <returns>Kết quả đã đủ 5 quân tại cột thứ b chưa</returns>
        public bool CheckRow(int a, int b)
        {
            int count = 1;
            int block = 0;
            int x = a + 1;
            while (x < mapHeight && map[a, b] == map[x, b])
            {
                count++;
                x++;
            }
            if (x < mapHeight && map[x, b] != 0)
            {
                block++;
            }
            x = a - 1;
            while (x >= 0 && map[a, b] == map[x, b])
            {
                count++;
                x--;
            }
            if (x < mapHeight && x >= 0 && map[x, b] != 0)
            {
                block++;
            }
            if (count == 5 && block < 2)
                return true;
            else
                return false;
        }
        /// <summary>
        /// Kiểm tra xem hàng thứ a đã đủ 5 quân chưa
        /// </summary>
        /// <param name="a">Vị trí dòng tại ô được đánh</param>
        /// <param name="b">Vị trí cột tại ô được đánh</param>
        /// <returns>Kết quả đã đủ 5 quân tại hàng thứ a chưa</returns>
        public bool CheckCol(int a, int b)
        {
            int count = 1;
            int y = b + 1;
            int block = 0;
            while (y < mapWidth && map[a, b] == map[a, y])
            {
                count++;
                y++;
            }
            if (y < mapWidth && map[a, y] != 0)
            {
                block++;
            }

            y = b - 1;
            while (y >= 0 && map[a, b] == map[a, y])
            {
                count++;
                y--;
            }

            if (y < mapWidth && y >= 0 && map[a, y] != 0)
            {
                block++;
            }
            if (count == 5 && block < 2)
                return true;
            else
                return false;
        }
        /// <summary>
        /// Kiểm tra xem đường chéo chính tại vị trí [a,b] đã đủ 5 quân chưa
        /// </summary>
        /// <param name="a">Vị trí dòng tại ô được đánh</param>
        /// <param name="b">Vị trí cột tại ô được đánh</param>
        /// <returns>Kết quả đã đủ 5 quân tại đường chéo chính vị trí [a,b] chưa</returns>
        public bool CheckDiagonal(int a, int b)
        {
            int count = 1;
            int block = 0;
            int x = a + 1;
            int y = b + 1;
            while (x < mapHeight && y < mapWidth && map[a, b] == map[x, y])
            {
                count = count + 1;
                x++;
                y++;
            }
            if (x < mapHeight && y < mapWidth && map[x, y] != 0)
            {
                block++;
            }

            x = a - 1;
            y = b - 1;
            while (x >= 0 && y >= 0 && map[a, b] == map[x, y])
            {
                count = count + 1;
                x--;
                y--;
            }
            if (x < mapHeight && y < mapWidth && x >= 0 && y >= 0 && map[x, y] != 0)
            {
                block++;
            }
            if (count == 5 && block < 2)
                return true;
            else
                return false;

        }
        /// <summary>
        /// Kiểm tra xem đường chéo phụ tại vị trí [a,b] đã đủ 5 quân chưa
        /// </summary>
        /// <param name="a">Vị trí dòng tại ô được đánh</param>
        /// <param name="b">Vị trí cột tại ô được đánh</param>
        /// <returns>Kết quả đã đủ 5 quân tại đường chéo phụ vị trí [a,b] chưa</returns>
        public bool CheckDiagonalPart(int a, int b)
        {
            int count = 1;
            int block = 0;
            int x = a + 1;
            int y = b - 1;
            while (x < mapHeight && y >= 0 && map[a, b] == map[x, y])
            {
                count++;
                x++;
                y--;
            }
            if (x < mapHeight && y >= 0 && map[x, y] != 0)
            {
                block++;
            }
            x = a - 1;
            y = b + 1;
            while (x >= 0 && y < mapWidth && map[a, b] == map[x, y])
            {
                count++;
                x--;
                y++;
            }
            if (x >= 0 && y < mapWidth && map[x, y] != 0)
            {
                block++;
            }
            if (count == 5 && block < 2)
                return true;
            else
                return false;
        }
        public bool Total_Check(int x, int y)
        {
            if (CheckRow(x, y) || CheckCol(x, y) || CheckDiagonal(x, y) || CheckDiagonalPart(x, y))
                return true;
            return false;
        }
        /// <summary>
        /// Đánh dấu người chơi tại vị trí [row, col] trên ma trận ( Chế độ 1 chơi với máy)
        /// </summary>
        /// <param name="row">Vị trí dòng được đánh</param>
        /// <param name="col">Vị trí cột được đánh</param>
        public void player_Computer_PlayAt(int row, int col)
        {

            map[row, col] = (int)currentPlayer;

            if (Total_Check(row, col))
            {
                if (Win != null)
                    Win(currentPlayer);
            }
            currentPlayer = Players.O;
            // Máy đánh liền sau đó
            if (computer != null)
            {
                Location At = computerPlayAt();
                computer(At.Row, At.Col);
                map[At.Row, At.Col] = 2;

                if (Total_Check(At.Row, At.Col))
                {
                    if (Win != null)
                        Win(currentPlayer);
                }
                currentPlayer = Players.X;
            }


        }
        /// <summary>
        /// Đánh dấu người chơi tại vị trí [row, col] trên ma trận ( Chế độ 2 người)
        /// </summary>
        /// <param name="row">Vị trí dòng được đánh</param>
        /// <param name="col">Vị trí cột được đánh</param>
        public void player_Player_PlayAt(int row, int col)
        {
            map[row, col] = (int)currentPlayer;

            if (Total_Check(row, col))
            {
                if (Win != null)
                    Win(currentPlayer);

            }
            currentPlayer = (currentPlayer == Players.X ? currentPlayer = Players.O : Players.X);
        }
        /// <summary>
        /// Kiểm tra xem có tồn tại cột nào có 3 quân chưa bị chặn không
        /// </summary>
        /// <param name="a">vị trí dòng</param>
        /// <param name="b">vị trí cột</param>
        /// <param name="NguoiChoi">Quân cần xét (1: Người chơi, 2: Máy)</param>
        /// <returns>Có tồn tại cột nào có 3 quân chưa bị chặn không</returns>
        public bool computerCheckRow3(int a, int b, int NguoiChoi)
        {
            int count = 0;
            int block = 0;
            int x = a + 1;
            while (x < mapHeight && NguoiChoi == map[x, b])
            {
                count++;
                x++;
            }
            if (x < mapHeight && map[x, b] != 0)
            {
                block++;
            }
            if (count == 3 && block == 0)
                return true;
            else
            {

                count = 0;
                block = 0;
                x = a - 1;
                while (x >= 0 && NguoiChoi == map[x, b])
                {
                    count++;
                    x--;
                }
                if (x < mapHeight && x >= 0 && map[x, b] != 0)
                {
                    block++;
                }
                if (count == 3 && block == 0)
                    return true;
                else
                    return false;
            }

        }
        /// <summary>
        /// Kiểm tra xem có tồn tại hàng nào có 3 quân chưa bị chặn không
        /// </summary>
        /// <param name="a">vị trí dòng</param>
        /// <param name="b">vị trí cột</param>
        /// <param name="NguoiChoi">Quân cần xét (1: Người chơi, 2: Máy)</param>
        /// <returns>Có tồn tại hàng nào có 3 quân chưa bị chặn không</returns>
        public bool computerCheckCol3(int a, int b, int NguoiChoi)
        {
            int count = 0;
            int y = b + 1;
            int block = 0;
            while (y < mapWidth && NguoiChoi == map[a, y])
            {
                count++;
                y++;
            }
            if (y < mapWidth && map[a, y] != 0)
            {
                block++;
            }
            if (count == 3 && block == 0)
                return true;
            else
            {

                count = 0;
                block = 0;
                y = b - 1;
                while (y >= 0 && NguoiChoi == map[a, y])
                {
                    count++;
                    y--;
                }

                if (y < mapWidth && y >= 0 && map[a, y] != 0)
                {
                    block++;
                }
                if (count == 3 && block == 0)
                    return true;
                else
                    return false;

            }

        }
        /// <summary>
        /// Kiểm tra xem có tồn tại đường chéo chính nào có 3 quân chưa bị chặn không
        /// </summary>
        /// <param name="a">vị trí dòng</param>
        /// <param name="b">vị trí cột</param>
        /// <param name="NguoiChoi">Quân cần xét (1: Người chơi, 2: Máy)</param>
        /// <returns>Có tồn tại đường chéo chính nào có 3 quân chưa bị chặn không</returns>
        public bool computerCheckDiagonal3(int a, int b, int NguoiChoi)
        {
            int count = 0;
            int block = 0;
            int x = a + 1;
            int y = b + 1;
            while (x < mapHeight && y < mapWidth && NguoiChoi == map[x, y])
            {
                count = count + 1;
                x++;
                y++;
            }
            if (x < mapHeight && y < mapWidth && map[x, y] != 0)
            {
                block++;
            }
            if (count == 3 && block == 0)
                return true;
            else
            {
                count = 0;
                block = 0;
                x = a - 1;
                y = b - 1;
                while (x >= 0 && y >= 0 && NguoiChoi == map[x, y])
                {
                    count = count + 1;
                    x--;
                    y--;
                }
                if (x < mapHeight && y < mapWidth && x >= 0 && y >= 0 && map[x, y] != 0)
                {
                    block++;
                }
                if (count == 3 && block == 0)
                    return true;
                else
                    return false;
            }
        }
        /// <summary>
        /// Kiểm tra xem có tồn tại đường chéo phụ nào có 3 quân chưa bị chặn không
        /// </summary>
        /// <param name="a">vị trí dòng</param>
        /// <param name="b">vị trí cột</param>
        /// <param name="NguoiChoi">Quân cần xét (1: Người chơi, 2: Máy)</param>
        /// <returns>Có tồn tại đường chéo phụ nào có 3 quân chưa bị chặn không</returns>
        public bool computerCheckDiagonalPar3(int a, int b, int NguoiChoi)
        {
            int count = 0;
            int block = 0;
            int x = a + 1;
            int y = b - 1;
            while (x < mapHeight && y >= 0 && NguoiChoi == map[x, y])
            {
                count++;
                x++;
                y--;
            }
            if (x < mapHeight && y >= 0 && map[x, y] != 0)
            {
                block++;
            }
            if (count == 3 && block == 0)
                return true;
            else
            {
                count = 0;
                block = 0;
                x = a - 1;
                y = b + 1;
                while (x >= 0 && y < mapWidth && NguoiChoi == map[x, y])
                {
                    count++;
                    x--;
                    y++;
                }
                if (x >= 0 && y < mapWidth && map[x, y] != 0)
                {
                    block++;
                }
                if (count == 3 && block == 0)
                    return true;
                else
                    return false;
            }

        }
        /// <summary>
        /// Đếm số quân liên tiếp ở cột b từ vị trí [a,b]
        /// </summary>
        /// <param name="a">vị trí dòng</param>
        /// <param name="b">vị trí cột</param>
        /// <param name="NguoiChoi">Quân cần xét (1: Người chơi, 2: Máy)</param>
        /// <returns>Số quân liên tiếp trên cột b từ vị trí [a,b]</returns>
        public int computerCheckRow(int a, int b, int NguoiChoi)
        {
            int count = 0;
            int x = a + 1;
            while (x < mapHeight && NguoiChoi == map[x, b])
            {
                count++;
                x++;
            }

            x = a - 1;
            while (x >= 0 && NguoiChoi == map[x, b])
            {
                count++;
                x--;
            }

            return count;
        }
        /// <summary>
        /// Đếm số quân liên tiếp ở hàng a từ vị trí [a,b]
        /// </summary>
        /// <param name="a">vị trí dòng</param>
        /// <param name="b">vị trí cột</param>
        /// <param name="NguoiChoi">Quân cần xét (1: Người chơi, 2: Máy)</param>
        /// <returns>Số quân liên tiếp ở hàng a từ vị trí [a,b]</returns>
        public int computerCheckCol(int a, int b, int NguoiChoi)
        {
            int count = 0;
            int y = b + 1;

            while (y < mapWidth && NguoiChoi == map[a, y])
            {
                count++;
                y++;
            }

            y = b - 1;
            while (y >= 0 && NguoiChoi == map[a, y])
            {
                count++;
                y--;
            }

            return count;
        }
        /// <summary>
        /// Đếm số quân liên tiếp ở đường chéo chính từ vị trí [a,b]
        /// </summary>
        /// <param name="a">vị trí dòng</param>
        /// <param name="b">vị trí cột</param>
        /// <param name="NguoiChoi">Quân cần xét (1: Người chơi, 2: Máy)</param>
        /// <returns>Số quân liên tiếp trên đường chéo chính từ vị trí [a,b]</returns>
        public int computerCheckDiagonal(int a, int b, int NguoiChoi)
        {
            int count = 0;
            int x = a + 1;
            int y = b + 1;
            while (x < mapHeight && y < mapWidth && NguoiChoi == map[x, y])
            {
                count = count + 1;
                x++;
                y++;
            }

            x = a - 1;
            y = b - 1;
            while (x >= 0 && y >= 0 && NguoiChoi == map[x, y])
            {
                count = count + 1;
                x--;
                y--;
            }

            return count;

        }
        /// <summary>
        /// Đếm số quân liên tiếp ở đường chéo phụ từ vị trí [a,b]
        /// </summary>
        /// <param name="a">vị trí dòng</param>
        /// <param name="b">vị trí cột</param>
        /// <param name="NguoiChoi">Quân cần xét (1: Người chơi, 2: Máy)</param>
        /// <returns>Số quân liên tiếp trên đường chéo phụ từ vị trí [a,b]</returns>
        public int computerCheckDiagonalPart(int a, int b, int NguoiChoi)
        {
            int count = 0;
            int x = a + 1;
            int y = b - 1;
            while (x < mapHeight && y >= 0 && NguoiChoi == map[x, y])
            {
                count++;
                x++;
                y--;
            }

            x = a - 1;
            y = b + 1;
            while (x >= 0 && y < mapWidth && NguoiChoi == map[x, y])
            {
                count++;
                x--;
                y++;
            }

            return count;
        }
        /// <summary>
        /// Kiểm tra số quân xung quanh lân cận 4 tại ô [a,b]
        /// </summary>
        /// <param name="a">Vị trí hàng a</param>
        /// <param name="b">Vị trí hàng b</param>
        /// <param name="NguoiChoi">Quân cần xét (1: Người chơi, 2: Máy)</param>
        /// <returns>Số quân xung quanh lân cận 4 tại ô [a,b]</returns>
        public int computerCheck4(int a, int b, int NguoiChoi)
        {
            int count = 0;
            if ((a - 1) >= 0 && map[a - 1, b] == NguoiChoi)
            {
                count++;
            }
            if ((a + 1) < mapHeight && map[a + 1, b] == NguoiChoi)
            {
                count++;
            }
            if ((b - 1) >= 0 && map[a, b - 1] == NguoiChoi)
            {
                count++;
            }
            if ((b + 1) < mapWidth && map[a, b + 1] == NguoiChoi)
            {
                count++;
            }
            return count;
        }
        /// <summary>
        /// Xác định vị trí đánh tối ưu tại lượt chơi cho máy
        /// Các vị trí đánh được chia làm nhiều cấp độ từ [0,12]
        /// Cấp độ càng thấp ưu tiên đánh càng cao
        /// </summary>
        /// <returns>Vị trí đánh tối ưu tại lượt chơi của máy</returns>
        public Location computerPlayAt()
        {

            Location a = new Location();

            List<Location> [] grade = new List<Location>[13];
            for (int i = 0; i < 13; i++)
            {
                grade[i] = new List<Location>();
            }

            for (int i = 0; i < mapHeight; i++)
            {
                for (int j = 0; j < mapWidth; j++)
                {
                    if (map[i, j] == 0)// Ô trống chưa đánh
                    {
                        int ngang_1 = computerCheckCol(i, j, 1);
                        int doc_1 = computerCheckRow(i, j, 1);
                        int cheoChinh_1 = computerCheckDiagonal(i, j, 1);
                        int cheoPhu_1 = computerCheckDiagonalPart(i, j, 1);


                        int ngang_2 = computerCheckCol(i, j, 2);
                        int doc_2 = computerCheckRow(i, j, 2);
                        int cheoChinh_2 = computerCheckDiagonal(i, j, 2);
                        int cheoPhu_2 = computerCheckDiagonalPart(i, j, 2);


                        if (ngang_2 == 4 || doc_2 == 4 || cheoChinh_2 == 4 || cheoPhu_2 == 4)
                        {
                            a.Row = i;
                            a.Col = j;
                            grade[0].Add(a);
                        }
                        else
                        {
                            if (ngang_1 == 4 || doc_1 == 4 || cheoChinh_1 == 4 || cheoPhu_1 == 4)
                            {
                                a.Row = i;
                                a.Col = j;
                                grade[1].Add(a);
                            }
                            else
                            {
                                if ((ngang_1 == 3 && computerCheckCol3(i, j, 1) == true) || (doc_1 == 3 && computerCheckRow3(i, j, 1) == true) || (cheoChinh_1 == 3 && computerCheckDiagonal3(i, j, 1) == true) || (cheoPhu_1 == 3 && computerCheckDiagonalPar3(i, j, 1) == true))
                                {
                                    a.Row = i;
                                    a.Col = j;
                                    grade[2].Add(a);
                                }
                                else
                                {
                                    if (computerCheck4(i, j,1) >= 3)
                                    {
                                        a.Row = i;
                                        a.Col = j;
                                        grade[3].Add(a);
                                    }
                                    else
                                    {
                                        if ((ngang_1 >= 2 && doc_1 >= 2) || (ngang_1 >= 2 && cheoChinh_1 >= 2) || (ngang_1 >= 2 && cheoPhu_1 >= 2) || (doc_1 >= 2 && cheoChinh_1 >= 2) || (doc_1 >= 2 && cheoPhu_1 >= 2) || (cheoChinh_1 >= 2 && cheoPhu_1 >= 2))
                                        {
                                            a.Row = i;
                                            a.Col = j;
                                            grade[4].Add(a);
                                        }
                                        else
                                        {
                                            if ((ngang_1 >= 2 && doc_1 >= 2) || (ngang_1 >= 2 && cheoChinh_1 >= 2) || (ngang_1 >= 2 && cheoPhu_1 >= 2) || (doc_1 >= 2 && cheoChinh_1 >= 2) || (doc_1 >= 2 && cheoPhu_1 >= 2) || (cheoChinh_1 >= 2 && cheoPhu_1 >= 2))
                                            {
                                                a.Row = i;
                                                a.Col = j;
                                                grade[5].Add(a);
                                            }
                                            else
                                            {
                                                if ((ngang_2 >= 2 && doc_2 >= 2) || (ngang_2 >= 2 && cheoChinh_2 >= 2) || (ngang_2 >= 2 && cheoPhu_2 >= 2) || (doc_2 >= 2 && cheoChinh_2 >= 2) || (doc_2 >= 2 && cheoPhu_2 >= 2) || (cheoChinh_2 >= 2 && cheoPhu_2 >= 2))
                                                {
                                                    a.Row = i;
                                                    a.Col = j;
                                                    grade[6].Add(a);
                                                }
                                                else
                                                {
                                                    if (ngang_2 > 3 || doc_2 > 3 || cheoChinh_2 > 3 || cheoPhu_2 > 3)
                                                    {
                                                        a.Row = i;
                                                        a.Col = j;
                                                        grade[7].Add(a);
                                                    }
                                                    else
                                                    {
                                                        if (ngang_2 == 3 || doc_2 == 3 || cheoChinh_2 == 3 || cheoPhu_2 == 3)
                                                        {

                                                            a.Row = i;
                                                            a.Col = j;
                                                            grade[8].Add(a);
                                                        }
                                                        else
                                                        {
                                                            if (computerCheck4(i,j,2) >= 3)
                                                            {
                                                                a.Row = i;
                                                                a.Col = j;
                                                                grade[9].Add(a);
                                                            }
                                                            else
                                                            {
                                                                if (ngang_2 == 2 || doc_2 == 2 || cheoChinh_2 == 2 || cheoPhu_2 == 2)
                                                                {
                                                                    a.Row = i;
                                                                    a.Col = j;
                                                                    grade[10].Add(a);
                                                                }
                                                                else
                                                                {
                                                                    if (ngang_2 == 1 || doc_2 == 1 || cheoChinh_2 == 1 || cheoPhu_2 == 1)
                                                                    {
                                                                        a.Row = i;
                                                                        a.Col = j;
                                                                        grade[11].Add(a);
                                                                    }
                                                                    else
                                                                    {
                                                                        if (ngang_1 == 1 || doc_1 == 1 || cheoChinh_1 == 1 || cheoPhu_1 == 1)
                                                                        {
                                                                            a.Row = i;
                                                                            a.Col = j;
                                                                            grade[12].Add(a);
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                           
                                                        }
                                                    }
                                                }
                                            }

                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            Random rd = new Random();
            int row = rd.Next(15, 20);
            int col = rd.Next(15, 20);
            a.Row = row;
            a.Col = col;
            for (int i = 0; i < 13; i++)
            {
                if (grade[i].Count() != 0)
                {
                    int index = rd.Next(0, grade[i].Count());
                    a = grade[i][index];
                    break;
                }
            }
            return a;
        }

        /// <summary>
        /// Lưu màn chơi
        /// </summary>
        /// <param name="s">Dòng file nhị phân ghi</param>
        /// <param name="option">Chế độ chơi hiện tại</param>
        public void saveGame(BinaryWriter s, int option)
        {
           
            s.Write(mapHeight);
            s.Write(mapWidth);
            s.Write(option);
            s.Write((int)CurrentPlayer);
            s.Write(player1.m_Name);
            s.Write(player2.m_Name);

            for (int i = 0; i < mapHeight; i++)
            {
                for (int j = 0; j < mapWidth; j++)
                {
                    s.Write(map[i, j]);

                }
            }
            s.Close();
        }
        /// <summary>
        /// Load lại màn chơi cũ trước đó
        /// </summary>
        /// <param name="s">Dòng file nhị phân lưu màn chơi trước đó</param>
        /// <param name="arr">Ma trận chứa bản đồ của màn chơi trước đó</param>
        public void loadGame(BinaryReader s, int[,] arr)
        {
            while (s.PeekChar() > 0)// Khi vẫn chưa kết thúc file
            {
                
                this.mapHeight = s.ReadInt32();
                this.mapWidth = s.ReadInt32();
                this.option = s.ReadInt32();
               
                int currentplayer = s.ReadInt32();
                this.player1.m_Name = s.ReadString();
                this.player2.m_Name = s.ReadString();
                this.currentPlayer = (Players)currentplayer;

                for (int i = 0; i < mapHeight; i++)
                {
                    for (int j = 0; j < mapWidth; j++)
                    {
                        arr[i, j] = s.ReadInt32();
                        map[i, j] = arr[i, j];
                    }
                }
            }
            s.Close();
        }
    }
}
