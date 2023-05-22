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
            this.lblGameRules = new System.Windows.Forms.Label();
            this.txtRules = new System.Windows.Forms.TextBox();
            this.btnChangeTheme = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGameRules
            // 
            this.lblGameRules.Font = new System.Drawing.Font("Consolas", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGameRules.ForeColor = System.Drawing.Color.White;
            this.lblGameRules.Location = new System.Drawing.Point(140, 45);
            this.lblGameRules.Name = "lblGameRules";
            this.lblGameRules.Size = new System.Drawing.Size(420, 60);
            this.lblGameRules.TabIndex = 0;
            this.lblGameRules.Text = "Правила игры";
            // 
            // txtRules
            // 
            this.txtRules.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(56)))), ((int)(((byte)(82)))));
            this.txtRules.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRules.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtRules.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRules.ForeColor = System.Drawing.Color.White;
            this.txtRules.Location = new System.Drawing.Point(0, 121);
            this.txtRules.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRules.Multiline = true;
            this.txtRules.Name = "txtRules";
            this.txtRules.ReadOnly = true;
            this.txtRules.Size = new System.Drawing.Size(686, 450);
            this.txtRules.TabIndex = 2;
            this.txtRules.TabStop = false;
            this.txtRules.Text = resources.GetString("txtRules.Text");
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
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // GameRules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(56)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(686, 571);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnChangeTheme);
            this.Controls.Add(this.txtRules);
            this.Controls.Add(this.lblGameRules);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(702, 610);
            this.MinimumSize = new System.Drawing.Size(702, 610);
            this.Name = "GameRules";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "GameRules";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameRules_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblGameRules;
        private TextBox txtRules;
        private Button btnChangeTheme;
        private Button btnBack;
    }
}