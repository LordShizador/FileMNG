using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileMNG
{
    public partial class ForgetPasswordForm : Form
    {
        public ForgetPasswordForm()
        {
            InitializeComponent();
            forgetPasswordButton.BackColor = Color.Red;
        }

        private void forgetPasswordButton_Click(object sender, EventArgs e)
        {
            try
            {
                //добавить проверку почты
                MailAddress from = new MailAddress("FileMNG@yandex.ru", "FileMNG");
                if (Core.Context.Users.Select(s => s.Login == forgetPasswordTextBox.Text).FirstOrDefault() || Core.Context.Users.Select(s=>s.E_mail==forgetPasswordTextBox.Text).FirstOrDefault())
                {
                    //Запись  в переменную данных юзера
                    var db = Core.Context.Users.Where(w => w.Login == forgetPasswordTextBox.Text || w.E_mail == forgetPasswordTextBox.Text).ToList();

                    MailAddress to = new MailAddress(db.Select(s=>s.E_mail).FirstOrDefault());
                    MailMessage m = new MailMessage(from, to);

                    m.Subject = "Восстановление пароля";

                    // Генерация нового пароля
                    string pass = GenPassword();

                    // Изменения пароля в БД
                    string query = "Update Users set Password = @Password where Login=@login";
                    SqlParameter Password = new SqlParameter("@Password", pass);
                    SqlParameter Login = new SqlParameter("@Login", db.Select(s => s.Login).FirstOrDefault());
                    Core.Context.Database.ExecuteSqlCommand(query, Password, Login);

                    m.Body = "Новый пароль " + pass;
                    m.IsBodyHtml = true;
                    SmtpClient smtp = new SmtpClient("smtp.yandex.ru", 587);
                    smtp.EnableSsl = true;
                    smtp.Credentials = new NetworkCredential("FileMNG@yandex.ru", "FileMNG123");
                    smtp.Send(m);
                    Console.Read();
                    MessageBox.Show("вам на почту выслано письмо с паролем. Если письмо отсутствует проверте папку спам", "Успешно", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Пользователь не найден","Ошибка");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Ошибка");
            }
            
        }
        public static string GenPassword()
        {
            string pass = "";
            var r = new Random();
            while (pass.Length < 8)
            {
                Char c = (char)r.Next(33, 125);
                if (Char.IsLetterOrDigit(c))
                    pass += c;
            }
            return pass;
        }
    }
}
