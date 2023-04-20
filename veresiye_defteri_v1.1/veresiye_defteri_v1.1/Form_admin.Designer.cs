namespace veresiye_defteri_v1._1
{
    partial class Form_admin
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
            panel_screen = new Panel();
            panel_button = new Panel();
            button_customer = new Button();
            button_user = new Button();
            tableLayoutPanel1.SuspendLayout();
            panel_button.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel_screen, 0, 1);
            tableLayoutPanel1.Controls.Add(panel_button, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel_screen
            // 
            panel_screen.Dock = DockStyle.Fill;
            panel_screen.Location = new Point(3, 58);
            panel_screen.Name = "panel_screen";
            panel_screen.Size = new Size(794, 389);
            panel_screen.TabIndex = 0;
            // 
            // panel_button
            // 
            panel_button.Controls.Add(button_customer);
            panel_button.Controls.Add(button_user);
            panel_button.Dock = DockStyle.Fill;
            panel_button.Location = new Point(3, 3);
            panel_button.Name = "panel_button";
            panel_button.Size = new Size(794, 49);
            panel_button.TabIndex = 1;
            // 
            // button_customer
            // 
            button_customer.Location = new Point(114, 3);
            button_customer.Name = "button_customer";
            button_customer.Size = new Size(105, 43);
            button_customer.TabIndex = 1;
            button_customer.Text = "MÜŞTERİ İŞLEMLERİ";
            button_customer.UseVisualStyleBackColor = true;
            // 
            // button_user
            // 
            button_user.Location = new Point(3, 3);
            button_user.Name = "button_user";
            button_user.Size = new Size(105, 43);
            button_user.TabIndex = 0;
            button_user.Text = "KULLANICI İŞLEMLERİ";
            button_user.UseVisualStyleBackColor = true;
            button_user.Click += button_user_Click;
            // 
            // Form_admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            IsMdiContainer = true;
            Name = "Form_admin";
            Text = "Form_admin";
            FormClosing += Form_admin_FormClosing;
            tableLayoutPanel1.ResumeLayout(false);
            panel_button.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel_screen;
        private Panel panel_button;
        private Button button_customer;
        private Button button_user;
    }
}