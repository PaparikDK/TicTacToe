using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class FormGamePage : Form
    {
        // Не закатывай так глаза, я знаю, что ты думаешь
        FrmMainMenu menu;
        Color lightColorTheme = Color.FromArgb(237, 229, 220);
        Color darkColorTheme = Color.FromArgb(45, 56, 82);
        Color specialColorBlack = Color.FromArgb(69, 69, 69);        
        bool isLightTheme = Convert.ToBoolean(Properties.Resources.isLightTheme);
        /// <summary>
        /// Создаём форму "Игра"
        /// </summary>
        /// <param name="menu"> СсылОчка на главную форму </param>
        public FormGamePage(FrmMainMenu menu)
        {
            InitializeComponent();
            this.menu = menu;
            
        }

        void changeTheme()
        {
            changeFormTheme();
            menu.changeFormTheme();
            menu.rulesPage.changeFormTheme();
        }

        // Дежавю?
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

        // Тебе надо - сам и наследуй
        void SetTheme()
        {
            if (isLightTheme)
            {                
                BackColor = darkColorTheme;
                lblWhoseQueue.BackColor = darkColorTheme;
                lblWhoseQueue.ForeColor = Color.White;
                pGameArea.BackColor = Color.White;
                btnChangeTheme.BackColor = lightColorTheme;
                btnBack.BackColor = lightColorTheme;
                btnBack.ForeColor = specialColorBlack;

                foreach (PictureBox picBox in pGameArea.Controls.OfType<PictureBox>())
                {
                    picBox.BackColor = darkColorTheme;
                }
            }
            else if (!isLightTheme)
            {               
                BackColor = lightColorTheme;
                lblWhoseQueue.BackColor = lightColorTheme;
                lblWhoseQueue.ForeColor = specialColorBlack;
                pGameArea.BackColor = specialColorBlack;
                btnChangeTheme.BackColor = darkColorTheme;
                btnBack.BackColor = darkColorTheme;
                btnBack.ForeColor = Color.White;

                foreach (PictureBox picBox in pGameArea.Controls.OfType<PictureBox>())
                {
                    picBox.BackColor = lightColorTheme;
                }
            }
        }

        // натыркал куда угодно, поди разбери, что тут нужно, а что нет
        private void lblZeroOrCross_Click(object sender, EventArgs e)
        {
            
        }

        // повернутися до головного екрану
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu.Show();
        }

        // те самые поля для хрэстиков / ноликов
        private void picBox_1_1_Click(object sender, EventArgs e)
        {

        }

        private void picBx_1_2_Click(object sender, EventArgs e)
        {

        }

        private void picBox_1_3_Click(object sender, EventArgs e)
        {

        }

        private void picBox_2_1_Click(object sender, EventArgs e)
        {

        }

        private void picBox_2_2_Click(object sender, EventArgs e)
        {

        }

        private void picBox_2_3_Click(object sender, EventArgs e)
        {

        }

        private void picBox_3_1_Click(object sender, EventArgs e)
        {

        }

        private void picBox_3_2_Click(object sender, EventArgs e)
        {

        }

        private void picBox_3_3_Click(object sender, EventArgs e)
        {

        }

        // кнопка на случай, даже если в Крестики-нолики начинает бомбить пердак
        private void FormGamePage_FormClosing(object sender, FormClosingEventArgs e)
        {
            menu.Close();
        }
        
        private void lblWhoseQueue_Click(object sender, EventArgs e)
        {

        }

        // меняй
        private void btnChangeTheme_Click_1(object sender, EventArgs e)
        {
            changeTheme();
        }
    }
}