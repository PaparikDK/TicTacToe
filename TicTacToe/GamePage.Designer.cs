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
            this.lblWhoseQueue = new System.Windows.Forms.Label();
            this.pGameArea = new System.Windows.Forms.Panel();
            this.picBox_8 = new System.Windows.Forms.PictureBox();
            this.picBox_7 = new System.Windows.Forms.PictureBox();
            this.picBox_6 = new System.Windows.Forms.PictureBox();
            this.picBox_5 = new System.Windows.Forms.PictureBox();
            this.picBox_4 = new System.Windows.Forms.PictureBox();
            this.picBox_3 = new System.Windows.Forms.PictureBox();
            this.picBox_2 = new System.Windows.Forms.PictureBox();
            this.picBox_1 = new System.Windows.Forms.PictureBox();
            this.picBox_0 = new System.Windows.Forms.PictureBox();
            this.btnChangeTheme = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.picBoxZeroOrCross = new System.Windows.Forms.PictureBox();
            this.btnRestart = new System.Windows.Forms.Button();
            this.pGameArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxZeroOrCross)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWhoseQueue
            // 
            this.lblWhoseQueue.AutoSize = true;
            this.lblWhoseQueue.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWhoseQueue.ForeColor = System.Drawing.Color.White;
            this.lblWhoseQueue.Location = new System.Drawing.Point(382, 24);
            this.lblWhoseQueue.Name = "lblWhoseQueue";
            this.lblWhoseQueue.Size = new System.Drawing.Size(209, 32);
            this.lblWhoseQueue.TabIndex = 1;
            this.lblWhoseQueue.Text = "Сейчас ходит:";
            this.lblWhoseQueue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pGameArea
            // 
            this.pGameArea.BackColor = System.Drawing.Color.White;
            this.pGameArea.Controls.Add(this.picBox_8);
            this.pGameArea.Controls.Add(this.picBox_7);
            this.pGameArea.Controls.Add(this.picBox_6);
            this.pGameArea.Controls.Add(this.picBox_5);
            this.pGameArea.Controls.Add(this.picBox_4);
            this.pGameArea.Controls.Add(this.picBox_3);
            this.pGameArea.Controls.Add(this.picBox_2);
            this.pGameArea.Controls.Add(this.picBox_1);
            this.pGameArea.Controls.Add(this.picBox_0);
            this.pGameArea.Location = new System.Drawing.Point(88, 90);
            this.pGameArea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pGameArea.Name = "pGameArea";
            this.pGameArea.Size = new System.Drawing.Size(534, 458);
            this.pGameArea.TabIndex = 3;
            // 
            // picBox_8
            // 
            this.picBox_8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(56)))), ((int)(((byte)(82)))));
            this.picBox_8.Location = new System.Drawing.Point(359, 308);
            this.picBox_8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picBox_8.Name = "picBox_8";
            this.picBox_8.Size = new System.Drawing.Size(175, 150);
            this.picBox_8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_8.TabIndex = 8;
            this.picBox_8.TabStop = false;
            this.picBox_8.Click += new System.EventHandler(this.picBox_8_Click);
            // 
            // picBox_7
            // 
            this.picBox_7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(56)))), ((int)(((byte)(82)))));
            this.picBox_7.Location = new System.Drawing.Point(179, 308);
            this.picBox_7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picBox_7.Name = "picBox_7";
            this.picBox_7.Size = new System.Drawing.Size(175, 150);
            this.picBox_7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_7.TabIndex = 7;
            this.picBox_7.TabStop = false;
            this.picBox_7.Click += new System.EventHandler(this.picBox_7_Click);
            // 
            // picBox_6
            // 
            this.picBox_6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(56)))), ((int)(((byte)(82)))));
            this.picBox_6.Location = new System.Drawing.Point(0, 308);
            this.picBox_6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picBox_6.Name = "picBox_6";
            this.picBox_6.Size = new System.Drawing.Size(175, 150);
            this.picBox_6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_6.TabIndex = 6;
            this.picBox_6.TabStop = false;
            this.picBox_6.Click += new System.EventHandler(this.picBox_6_Click);
            // 
            // picBox_5
            // 
            this.picBox_5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(56)))), ((int)(((byte)(82)))));
            this.picBox_5.Location = new System.Drawing.Point(359, 154);
            this.picBox_5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picBox_5.Name = "picBox_5";
            this.picBox_5.Size = new System.Drawing.Size(175, 150);
            this.picBox_5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_5.TabIndex = 5;
            this.picBox_5.TabStop = false;
            this.picBox_5.Click += new System.EventHandler(this.picBox_5_Click);
            // 
            // picBox_4
            // 
            this.picBox_4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(56)))), ((int)(((byte)(82)))));
            this.picBox_4.Location = new System.Drawing.Point(179, 154);
            this.picBox_4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picBox_4.Name = "picBox_4";
            this.picBox_4.Size = new System.Drawing.Size(175, 150);
            this.picBox_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_4.TabIndex = 4;
            this.picBox_4.TabStop = false;
            this.picBox_4.Click += new System.EventHandler(this.picBox_4_Click);
            // 
            // picBox_3
            // 
            this.picBox_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(56)))), ((int)(((byte)(82)))));
            this.picBox_3.Location = new System.Drawing.Point(0, 154);
            this.picBox_3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picBox_3.Name = "picBox_3";
            this.picBox_3.Size = new System.Drawing.Size(175, 150);
            this.picBox_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_3.TabIndex = 3;
            this.picBox_3.TabStop = false;
            this.picBox_3.Click += new System.EventHandler(this.picBox_3_Click);
            // 
            // picBox_2
            // 
            this.picBox_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(56)))), ((int)(((byte)(82)))));
            this.picBox_2.Location = new System.Drawing.Point(359, 0);
            this.picBox_2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picBox_2.Name = "picBox_2";
            this.picBox_2.Size = new System.Drawing.Size(175, 150);
            this.picBox_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_2.TabIndex = 2;
            this.picBox_2.TabStop = false;
            this.picBox_2.Click += new System.EventHandler(this.picBox_2_Click);
            // 
            // picBox_1
            // 
            this.picBox_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(56)))), ((int)(((byte)(82)))));
            this.picBox_1.Location = new System.Drawing.Point(179, 0);
            this.picBox_1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picBox_1.Name = "picBox_1";
            this.picBox_1.Size = new System.Drawing.Size(175, 150);
            this.picBox_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_1.TabIndex = 1;
            this.picBox_1.TabStop = false;
            this.picBox_1.Click += new System.EventHandler(this.picBox_1_Click);
            // 
            // picBox_0
            // 
            this.picBox_0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(56)))), ((int)(((byte)(82)))));
            this.picBox_0.Location = new System.Drawing.Point(0, 0);
            this.picBox_0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picBox_0.MaximumSize = new System.Drawing.Size(175, 150);
            this.picBox_0.MinimumSize = new System.Drawing.Size(175, 150);
            this.picBox_0.Name = "picBox_0";
            this.picBox_0.Size = new System.Drawing.Size(175, 150);
            this.picBox_0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_0.TabIndex = 0;
            this.picBox_0.TabStop = false;
            this.picBox_0.Click += new System.EventHandler(this.picBox_0_Click);
            // 
            // btnChangeTheme
            // 
            this.btnChangeTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(229)))), ((int)(((byte)(220)))));
            this.btnChangeTheme.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.btnChangeTheme.FlatAppearance.BorderSize = 2;
            this.btnChangeTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeTheme.Location = new System.Drawing.Point(54, 9);
            this.btnChangeTheme.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChangeTheme.Name = "btnChangeTheme";
            this.btnChangeTheme.Size = new System.Drawing.Size(38, 38);
            this.btnChangeTheme.TabIndex = 8;
            this.btnChangeTheme.Text = "🌙";
            this.btnChangeTheme.UseVisualStyleBackColor = false;
            this.btnChangeTheme.Click += new System.EventHandler(this.btnChangeTheme_Click_1);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(229)))), ((int)(((byte)(220)))));
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.btnBack.FlatAppearance.BorderSize = 2;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.btnBack.Location = new System.Drawing.Point(10, 9);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(38, 38);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // picBoxZeroOrCross
            // 
            this.picBoxZeroOrCross.Location = new System.Drawing.Point(598, 9);
            this.picBoxZeroOrCross.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picBoxZeroOrCross.Name = "picBoxZeroOrCross";
            this.picBoxZeroOrCross.Size = new System.Drawing.Size(60, 60);
            this.picBoxZeroOrCross.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxZeroOrCross.TabIndex = 10;
            this.picBoxZeroOrCross.TabStop = false;
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(229)))), ((int)(((byte)(220)))));
            this.btnRestart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.btnRestart.FlatAppearance.BorderSize = 2;
            this.btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestart.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRestart.Location = new System.Drawing.Point(98, 9);
            this.btnRestart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(96, 38);
            this.btnRestart.TabIndex = 11;
            this.btnRestart.Text = "Заново";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // FormGamePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(56)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(686, 571);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.picBoxZeroOrCross);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnChangeTheme);
            this.Controls.Add(this.pGameArea);
            this.Controls.Add(this.lblWhoseQueue);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(702, 610);
            this.MinimumSize = new System.Drawing.Size(702, 610);
            this.Name = "FormGamePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "GamePage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormGamePage_FormClosing);
            this.pGameArea.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxZeroOrCross)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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