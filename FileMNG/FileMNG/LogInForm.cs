using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace FileMNG
{
    public partial class LogInForm : Form
    {
        string text;
        public LogInForm()
        {
            InitializeComponent();
        }

        private void RegistrationLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LogInPanel.Visible = false;
            registrationPanel.Visible = true;
            this.Width = 330;
            this.Height = 620;
            capchaPictureBox.Image = this.CreateImage(capchaPictureBox.Width, capchaPictureBox.Height);
            //MessageBox.Show(text,"Уберите меня");
        }
        private Bitmap CreateImage(int Width, int Height)
        {
            Random rnd = new Random();

            //Создадим изображение
            Bitmap result = new Bitmap(Width, Height);

            //Вычислим позицию текста
            int Xpos = 10;
            int Ypos = 10;

            //Добавим различные цвета ддя текста
            Brush[] colors = {
                Brushes.Black,
                Brushes.Red,
                Brushes.Green,
                Brushes.Yellow,
                Brushes.White,
                Brushes.Tomato,
                Brushes.Sienna,
                Brushes.Pink };

            //Добавим различные цвета линий
            Pen[] colorpens = {
                Pens.Black,
                Pens.Red,
                Pens.RoyalBlue,
                Pens.Green,
                Pens.Yellow,
                Pens.White,
                Pens.Tomato,
                Pens.Sienna,
                Pens.Pink };

            //Делаем случайный стиль текста
            FontStyle[] fontstyle = {
                FontStyle.Bold,
                FontStyle.Italic,
                FontStyle.Regular,
                FontStyle.Strikeout,
                FontStyle.Underline};

            //Добавим различные углы поворота текста
            Int16[] rotate = { 1, -1, 2, -2, 3, -3, 4, -4, 5, -5, 6, -6 };

            //Укажем где рисовать
            Graphics g = Graphics.FromImage((Image)result);

            //Пусть фон картинки будет серым
            g.Clear(Color.Aqua);

            //Делаем случайный угол поворота текста
            g.RotateTransform(rnd.Next(rotate.Length));

            //Генерируем текст
            text = String.Empty;
            string ALF = "7890QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm";
            for (int i = 0; i < 5; ++i)
                text += ALF[rnd.Next(ALF.Length)];

            //Нарисуем сгенирируемый текст
            g.DrawString(text,
            new Font("Arial", 25, fontstyle[rnd.Next(fontstyle.Length)]),
            colors[rnd.Next(colors.Length)],
            new PointF(Xpos, Ypos));

            //Добавим немного помех
            //Линии из углов
            for (int i = 0; i < 8; i++)
            {
                g.DrawLine(Pens.LightGray,
                     new Point(0, 0),
                     new Point(Width - rnd.Next(Width), Height - 1));
            }

            for (int i = 0; i < 8; i++)
            {
                g.DrawLine(Pens.LightGray,
                new Point(0, 0),
                new Point(Width - 1, Height - rnd.Next(Height)));
            }

                //Белые точки
                for (int i = 0; i < Width; ++i)
                    for (int j = 0; j < Height; ++j)
                        if (rnd.Next() % 20 == 0)
                            result.SetPixel(i, j, Color.White);

                return result;           
        }

        private void checkCapchaButton_Click(object sender, EventArgs e)
        {
            if (checkCapchaTextBox.Text == text)
            {
                MessageBox.Show("Верно!");
                registrationButton.Enabled = true;
                checkCapchaTextBox.Enabled = false;
                checkCapchaButton.Enabled = false;
                genNewCapchaButton.Enabled = false;
            }
            else

                MessageBox.Show("Ошибка!");
        }

        private void genNewCapchaButton_Click(object sender, EventArgs e)
        {
            capchaPictureBox.Image = this.CreateImage(capchaPictureBox.Width, capchaPictureBox.Height);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            LogInPanel.Visible = true;
            registrationPanel.Visible = false;
            this.Width = 330;
            this.Height = 250;
        }

        private void forgetPasswordLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form forget = new ForgetPasswordForm();
            this.Hide();
            forget.ShowDialog();
            this.Show();
        }

        private void logInButton_Click(object sender, EventArgs e)
        {

        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            //string cond = @"(\w([-+.]\w+)*@\w+([-.]\w)*\.\w+([-.]\w+)*)";
            string cond = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            if (String.IsNullOrWhiteSpace(regLoginTextBox.Text))
            {
                MessageBox.Show("Введите логин");
            }
            else if (Core.Context.Users.Select(s => s.Login == regLoginTextBox.Text).FirstOrDefault())
            {
                MessageBox.Show("Логин занят");
            }
            else if (String.IsNullOrWhiteSpace(emailTextBox.Text))
            {
                MessageBox.Show("Введите почту");
            }
            else if (Core.Context.Users.Select(s => s.E_mail == emailTextBox.Text).FirstOrDefault())
            {
                MessageBox.Show("Почта занята");
            }
            else if (Regex.IsMatch(emailTextBox.Text,cond))
            {
                MessageBox.Show("Введите почту");
            }
            else if (String.IsNullOrWhiteSpace(regPasswordTextBox.Text))
            {
                MessageBox.Show("Введите пароль");
            }
            else if (String.IsNullOrWhiteSpace(ConfirmPassword.Text) || ConfirmPassword.Text != regPasswordTextBox.Text)
            {
                MessageBox.Show("Пароли не совпадают");
            }
            
            else
            {
                // проверку логина и мыла
                User user = new User();
                user.E_mail = emailTextBox.Text;
                user.Login = regLoginTextBox.Text;
                user.IdRole = 3;
                user.Password = regPasswordTextBox.Text;
                user.Phone = phoneTextBox.Text;
                user.UserName = userNameTextBox.Text;
                Core.Context.Users.Add(user);
                Core.Context.SaveChanges();
                MessageBox.Show("Вы успешно зарегестрированы", "Успешно");
                regLoginTextBox.Text = "";
                regPasswordTextBox.Text = "";
                emailTextBox.Text = "";
                ConfirmPassword.Text = "";
                userNameTextBox.Text = "";
                phoneTextBox.Text = "";
                LogInPanel.Visible = true;
                registrationPanel.Visible = false;
                this.Width = 330;
                this.Height = 250;
            }   
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void LogInForm_Load(object sender, EventArgs e)
        {
            logInButton.BackColor = Color.Red;
            logInButton.ForeColor = Color.White;
            registrationButton.BackColor = Color.Red;
            registrationButton.ForeColor = Color.White;
            BackButton.ForeColor = Color.White;
            BackButton.BackColor = Color.Red;
            genNewCapchaButton.BackColor = Color.Red;
            genNewCapchaButton.ForeColor = Color.White;
            checkCapchaButton.ForeColor = Color.White;
            checkCapchaButton.BackColor = Color.Red;

        }
    }
}
    