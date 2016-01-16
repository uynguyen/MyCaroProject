namespace DoAn
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.mnStrip = new System.Windows.Forms.MenuStrip();
            this.mnsGame = new System.Windows.Forms.ToolStripMenuItem();
            this.mntNew = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.highScoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.lblWin1 = new System.Windows.Forms.Label();
            this.lblLose = new System.Windows.Forms.Label();
            this.lblScore1 = new System.Windows.Forms.Label();
            this.lblWin2 = new System.Windows.Forms.Label();
            this.lblLose2 = new System.Windows.Forms.Label();
            this.lblScore2 = new System.Windows.Forms.Label();
            this.lblPlayer1F2 = new System.Windows.Forms.Label();
            this.lblPlayer2F2 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.savefileDlg = new System.Windows.Forms.SaveFileDialog();
            this.openfileDlg = new System.Windows.Forms.OpenFileDialog();
            this.mnStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // mnStrip
            // 
            this.mnStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsGame,
            this.aboutToolStripMenuItem});
            this.mnStrip.Location = new System.Drawing.Point(0, 0);
            this.mnStrip.Name = "mnStrip";
            this.mnStrip.Size = new System.Drawing.Size(1304, 24);
            this.mnStrip.TabIndex = 1;
            this.mnStrip.Text = "menuStrip1";
            // 
            // mnsGame
            // 
            this.mnsGame.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mntNew,
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.signToolStripMenuItem,
            this.highScoreToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.mnsGame.Name = "mnsGame";
            this.mnsGame.Size = new System.Drawing.Size(50, 20);
            this.mnsGame.Text = "Game";
            // 
            // mntNew
            // 
            this.mntNew.Name = "mntNew";
            this.mntNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mntNew.Size = new System.Drawing.Size(172, 22);
            this.mntNew.Text = "New        ";
            this.mntNew.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.saveToolStripMenuItem.Text = "Save        ";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.loadToolStripMenuItem.Text = "Load       ";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // signToolStripMenuItem
            // 
            this.signToolStripMenuItem.Name = "signToolStripMenuItem";
            this.signToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.signToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.signToolStripMenuItem.Text = "Resign";
            this.signToolStripMenuItem.Click += new System.EventHandler(this.signToolStripMenuItem_Click);
            // 
            // highScoreToolStripMenuItem
            // 
            this.highScoreToolStripMenuItem.Name = "highScoreToolStripMenuItem";
            this.highScoreToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.highScoreToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.highScoreToolStripMenuItem.Text = "HighScore";
            this.highScoreToolStripMenuItem.Click += new System.EventHandler(this.highScoreToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(172, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.ReadOnly = true;
            this.toolStripTextBox1.Size = new System.Drawing.Size(400, 23);
            this.toolStripTextBox1.Text = "Nguyễn Long Uy _ 1212505_ Email: 1212505@student.hcmus.edu.vn";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(-23, -46);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.Image = global::DoAn.Properties.Resources.B;
            this.pictureBox3.ImageLocation = "";
            this.pictureBox3.Location = new System.Drawing.Point(1025, 41);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(275, 336);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(281, 336);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.Location = new System.Drawing.Point(293, 41);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(49, 672);
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.Location = new System.Drawing.Point(970, 41);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(49, 672);
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.BackgroundImage")));
            this.pictureBox6.Location = new System.Drawing.Point(293, 672);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(726, 41);
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            // 
            // lblWin1
            // 
            this.lblWin1.AutoSize = true;
            this.lblWin1.Font = new System.Drawing.Font("Mistral", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWin1.ForeColor = System.Drawing.Color.Red;
            this.lblWin1.Location = new System.Drawing.Point(12, 433);
            this.lblWin1.Name = "lblWin1";
            this.lblWin1.Size = new System.Drawing.Size(100, 65);
            this.lblWin1.TabIndex = 7;
            this.lblWin1.Text = "Win";
            // 
            // lblLose
            // 
            this.lblLose.AutoSize = true;
            this.lblLose.Font = new System.Drawing.Font("Mistral", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLose.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblLose.Location = new System.Drawing.Point(160, 433);
            this.lblLose.Name = "lblLose";
            this.lblLose.Size = new System.Drawing.Size(94, 65);
            this.lblLose.TabIndex = 7;
            this.lblLose.Text = "Lose";
            // 
            // lblScore1
            // 
            this.lblScore1.Font = new System.Drawing.Font("Mistral", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblScore1.Location = new System.Drawing.Point(13, 508);
            this.lblScore1.Name = "lblScore1";
            this.lblScore1.Size = new System.Drawing.Size(241, 65);
            this.lblScore1.TabIndex = 7;
            this.lblScore1.Text = "0 : 0";
            this.lblScore1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblWin2
            // 
            this.lblWin2.AutoSize = true;
            this.lblWin2.Font = new System.Drawing.Font("Mistral", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWin2.ForeColor = System.Drawing.Color.Red;
            this.lblWin2.Location = new System.Drawing.Point(1064, 433);
            this.lblWin2.Name = "lblWin2";
            this.lblWin2.Size = new System.Drawing.Size(100, 65);
            this.lblWin2.TabIndex = 7;
            this.lblWin2.Text = "Win";
            // 
            // lblLose2
            // 
            this.lblLose2.AutoSize = true;
            this.lblLose2.Font = new System.Drawing.Font("Mistral", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLose2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblLose2.Location = new System.Drawing.Point(1206, 433);
            this.lblLose2.Name = "lblLose2";
            this.lblLose2.Size = new System.Drawing.Size(94, 65);
            this.lblLose2.TabIndex = 7;
            this.lblLose2.Text = "Lose";
            // 
            // lblScore2
            // 
            this.lblScore2.Font = new System.Drawing.Font("Mistral", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblScore2.Location = new System.Drawing.Point(1065, 508);
            this.lblScore2.Name = "lblScore2";
            this.lblScore2.Size = new System.Drawing.Size(235, 65);
            this.lblScore2.TabIndex = 7;
            this.lblScore2.Text = "0 : 0";
            this.lblScore2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPlayer1F2
            // 
            this.lblPlayer1F2.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1F2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblPlayer1F2.Location = new System.Drawing.Point(13, 391);
            this.lblPlayer1F2.Name = "lblPlayer1F2";
            this.lblPlayer1F2.Size = new System.Drawing.Size(241, 33);
            this.lblPlayer1F2.TabIndex = 8;
            this.lblPlayer1F2.Text = "label2";
            this.lblPlayer1F2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPlayer2F2
            // 
            this.lblPlayer2F2.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer2F2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblPlayer2F2.Location = new System.Drawing.Point(1059, 391);
            this.lblPlayer2F2.Name = "lblPlayer2F2";
            this.lblPlayer2F2.Size = new System.Drawing.Size(241, 33);
            this.lblPlayer2F2.TabIndex = 8;
            this.lblPlayer2F2.Text = "label2";
            this.lblPlayer2F2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.Info;
            this.btnBack.Font = new System.Drawing.Font("Mistral", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Red;
            this.btnBack.Location = new System.Drawing.Point(23, 639);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(243, 74);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back Home";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // savefileDlg
            // 
            this.savefileDlg.DefaultExt = "UyNguyen";
            this.savefileDlg.Filter = "UyNguyen |*.UyNguyen";
            // 
            // openfileDlg
            // 
            this.openfileDlg.Filter = "UyNguyen|*.UyNguyen";
            this.openfileDlg.FileOk += new System.ComponentModel.CancelEventHandler(this.openfileDlg_FileOk);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 749);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblPlayer2F2);
            this.Controls.Add(this.lblPlayer1F2);
            this.Controls.Add(this.lblScore2);
            this.Controls.Add(this.lblScore1);
            this.Controls.Add(this.lblLose2);
            this.Controls.Add(this.lblLose);
            this.Controls.Add(this.lblWin2);
            this.Controls.Add(this.lblWin1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.mnStrip);
            this.MainMenuStrip = this.mnStrip;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameCaro";
            this.mnStrip.ResumeLayout(false);
            this.mnStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnStrip;
        private System.Windows.Forms.ToolStripMenuItem mnsGame;
        private System.Windows.Forms.ToolStripMenuItem mntNew;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label lblWin1;
        private System.Windows.Forms.Label lblLose;
        private System.Windows.Forms.Label lblScore1;
        private System.Windows.Forms.Label lblWin2;
        private System.Windows.Forms.Label lblLose2;
        private System.Windows.Forms.Label lblScore2;
        private System.Windows.Forms.Label lblPlayer1F2;
        private System.Windows.Forms.Label lblPlayer2F2;
        private System.Windows.Forms.ToolStripMenuItem signToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem highScoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.SaveFileDialog savefileDlg;
        private System.Windows.Forms.OpenFileDialog openfileDlg;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
    }
}

