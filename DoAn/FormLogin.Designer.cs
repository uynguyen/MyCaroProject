namespace DoAn
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.lblPlayer1F1 = new System.Windows.Forms.Label();
            this.lblFlayer2F1 = new System.Windows.Forms.Label();
            this.cmbNamePlayer1 = new System.Windows.Forms.ComboBox();
            this.cmbNamePlayer2 = new System.Windows.Forms.ComboBox();
            this.btnStartF1 = new System.Windows.Forms.Button();
            this.rdbOption = new System.Windows.Forms.RadioButton();
            this.rdbOption2 = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPlayer1F1
            // 
            this.lblPlayer1F1.BackColor = System.Drawing.SystemColors.Info;
            this.lblPlayer1F1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPlayer1F1.Font = new System.Drawing.Font("Mistral", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1F1.ForeColor = System.Drawing.Color.Red;
            this.lblPlayer1F1.Location = new System.Drawing.Point(108, 272);
            this.lblPlayer1F1.Name = "lblPlayer1F1";
            this.lblPlayer1F1.Size = new System.Drawing.Size(194, 44);
            this.lblPlayer1F1.TabIndex = 0;
            this.lblPlayer1F1.Text = "Player1 (X):";
            // 
            // lblFlayer2F1
            // 
            this.lblFlayer2F1.BackColor = System.Drawing.SystemColors.Window;
            this.lblFlayer2F1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFlayer2F1.Font = new System.Drawing.Font("Mistral", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlayer2F1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblFlayer2F1.Location = new System.Drawing.Point(602, 271);
            this.lblFlayer2F1.Name = "lblFlayer2F1";
            this.lblFlayer2F1.Size = new System.Drawing.Size(194, 45);
            this.lblFlayer2F1.TabIndex = 0;
            this.lblFlayer2F1.Text = "Player2 (O):";
            // 
            // cmbNamePlayer1
            // 
            this.cmbNamePlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNamePlayer1.FormattingEnabled = true;
            this.cmbNamePlayer1.Location = new System.Drawing.Point(73, 338);
            this.cmbNamePlayer1.Name = "cmbNamePlayer1";
            this.cmbNamePlayer1.Size = new System.Drawing.Size(279, 33);
            this.cmbNamePlayer1.Sorted = true;
            this.cmbNamePlayer1.TabIndex = 4;
            // 
            // cmbNamePlayer2
            // 
            this.cmbNamePlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNamePlayer2.FormattingEnabled = true;
            this.cmbNamePlayer2.Location = new System.Drawing.Point(556, 338);
            this.cmbNamePlayer2.Name = "cmbNamePlayer2";
            this.cmbNamePlayer2.Size = new System.Drawing.Size(279, 33);
            this.cmbNamePlayer2.Sorted = true;
            this.cmbNamePlayer2.TabIndex = 4;
            // 
            // btnStartF1
            // 
            this.btnStartF1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnStartF1.BackColor = System.Drawing.SystemColors.Info;
            this.btnStartF1.Font = new System.Drawing.Font("Mistral", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartF1.Location = new System.Drawing.Point(380, 132);
            this.btnStartF1.Name = "btnStartF1";
            this.btnStartF1.Size = new System.Drawing.Size(144, 68);
            this.btnStartF1.TabIndex = 1;
            this.btnStartF1.Text = "Vs";
            this.btnStartF1.UseVisualStyleBackColor = false;
            this.btnStartF1.Click += new System.EventHandler(this.btnStartF1_Click);
            // 
            // rdbOption
            // 
            this.rdbOption.AutoSize = true;
            this.rdbOption.BackColor = System.Drawing.SystemColors.Info;
            this.rdbOption.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbOption.Location = new System.Drawing.Point(249, 417);
            this.rdbOption.Name = "rdbOption";
            this.rdbOption.Size = new System.Drawing.Size(183, 30);
            this.rdbOption.TabIndex = 5;
            this.rdbOption.TabStop = true;
            this.rdbOption.Text = "Player1_Vs_Computer";
            this.rdbOption.UseVisualStyleBackColor = false;
            this.rdbOption.CheckedChanged += new System.EventHandler(this.rdbOption_CheckedChanged);
            // 
            // rdbOption2
            // 
            this.rdbOption2.AutoSize = true;
            this.rdbOption2.BackColor = System.Drawing.SystemColors.Info;
            this.rdbOption2.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbOption2.Location = new System.Drawing.Point(59, 417);
            this.rdbOption2.Name = "rdbOption2";
            this.rdbOption2.Size = new System.Drawing.Size(171, 30);
            this.rdbOption2.TabIndex = 5;
            this.rdbOption2.TabStop = true;
            this.rdbOption2.Text = "Player1_Vs_Player2";
            this.rdbOption2.UseVisualStyleBackColor = false;
            this.rdbOption2.CheckedChanged += new System.EventHandler(this.rdbOption2_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(108, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 244);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(602, 33);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(194, 235);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(896, 473);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.rdbOption2);
            this.Controls.Add(this.rdbOption);
            this.Controls.Add(this.cmbNamePlayer2);
            this.Controls.Add(this.cmbNamePlayer1);
            this.Controls.Add(this.btnStartF1);
            this.Controls.Add(this.lblFlayer2F1);
            this.Controls.Add(this.lblPlayer1F1);
            this.MaximizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginGame";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlayer1F1;
        private System.Windows.Forms.Label lblFlayer2F1;
        private System.Windows.Forms.Button btnStartF1;
        private System.Windows.Forms.ComboBox cmbNamePlayer1;
        private System.Windows.Forms.ComboBox cmbNamePlayer2;
        private System.Windows.Forms.RadioButton rdbOption;
        private System.Windows.Forms.RadioButton rdbOption2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}