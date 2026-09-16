namespace Mayhem2
{
    partial class RegisterForm
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
            components = new System.ComponentModel.Container();
            txtFullName = new HartUI.Controls.cuiTextBox();
            txtLogin = new HartUI.Controls.cuiTextBox();
            txtEmail = new HartUI.Controls.cuiTextBox();
            txtPhone = new HartUI.Controls.cuiTextBox();
            txtPassword = new HartUI.Controls.cuiTextBox();
            txtConfirmPassword = new HartUI.Controls.cuiTextBox();
            btnRegister = new HartUI.Controls.cuiButton();
            btnBack = new HartUI.Controls.cuiButton();
            chkShowPassword = new HartUI.Controls.cuiCheckbox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // txtFullName
            // 
            txtFullName.Anchor = AnchorStyles.None;
            txtFullName.BackgroundColor = Color.White;
            txtFullName.Content = "";
            txtFullName.FocusBackgroundColor = Color.White;
            txtFullName.FocusImageTint = Color.White;
            txtFullName.FocusOutlineColor = Color.Black;
            txtFullName.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFullName.ForeColor = Color.Gray;
            txtFullName.Image = null;
            txtFullName.ImageExpand = new Point(0, 0);
            txtFullName.ImageOffset = new Point(0, 0);
            txtFullName.ImageTextSpacing = 8;
            txtFullName.Location = new Point(355, 64);
            txtFullName.Margin = new Padding(4);
            txtFullName.Multiline = false;
            txtFullName.Name = "txtFullName";
            txtFullName.NormalImageTint = Color.White;
            txtFullName.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            txtFullName.Padding = new Padding(16, 14, 16, 0);
            txtFullName.PasswordChar = false;
            txtFullName.PlaceholderColor = Color.LightGray;
            txtFullName.PlaceholderText = "ФИО";
            txtFullName.Rounding = new Padding(20);
            txtFullName.Size = new Size(266, 45);
            txtFullName.TabIndex = 0;
            txtFullName.TextOffset = new Size(0, 0);
            txtFullName.UnderlinedStyle = true;
            // 
            // txtLogin
            // 
            txtLogin.Anchor = AnchorStyles.None;
            txtLogin.BackgroundColor = Color.White;
            txtLogin.Content = "";
            txtLogin.FocusBackgroundColor = Color.White;
            txtLogin.FocusImageTint = Color.White;
            txtLogin.FocusOutlineColor = Color.Black;
            txtLogin.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLogin.ForeColor = Color.Gray;
            txtLogin.Image = null;
            txtLogin.ImageExpand = new Point(0, 0);
            txtLogin.ImageOffset = new Point(0, 0);
            txtLogin.ImageTextSpacing = 8;
            txtLogin.Location = new Point(355, 117);
            txtLogin.Margin = new Padding(4);
            txtLogin.Multiline = false;
            txtLogin.Name = "txtLogin";
            txtLogin.NormalImageTint = Color.White;
            txtLogin.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            txtLogin.Padding = new Padding(16, 14, 16, 0);
            txtLogin.PasswordChar = false;
            txtLogin.PlaceholderColor = Color.LightGray;
            txtLogin.PlaceholderText = "Логин";
            txtLogin.Rounding = new Padding(20);
            txtLogin.Size = new Size(266, 45);
            txtLogin.TabIndex = 1;
            txtLogin.TextOffset = new Size(0, 0);
            txtLogin.UnderlinedStyle = true;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.None;
            txtEmail.BackgroundColor = Color.White;
            txtEmail.Content = "";
            txtEmail.FocusBackgroundColor = Color.White;
            txtEmail.FocusImageTint = Color.White;
            txtEmail.FocusOutlineColor = Color.Black;
            txtEmail.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.ForeColor = Color.Gray;
            txtEmail.Image = null;
            txtEmail.ImageExpand = new Point(0, 0);
            txtEmail.ImageOffset = new Point(0, 0);
            txtEmail.ImageTextSpacing = 8;
            txtEmail.Location = new Point(355, 170);
            txtEmail.Margin = new Padding(4);
            txtEmail.Multiline = false;
            txtEmail.Name = "txtEmail";
            txtEmail.NormalImageTint = Color.White;
            txtEmail.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            txtEmail.Padding = new Padding(16, 14, 16, 0);
            txtEmail.PasswordChar = false;
            txtEmail.PlaceholderColor = Color.LightGray;
            txtEmail.PlaceholderText = "Email";
            txtEmail.Rounding = new Padding(20);
            txtEmail.Size = new Size(266, 45);
            txtEmail.TabIndex = 2;
            txtEmail.TextOffset = new Size(0, 0);
            txtEmail.UnderlinedStyle = true;
            // 
            // txtPhone
            // 
            txtPhone.Anchor = AnchorStyles.None;
            txtPhone.BackgroundColor = Color.White;
            txtPhone.Content = "";
            txtPhone.FocusBackgroundColor = Color.White;
            txtPhone.FocusImageTint = Color.White;
            txtPhone.FocusOutlineColor = Color.Black;
            txtPhone.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhone.ForeColor = Color.Gray;
            txtPhone.Image = null;
            txtPhone.ImageExpand = new Point(0, 0);
            txtPhone.ImageOffset = new Point(0, 0);
            txtPhone.ImageTextSpacing = 8;
            txtPhone.Location = new Point(355, 223);
            txtPhone.Margin = new Padding(4);
            txtPhone.Multiline = false;
            txtPhone.Name = "txtPhone";
            txtPhone.NormalImageTint = Color.White;
            txtPhone.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            txtPhone.Padding = new Padding(16, 14, 16, 0);
            txtPhone.PasswordChar = false;
            txtPhone.PlaceholderColor = Color.LightGray;
            txtPhone.PlaceholderText = "Телефон";
            txtPhone.Rounding = new Padding(20);
            txtPhone.Size = new Size(266, 45);
            txtPhone.TabIndex = 3;
            txtPhone.TextOffset = new Size(0, 0);
            txtPhone.UnderlinedStyle = true;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.None;
            txtPassword.BackgroundColor = Color.White;
            txtPassword.Content = "";
            txtPassword.FocusBackgroundColor = Color.White;
            txtPassword.FocusImageTint = Color.White;
            txtPassword.FocusOutlineColor = Color.Black;
            txtPassword.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.Gray;
            txtPassword.Image = null;
            txtPassword.ImageExpand = new Point(0, 0);
            txtPassword.ImageOffset = new Point(0, 0);
            txtPassword.ImageTextSpacing = 8;
            txtPassword.Location = new Point(355, 276);
            txtPassword.Margin = new Padding(4);
            txtPassword.Multiline = false;
            txtPassword.Name = "txtPassword";
            txtPassword.NormalImageTint = Color.White;
            txtPassword.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            txtPassword.Padding = new Padding(16, 14, 16, 0);
            txtPassword.PasswordChar = false;
            txtPassword.PlaceholderColor = Color.LightGray;
            txtPassword.PlaceholderText = "Пароль";
            txtPassword.Rounding = new Padding(20);
            txtPassword.Size = new Size(266, 45);
            txtPassword.TabIndex = 4;
            txtPassword.TextOffset = new Size(0, 0);
            txtPassword.UnderlinedStyle = true;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Anchor = AnchorStyles.None;
            txtConfirmPassword.BackgroundColor = Color.White;
            txtConfirmPassword.Content = "";
            txtConfirmPassword.FocusBackgroundColor = Color.White;
            txtConfirmPassword.FocusImageTint = Color.White;
            txtConfirmPassword.FocusOutlineColor = Color.Black;
            txtConfirmPassword.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConfirmPassword.ForeColor = Color.Gray;
            txtConfirmPassword.Image = null;
            txtConfirmPassword.ImageExpand = new Point(0, 0);
            txtConfirmPassword.ImageOffset = new Point(0, 0);
            txtConfirmPassword.ImageTextSpacing = 8;
            txtConfirmPassword.Location = new Point(355, 329);
            txtConfirmPassword.Margin = new Padding(4);
            txtConfirmPassword.Multiline = false;
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.NormalImageTint = Color.White;
            txtConfirmPassword.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            txtConfirmPassword.Padding = new Padding(16, 14, 16, 0);
            txtConfirmPassword.PasswordChar = false;
            txtConfirmPassword.PlaceholderColor = Color.LightGray;
            txtConfirmPassword.PlaceholderText = "Подтвердите пароль";
            txtConfirmPassword.Rounding = new Padding(20);
            txtConfirmPassword.Size = new Size(266, 45);
            txtConfirmPassword.TabIndex = 5;
            txtConfirmPassword.TextOffset = new Size(0, 0);
            txtConfirmPassword.UnderlinedStyle = true;
            // 
            // btnRegister
            // 
            btnRegister.Anchor = AnchorStyles.None;
            btnRegister.CheckButton = false;
            btnRegister.Checked = false;
            btnRegister.CheckedBackground = Color.FromArgb(61, 24, 226);
            btnRegister.CheckedForeColor = Color.White;
            btnRegister.CheckedImageTint = Color.White;
            btnRegister.CheckedOutline = Color.FromArgb(61, 24, 226);
            btnRegister.Content = "Регистрация";
            btnRegister.DialogResult = DialogResult.None;
            btnRegister.Font = new Font("Microsoft Sans Serif", 9.75F);
            btnRegister.ForeColor = Color.Black;
            btnRegister.HoverBackground = Color.White;
            btnRegister.HoverForeColor = Color.DimGray;
            btnRegister.HoverImageTint = Color.DimGray;
            btnRegister.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnRegister.Image = null;
            btnRegister.ImageExpand = new Point(0, 0);
            btnRegister.Location = new Point(355, 381);
            btnRegister.Name = "btnRegister";
            btnRegister.NormalBackground = Color.White;
            btnRegister.NormalForeColor = Color.Black;
            btnRegister.NormalImageTint = Color.Black;
            btnRegister.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnRegister.OutlineThickness = 1F;
            btnRegister.Padding = new Padding(12);
            btnRegister.PressedBackground = Color.WhiteSmoke;
            btnRegister.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnRegister.PressedImageTint = Color.FromArgb(32, 32, 32);
            btnRegister.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnRegister.Rounding = new Padding(20);
            btnRegister.Size = new Size(125, 45);
            btnRegister.TabIndex = 6;
            btnRegister.TextAlignment = StringAlignment.Center;
            btnRegister.TextPadding = 12;
            btnRegister.TextSpacing = 2;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.None;
            btnBack.CheckButton = false;
            btnBack.Checked = false;
            btnBack.CheckedBackground = Color.FromArgb(61, 24, 226);
            btnBack.CheckedForeColor = Color.White;
            btnBack.CheckedImageTint = Color.White;
            btnBack.CheckedOutline = Color.FromArgb(61, 24, 226);
            btnBack.Content = "Назад";
            btnBack.DialogResult = DialogResult.None;
            btnBack.Font = new Font("Microsoft Sans Serif", 9.75F);
            btnBack.ForeColor = Color.White;
            btnBack.HoverBackground = Color.Transparent;
            btnBack.HoverForeColor = Color.DimGray;
            btnBack.HoverImageTint = Color.DimGray;
            btnBack.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnBack.Image = null;
            btnBack.ImageExpand = new Point(0, 0);
            btnBack.Location = new Point(496, 381);
            btnBack.Name = "btnBack";
            btnBack.NormalBackground = Color.Black;
            btnBack.NormalForeColor = Color.White;
            btnBack.NormalImageTint = Color.Black;
            btnBack.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnBack.OutlineThickness = 1F;
            btnBack.Padding = new Padding(12);
            btnBack.PressedBackground = Color.WhiteSmoke;
            btnBack.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnBack.PressedImageTint = Color.FromArgb(32, 32, 32);
            btnBack.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnBack.Rounding = new Padding(20);
            btnBack.Size = new Size(125, 45);
            btnBack.TabIndex = 7;
            btnBack.TextAlignment = StringAlignment.Center;
            btnBack.TextPadding = 12;
            btnBack.TextSpacing = 2;
            // 
            // chkShowPassword
            // 
            chkShowPassword.Anchor = AnchorStyles.None;
            chkShowPassword.Checked = false;
            chkShowPassword.CheckedForeground = Color.FromArgb(61, 24, 226);
            chkShowPassword.CheckedOutlineColor = Color.FromArgb(61, 24, 226);
            chkShowPassword.CheckedSymbolColor = Color.White;
            chkShowPassword.Content = "Показать пароль";
            chkShowPassword.Location = new Point(628, 292);
            chkShowPassword.MinimumSize = new Size(16, 16);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.OutlineThickness = 1F;
            chkShowPassword.Rounding = 4;
            chkShowPassword.ShowSymbols = true;
            chkShowPassword.Size = new Size(116, 16);
            chkShowPassword.TabIndex = 8;
            chkShowPassword.UncheckedForeground = Color.Empty;
            chkShowPassword.UncheckedOutlineColor = Color.Gray;
            chkShowPassword.UncheckedSymbolColor = Color.Empty;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 461);
            Controls.Add(chkShowPassword);
            Controls.Add(btnBack);
            Controls.Add(btnRegister);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtPhone);
            Controls.Add(txtEmail);
            Controls.Add(txtLogin);
            Controls.Add(txtFullName);
            Name = "RegisterForm";
            Text = "RegisterForm";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private HartUI.Controls.cuiTextBox txtFullName;
        private HartUI.Controls.cuiTextBox txtLogin;
        private HartUI.Controls.cuiTextBox txtEmail;
        private HartUI.Controls.cuiTextBox txtPhone;
        private HartUI.Controls.cuiTextBox txtPassword;
        private HartUI.Controls.cuiTextBox txtConfirmPassword;
        private HartUI.Controls.cuiButton btnRegister;
        private HartUI.Controls.cuiButton btnBack;
        private HartUI.Controls.cuiCheckbox chkShowPassword;
        private ErrorProvider errorProvider1;
    }
}