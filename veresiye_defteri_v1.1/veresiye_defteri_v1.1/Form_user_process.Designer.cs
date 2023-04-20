namespace veresiye_defteri_v1._1
{
    partial class Form_user_process
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
            tableLayoutPanel1 = new TableLayoutPanel();
            panel_left = new Panel();
            button_f5 = new Button();
            panel_info_screen = new Panel();
            button_user_add = new Button();
            button_user_save = new Button();
            button_user_del = new Button();
            label3 = new Label();
            textBox_password = new TextBox();
            label2 = new Label();
            textBox_user_code = new TextBox();
            label1 = new Label();
            textBox_name = new TextBox();
            dataGridView_users = new DataGridView();
            tableLayoutPanel1.SuspendLayout();
            panel_left.SuspendLayout();
            panel_info_screen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_users).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel_left, 0, 0);
            tableLayoutPanel1.Controls.Add(panel_info_screen, 2, 0);
            tableLayoutPanel1.Controls.Add(dataGridView_users, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(769, 438);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel_left
            // 
            panel_left.Controls.Add(button_f5);
            panel_left.Dock = DockStyle.Fill;
            panel_left.Location = new Point(3, 3);
            panel_left.Name = "panel_left";
            panel_left.Size = new Size(144, 432);
            panel_left.TabIndex = 0;
            // 
            // button_f5
            // 
            button_f5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button_f5.Location = new Point(27, 9);
            button_f5.Name = "button_f5";
            button_f5.Size = new Size(83, 41);
            button_f5.TabIndex = 0;
            button_f5.Text = "YENİLE";
            button_f5.UseVisualStyleBackColor = true;
            button_f5.Click += button_f5_Click;
            // 
            // panel_info_screen
            // 
            panel_info_screen.Controls.Add(button_user_add);
            panel_info_screen.Controls.Add(button_user_save);
            panel_info_screen.Controls.Add(button_user_del);
            panel_info_screen.Controls.Add(label3);
            panel_info_screen.Controls.Add(textBox_password);
            panel_info_screen.Controls.Add(label2);
            panel_info_screen.Controls.Add(textBox_user_code);
            panel_info_screen.Controls.Add(label1);
            panel_info_screen.Controls.Add(textBox_name);
            panel_info_screen.Dock = DockStyle.Fill;
            panel_info_screen.Location = new Point(462, 3);
            panel_info_screen.Name = "panel_info_screen";
            panel_info_screen.Size = new Size(304, 432);
            panel_info_screen.TabIndex = 2;
            // 
            // button_user_add
            // 
            button_user_add.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_user_add.Location = new Point(191, 318);
            button_user_add.Name = "button_user_add";
            button_user_add.Size = new Size(104, 50);
            button_user_add.TabIndex = 0;
            button_user_add.Text = "YENİ KULLANICI EKLE";
            button_user_add.UseVisualStyleBackColor = true;
            button_user_add.Click += button_user_add_Click;
            // 
            // button_user_save
            // 
            button_user_save.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_user_save.Location = new Point(212, 133);
            button_user_save.Name = "button_user_save";
            button_user_save.Size = new Size(83, 41);
            button_user_save.TabIndex = 1;
            button_user_save.Text = "KAYDET";
            button_user_save.UseVisualStyleBackColor = true;
            button_user_save.Click += button_user_save_Click;
            // 
            // button_user_del
            // 
            button_user_del.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_user_del.Location = new Point(212, 180);
            button_user_del.Name = "button_user_del";
            button_user_del.Size = new Size(83, 41);
            button_user_del.TabIndex = 2;
            button_user_del.Text = "SİL";
            button_user_del.UseVisualStyleBackColor = true;
            button_user_del.Click += button_user_del_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(25, 92);
            label3.Name = "label3";
            label3.Size = new Size(90, 25);
            label3.TabIndex = 5;
            label3.Text = "PAROLA :";
            // 
            // textBox_password
            // 
            textBox_password.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox_password.Location = new Point(121, 94);
            textBox_password.Name = "textBox_password";
            textBox_password.Size = new Size(174, 23);
            textBox_password.TabIndex = 4;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(25, 63);
            label2.Name = "label2";
            label2.Size = new Size(58, 25);
            label2.TabIndex = 3;
            label2.Text = "İSİM :";
            // 
            // textBox_user_code
            // 
            textBox_user_code.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox_user_code.Enabled = false;
            textBox_user_code.Location = new Point(198, 36);
            textBox_user_code.Name = "textBox_user_code";
            textBox_user_code.Size = new Size(97, 23);
            textBox_user_code.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(25, 34);
            label1.Name = "label1";
            label1.Size = new Size(167, 25);
            label1.TabIndex = 1;
            label1.Text = "KULLANICI KODU :";
            // 
            // textBox_name
            // 
            textBox_name.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox_name.Location = new Point(89, 65);
            textBox_name.Name = "textBox_name";
            textBox_name.Size = new Size(206, 23);
            textBox_name.TabIndex = 0;
            // 
            // dataGridView_users
            // 
            dataGridView_users.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_users.Dock = DockStyle.Fill;
            dataGridView_users.Location = new Point(153, 3);
            dataGridView_users.Name = "dataGridView_users";
            dataGridView_users.RowTemplate.Height = 25;
            dataGridView_users.Size = new Size(303, 432);
            dataGridView_users.TabIndex = 3;
            dataGridView_users.CellClick += dataGridView_users_CellClick;
            // 
            // Form_user_process
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(769, 438);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_user_process";
            Text = "Form_user_process";
            FormClosing += Form_user_process_FormClosing;
            Load += Form_user_process_Load;
            tableLayoutPanel1.ResumeLayout(false);
            panel_left.ResumeLayout(false);
            panel_info_screen.ResumeLayout(false);
            panel_info_screen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_users).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel_left;
        private Button button_user_del;
        private Button button_user_save;
        private Button button_user_add;
        private Panel panel_info_screen;
        private Label label3;
        private TextBox textBox_password;
        private Label label2;
        private TextBox textBox_user_code;
        private Label label1;
        private TextBox textBox_name;
        private DataGridView dataGridView_users;
        private Button button_f5;
    }
}