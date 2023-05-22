using System;
using System.Diagnostics;
using System.Drawing.Text;

namespace TicTacToe
{
    public partial class FrmMainMenu : Form
    {
        // создаю формы для игры и форму с правилами (позже добавим форму достижений) как поля
        internal FormGamePage gamePage;
        internal GameRules rulesPage;

        // заранее задал собственные цвета в виде переменных, чтобы быстрее было работать и легче понимать код
        Color lightColorTheme = Color.FromArgb(237, 229, 220);
        Color darkColorTheme = Color.FromArgb(45, 56, 82);
        Color specialColorBlack = Color.FromArgb(69, 69, 69);
        bool isLightTheme = Convert.ToBoolean(Properties.Resources.isLightTheme);

        public FrmMainMenu() // конструктор (не Лего)
        {
            InitializeComponent();
            gamePage = new FormGamePage(this);
            rulesPage = new GameRules(this);
        }

        // запускает смену тем во ВСЕХ формах
        public void changeTheme()
        {
            changeFormTheme();
            gamePage.changeFormTheme();
            rulesPage.changeFormTheme();
        }

        // Метод меняет значение поля для темы и вызывает метод смены темы
        void changeFormTheme()
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
                lblSmallFontBottomPage.BackColor = darkColorTheme;
                lblSmallFontBottomPage.ForeColor = lightColorTheme;
                lblTictactoe.BackColor = darkColorTheme;
                lblTictactoe.ForeColor = lightColorTheme;
                lblTictactoeRus.BackColor = darkColorTheme;
                lblTictactoeRus.ForeColor = lightColorTheme;
                btnChangeTheme.BackColor = lightColorTheme;                                
            }
            else if (!isLightTheme)
            {
                BackColor = lightColorTheme;
                lblSmallFontBottomPage.BackColor = lightColorTheme;
                lblSmallFontBottomPage.ForeColor = darkColorTheme;
                lblTictactoe.BackColor = lightColorTheme;
                lblTictactoe.ForeColor = darkColorTheme;
                lblTictactoeRus.BackColor = lightColorTheme;
                lblTictactoeRus.ForeColor = darkColorTheme;
                btnChangeTheme.BackColor = darkColorTheme;                
            }
            foreach (Button btn in Controls.OfType<Button>())
            {
                changeBtnsTheme(btn);
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

        // открываем форму gamePage в режиме игры ИГРОК VS БОТ
        private void btn1VsBotGame_Click(object sender, EventArgs e)
        {
            gamePage.Show(this.Location);
            gamePage.isBot = true;
            gamePage.restartGame();
            this.Hide();
        }

        // открываем форму gamePage в режиме игры ИГРОК VS ИГРОК 
        private void btn1Vs1Game_Click(object sender, EventArgs e)
        {
            gamePage.Show(this.Location);
            gamePage.isBot = false;
            gamePage.restartGame();
            this.Hide();
        }

        // открываем форму с правилами игры
        private void btnGameRules_Click(object sender, EventArgs e)
        {
            rulesPage.Show(this.Location);
            this.Hide();
        }

        // меняем тему во всех формах        
        private void btnChangeTheme_Click(object sender, EventArgs e)
        {
            changeTheme();
        }

        public void Show(Point location)
        {
            this.Location = location;
            base.Show();
        }
    }
}