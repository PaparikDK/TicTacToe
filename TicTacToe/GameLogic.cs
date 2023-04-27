using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public partial class FormGamePage
    {
        public static int stroke_Couter; //Счётчик ходов, исходя из которого записывается крестик либо нолик

        int[] recorded_choice = new int[9]; // Массив для записи выбора позиции хрэстика/нолика
        public void AI() {
            
        }
        public void choiceRecord(int choice) //Запись выбора позиции хрэстика/нолика в массив
        {
            if (stroke_Couter%2 == 0)
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
    }
}
