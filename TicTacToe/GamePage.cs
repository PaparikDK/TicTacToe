using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
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
        bool isCrossQueue = true; // переменная для теста картинок - можешь пользоваться ей даль

        // Пречисляемый тип с данными "хрэстик" и "нолик" чисто для души (1 и 0 слишком скучно)
        enum TypeOfPicture
        {
            None,
            Cross,
            Circle
        }
        // массив с признаками того, в какой клетке (по индексу) какой стоит значок - хрэстик или нолик.
        TypeOfPicture[] arrPictureOnPicBox = new TypeOfPicture[9];

        /// <summary>
        /// Создаём форму "Игра"
        /// </summary>
        /// <param name="menu"> СсылОчка на главную форму </param>
        public FormGamePage(FrmMainMenu menu)
        {
            InitializeComponent();
            this.menu = menu;
            picBoxZeroOrCross.Image = Properties.Resources.Cross;
        }

        // метод выводит очередь игрока
        void ChangeGamer(Image img)
        {
            picBoxZeroOrCross.Image = img;
        }

        // метод устанавливает знак в поле
        void SetPicture(int indexOfPicBox)
        {
            if (isCrossQueue)
            {
                //установили хрэстик
                listPicBoxFields.ElementAt(indexOfPicBox).Image = Properties.Resources.Cross;
                // в массиве типов значков на клетках под индексом данной клетки поставили метку
                // "хрэстик"
                arrPictureOnPicBox[indexOfPicBox] = TypeOfPicture.Cross;
                // очередь ноликов
                isCrossQueue = false;
                // устанавливаем нолик цвета в зависимости от темы
                if (isLightTheme)
                {
                    // изменили значок текущего хода
                    ChangeGamer(Properties.Resources.CircleBlack);
                }
                else
                {
                    ChangeGamer(Properties.Resources.CircleWhite);
                }
            }
            else if (!isCrossQueue)
            {
                if (isLightTheme)
                {
                    // установили в клетку кружочек тёмного цвета
                    listPicBoxFields.ElementAt(indexOfPicBox).Image = Properties.Resources.CircleBlack;
                }
                else
                {
                    // установили в клетку кружочек белого цвета
                    listPicBoxFields.ElementAt(indexOfPicBox).Image = Properties.Resources.CircleWhite;

                }
                // в массиве типов значков на клетках под индексом данной клетки поставили метку
                // "нолик"
                arrPictureOnPicBox[indexOfPicBox] = TypeOfPicture.Circle;
                // изменили значок текущего хода
                ChangeGamer(Properties.Resources.Cross);
                // очередь крестиков
                isCrossQueue = true;
            }
        }

        // сменить тему
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

        // меняем цвета кружочков
        void changeCirclesTheme()
        {
            // проходимся по всем клеткам игрового поля
            for (int i = 0; i < 9; i++)
            {
                // если в клетке стоит круг и тема сейчас светлая,
                // то меняем кружочки на белые (затем установится тёмная тема)
                if (arrPictureOnPicBox[i] == TypeOfPicture.Circle && isLightTheme)
                {
                    listPicBoxFields.ElementAt(i).Image = null;
                    listPicBoxFields.ElementAt(i).Image = Properties.Resources.CircleWhite;
                    picBoxZeroOrCross.Image = null;
                    picBoxZeroOrCross.Image = Properties.Resources.CircleWhite;
                }
                // если в клетке стоит круг и тема сейчас тёмная,
                // то меняем кружочки на чёрные (затем установится светлая тема)
                else if (arrPictureOnPicBox[i] == TypeOfPicture.Circle && !isLightTheme)
                {
                    listPicBoxFields.ElementAt(i).Image = null;
                    listPicBoxFields.ElementAt(i).Image = Properties.Resources.CircleBlack;
                    picBoxZeroOrCross.Image = null;
                    picBoxZeroOrCross.Image = Properties.Resources.CircleBlack;
                }
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
                btnRestart.BackColor = lightColorTheme;
                btnRestart.ForeColor = specialColorBlack;

                foreach (PictureBox picBox in pGameArea.Controls.OfType<PictureBox>())
                {
                    picBox.BackColor = darkColorTheme;
                }
                changeCirclesTheme();
            }
            else if (!isLightTheme)
            {
                BackColor = lightColorTheme;
                lblWhoseQueue.BackColor = lightColorTheme;
                lblWhoseQueue.ForeColor = specialColorBlack;
                pGameArea.BackColor = specialColorBlack;
                btnChangeTheme.BackColor = darkColorTheme;
                btnBack.BackColor = darkColorTheme;
                btnBack.ForeColor = lightColorTheme;
                btnRestart.BackColor = darkColorTheme;
                btnRestart.ForeColor = lightColorTheme;

                foreach (PictureBox picBox in pGameArea.Controls.OfType<PictureBox>())
                {
                    picBox.BackColor = lightColorTheme;
                }
                changeCirclesTheme();
            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            restartGame();
        }

        // рестарт игры
        private void restartGame()
        {
            // сейчас каждую игру начинают крестики - сделаете рандомно
            isCrossQueue = true;
            // устанавливаем значок в "Сейчас ходит:"
            if (isCrossQueue)
            {
                picBoxZeroOrCross.Image = Properties.Resources.Cross;
            }
            else if (!isCrossQueue && isLightTheme)
            {
                picBoxZeroOrCross.Image = Properties.Resources.CircleBlack;
            }
            else if (!isCrossQueue && !isLightTheme)
            {
                picBoxZeroOrCross.Image = Properties.Resources.CircleWhite;
            }

            // сбрасываем все клетки
            foreach (PictureBox picBox in listPicBoxFields)
            {
                // убираем символ
                picBox.Image = null;
                // делаем активным
                picBox.Enabled = true;
            }

            // очищаем массив
            for (int i = 0; i < 9; i++) 
            {
                arrPictureOnPicBox[i] = TypeOfPicture.None;
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
            menu.Show(this.Location);
        }

        // те самые поля для хрэстиков / ноликов
        private void picBox_1_1_Click(object sender, EventArgs e)
        {
            SetPicture(0);
            picBox_0.Enabled = false;
        }

        private void picBx_1_2_Click(object sender, EventArgs e)
        {
            SetPicture(1);
            picBox_1.Enabled = false;
        }

        private void picBox_1_3_Click(object sender, EventArgs e)
        {
            SetPicture(2);
            picBox_2.Enabled = false;
        }

        private void picBox_2_1_Click(object sender, EventArgs e)
        {
            SetPicture(3);
            picBox_3.Enabled = false;
        }

        private void picBox_2_2_Click(object sender, EventArgs e)
        {
            SetPicture(4);
            picBox_4.Enabled = false;
        }

        private void picBox_2_3_Click(object sender, EventArgs e)
        {
            SetPicture(5);
            picBox_5.Enabled = false;
        }

        private void picBox_3_1_Click(object sender, EventArgs e)
        {
            SetPicture(6);
            picBox_6.Enabled = false;
        }

        private void picBox_3_2_Click(object sender, EventArgs e)
        {
            SetPicture(7);
            picBox_7.Enabled = false;
        }

        private void picBox_3_3_Click(object sender, EventArgs e)
        {
            SetPicture(8);
            picBox_8.Enabled = false;
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

        public void Show(Point location)
        {
            this.Location = location;
            base.Show();
        }

        
    }
}