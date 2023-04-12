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
            this.lblZeroOrCross = new System.Windows.Forms.Label();
            this.pGameArea = new System.Windows.Forms.Panel();
            this.picBox_3_3 = new System.Windows.Forms.PictureBox();
            this.picBox_3_2 = new System.Windows.Forms.PictureBox();
            this.picBox_3_1 = new System.Windows.Forms.PictureBox();
            this.picBox_2_3 = new System.Windows.Forms.PictureBox();
            this.picBox_2_2 = new System.Windows.Forms.PictureBox();
            this.picBox_2_1 = new System.Windows.Forms.PictureBox();
            this.picBox_1_3 = new System.Windows.Forms.PictureBox();
            this.picBox_1_2 = new System.Windows.Forms.PictureBox();
            this.picBox_1_1 = new System.Windows.Forms.PictureBox();
            this.btnChangeTheme = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.pGameArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_3_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_3_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_3_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_2_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_2_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_2_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_1_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_1_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_1_1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWhoseQueue
            // 
            this.lblWhoseQueue.AutoSize = true;
            this.lblWhoseQueue.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWhoseQueue.ForeColor = System.Drawing.Color.White;
            this.lblWhoseQueue.Location = new System.Drawing.Point(413, 34);
            this.lblWhoseQueue.Name = "lblWhoseQueue";
            this.lblWhoseQueue.Size = new System.Drawing.Size(264, 40);
            this.lblWhoseQueue.TabIndex = 1;
            this.lblWhoseQueue.Text = "Сейчас ходит:";
            this.lblWhoseQueue.Click += new System.EventHandler(this.lblWhoseQueue_Click);
            // 
            // lblZeroOrCross
            // 
            this.lblZeroOrCross.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblZeroOrCross.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblZeroOrCross.Location = new System.Drawing.Point(683, 12);
            this.lblZeroOrCross.Name = "lblZeroOrCross";
            this.lblZeroOrCross.Size = new System.Drawing.Size(80, 80);
            this.lblZeroOrCross.TabIndex = 2;
            this.lblZeroOrCross.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblZeroOrCross.Click += new System.EventHandler(this.lblZeroOrCross_Click);
            // 
            // pGameArea
            // 
            this.pGameArea.BackColor = System.Drawing.Color.White;
            this.pGameArea.Controls.Add(this.picBox_3_3);
            this.pGameArea.Controls.Add(this.picBox_3_2);
            this.pGameArea.Controls.Add(this.picBox_3_1);
            this.pGameArea.Controls.Add(this.picBox_2_3);
            this.pGameArea.Controls.Add(this.picBox_2_2);
            this.pGameArea.Controls.Add(this.picBox_2_1);
            this.pGameArea.Controls.Add(this.picBox_1_3);
            this.pGameArea.Controls.Add(this.picBox_1_2);
            this.pGameArea.Controls.Add(this.picBox_1_1);
            this.pGameArea.Location = new System.Drawing.Point(100, 120);
            this.pGameArea.Name = "pGameArea";
            this.pGameArea.Size = new System.Drawing.Size(610, 610);
            this.pGameArea.TabIndex = 3;
            // 
            // picBox_3_3
            // 
            this.picBox_3_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(56)))), ((int)(((byte)(82)))));
            this.picBox_3_3.Location = new System.Drawing.Point(410, 410);
            this.picBox_3_3.Name = "picBox_3_3";
            this.picBox_3_3.Size = new System.Drawing.Size(200, 200);
            this.picBox_3_3.TabIndex = 8;
            this.picBox_3_3.TabStop = false;
            this.picBox_3_3.Click += new System.EventHandler(this.picBox_3_3_Click);
            // 
            // picBox_3_2
            // 
            this.picBox_3_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(56)))), ((int)(((byte)(82)))));
            this.picBox_3_2.Location = new System.Drawing.Point(205, 410);
            this.picBox_3_2.Name = "picBox_3_2";
            this.picBox_3_2.Size = new System.Drawing.Size(200, 200);
            this.picBox_3_2.TabIndex = 7;
            this.picBox_3_2.TabStop = false;
            this.picBox_3_2.Click += new System.EventHandler(this.picBox_3_2_Click);
            // 
            // picBox_3_1
            // 
            this.picBox_3_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(56)))), ((int)(((byte)(82)))));
            this.picBox_3_1.Location = new System.Drawing.Point(0, 410);
            this.picBox_3_1.Name = "picBox_3_1";
            this.picBox_3_1.Size = new System.Drawing.Size(200, 200);
            this.picBox_3_1.TabIndex = 6;
            this.picBox_3_1.TabStop = false;
            this.picBox_3_1.Click += new System.EventHandler(this.picBox_3_1_Click);
            // 
            // picBox_2_3
            // 
            this.picBox_2_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(56)))), ((int)(((byte)(82)))));
            this.picBox_2_3.Location = new System.Drawing.Point(410, 205);
            this.picBox_2_3.Name = "picBox_2_3";
            this.picBox_2_3.Size = new System.Drawing.Size(200, 200);
            this.picBox_2_3.TabIndex = 5;
            this.picBox_2_3.TabStop = false;
            this.picBox_2_3.Click += new System.EventHandler(this.picBox_2_3_Click);
            // 
            // picBox_2_2
            // 
            this.picBox_2_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(56)))), ((int)(((byte)(82)))));
            this.picBox_2_2.Location = new System.Drawing.Point(205, 205);
            this.picBox_2_2.Name = "picBox_2_2";
            this.picBox_2_2.Size = new System.Drawing.Size(200, 200);
            this.picBox_2_2.TabIndex = 4;
            this.picBox_2_2.TabStop = false;
            this.picBox_2_2.Click += new System.EventHandler(this.picBox_2_2_Click);
            // 
            // picBox_2_1
            // 
            this.picBox_2_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(56)))), ((int)(((byte)(82)))));
            this.picBox_2_1.Location = new System.Drawing.Point(0, 205);
            this.picBox_2_1.Name = "picBox_2_1";
            this.picBox_2_1.Size = new System.Drawing.Size(200, 200);
            this.picBox_2_1.TabIndex = 3;
            this.picBox_2_1.TabStop = false;
            this.picBox_2_1.Click += new System.EventHandler(this.picBox_2_1_Click);
            // 
            // picBox_1_3
            // 
            this.picBox_1_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(56)))), ((int)(((byte)(82)))));
            this.picBox_1_3.Location = new System.Drawing.Point(410, 0);
            this.picBox_1_3.Name = "picBox_1_3";
            this.picBox_1_3.Size = new System.Drawing.Size(200, 200);
            this.picBox_1_3.TabIndex = 2;
            this.picBox_1_3.TabStop = false;
            this.picBox_1_3.Click += new System.EventHandler(this.picBox_1_3_Click);
            // 
            // picBox_1_2
            // 
            this.picBox_1_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(56)))), ((int)(((byte)(82)))));
            this.picBox_1_2.Location = new System.Drawing.Point(205, 0);
            this.picBox_1_2.Name = "picBox_1_2";
            this.picBox_1_2.Size = new System.Drawing.Size(200, 200);
            this.picBox_1_2.TabIndex = 1;
            this.picBox_1_2.TabStop = false;
            this.picBox_1_2.Click += new System.EventHandler(this.picBx_1_2_Click);
            // 
            // picBox_1_1
            // 
            this.picBox_1_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(56)))), ((int)(((byte)(82)))));
            this.picBox_1_1.Location = new System.Drawing.Point(0, 0);
            this.picBox_1_1.Name = "picBox_1_1";
            this.picBox_1_1.Size = new System.Drawing.Size(200, 200);
            this.picBox_1_1.TabIndex = 0;
            this.picBox_1_1.TabStop = false;
            this.picBox_1_1.Click += new System.EventHandler(this.picBox_1_1_Click);
            // 
            // btnChangeTheme
            // 
            this.btnChangeTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(229)))), ((int)(((byte)(220)))));
            this.btnChangeTheme.FlatAppearance.BorderSize = 0;
            this.btnChangeTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeTheme.Location = new System.Drawing.Point(80, 12);
            this.btnChangeTheme.Name = "btnChangeTheme";
            this.btnChangeTheme.Size = new System.Drawing.Size(50, 50);
            this.btnChangeTheme.TabIndex = 8;
            this.btnChangeTheme.UseVisualStyleBackColor = false;
            this.btnChangeTheme.Click += new System.EventHandler(this.btnChangeTheme_Click_1);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(229)))), ((int)(((byte)(220)))));
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(50, 50);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FormGamePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(56)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(782, 753);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnChangeTheme);
            this.Controls.Add(this.pGameArea);
            this.Controls.Add(this.lblZeroOrCross);
            this.Controls.Add(this.lblWhoseQueue);
            this.MaximumSize = new System.Drawing.Size(800, 800);
            this.MinimumSize = new System.Drawing.Size(800, 800);
            this.Name = "FormGamePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GamePage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormGamePage_FormClosing);
            this.pGameArea.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_3_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_3_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_3_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_2_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_2_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_2_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_1_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_1_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_1_1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblWhoseQueue;
        private Label lblZeroOrCross;
        private Panel pGameArea;
        private PictureBox picBox_1_2;
        private PictureBox picBox_1_1;
        private PictureBox picBox_1_3;
        private PictureBox picBox_2_1;
        private PictureBox picBox_3_3;
        private PictureBox picBox_3_2;
        private PictureBox picBox_3_1;
        private PictureBox picBox_2_3;
        private PictureBox picBox_2_2;
        private Button btnChangeTheme;
        private Button btnBack;
    }
}