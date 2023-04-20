namespace veresiye_defteri_v1._1
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            textBox_user_code = new TextBox();
            textBox_user_password = new TextBox();
            button_login = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(143, 31);
            label1.Name = "label1";
            label1.Size = new Size(167, 25);
            label1.TabIndex = 0;
            label1.Text = "KULLANICI KODU :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(220, 76);
            label2.Name = "label2";
            label2.Size = new Size(90, 25);
            label2.TabIndex = 1;
            label2.Text = "PAROLA :";
            // 
            // textBox_user_code
            // 
            textBox_user_code.Location = new Point(316, 33);
            textBox_user_code.Name = "textBox_user_code";
            textBox_user_code.Size = new Size(105, 23);
            textBox_user_code.TabIndex = 2;
            // 
            // textBox_user_password
            // 
            textBox_user_password.Location = new Point(316, 78);
            textBox_user_password.Name = "textBox_user_password";
            textBox_user_password.Size = new Size(105, 23);
            textBox_user_password.TabIndex = 3;
            // 
            // button_login
            // 
            button_login.Location = new Point(346, 125);
            button_login.Name = "button_login";
            button_login.Size = new Size(75, 23);
            button_login.TabIndex = 4;
            button_login.Text = "GİRİŞ";
            button_login.UseVisualStyleBackColor = true;
            button_login.Click += button_login_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(455, 175);
            Controls.Add(button_login);
            Controls.Add(textBox_user_password);
            Controls.Add(textBox_user_code);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox_user_code;
        private TextBox textBox_user_password;
        private Button button_login;
    }
}