
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
            this.lblTictactoe = new System.Windows.Forms.Label();
            this.lblTictactoeRus = new System.Windows.Forms.Label();
            this.btn1Vs1Game = new System.Windows.Forms.Button();
            this.btn1VsBotGame = new System.Windows.Forms.Button();
            this.btnGameRules = new System.Windows.Forms.Button();
            this.lblSmallFontBottomPage = new System.Windows.Forms.Label();
            this.btnChangeTheme = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTictactoe
            // 
            this.lblTictactoe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTictactoe.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTictactoe.ForeColor = System.Drawing.Color.White;
            this.lblTictactoe.Location = new System.Drawing.Point(153, 52);
            this.lblTictactoe.Name = "lblTictactoe";
            this.lblTictactoe.Size = new System.Drawing.Size(394, 75);
            this.lblTictactoe.TabIndex = 0;
            this.lblTictactoe.Text = "TIC TAC TOE";
            this.lblTictactoe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTictactoeRus
            // 
            this.lblTictactoeRus.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTictactoeRus.ForeColor = System.Drawing.Color.White;
            this.lblTictactoeRus.Location = new System.Drawing.Point(254, 128);
            this.lblTictactoeRus.Name = "lblTictactoeRus";
            this.lblTictactoeRus.Size = new System.Drawing.Size(192, 30);
            this.lblTictactoeRus.TabIndex = 1;
            this.lblTictactoeRus.Text = "крестики-нолики";
            this.lblTictactoeRus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn1Vs1Game
            // 
            this.btn1Vs1Game.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(229)))), ((int)(((byte)(220)))));
            this.btn1Vs1Game.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.btn1Vs1Game.FlatAppearance.BorderSize = 2;
            this.btn1Vs1Game.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1Vs1Game.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn1Vs1Game.Location = new System.Drawing.Point(175, 188);
            this.btn1Vs1Game.Name = "btn1Vs1Game";
            this.btn1Vs1Game.Size = new System.Drawing.Size(350, 52);
            this.btn1Vs1Game.TabIndex = 2;
            this.btn1Vs1Game.Text = "1 VS 1";
            this.btn1Vs1Game.UseVisualStyleBackColor = false;
            this.btn1Vs1Game.Click += new System.EventHandler(this.btn1Vs1Game_Click);
            // 
            // btn1VsBotGame
            // 
            this.btn1VsBotGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(229)))), ((int)(((byte)(220)))));
            this.btn1VsBotGame.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.btn1VsBotGame.FlatAppearance.BorderSize = 2;
            this.btn1VsBotGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1VsBotGame.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn1VsBotGame.Location = new System.Drawing.Point(175, 255);
            this.btn1VsBotGame.Name = "btn1VsBotGame";
            this.btn1VsBotGame.Size = new System.Drawing.Size(350, 52);
            this.btn1VsBotGame.TabIndex = 3;
            this.btn1VsBotGame.Text = "1 VS БОТ";
            this.btn1VsBotGame.UseVisualStyleBackColor = false;
            this.btn1VsBotGame.Click += new System.EventHandler(this.btn1VsBotGame_Click);
            // 
            // btnGameRules
            // 
            this.btnGameRules.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(229)))), ((int)(((byte)(220)))));
            this.btnGameRules.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.btnGameRules.FlatAppearance.BorderSize = 2;
            this.btnGameRules.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGameRules.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGameRules.Location = new System.Drawing.Point(175, 323);
            this.btnGameRules.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGameRules.Name = "btnGameRules";
            this.btnGameRules.Size = new System.Drawing.Size(350, 38);
            this.btnGameRules.TabIndex = 4;
            this.btnGameRules.Text = "Правила игры";
            this.btnGameRules.UseVisualStyleBackColor = false;
            this.btnGameRules.Click += new System.EventHandler(this.btnGameRules_Click);
            // 
            // lblSmallFontBottomPage
            // 
            this.lblSmallFontBottomPage.AutoSize = true;
            this.lblSmallFontBottomPage.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSmallFontBottomPage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSmallFontBottomPage.Location = new System.Drawing.Point(10, 544);
            this.lblSmallFontBottomPage.Name = "lblSmallFontBottomPage";
            this.lblSmallFontBottomPage.Size = new System.Drawing.Size(301, 14);
            this.lblSmallFontBottomPage.TabIndex = 6;
            this.lblSmallFontBottomPage.Text = "Все права принадлежат компании NeVeReXiStS";
            // 
            // btnChangeTheme
            // 
            this.btnChangeTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(229)))), ((int)(((byte)(220)))));
            this.btnChangeTheme.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.btnChangeTheme.FlatAppearance.BorderSize = 2;
            this.btnChangeTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeTheme.Location = new System.Drawing.Point(637, 9);
            this.btnChangeTheme.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChangeTheme.Name = "btnChangeTheme";
            this.btnChangeTheme.Size = new System.Drawing.Size(38, 38);
            this.btnChangeTheme.TabIndex = 7;
            this.btnChangeTheme.Text = "🌙";
            this.btnChangeTheme.UseVisualStyleBackColor = false;
            this.btnChangeTheme.Click += new System.EventHandler(this.btnChangeTheme_Click);
            // 
            // FrmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(56)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(686, 571);
            this.Controls.Add(this.btnChangeTheme);
            this.Controls.Add(this.lblSmallFontBottomPage);
            this.Controls.Add(this.btnGameRules);
            this.Controls.Add(this.btn1VsBotGame);
            this.Controls.Add(this.btn1Vs1Game);
            this.Controls.Add(this.lblTictactoeRus);
            this.Controls.Add(this.lblTictactoe);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(702, 610);
            this.MinimumSize = new System.Drawing.Size(702, 610);
            this.Name = "FrmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TIC TAC TOE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTictactoe;
        private Label lblTictactoeRus;
        private Button btn1Vs1Game;
        private Button btn1VsBotGame;
        private Button btnGameRules;
        private Label lblSmallFontBottomPage;
        private Button btnChangeTheme;
    }
}