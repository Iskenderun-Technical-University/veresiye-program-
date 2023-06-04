namespace veresiye_defteri_v1._1
{
    partial class Form_user_add
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox_name = new TextBox();
            textBox_password = new TextBox();
            textBox_again_password = new TextBox();
            button_user_add = new Button();
            label4 = new Label();
            comboBox_authority = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(114, 45);
            label1.Name = "label1";
            label1.Size = new Size(58, 25);
            label1.TabIndex = 0;
            label1.Text = "İSİM :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(82, 80);
            label2.Name = "label2";
            label2.Size = new Size(90, 25);
            label2.TabIndex = 1;
            label2.Text = "PAROLA :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 115);
            label3.Name = "label3";
            label3.Size = new Size(160, 25);
            label3.TabIndex = 2;
            label3.Text = "TEKRAR PAROLA :";
            // 
            // textBox_name
            // 
            textBox_name.Location = new Point(178, 45);
            textBox_name.Name = "textBox_name";
            textBox_name.Size = new Size(132, 23);
            textBox_name.TabIndex = 3;
            // 
            // textBox_password
            // 
            textBox_password.Location = new Point(178, 82);
            textBox_password.Name = "textBox_password";
            textBox_password.Size = new Size(132, 23);
            textBox_password.TabIndex = 4;
            // 
            // textBox_again_password
            // 
            textBox_again_password.Location = new Point(178, 117);
            textBox_again_password.Name = "textBox_again_password";
            textBox_again_password.Size = new Size(132, 23);
            textBox_again_password.TabIndex = 5;
            // 
            // button_user_add
            // 
            button_user_add.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_user_add.Location = new Point(228, 206);
            button_user_add.Name = "button_user_add";
            button_user_add.Size = new Size(82, 29);
            button_user_add.TabIndex = 6;
            button_user_add.Text = "KAYDET";
            button_user_add.UseVisualStyleBackColor = true;
            button_user_add.Click += button_user_add_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(104, 150);
            label4.Name = "label4";
            label4.Size = new Size(68, 25);
            label4.TabIndex = 7;
            label4.Text = "YETKİ :";
            // 
            // comboBox_authority
            // 
            comboBox_authority.FormattingEnabled = true;
            comboBox_authority.Items.AddRange(new object[] { "admin", "kullanıcı" });
            comboBox_authority.Location = new Point(178, 152);
            comboBox_authority.Name = "comboBox_authority";
            comboBox_authority.Size = new Size(132, 23);
            comboBox_authority.TabIndex = 8;
            // 
            // Form_user_add
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(325, 243);
            Controls.Add(comboBox_authority);
            Controls.Add(label4);
            Controls.Add(button_user_add);
            Controls.Add(textBox_again_password);
            Controls.Add(textBox_password);
            Controls.Add(textBox_name);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form_user_add";
            Text = "Form_user_add";
            Load += Form_user_add_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox_name;
        private TextBox textBox_password;
        private TextBox textBox_again_password;
        private Button button_user_add;
        private Label label4;
        private ComboBox comboBox_authority;
    }
}