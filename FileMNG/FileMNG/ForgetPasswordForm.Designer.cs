
namespace FileMNG
{
    partial class ForgetPasswordForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.forgetPasswordButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.forgetPasswordTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // forgetPasswordButton
            // 
            this.forgetPasswordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.forgetPasswordButton.Location = new System.Drawing.Point(15, 51);
            this.forgetPasswordButton.Name = "forgetPasswordButton";
            this.forgetPasswordButton.Size = new System.Drawing.Size(115, 23);
            this.forgetPasswordButton.TabIndex = 0;
            this.forgetPasswordButton.Text = "Восстановить";
            this.forgetPasswordButton.UseVisualStyleBackColor = true;
            this.forgetPasswordButton.Click += new System.EventHandler(this.forgetPasswordButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите логин или почту";
            // 
            // forgetPasswordTextBox
            // 
            this.forgetPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.forgetPasswordTextBox.Location = new System.Drawing.Point(15, 25);
            this.forgetPasswordTextBox.Name = "forgetPasswordTextBox";
            this.forgetPasswordTextBox.Size = new System.Drawing.Size(171, 22);
            this.forgetPasswordTextBox.TabIndex = 2;
            // 
            // ForgetPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(213, 83);
            this.Controls.Add(this.forgetPasswordTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.forgetPasswordButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(229, 122);
            this.MinimumSize = new System.Drawing.Size(229, 122);
            this.Name = "ForgetPasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Восстановление пароля";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button forgetPasswordButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox forgetPasswordTextBox;
    }
}