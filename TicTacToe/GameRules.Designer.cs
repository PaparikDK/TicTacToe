namespace TicTacToe
{
    partial class GameRules
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameRules));
            lblGameRules = new Label();
            txtRules = new TextBox();
            btnChangeTheme = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // lblGameRules
            // 
            lblGameRules.Font = new Font("Consolas", 40F, FontStyle.Regular, GraphicsUnit.Point);
            lblGameRules.ForeColor = Color.White;
            lblGameRules.Location = new Point(160, 60);
            lblGameRules.Name = "lblGameRules";
            lblGameRules.Size = new Size(480, 80);
            lblGameRules.TabIndex = 0;
            lblGameRules.Text = "Правила игры";
            // 
            // txtRules
            // 
            txtRules.BackColor = Color.FromArgb(45, 56, 82);
            txtRules.BorderStyle = BorderStyle.None;
            txtRules.Dock = DockStyle.Bottom;
            txtRules.Font = new Font("Consolas", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtRules.ForeColor = Color.White;
            txtRules.Location = new Point(0, 153);
            txtRules.Multiline = true;
            txtRules.Name = "txtRules";
            txtRules.ReadOnly = true;
            txtRules.Size = new Size(782, 600);
            txtRules.TabIndex = 2;
            txtRules.TabStop = false;
            txtRules.Text = resources.GetString("txtRules.Text");
            // 
            // btnChangeTheme
            // 
            btnChangeTheme.BackColor = Color.FromArgb(237, 229, 220);
            btnChangeTheme.FlatAppearance.BorderColor = Color.FromArgb(192, 89, 89);
            btnChangeTheme.FlatAppearance.BorderSize = 2;
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
            btnBack.FlatAppearance.BorderColor = Color.FromArgb(192, 89, 89);
            btnBack.FlatAppearance.BorderSize = 2;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Consolas", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnBack.ForeColor = Color.FromArgb(69, 69, 69);
            btnBack.Location = new Point(12, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(50, 50);
            btnBack.TabIndex = 10;
            btnBack.Text = "<";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // GameRules
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 56, 82);
            ClientSize = new Size(782, 753);
            Controls.Add(btnBack);
            Controls.Add(btnChangeTheme);
            Controls.Add(txtRules);
            Controls.Add(lblGameRules);
            MaximumSize = new Size(800, 800);
            MinimumSize = new Size(800, 800);
            Name = "GameRules";
            StartPosition = FormStartPosition.Manual;
            Text = "GameRules";
            FormClosing += GameRules_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblGameRules;
        private TextBox txtRules;
        private Button btnChangeTheme;
        private Button btnBack;
    }
}