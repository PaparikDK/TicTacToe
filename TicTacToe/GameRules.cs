using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class GameRules : Form
    {
        // ссылОчка на главную форму хранится здеся
        FrmMainMenu menu;

        // дадададдада, я знаю, что это можно было тупо наследовать, не учи деда кашлять
        Color lightColorTheme = Color.FromArgb(237, 229, 220);
        Color darkColorTheme = Color.FromArgb(45, 56, 82);
        Color specialColorBlack = Color.FromArgb(69, 69, 69);

        // прыжок с переподвыподвертом
        bool isLightTheme = Convert.ToBoolean(Properties.Resources.isLightTheme);

        /// <summary>
        /// Создаём форму "Правила игры"
        /// </summary>
        /// <param name="menu"> СсылОчка на главную форму </param>
        public GameRules(FrmMainMenu menu)
        {
            InitializeComponent();
            this.menu = menu;
        }

        void changeTheme()
        {
            changeFormTheme();
            menu.changeFormTheme();
            menu.gamePage.changeFormTheme();
        }

        // да, во всех трёх классах этот метод одинаков
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

        // меняем цвета всех элементов формы
        // Что? Можно было переопределить? Ла-ла-ла-ла-ла ничего не слышу
        void SetTheme()
        {            
            if (isLightTheme)
            {                
                BackColor = darkColorTheme;
                lblGameRules.BackColor = darkColorTheme;
                lblGameRules.ForeColor = Color.White;
                txtRules.BackColor = darkColorTheme;
                txtRules.ForeColor = Color.White;
                btnChangeTheme.BackColor = lightColorTheme;
                btnBack.BackColor = lightColorTheme;
                btnBack.ForeColor = specialColorBlack;
            }
            else if (!isLightTheme)
            {
                BackColor = lightColorTheme;
                lblGameRules.BackColor = lightColorTheme;
                lblGameRules.ForeColor = specialColorBlack;
                txtRules.BackColor = lightColorTheme;
                txtRules.ForeColor = specialColorBlack;
                btnChangeTheme.BackColor = darkColorTheme;
                btnBack.BackColor = darkColorTheme;
                btnBack.ForeColor = Color.White;
            }
        }

        // Скрываем форму с правилами, открываем главное меню (кнопка назад)
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu.Show();
        }

        // По нажатии на хрэстик в любой форме игра закрывается.
        // Скажем за это спасибо данному переопределённому методу.        
        private void GameRules_FormClosing(object sender, FormClosingEventArgs e)
        {
            menu.Close();
        }

        // угадай что? Меняем тему, умница
        private void btnChangeTheme_Click_1(object sender, EventArgs e)
        {
            changeTheme();            
        }       
    }
}
