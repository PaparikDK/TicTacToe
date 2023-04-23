
namespace TicTacToe
{
    partial class FrmMainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTictactoe = new Label();
            lblTictactoeRus = new Label();
            btn1Vs1Game = new Button();
            btn1VsBotGame = new Button();
            btnGameRules = new Button();
            btnScores = new Button();
            lblSmallFontBottomPage = new Label();
            btnChangeTheme = new Button();
            SuspendLayout();
            // 
            // lblTictactoe
            // 
            lblTictactoe.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTictactoe.Font = new Font("Impact", 48F, FontStyle.Regular, GraphicsUnit.Point);
            lblTictactoe.ForeColor = Color.White;
            lblTictactoe.Location = new Point(175, 70);
            lblTictactoe.Name = "lblTictactoe";
            lblTictactoe.Size = new Size(450, 100);
            lblTictactoe.TabIndex = 0;
            lblTictactoe.Text = "TIC TAC TOE";
            lblTictactoe.TextAlign = ContentAlignment.MiddleCenter;
            lblTictactoe.Click += label1_Click;
            // 
            // lblTictactoeRus
            // 
            lblTictactoeRus.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblTictactoeRus.ForeColor = Color.White;
            lblTictactoeRus.Location = new Point(290, 170);
            lblTictactoeRus.Name = "lblTictactoeRus";
            lblTictactoeRus.Size = new Size(220, 40);
            lblTictactoeRus.TabIndex = 1;
            lblTictactoeRus.Text = "крестики-нолики";
            lblTictactoeRus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn1Vs1Game
            // 
            btn1Vs1Game.BackColor = Color.FromArgb(237, 229, 220);
            btn1Vs1Game.FlatAppearance.BorderColor = Color.FromArgb(192, 89, 89);
            btn1Vs1Game.FlatAppearance.BorderSize = 2;
            btn1Vs1Game.FlatStyle = FlatStyle.Flat;
            btn1Vs1Game.Font = new Font("Consolas", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            btn1Vs1Game.Location = new Point(200, 250);
            btn1Vs1Game.Margin = new Padding(3, 4, 3, 4);
            btn1Vs1Game.Name = "btn1Vs1Game";
            btn1Vs1Game.Size = new Size(400, 70);
            btn1Vs1Game.TabIndex = 2;
            btn1Vs1Game.Text = "1 VS 1";
            btn1Vs1Game.UseVisualStyleBackColor = false;
            btn1Vs1Game.Click += btn1Vs1Game_Click;
            // 
            // btn1VsBotGame
            // 
            btn1VsBotGame.BackColor = Color.FromArgb(237, 229, 220);
            btn1VsBotGame.FlatAppearance.BorderColor = Color.FromArgb(192, 89, 89);
            btn1VsBotGame.FlatAppearance.BorderSize = 2;
            btn1VsBotGame.FlatStyle = FlatStyle.Flat;
            btn1VsBotGame.Font = new Font("Consolas", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            btn1VsBotGame.Location = new Point(200, 340);
            btn1VsBotGame.Margin = new Padding(3, 4, 3, 4);
            btn1VsBotGame.Name = "btn1VsBotGame";
            btn1VsBotGame.Size = new Size(400, 70);
            btn1VsBotGame.TabIndex = 3;
            btn1VsBotGame.Text = "1 VS БОТ";
            btn1VsBotGame.UseVisualStyleBackColor = false;
            btn1VsBotGame.Click += btn1VsBotGame_Click;
            // 
            // btnGameRules
            // 
            btnGameRules.BackColor = Color.FromArgb(237, 229, 220);
            btnGameRules.FlatAppearance.BorderColor = Color.FromArgb(192, 89, 89);
            btnGameRules.FlatAppearance.BorderSize = 2;
            btnGameRules.FlatStyle = FlatStyle.Flat;
            btnGameRules.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnGameRules.Location = new Point(200, 431);
            btnGameRules.Name = "btnGameRules";
            btnGameRules.Size = new Size(190, 50);
            btnGameRules.TabIndex = 4;
            btnGameRules.Text = "Правила игры";
            btnGameRules.UseVisualStyleBackColor = false;
            btnGameRules.Click += btnGameRules_Click;
            // 
            // btnScores
            // 
            btnScores.BackColor = Color.FromArgb(237, 229, 220);
            btnScores.FlatAppearance.BorderColor = Color.FromArgb(192, 89, 89);
            btnScores.FlatAppearance.BorderSize = 2;
            btnScores.FlatStyle = FlatStyle.Flat;
            btnScores.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnScores.Location = new Point(410, 431);
            btnScores.Name = "btnScores";
            btnScores.Size = new Size(190, 50);
            btnScores.TabIndex = 5;
            btnScores.Text = "Достижения";
            btnScores.UseVisualStyleBackColor = false;
            btnScores.Click += btnScores_Click;
            // 
            // lblSmallFontBottomPage
            // 
            lblSmallFontBottomPage.AutoSize = true;
            lblSmallFontBottomPage.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblSmallFontBottomPage.ForeColor = SystemColors.ControlLightLight;
            lblSmallFontBottomPage.Location = new Point(12, 726);
            lblSmallFontBottomPage.Name = "lblSmallFontBottomPage";
            lblSmallFontBottomPage.Size = new Size(344, 18);
            lblSmallFontBottomPage.TabIndex = 6;
            lblSmallFontBottomPage.Text = "Все права принадлежат компании NeVeReXiStS";
            // 
            // btnChangeTheme
            // 
            btnChangeTheme.BackColor = Color.FromArgb(237, 229, 220);
            btnChangeTheme.FlatAppearance.BorderColor = Color.FromArgb(192, 89, 89);
            btnChangeTheme.FlatAppearance.BorderSize = 2;
            btnChangeTheme.FlatStyle = FlatStyle.Flat;
            btnChangeTheme.Location = new Point(720, 12);
            btnChangeTheme.Name = "btnChangeTheme";
            btnChangeTheme.Size = new Size(50, 50);
            btnChangeTheme.TabIndex = 7;
            btnChangeTheme.UseVisualStyleBackColor = false;
            btnChangeTheme.Click += btnChangeTheme_Click;
            // 
            // FrmMainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 56, 82);
            ClientSize = new Size(782, 753);
            Controls.Add(btnChangeTheme);
            Controls.Add(lblSmallFontBottomPage);
            Controls.Add(btnScores);
            Controls.Add(btnGameRules);
            Controls.Add(btn1VsBotGame);
            Controls.Add(btn1Vs1Game);
            Controls.Add(lblTictactoeRus);
            Controls.Add(lblTictactoe);
            MaximumSize = new Size(800, 800);
            MinimumSize = new Size(800, 800);
            Name = "FrmMainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TIC TAC TOE";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTictactoe;
        private Label lblTictactoeRus;
        private Button btn1Vs1Game;
        private Button btn1VsBotGame;
        private Button btnGameRules;
        private Button btnScores;
        private Label lblSmallFontBottomPage;
        private Button btnChangeTheme;
    }
}