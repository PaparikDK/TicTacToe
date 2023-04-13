using System.Collections;

namespace TicTacToe
{
    partial class FormGamePage
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
            lblWhoseQueue = new Label();
            pGameArea = new Panel();
            picBox_8 = new PictureBox();
            picBox_7 = new PictureBox();
            picBox_6 = new PictureBox();
            picBox_5 = new PictureBox();
            picBox_4 = new PictureBox();
            picBox_3 = new PictureBox();
            picBox_2 = new PictureBox();
            picBox_1 = new PictureBox();
            picBox_0 = new PictureBox();
            btnChangeTheme = new Button();
            btnBack = new Button();
            picBoxZeroOrCross = new PictureBox();
            btnRestart = new Button();
            pGameArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBox_8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBox_7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBox_6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBox_5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBox_4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBox_3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBox_2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBox_1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBox_0).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxZeroOrCross).BeginInit();
            SuspendLayout();
            // 
            // lblWhoseQueue
            // 
            lblWhoseQueue.AutoSize = true;
            lblWhoseQueue.Font = new Font("Consolas", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblWhoseQueue.ForeColor = Color.White;
            lblWhoseQueue.Location = new Point(413, 34);
            lblWhoseQueue.Name = "lblWhoseQueue";
            lblWhoseQueue.Size = new Size(264, 40);
            lblWhoseQueue.TabIndex = 1;
            lblWhoseQueue.Text = "Сейчас ходит:";
            lblWhoseQueue.Click += lblWhoseQueue_Click;
            // 
            // pGameArea
            // 
            pGameArea.BackColor = Color.White;
            pGameArea.Controls.Add(picBox_8);
            pGameArea.Controls.Add(picBox_7);
            pGameArea.Controls.Add(picBox_6);
            pGameArea.Controls.Add(picBox_5);
            pGameArea.Controls.Add(picBox_4);
            pGameArea.Controls.Add(picBox_3);
            pGameArea.Controls.Add(picBox_2);
            pGameArea.Controls.Add(picBox_1);
            pGameArea.Controls.Add(picBox_0);
            pGameArea.Location = new Point(100, 120);
            pGameArea.Name = "pGameArea";
            pGameArea.Size = new Size(610, 610);
            pGameArea.TabIndex = 3;
            // 
            // picBox_8
            // 
            picBox_8.BackColor = Color.FromArgb(45, 56, 82);
            picBox_8.Location = new Point(410, 410);
            picBox_8.Name = "picBox_8";
            picBox_8.Size = new Size(200, 200);
            picBox_8.SizeMode = PictureBoxSizeMode.CenterImage;
            picBox_8.TabIndex = 8;
            picBox_8.TabStop = false;
            picBox_8.Click += picBox_3_3_Click;
            // 
            // picBox_7
            // 
            picBox_7.BackColor = Color.FromArgb(45, 56, 82);
            picBox_7.Location = new Point(205, 410);
            picBox_7.Name = "picBox_7";
            picBox_7.Size = new Size(200, 200);
            picBox_7.SizeMode = PictureBoxSizeMode.CenterImage;
            picBox_7.TabIndex = 7;
            picBox_7.TabStop = false;
            picBox_7.Click += picBox_3_2_Click;
            // 
            // picBox_6
            // 
            picBox_6.BackColor = Color.FromArgb(45, 56, 82);
            picBox_6.Location = new Point(0, 410);
            picBox_6.Name = "picBox_6";
            picBox_6.Size = new Size(200, 200);
            picBox_6.SizeMode = PictureBoxSizeMode.CenterImage;
            picBox_6.TabIndex = 6;
            picBox_6.TabStop = false;
            picBox_6.Click += picBox_3_1_Click;
            // 
            // picBox_5
            // 
            picBox_5.BackColor = Color.FromArgb(45, 56, 82);
            picBox_5.Location = new Point(410, 205);
            picBox_5.Name = "picBox_5";
            picBox_5.Size = new Size(200, 200);
            picBox_5.SizeMode = PictureBoxSizeMode.CenterImage;
            picBox_5.TabIndex = 5;
            picBox_5.TabStop = false;
            picBox_5.Click += picBox_2_3_Click;
            // 
            // picBox_4
            // 
            picBox_4.BackColor = Color.FromArgb(45, 56, 82);
            picBox_4.Location = new Point(205, 205);
            picBox_4.Name = "picBox_4";
            picBox_4.Size = new Size(200, 200);
            picBox_4.SizeMode = PictureBoxSizeMode.CenterImage;
            picBox_4.TabIndex = 4;
            picBox_4.TabStop = false;
            picBox_4.Click += picBox_2_2_Click;
            // 
            // picBox_3
            // 
            picBox_3.BackColor = Color.FromArgb(45, 56, 82);
            picBox_3.Location = new Point(0, 205);
            picBox_3.Name = "picBox_3";
            picBox_3.Size = new Size(200, 200);
            picBox_3.SizeMode = PictureBoxSizeMode.CenterImage;
            picBox_3.TabIndex = 3;
            picBox_3.TabStop = false;
            picBox_3.Click += picBox_2_1_Click;
            // 
            // picBox_2
            // 
            picBox_2.BackColor = Color.FromArgb(45, 56, 82);
            picBox_2.Location = new Point(410, 0);
            picBox_2.Name = "picBox_2";
            picBox_2.Size = new Size(200, 200);
            picBox_2.SizeMode = PictureBoxSizeMode.CenterImage;
            picBox_2.TabIndex = 2;
            picBox_2.TabStop = false;
            picBox_2.Click += picBox_1_3_Click;
            // 
            // picBox_1
            // 
            picBox_1.BackColor = Color.FromArgb(45, 56, 82);
            picBox_1.Location = new Point(205, 0);
            picBox_1.Name = "picBox_1";
            picBox_1.Size = new Size(200, 200);
            picBox_1.SizeMode = PictureBoxSizeMode.CenterImage;
            picBox_1.TabIndex = 1;
            picBox_1.TabStop = false;
            picBox_1.Click += picBx_1_2_Click;
            // 
            // picBox_0
            // 
            picBox_0.BackColor = Color.FromArgb(45, 56, 82);
            picBox_0.Location = new Point(0, 0);
            picBox_0.MaximumSize = new Size(200, 200);
            picBox_0.MinimumSize = new Size(200, 200);
            picBox_0.Name = "picBox_0";
            picBox_0.Size = new Size(200, 200);
            picBox_0.SizeMode = PictureBoxSizeMode.CenterImage;
            picBox_0.TabIndex = 0;
            picBox_0.TabStop = false;
            picBox_0.Click += picBox_1_1_Click;
            // 
            // btnChangeTheme
            // 
            btnChangeTheme.BackColor = Color.FromArgb(237, 229, 220);
            btnChangeTheme.FlatAppearance.BorderSize = 0;
            btnChangeTheme.FlatStyle = FlatStyle.Flat;
            btnChangeTheme.Location = new Point(80, 12);
            btnChangeTheme.Name = "btnChangeTheme";
            btnChangeTheme.Size = new Size(50, 50);
            btnChangeTheme.TabIndex = 8;
            btnChangeTheme.UseVisualStyleBackColor = false;
            btnChangeTheme.Click += btnChangeTheme_Click_1;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(237, 229, 220);
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Consolas", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnBack.ForeColor = Color.FromArgb(69, 69, 69);
            btnBack.Location = new Point(12, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(50, 50);
            btnBack.TabIndex = 9;
            btnBack.Text = "<";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // picBoxZeroOrCross
            // 
            picBoxZeroOrCross.Location = new Point(683, 12);
            picBoxZeroOrCross.Name = "picBoxZeroOrCross";
            picBoxZeroOrCross.Size = new Size(80, 80);
            picBoxZeroOrCross.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxZeroOrCross.TabIndex = 10;
            picBoxZeroOrCross.TabStop = false;
            // 
            // btnRestart
            // 
            btnRestart.BackColor = Color.FromArgb(237, 229, 220);
            btnRestart.FlatAppearance.BorderSize = 0;
            btnRestart.FlatStyle = FlatStyle.Flat;
            btnRestart.Font = new Font("Consolas", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnRestart.Location = new Point(150, 12);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(108, 50);
            btnRestart.TabIndex = 11;
            btnRestart.Text = "Заново";
            btnRestart.UseVisualStyleBackColor = false;
            btnRestart.Click += btnRestart_Click;
            // 
            // FormGamePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 56, 82);
            ClientSize = new Size(782, 753);
            Controls.Add(btnRestart);
            Controls.Add(picBoxZeroOrCross);
            Controls.Add(btnBack);
            Controls.Add(btnChangeTheme);
            Controls.Add(pGameArea);
            Controls.Add(lblWhoseQueue);
            MaximumSize = new Size(800, 800);
            MinimumSize = new Size(800, 800);
            Name = "FormGamePage";
            StartPosition = FormStartPosition.Manual;
            Text = "GamePage";
            FormClosing += FormGamePage_FormClosing;
            pGameArea.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picBox_8).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBox_7).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBox_6).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBox_5).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBox_4).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBox_3).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBox_2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBox_1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBox_0).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxZeroOrCross).EndInit();
            ResumeLayout(false);
            PerformLayout();

            listPicBoxFields.Add(picBox_0);
            listPicBoxFields.Add(picBox_1);
            listPicBoxFields.Add(picBox_2);
            listPicBoxFields.Add(picBox_3);
            listPicBoxFields.Add(picBox_4);
            listPicBoxFields.Add(picBox_5);
            listPicBoxFields.Add(picBox_6);
            listPicBoxFields.Add(picBox_7);
            listPicBoxFields.Add(picBox_8);
        }

        // список наших pcitureBoxов, чтобы иметь возможность обращаться по индексу
        List<PictureBox> listPicBoxFields = new List<PictureBox>(9);
        #endregion
        private Label lblWhoseQueue;
        private Panel pGameArea;
        private PictureBox picBox_1;
        private PictureBox picBox_0;
        private PictureBox picBox_2;
        private PictureBox picBox_3;
        private PictureBox picBox_8;
        private PictureBox picBox_7;
        private PictureBox picBox_6;
        private PictureBox picBox_5;
        private PictureBox picBox_4;
        private Button btnChangeTheme;
        private Button btnBack;
        private PictureBox picBoxZeroOrCross;
        private Button btnRestart;
    }
}