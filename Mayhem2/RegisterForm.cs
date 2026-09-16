using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Mayhem2
{
    public partial class RegisterForm : Form
    {
        private readonly string connectionString =
            @"Data Source=HOME-PC\SQLEXPRESS;Initial Catalog=RealEstateDB;Integrated Security=True;TrustServerCertificate=True;";
        public RegisterForm()
        {
            InitializeComponent();
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            string fullName = txtFullName.Text.Trim();
            string login = txtLogin.Text.Trim();
            string email = txtEmail.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string password = txtPassword.Text;
            string confirm = txtConfirmPassword.Text;

            bool hasError = false; // флаг для ошибок 

            // проверка пустых полей 
            if (string.IsNullOrEmpty(fullName))
            {
                errorProvider1.SetError(txtFullName, "Введите ФИО");
                hasError = true;
            }
            if (string.IsNullOrEmpty(login))
            {
                errorProvider1.SetError(txtLogin, "Введите логин");
                hasError = true;
            }
            if (string.IsNullOrEmpty(email))
            {
                errorProvider1.SetError(txtEmail, "Введите email");
                hasError = true;
            }
            if (string.IsNullOrEmpty(phone))
            {
                errorProvider1.SetError(txtPhone, "Введите телефон");
                hasError = true;
            }
            if (string.IsNullOrEmpty(password))
            {
                errorProvider1.SetError(txtPassword, "Введите пароль");
                hasError = true;
            }
            if (!string.IsNullOrEmpty(confirm))
            {
                errorProvider1.SetError(txtConfirmPassword, "Повторите пароль");
                hasError = true;
            }
            if (hasError) return;
            /////////////////////
            
            /////////////////////
            
            // проверка email
            if (!email.Contains("@"))
            {
                errorProvider1.SetError(txtEmail, "Email должен содержать @");
                hasError = true;
            }

        }
    }
}
