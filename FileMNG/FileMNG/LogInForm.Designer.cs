
namespace FileMNG
{
    partial class LogInForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.registrationPanel = new System.Windows.Forms.Panel();
            this.checkCapchaTextBox = new System.Windows.Forms.TextBox();
            this.genNewCapchaButton = new System.Windows.Forms.Button();
            this.capchaPictureBox = new System.Windows.Forms.PictureBox();
            this.checkCapchaButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ConfirmPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.regPasswordTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.registrationButton = new System.Windows.Forms.Button();
            this.regLoginTextBox = new System.Windows.Forms.TextBox();
            this.LogInPanel = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.fogertMeCheckBox = new System.Windows.Forms.CheckBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.logInButton = new System.Windows.Forms.Button();
            this.RegistrationLink = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.forgetPasswordLink = new System.Windows.Forms.LinkLabel();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.registrationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.capchaPictureBox)).BeginInit();
            this.LogInPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // registrationPanel
            // 
            this.registrationPanel.BackColor = System.Drawing.Color.Black;
            this.registrationPanel.Controls.Add(this.checkCapchaTextBox);
            this.registrationPanel.Controls.Add(this.genNewCapchaButton);
            this.registrationPanel.Controls.Add(this.capchaPictureBox);
            this.registrationPanel.Controls.Add(this.checkCapchaButton);
            this.registrationPanel.Controls.Add(this.label10);
            this.registrationPanel.Controls.Add(this.label9);
            this.registrationPanel.Controls.Add(this.userNameTextBox);
            this.registrationPanel.Controls.Add(this.phoneTextBox);
            this.registrationPanel.Controls.Add(this.label8);
            this.registrationPanel.Controls.Add(this.emailTextBox);
            this.registrationPanel.Controls.Add(this.label7);
            this.registrationPanel.Controls.Add(this.ConfirmPassword);
            this.registrationPanel.Controls.Add(this.label6);
            this.registrationPanel.Controls.Add(this.regPasswordTextBox);
            this.registrationPanel.Controls.Add(this.label5);
            this.registrationPanel.Controls.Add(this.label4);
            this.registrationPanel.Controls.Add(this.registrationButton);
            this.registrationPanel.Controls.Add(this.regLoginTextBox);
            this.registrationPanel.Location = new System.Drawing.Point(11, 10);
            this.registrationPanel.Name = "registrationPanel";
            this.registrationPanel.Size = new System.Drawing.Size(293, 531);
            this.registrationPanel.TabIndex = 10;
            this.registrationPanel.Visible = false;
            // 
            // checkCapchaTextBox
            // 
            this.checkCapchaTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkCapchaTextBox.Location = new System.Drawing.Point(67, 402);
            this.checkCapchaTextBox.Name = "checkCapchaTextBox";
            this.checkCapchaTextBox.Size = new System.Drawing.Size(164, 29);
            this.checkCapchaTextBox.TabIndex = 21;
            // 
            // genNewCapchaButton
            // 
            this.genNewCapchaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.genNewCapchaButton.Location = new System.Drawing.Point(149, 437);
            this.genNewCapchaButton.Name = "genNewCapchaButton";
            this.genNewCapchaButton.Size = new System.Drawing.Size(118, 31);
            this.genNewCapchaButton.TabIndex = 13;
            this.genNewCapchaButton.Text = "Сгенерировать";
            this.genNewCapchaButton.UseVisualStyleBackColor = true;
            this.genNewCapchaButton.Click += new System.EventHandler(this.genNewCapchaButton_Click);
            // 
            // capchaPictureBox
            // 
            this.capchaPictureBox.Location = new System.Drawing.Point(49, 299);
            this.capchaPictureBox.Name = "capchaPictureBox";
            this.capchaPictureBox.Size = new System.Drawing.Size(202, 97);
            this.capchaPictureBox.TabIndex = 14;
            this.capchaPictureBox.TabStop = false;
            // 
            // checkCapchaButton
            // 
            this.checkCapchaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkCapchaButton.Location = new System.Drawing.Point(48, 437);
            this.checkCapchaButton.Name = "checkCapchaButton";
            this.checkCapchaButton.Size = new System.Drawing.Size(95, 27);
            this.checkCapchaButton.TabIndex = 12;
            this.checkCapchaButton.Text = "Проверить";
            this.checkCapchaButton.UseVisualStyleBackColor = true;
            this.checkCapchaButton.Click += new System.EventHandler(this.checkCapchaButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(97, 511);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "* обязательно";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(46, 194);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "Имя пользователя";
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userNameTextBox.Location = new System.Drawing.Point(48, 213);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(199, 29);
            this.userNameTextBox.TabIndex = 18;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneTextBox.Location = new System.Drawing.Point(49, 264);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(199, 29);
            this.phoneTextBox.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(45, 245);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Номер телефона";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailTextBox.Location = new System.Drawing.Point(49, 66);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(199, 29);
            this.emailTextBox.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(46, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "*Введите e-mail";
            // 
            // ConfirmPassword
            // 
            this.ConfirmPassword.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConfirmPassword.Location = new System.Drawing.Point(49, 162);
            this.ConfirmPassword.Name = "ConfirmPassword";
            this.ConfirmPassword.PasswordChar = '*';
            this.ConfirmPassword.Size = new System.Drawing.Size(199, 29);
            this.ConfirmPassword.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(45, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "*Подтверждение пароль";
            // 
            // regPasswordTextBox
            // 
            this.regPasswordTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regPasswordTextBox.Location = new System.Drawing.Point(49, 111);
            this.regPasswordTextBox.Name = "regPasswordTextBox";
            this.regPasswordTextBox.PasswordChar = '*';
            this.regPasswordTextBox.Size = new System.Drawing.Size(199, 29);
            this.regPasswordTextBox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(46, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "*Введите пароль";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(46, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "*Введите логин";
            // 
            // registrationButton
            // 
            this.registrationButton.Enabled = false;
            this.registrationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registrationButton.Location = new System.Drawing.Point(75, 474);
            this.registrationButton.Name = "registrationButton";
            this.registrationButton.Size = new System.Drawing.Size(156, 34);
            this.registrationButton.TabIndex = 0;
            this.registrationButton.Text = "Зарегестрироваться";
            this.registrationButton.UseVisualStyleBackColor = true;
            this.registrationButton.Click += new System.EventHandler(this.registrationButton_Click);
            // 
            // regLoginTextBox
            // 
            this.regLoginTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regLoginTextBox.Location = new System.Drawing.Point(49, 19);
            this.regLoginTextBox.Name = "regLoginTextBox";
            this.regLoginTextBox.Size = new System.Drawing.Size(199, 29);
            this.regLoginTextBox.TabIndex = 11;
            // 
            // LogInPanel
            // 
            this.LogInPanel.BackColor = System.Drawing.Color.Black;
            this.LogInPanel.Controls.Add(this.checkBox1);
            this.LogInPanel.Controls.Add(this.fogertMeCheckBox);
            this.LogInPanel.Controls.Add(this.passwordTextBox);
            this.LogInPanel.Controls.Add(this.label3);
            this.LogInPanel.Controls.Add(this.logInButton);
            this.LogInPanel.Controls.Add(this.RegistrationLink);
            this.LogInPanel.Controls.Add(this.label1);
            this.LogInPanel.Controls.Add(this.forgetPasswordLink);
            this.LogInPanel.Controls.Add(this.loginTextBox);
            this.LogInPanel.Controls.Add(this.label2);
            this.LogInPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LogInPanel.Location = new System.Drawing.Point(8, 10);
            this.LogInPanel.Name = "LogInPanel";
            this.LogInPanel.Size = new System.Drawing.Size(295, 207);
            this.LogInPanel.TabIndex = 11;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.checkBox1.Location = new System.Drawing.Point(132, 130);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(164, 20);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Работать автономно";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // fogertMeCheckBox
            // 
            this.fogertMeCheckBox.AutoSize = true;
            this.fogertMeCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fogertMeCheckBox.ForeColor = System.Drawing.SystemColors.Control;
            this.fogertMeCheckBox.Location = new System.Drawing.Point(3, 130);
            this.fogertMeCheckBox.Name = "fogertMeCheckBox";
            this.fogertMeCheckBox.Size = new System.Drawing.Size(134, 20);
            this.fogertMeCheckBox.TabIndex = 8;
            this.fogertMeCheckBox.Text = "Запомнить меня";
            this.fogertMeCheckBox.UseVisualStyleBackColor = true;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordTextBox.Location = new System.Drawing.Point(37, 67);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(220, 22);
            this.passwordTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(34, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Нет акаунта.";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // logInButton
            // 
            this.logInButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logInButton.Location = new System.Drawing.Point(70, 96);
            this.logInButton.Name = "logInButton";
            this.logInButton.Size = new System.Drawing.Size(125, 28);
            this.logInButton.TabIndex = 0;
            this.logInButton.Text = "Авторизация";
            this.logInButton.UseVisualStyleBackColor = true;
            this.logInButton.Click += new System.EventHandler(this.logInButton_Click);
            // 
            // RegistrationLink
            // 
            this.RegistrationLink.AutoSize = true;
            this.RegistrationLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegistrationLink.Location = new System.Drawing.Point(129, 184);
            this.RegistrationLink.Name = "RegistrationLink";
            this.RegistrationLink.Size = new System.Drawing.Size(141, 16);
            this.RegistrationLink.TabIndex = 6;
            this.RegistrationLink.TabStop = true;
            this.RegistrationLink.Text = "Зарегестрируйтесь.";
            this.RegistrationLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RegistrationLink_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(35, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите логин/email";
            // 
            // forgetPasswordLink
            // 
            this.forgetPasswordLink.AutoSize = true;
            this.forgetPasswordLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.forgetPasswordLink.Location = new System.Drawing.Point(89, 153);
            this.forgetPasswordLink.Name = "forgetPasswordLink";
            this.forgetPasswordLink.Size = new System.Drawing.Size(115, 16);
            this.forgetPasswordLink.TabIndex = 5;
            this.forgetPasswordLink.TabStop = true;
            this.forgetPasswordLink.Text = "Забыли пароль?";
            this.forgetPasswordLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.forgetPasswordLink_LinkClicked);
            // 
            // loginTextBox
            // 
            this.loginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginTextBox.Location = new System.Drawing.Point(37, 29);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(220, 22);
            this.loginTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(35, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введите пароль";
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackButton.Location = new System.Drawing.Point(112, 549);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(101, 30);
            this.BackButton.TabIndex = 12;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(307, 222);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.LogInPanel);
            this.Controls.Add(this.registrationPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "LogInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.LogInForm_Load);
            this.registrationPanel.ResumeLayout(false);
            this.registrationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.capchaPictureBox)).EndInit();
            this.LogInPanel.ResumeLayout(false);
            this.LogInPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel registrationPanel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ConfirmPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox regPasswordTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button registrationButton;
        private System.Windows.Forms.TextBox regLoginTextBox;
        private System.Windows.Forms.Panel LogInPanel;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox fogertMeCheckBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button logInButton;
        private System.Windows.Forms.LinkLabel RegistrationLink;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel forgetPasswordLink;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox checkCapchaTextBox;
        private System.Windows.Forms.Button genNewCapchaButton;
        private System.Windows.Forms.PictureBox capchaPictureBox;
        private System.Windows.Forms.Button checkCapchaButton;
        private System.Windows.Forms.Button BackButton;
    }
}

