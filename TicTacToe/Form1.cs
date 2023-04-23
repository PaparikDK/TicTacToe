using System;
using System.Diagnostics;
using System.Drawing.Text;

namespace TicTacToe
{
    public partial class FrmMainMenu : Form
    {
        /*
         * ����� �����, ��� � ��������� � ������ � ����������� ���������, ��������, ����� ��� �������������
         * ��� ����� �� ������-���� ������������ ������ � ������ ���� ������, ������ ������� ����������� ��������
         * � �. �. �� ��� �� � ��� �� ��� �������� �� �� ������, ��� � ���� :)
         */

        // ������ ����� ��� ���� � ����� � ��������� (����� ������� ����� ����������) ��� ����
        internal FormGamePage gamePage;
        internal GameRules rulesPage;
        internal ScoresForm scoresPage;
        // ������� ����� ����������� ����� � ���� ����������, ����� ������� ���� �������� � ����� �������� ���
        Color lightColorTheme = Color.FromArgb(237, 229, 220);
        Color darkColorTheme = Color.FromArgb(45, 56, 82);
        Color specialColorBlack = Color.FromArgb(69, 69, 69);
        bool isLightTheme = Convert.ToBoolean(Properties.Resources.isLightTheme);
        /* ������ ������!
         * � ������� ���������������� ����� ��� ����� ������� � �������� �� ��������� ���� "isLightTheme" � ���� Resources
         * (�������� ������ � ������������ �������), �� ������ ����� ������ ������, �������� ������� ������ �������� ����,
         * �� � �� ��������� ����� �������� ��� �� ������� �������.
         * �� ������ ������ ���� isLightTheme ���������������� ����� ���� ������ � ������������������.
         */
        public FrmMainMenu() // ����������� (�� ����)
        {
            InitializeComponent();
            gamePage = new FormGamePage(this);
            rulesPage = new GameRules(this);
            scoresPage = new ScoresForm(this);
        }

        // ��� �������� ��������� ����� ��� �� ���� ������
        public void changeTheme()
        {
            changeFormTheme();
            gamePage.changeFormTheme();
            rulesPage.changeFormTheme();
            scoresPage.changeFormTheme();
        }

        // ����� ������ �������� ���� ��� ���� � �������� ����� ����� ����
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

        // ����� ����� ����� �� ���� ��������� �����
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

        // �������� ���� ������ �������
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

        // �������� �������, ��� �� �����
        private void label1_Click(object sender, EventArgs e)
        {

        }

        // ��������� ����� gamePage � ������ ���� ����� VS ���
        private void btn1VsBotGame_Click(object sender, EventArgs e)
        {
            gamePage.Show(this.Location);
            this.Hide();
        }

        // ��������� ����� gamePage � ������ ���� ����� VS ����� 
        private void btn1Vs1Game_Click(object sender, EventArgs e)
        {
            gamePage.Show(this.Location);
            this.Hide();
        }

        // ��������� ����� � ��������� ����
        private void btnGameRules_Click(object sender, EventArgs e)
        {
            rulesPage.Show(this.Location);
            this.Hide();
        }

        // ������ ���� �� ���� ������        
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