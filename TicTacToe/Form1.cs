using System;
using System.Diagnostics;
using System.Drawing.Text;

namespace TicTacToe
{
    public partial class FrmMainMenu : Form
    {
        /*
         * Скажу сразу, что я проебался в начале с несколькими моментами, например, таким как унаследвовать
         * все формы от какого-нить асбтрактного класса с полями типа цветов, общими РЕАЛЬНО одинаковыми методами
         * и т. д. но как бы а что вы мне сделаете вы не знаете, где я живу :)
         */

        // создаю формы для игры и форму с правилами (позже добавим форму достижений) как поля
        internal FormGamePage gamePage;
        internal GameRules rulesPage;
        internal ScoresForm scoresPage;
        // заранее задал собственные цвета в виде переменных, чтобы быстрее было работать и легче понимать код
        Color lightColorTheme = Color.FromArgb(237, 229, 220);
        Color darkColorTheme = Color.FromArgb(45, 56, 82);
        Color specialColorBlack = Color.FromArgb(69, 69, 69);
        bool isLightTheme = Convert.ToBoolean(Properties.Resources.isLightTheme);
        /* Важный момент!
         * В потугах синхронизировать смену тем между формами я доебался до включения поля "isLightTheme" в файл Resources
         * (смотреть справа в обозревателе решений), но оттуда можно только читать, поентаму придётся делать текствый файл,
         * но я со спокойной душой спихиваю это на совесть Кирилла.
         * На данный момент поле isLightTheme инициализируется через этот прыжок с переподвыподвертом.
         */
        public FrmMainMenu() // конструктор (не Лего)
        {
            InitializeComponent();
            gamePage = new FormGamePage(this);
            rulesPage = new GameRules(this);
            scoresPage = new ScoresForm(this);
        }

        // эта херовина запускает смену тем во ВСЕХ формах
        public void changeTheme()
        {
            changeFormTheme();
            gamePage.changeFormTheme();
            rulesPage.changeFormTheme();
            scoresPage.changeFormTheme();
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

        // случайно клацнул, это не нужно
        private void label1_Click(object sender, EventArgs e)
        {

        }

        // открываем форму gamePage в режиме игры ИГРОК VS БОТ
        private void btn1VsBotGame_Click(object sender, EventArgs e)
        {
            gamePage.Show(this.Location);
            this.Hide();
        }

        // открываем форму gamePage в режиме игры ИГРОК VS ИГРОК 
        private void btn1Vs1Game_Click(object sender, EventArgs e)
        {
            gamePage.Show(this.Location);
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

        private void btnScores_Click(object sender, EventArgs e)
        {
            scoresPage.Show(this.Location);
            this.Hide();
        }
    }
}