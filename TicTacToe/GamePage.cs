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

        // Переменные для бота
        public bool isBot = false;

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
            // Лапками добавляем пикБоксы в листПикБоксФиелдс, энд ес, ай эм фром Лондон литтл бит
            listPicBoxFields.Add(picBox_0);
            listPicBoxFields.Add(picBox_1);
            listPicBoxFields.Add(picBox_2);
            listPicBoxFields.Add(picBox_3);
            listPicBoxFields.Add(picBox_4);
            listPicBoxFields.Add(picBox_5);
            listPicBoxFields.Add(picBox_6);
            listPicBoxFields.Add(picBox_7);
            listPicBoxFields.Add(picBox_8);
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
                if (isLightTheme && isBot == false)
                {
                    // изменили значок текущего хода
                    ChangeGamer(Properties.Resources.CircleBlack);
                }
                else if (isBot == false && isBot == false)
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
            menu.changeTheme();            
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
        public void restartGame()
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

            // очистка логической части
            stroke_Couter = 0;
            Array.Clear(recorded_choice, 0, 9);
        }

        // повернутися до головного екрану
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu.Show(this.Location);
        }

        // те самые поля для хрэстиков / ноликов
        private void picBox_0_Click(object sender, EventArgs e)
        {
            SetPicture(0);
            picBox_0.Enabled = false;
            stroke_Couter++;
            choiceRecord(0);

            if (isBot == true)
                bot_input(stroke_Couter, recorded_choice);

        }

        private void picBox_1_Click(object sender, EventArgs e)
        {
            SetPicture(1);
            picBox_1.Enabled = false;
            stroke_Couter++;
            choiceRecord(1);

            if (isBot == true)
                bot_input(stroke_Couter, recorded_choice);
        }

        private void picBox_2_Click(object sender, EventArgs e)
        {
            SetPicture(2);
            picBox_2.Enabled = false;
            stroke_Couter++;
            choiceRecord(2);

            if (isBot == true)
                bot_input(stroke_Couter, recorded_choice);
        }

        private void picBox_3_Click(object sender, EventArgs e)
        {
            SetPicture(3);
            picBox_3.Enabled = false;
            stroke_Couter++;
            choiceRecord(3);

            if (isBot == true)
                bot_input(stroke_Couter, recorded_choice);
        }

        private void picBox_4_Click(object sender, EventArgs e)
        {
            SetPicture(4);
            picBox_4.Enabled = false;
            stroke_Couter++;
            choiceRecord(4);

            if (isBot == true)
                bot_input(stroke_Couter, recorded_choice);
        }

        private void picBox_5_Click(object sender, EventArgs e)
        {
            SetPicture(5);
            picBox_5.Enabled = false;
            stroke_Couter++;
            choiceRecord(5);

            if (isBot == true)
                bot_input(stroke_Couter, recorded_choice);
        }

        private void picBox_6_Click(object sender, EventArgs e)
        {
            SetPicture(6);
            picBox_6.Enabled = false;
            stroke_Couter++;
            choiceRecord(6);

            if (isBot == true)
                bot_input(stroke_Couter, recorded_choice);
        }

        private void picBox_7_Click(object sender, EventArgs e)
        {
            SetPicture(7);
            picBox_7.Enabled = false;
            stroke_Couter++;
            choiceRecord(7);

            if (isBot == true)
                bot_input(stroke_Couter, recorded_choice);
        }

        private void picBox_8_Click(object sender, EventArgs e)
        {
            SetPicture(8);
            picBox_8.Enabled = false;
            stroke_Couter++;
            choiceRecord(8);

            if (isBot == true)
                bot_input(stroke_Couter, recorded_choice);
        }

        // кнопка перезапуска
        private void FormGamePage_FormClosing(object sender, FormClosingEventArgs e)
        {
            menu.Close();
        }

        // меняем тему
        private void btnChangeTheme_Click_1(object sender, EventArgs e)
        {
            changeTheme();
        }

        public void Show(Point location)
        {
            this.Location = location;
            base.Show();
        }

        public static int stroke_Couter; //Счётчик ходов, исходя из которого записывается крестик либо нолик

        int[] recorded_choice = new int[9]; // Массив для записи выбора позиции хрэстика/нолика

        public void choiceRecord(int choice) //Запись выбора позиции хрэстика/нолика в массив
        {
            if (stroke_Couter % 2 == 0)
                recorded_choice[choice] = 2; // 2 - нолик
            else
                recorded_choice[choice] = 1; // 1 - хрэстик

            int is_win = win_check(recorded_choice);

            if (is_win == 1) //Вывод результата
            {
                MessageBox.Show("Победа крестиков", "Результат", MessageBoxButtons.OK);
                stroke_Couter = 0;
                Array.Clear(recorded_choice, 0, 9);
                restartGame();
            }
            else
            if (is_win == 2)
            {
                MessageBox.Show("Победа ноликов", "Результат", MessageBoxButtons.OK);
                stroke_Couter = 0;
                Array.Clear(recorded_choice, 0, 9);
                restartGame();
            }
            if (stroke_Couter == 9 && is_win == 0)
            {
                MessageBox.Show("Ничья", "Результат", MessageBoxButtons.OK);
                stroke_Couter = 0;
                Array.Clear(recorded_choice, 0, 9);
                restartGame();
            }
        }
        public static int win_check(int[] pole)
        {
            //Проверка по диагонали
            for (int i = 0; i < 5; i += 2)
            {
                if (((i != 4) && pole[4] == 1 && pole[i] == 1 && pole[8 - i] == 1))
                {
                    return 1; //win хрэстик
                }

                if (((i != 4) && pole[4] == 2 && pole[i] == 2 && pole[8 - i] == 2))
                {
                    return 2; //win нолик
                }
            }

            //Проверка по горизонтали
            for (int i = 0; i < 8; i += 3)
            {
                if ((pole[i] == 1 && pole[i + 1] == 1 && pole[i + 2] == 1))
                {
                    return 1;
                }

                if ((pole[i] == 2 && pole[i + 1] == 2 && pole[i + 2] == 2))
                {
                    return 2;
                }
            }

            //Проверка по вертикали
            for (int i = 0; i < 3; i += 1)
            {
                if ((pole[i] == 1 && pole[i + 3] == 1 && pole[i + 6] == 1))
                {
                    return 1;
                }

                if ((pole[i] == 2 && pole[i + 3] == 2 && pole[i + 6] == 2))
                {
                    return 2;
                }
            }

            return 0; //никто не win
        }

        static int bot_random(int[] pole)  //Получаем радномное число
        {
            Random rnd = new Random();
            int rnd1 = -1;

            do
            {
                rnd1 = rnd.Next(0, 8);
            } while (pole[rnd1] != 0);

            return rnd1;
        }

        public void bot_input(int hod, int[] pole1)    //Вставляем значение
        {
            int temp = bot_check(hod, pole1);

            System.Threading.Thread.Sleep(300);
            SetPicture(temp);
            listPicBoxFields[temp].Enabled = false;
            stroke_Couter++;
            choiceRecord(temp);
        }

        static int bot_check(int hod, int[] pole1)  //Проверка комбинаций
        {
            int[] pole = pole1;
            int i = 0;

            if (hod != 1)
            {
                //Проверка по диагонали для O
                for (i = 0; i < 9; i += 2)
                {
                    if ((i != 4) && pole[4] == 2 && pole[i] == 2 && pole[8 - i] == 0)
                    {
                        return (8 - i);
                    }
                }

                //Проверка по горизонтали для О
                for (i = 0; i < 8; i += 3)
                {
                    if ((pole[i] == 2 && pole[i + 1] == 2 && pole[i + 2] == 0))
                    {
                        return (i + 2);
                    }

                    if ((pole[i + 1] == 2 && pole[i + 2] == 2 && pole[i] == 0))
                    {
                        return i;
                    }

                    if ((pole[i] == 2 && pole[i + 2] == 2 && pole[i + 1] == 0))
                    {
                        return (i + 1);
                    }
                }

                //Проверка по вертикали для O
                for (i = 0; i < 3; i += 1)
                {
                    if ((pole[i] == 2 && pole[i + 3] == 2 && pole[i + 6] == 0))
                    {
                        return (i + 6);
                    }

                    if ((pole[i + 3] == 2 && pole[i + 6] == 2 && pole[i] == 0))
                    {
                        return i;
                    }

                    if ((pole[i] == 2 && pole[i + 6] == 2 && pole[i + 3] == 0))
                    {
                        return (i + 3);
                    }
                }

                //Проверка по диагонали для Х
                for (i = 0; i < 9; i += 2)
                {
                    if (((i != 4) && pole[4] == 1 && pole[i] == 1 && pole[8 - i] == 0)) //x - по диагонали
                    {
                        return (8 - i);
                    }
                }

                //Проверка по горизонтали для X
                for (i = 0; i < 8; i += 3)
                {
                    if ((pole[i] == 1 && pole[i + 1] == 1 && pole[i + 2] == 0))
                    {
                        return (i + 2);
                    }

                    if ((pole[i + 1] == 1 && pole[i + 2] == 1 && pole[i] == 0))
                    {
                        return i;
                    }

                    if ((pole[i] == 1 && pole[i + 2] == 1 && pole[i + 1] == 0))
                    {
                        return (i + 1);
                    }
                }

                //Проверка по вертикали для X
                for (i = 0; i < 3; i += 1)
                {
                    if ((pole[i] == 1 && pole[i + 3] == 1 && pole[i + 6] == 0))
                    {
                        return (i + 6);
                    }

                    if ((pole[i + 3] == 1 && pole[i + 6] == 1 && pole[i] == 0))
                    {
                        return i;
                    }

                    if ((pole[i] == 1 && pole[i + 6] == 1 && pole[i + 3] == 0))
                    {
                        return (i + 3);
                    }
                }
            }

            return bot_random(pole);
        }
    }
}