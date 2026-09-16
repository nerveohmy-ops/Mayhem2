namespace Mayhem2
{
    partial class AutorizationForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            cuiTextBox1 = new HartUI.Controls.cuiTextBox();
            cuiTextBox2 = new HartUI.Controls.cuiTextBox();
            cuiButton1 = new HartUI.Controls.cuiButton();
            cuiButton2 = new HartUI.Controls.cuiButton();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // cuiTextBox1
            // 
            cuiTextBox1.Anchor = AnchorStyles.None;
            cuiTextBox1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            cuiTextBox1.BackgroundColor = Color.White;
            cuiTextBox1.Content = "";
            cuiTextBox1.FocusBackgroundColor = Color.White;
            cuiTextBox1.FocusImageTint = Color.White;
            cuiTextBox1.FocusOutlineColor = Color.Black;
            cuiTextBox1.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiTextBox1.ForeColor = Color.Gray;
            cuiTextBox1.Image = null;
            cuiTextBox1.ImageExpand = new Point(0, 0);
            cuiTextBox1.ImageOffset = new Point(0, 0);
            cuiTextBox1.ImageTextSpacing = 8;
            cuiTextBox1.Location = new Point(353, 122);
            cuiTextBox1.Margin = new Padding(4);
            cuiTextBox1.Multiline = false;
            cuiTextBox1.Name = "cuiTextBox1";
            cuiTextBox1.NormalImageTint = Color.White;
            cuiTextBox1.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            cuiTextBox1.Padding = new Padding(16, 14, 16, 0);
            cuiTextBox1.PasswordChar = false;
            cuiTextBox1.PlaceholderColor = Color.LightGray;
            cuiTextBox1.PlaceholderText = "Введите email..";
            cuiTextBox1.Rounding = new Padding(20);
            cuiTextBox1.Size = new Size(266, 45);
            cuiTextBox1.TabIndex = 0;
            cuiTextBox1.TextOffset = new Size(0, 0);
            cuiTextBox1.UnderlinedStyle = true;
            cuiTextBox1.ContentChanged += cuiTextBox1_ContentChanged;
            // 
            // cuiTextBox2
            // 
            cuiTextBox2.Anchor = AnchorStyles.None;
            cuiTextBox2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            cuiTextBox2.BackgroundColor = Color.White;
            cuiTextBox2.Content = "";
            cuiTextBox2.FocusBackgroundColor = Color.White;
            cuiTextBox2.FocusImageTint = Color.White;
            cuiTextBox2.FocusOutlineColor = Color.Black;
            cuiTextBox2.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiTextBox2.ForeColor = Color.Gray;
            cuiTextBox2.Image = null;
            cuiTextBox2.ImageExpand = new Point(0, 0);
            cuiTextBox2.ImageOffset = new Point(0, 0);
            cuiTextBox2.ImageTextSpacing = 8;
            cuiTextBox2.Location = new Point(353, 175);
            cuiTextBox2.Margin = new Padding(4);
            cuiTextBox2.Multiline = false;
            cuiTextBox2.Name = "cuiTextBox2";
            cuiTextBox2.NormalImageTint = Color.White;
            cuiTextBox2.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            cuiTextBox2.Padding = new Padding(16, 14, 16, 0);
            cuiTextBox2.PasswordChar = true;
            cuiTextBox2.PlaceholderColor = Color.LightGray;
            cuiTextBox2.PlaceholderText = "Введите пароль..";
            cuiTextBox2.Rounding = new Padding(20);
            cuiTextBox2.Size = new Size(266, 45);
            cuiTextBox2.TabIndex = 1;
            cuiTextBox2.TextOffset = new Size(0, 0);
            cuiTextBox2.UnderlinedStyle = true;
            cuiTextBox2.ContentChanged += cuiTextBox2_ContentChanged;
            // 
            // cuiButton1
            // 
            cuiButton1.Anchor = AnchorStyles.None;
            cuiButton1.CheckButton = false;
            cuiButton1.Checked = false;
            cuiButton1.CheckedBackground = Color.FromArgb(61, 24, 226);
            cuiButton1.CheckedForeColor = Color.White;
            cuiButton1.CheckedImageTint = Color.White;
            cuiButton1.CheckedOutline = Color.Black;
            cuiButton1.Content = "Вход";
            cuiButton1.DialogResult = DialogResult.None;
            cuiButton1.Font = new Font("Microsoft Sans Serif", 9.75F);
            cuiButton1.ForeColor = Color.Black;
            cuiButton1.HoverBackground = Color.White;
            cuiButton1.HoverForeColor = Color.DimGray;
            cuiButton1.HoverImageTint = Color.DimGray;
            cuiButton1.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            cuiButton1.Image = null;
            cuiButton1.ImageExpand = new Point(0, 0);
            cuiButton1.Location = new Point(353, 227);
            cuiButton1.Name = "cuiButton1";
            cuiButton1.NormalBackground = Color.White;
            cuiButton1.NormalForeColor = Color.Black;
            cuiButton1.NormalImageTint = Color.Black;
            cuiButton1.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            cuiButton1.OutlineThickness = 1F;
            cuiButton1.Padding = new Padding(12);
            cuiButton1.PressedBackground = Color.WhiteSmoke;
            cuiButton1.PressedForeColor = Color.FromArgb(32, 32, 32);
            cuiButton1.PressedImageTint = Color.FromArgb(32, 32, 32);
            cuiButton1.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            cuiButton1.Rounding = new Padding(20);
            cuiButton1.Size = new Size(125, 45);
            cuiButton1.TabIndex = 2;
            cuiButton1.TextAlignment = StringAlignment.Center;
            cuiButton1.TextPadding = 12;
            cuiButton1.TextSpacing = 2;
            cuiButton1.Click += cuiButton1_Click;
            // 
            // cuiButton2
            // 
            cuiButton2.Anchor = AnchorStyles.None;
            cuiButton2.CheckButton = false;
            cuiButton2.Checked = false;
            cuiButton2.CheckedBackground = Color.FromArgb(61, 24, 226);
            cuiButton2.CheckedForeColor = Color.White;
            cuiButton2.CheckedImageTint = Color.White;
            cuiButton2.CheckedOutline = Color.Black;
            cuiButton2.Content = "Регистрация";
            cuiButton2.DialogResult = DialogResult.None;
            cuiButton2.Font = new Font("Microsoft Sans Serif", 9.75F);
            cuiButton2.ForeColor = Color.White;
            cuiButton2.HoverBackground = Color.White;
            cuiButton2.HoverForeColor = Color.DimGray;
            cuiButton2.HoverImageTint = Color.DimGray;
            cuiButton2.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            cuiButton2.Image = null;
            cuiButton2.ImageExpand = new Point(0, 0);
            cuiButton2.Location = new Point(494, 227);
            cuiButton2.Name = "cuiButton2";
            cuiButton2.NormalBackground = Color.Black;
            cuiButton2.NormalForeColor = Color.White;
            cuiButton2.NormalImageTint = Color.Black;
            cuiButton2.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            cuiButton2.OutlineThickness = 1F;
            cuiButton2.Padding = new Padding(12);
            cuiButton2.PressedBackground = Color.WhiteSmoke;
            cuiButton2.PressedForeColor = Color.FromArgb(32, 32, 32);
            cuiButton2.PressedImageTint = Color.FromArgb(32, 32, 32);
            cuiButton2.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            cuiButton2.Rounding = new Padding(20);
            cuiButton2.Size = new Size(125, 45);
            cuiButton2.TabIndex = 3;
            cuiButton2.TextAlignment = StringAlignment.Center;
            cuiButton2.TextPadding = 12;
            cuiButton2.TextSpacing = 2;
            cuiButton2.Click += cuiButton2_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // AutorizationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 461);
            Controls.Add(cuiButton2);
            Controls.Add(cuiButton1);
            Controls.Add(cuiTextBox2);
            Controls.Add(cuiTextBox1);
            Name = "AutorizationForm";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private HartUI.Controls.cuiTextBox cuiTextBox1;
        private HartUI.Controls.cuiTextBox cuiTextBox2;
        private HartUI.Controls.cuiButton cuiButton1;
        private HartUI.Controls.cuiButton cuiButton2;
        private ErrorProvider errorProvider1;
    }
}
