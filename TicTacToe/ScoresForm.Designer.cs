namespace TicTacToe
{
    partial class ScoresForm
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
            lblScores = new Label();
            btnBack = new Button();
            btnChangeTheme = new Button();
            pScore1 = new Panel();
            lblScore1Text = new Label();
            lblScore1Title = new Label();
            pictureBox1 = new PictureBox();
            pScore2 = new Panel();
            lblScore2Text = new Label();
            lblScore2Titile = new Label();
            pictureBox2 = new PictureBox();
            pScore3 = new Panel();
            lblScore3Text = new Label();
            lblScore3Title = new Label();
            pictureBox3 = new PictureBox();
            pScore1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pScore2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            pScore3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // lblScores
            // 
            lblScores.Font = new Font("Consolas", 40.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblScores.ForeColor = Color.White;
            lblScores.Location = new Point(198, 60);
            lblScores.Name = "lblScores";
            lblScores.Size = new Size(404, 80);
            lblScores.TabIndex = 0;
            lblScores.Text = "Достижения";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(237, 229, 220);
            btnBack.FlatAppearance.BorderColor = Color.FromArgb(192, 89, 89);
            btnBack.FlatAppearance.BorderSize = 2;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Consolas", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnBack.ForeColor = Color.FromArgb(69, 69, 69);
            btnBack.Location = new Point(12, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(50, 50);
            btnBack.TabIndex = 11;
            btnBack.Text = "<";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnChangeTheme
            // 
            btnChangeTheme.BackColor = Color.FromArgb(237, 229, 220);
            btnChangeTheme.FlatAppearance.BorderColor = Color.FromArgb(192, 89, 89);
            btnChangeTheme.FlatAppearance.BorderSize = 2;
            btnChangeTheme.FlatStyle = FlatStyle.Flat;
            btnChangeTheme.Location = new Point(77, 12);
            btnChangeTheme.Name = "btnChangeTheme";
            btnChangeTheme.Size = new Size(50, 50);
            btnChangeTheme.TabIndex = 12;
            btnChangeTheme.UseVisualStyleBackColor = false;
            btnChangeTheme.Click += btnChangeTheme_Click;
            // 
            // pScore1
            // 
            pScore1.Controls.Add(lblScore1Text);
            pScore1.Controls.Add(lblScore1Title);
            pScore1.Controls.Add(pictureBox1);
            pScore1.Location = new Point(12, 152);
            pScore1.Name = "pScore1";
            pScore1.Size = new Size(758, 125);
            pScore1.TabIndex = 13;
            // 
            // lblScore1Text
            // 
            lblScore1Text.AutoSize = true;
            lblScore1Text.Font = new Font("Consolas", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblScore1Text.ForeColor = Color.White;
            lblScore1Text.Location = new Point(128, 70);
            lblScore1Text.Name = "lblScore1Text";
            lblScore1Text.Size = new Size(454, 28);
            lblScore1Text.TabIndex = 2;
            lblScore1Text.Text = "Выиграйте 100 игр, играя за нолики";
            // 
            // lblScore1Title
            // 
            lblScore1Title.AutoSize = true;
            lblScore1Title.Font = new Font("Consolas", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblScore1Title.ForeColor = Color.White;
            lblScore1Title.Location = new Point(306, 10);
            lblScore1Title.Name = "lblScore1Title";
            lblScore1Title.Size = new Size(264, 40);
            lblScore1Title.TabIndex = 1;
            lblScore1Title.Text = "\"Без палочки\"";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(119, 119);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pScore2
            // 
            pScore2.Controls.Add(lblScore2Text);
            pScore2.Controls.Add(lblScore2Titile);
            pScore2.Controls.Add(pictureBox2);
            pScore2.Location = new Point(12, 283);
            pScore2.Name = "pScore2";
            pScore2.Size = new Size(758, 125);
            pScore2.TabIndex = 14;
            // 
            // lblScore2Text
            // 
            lblScore2Text.AutoSize = true;
            lblScore2Text.Font = new Font("Consolas", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblScore2Text.ForeColor = Color.White;
            lblScore2Text.Location = new Point(128, 70);
            lblScore2Text.Name = "lblScore2Text";
            lblScore2Text.Size = new Size(480, 28);
            lblScore2Text.TabIndex = 2;
            lblScore2Text.Text = "Выиграйте 100 игр, играя за крестики";
            // 
            // lblScore2Titile
            // 
            lblScore2Titile.AutoSize = true;
            lblScore2Titile.Font = new Font("Consolas", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblScore2Titile.ForeColor = Color.White;
            lblScore2Titile.Location = new Point(259, 10);
            lblScore2Titile.Name = "lblScore2Titile";
            lblScore2Titile.Size = new Size(359, 40);
            lblScore2Titile.TabIndex = 1;
            lblScore2Titile.Text = "\"C божьей помощью\"";
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(3, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(119, 119);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // pScore3
            // 
            pScore3.Controls.Add(lblScore3Text);
            pScore3.Controls.Add(lblScore3Title);
            pScore3.Controls.Add(pictureBox3);
            pScore3.Location = new Point(12, 414);
            pScore3.Name = "pScore3";
            pScore3.Size = new Size(758, 125);
            pScore3.TabIndex = 15;
            // 
            // lblScore3Text
            // 
            lblScore3Text.AutoSize = true;
            lblScore3Text.Font = new Font("Consolas", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblScore3Text.ForeColor = Color.White;
            lblScore3Text.Location = new Point(128, 70);
            lblScore3Text.Name = "lblScore3Text";
            lblScore3Text.Size = new Size(532, 28);
            lblScore3Text.TabIndex = 2;
            lblScore3Text.Text = "Заполните всё поле символами одного типа";
            // 
            // lblScore3Title
            // 
            lblScore3Title.AutoSize = true;
            lblScore3Title.Font = new Font("Consolas", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblScore3Title.ForeColor = Color.White;
            lblScore3Title.Location = new Point(316, 10);
            lblScore3Title.Name = "lblScore3Title";
            lblScore3Title.Size = new Size(245, 40);
            lblScore3Title.TabIndex = 1;
            lblScore3Title.Text = "\"Датамайнер\"";
            lblScore3Title.Click += label3_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(3, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(119, 119);
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // ScoresForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 56, 82);
            ClientSize = new Size(782, 753);
            Controls.Add(pScore3);
            Controls.Add(pScore2);
            Controls.Add(pScore1);
            Controls.Add(btnChangeTheme);
            Controls.Add(btnBack);
            Controls.Add(lblScores);
            MaximumSize = new Size(800, 800);
            MinimumSize = new Size(800, 800);
            Name = "ScoresForm";
            StartPosition = FormStartPosition.Manual;
            Text = "ScoresForm";
            FormClosing += ScoresForm_FormClosing_1;
            pScore1.ResumeLayout(false);
            pScore1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pScore2.ResumeLayout(false);
            pScore2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            pScore3.ResumeLayout(false);
            pScore3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblScores;
        private Button btnBack;
        private Button btnChangeTheme;
        private Panel pScore1;
        private Label lblScore1Text;
        private Label lblScore1Title;
        private PictureBox pictureBox1;
        private Panel pScore2;
        private Label lblScore2Text;
        private Label lblScore2Titile;
        private PictureBox pictureBox2;
        private Panel pScore3;
        private Label lblScore3Text;
        private Label lblScore3Title;
        private PictureBox pictureBox3;
    }
}