using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;

namespace TicTacToe
{
    public partial class ScoresForm : Form
    {
        FrmMainMenu menu;
        Color lightColorTheme = Color.FromArgb(237, 229, 220);
        Color darkColorTheme = Color.FromArgb(45, 56, 82);
        Color specialColorBlack = Color.FromArgb(69, 69, 69);
        bool isLightTheme = Convert.ToBoolean(Properties.Resources.isLightTheme);
        /// <summary>
        /// Создаём форму "Игра"
        /// </summary>
        /// <param name="menu"> СсылОчка на главную форму </param>
        public ScoresForm(FrmMainMenu menu)
        {
            InitializeComponent();
            this.menu = menu;
        }

        public void Show(Point location)
        {
            this.Location = location;
            base.Show();
        }

        void changeTheme()
        {
            menu.changeTheme();
        }

        // Метод меняет значение поля для темы и вызывает метод смены темы
        public void changeFormTheme()
        {
            SetTheme();
            if (isLightTheme)
            {
                isLightTheme = false;
            }
            else if (!isLightTheme)
            {
                isLightTheme = true;
            }
        }

        // метод смены цвета на всех элементах формы
        void SetTheme()
        {
            if (isLightTheme)
            {
                BackColor = darkColorTheme;
                btnBack.ForeColor = lightColorTheme;
                lblScores.ForeColor = Color.White;
                lblScores.BackColor = darkColorTheme;
            }
            else if (!isLightTheme)
            {
                BackColor = lightColorTheme;
                btnBack.ForeColor = darkColorTheme;
                lblScores.ForeColor = specialColorBlack;
                lblScores.BackColor = lightColorTheme;
            }
            foreach (Button btn in Controls.OfType<Button>())
            {
                changeBtnsTheme(btn);
            }
            foreach (Panel pnl in Controls.OfType<Panel>())
            {
                changePanelsTheme(pnl);
            }
        }

        // изменяет тему каждой кномпки
        void changeBtnsTheme(Button btn)
        {
            if (isLightTheme)
            {
                btn.BackColor = lightColorTheme;
                btn.ForeColor = specialColorBlack;
            }
            else if (!isLightTheme)
            {
                btn.BackColor = darkColorTheme;
                btn.ForeColor = lightColorTheme;
            }
        }

        void changePanelsTheme(Panel pnl)
        {
            if (isLightTheme)
            {
                pnl.BackColor = darkColorTheme;
                foreach (Label lbl in pnl.Controls.OfType<Label>())
                {
                    lbl.ForeColor = Color.White;
                    lbl.BackColor = darkColorTheme;
                }
            }
            else if (!isLightTheme)
            {
                pnl.BackColor = lightColorTheme;
                foreach (Label lbl in pnl.Controls.OfType<Label>())
                {
                    lbl.ForeColor = specialColorBlack;
                    lbl.BackColor = lightColorTheme;
                }
            }
        }

        private void ScoresForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            menu.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu.Show(this.Location);
        }

        private void btnChangeTheme_Click(object sender, EventArgs e)
        {
            menu.changeTheme();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ScoresForm_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            menu.Close();
        }
    }
}
