using System;
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
        // ������� ����� ����������� ����� � ���� ����������, ����� ������� ���� �������� � ����� �������� ���
        Color lightColorTheme = Color.FromArgb(237, 229, 220);
        Color darkColorTheme = Color.FromArgb(45, 56, 82);
        Color specialColorBlack = Color.FromArgb(69, 69, 69);

        /* ������ ������!
         * � ������� ���������������� ����� ��� ����� ������� � �������� �� ��������� ���� "isLightTheme" � ���� Resources
         * (�������� ������ � ������������ �������), �� ������ ����� ������ ������, �������� ������� ������ �������� ����,
         * �� � �� ��������� ����� �������� ��� �� ������� �������.
         * �� ������ ������ ���� isLightTheme ���������������� ����� ���� ������ � ������������������.
         */
        bool isLightTheme = Convert.ToBoolean(Properties.Resources.isLightTheme);
        public FrmMainMenu() // ����������� (�� ����)
        {
            InitializeComponent();
            gamePage = new FormGamePage(this);
            rulesPage = new GameRules(this);
        }

        // ��� �������� ��������� ����� ��� �� ���� ������
        void changeTheme()
        {
            changeFormTheme();
            gamePage.changeFormTheme();
            rulesPage.changeFormTheme();
        }

        // ����� ������ �������� ���� ��� ���� � �������� ����� ����� ����
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
        }

        // �������� �������, ��� �� �����
        private void label1_Click(object sender, EventArgs e)
        {

        }

        // ��������� ����� gamePage � ������ ���� ����� VS ���
        private void btn1VsBotGame_Click(object sender, EventArgs e)
        {
            gamePage.Show();
            this.Hide();
        }

        // ��������� ����� gamePage � ������ ���� ����� VS ����� 
        private void btn1Vs1Game_Click(object sender, EventArgs e)
        {
            gamePage.Show();
            this.Hide();
        }

        // ��������� ����� � ��������� ����
        private void btnGameRules_Click(object sender, EventArgs e)
        {
            rulesPage.Show();
            this.Hide();
        }

        // ������ ���� �� ���� ������        
        private void btnChangeTheme_Click(object sender, EventArgs e)
        {
            changeTheme();            
        }
    }
}