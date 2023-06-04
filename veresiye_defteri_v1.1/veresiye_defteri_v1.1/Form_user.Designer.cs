namespace veresiye_defteri_v1._1
{
    partial class Form_user
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
            tableLayoutPanel2 = new TableLayoutPanel();
            dataGridView_process = new DataGridView();
            dataGridView_musteri = new DataGridView();
            panel_process = new Panel();
            button_process_del = new Button();
            textBox_process_del = new TextBox();
            button_process_add = new Button();
            panel_search = new Panel();
            textBox_searh = new TextBox();
            button_f5 = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_process).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_musteri).BeginInit();
            panel_process.SuspendLayout();
            panel_search.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(panel_process, 0, 2);
            tableLayoutPanel1.Controls.Add(panel_search, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 44.0806046F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55.9193954F));
            tableLayoutPanel2.Controls.Add(dataGridView_process, 1, 0);
            tableLayoutPanel2.Controls.Add(dataGridView_musteri, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 48);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(794, 309);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // dataGridView_process
            // 
            dataGridView_process.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_process.Dock = DockStyle.Fill;
            dataGridView_process.Location = new Point(353, 3);
            dataGridView_process.Name = "dataGridView_process";
            dataGridView_process.RowTemplate.Height = 25;
            dataGridView_process.Size = new Size(438, 303);
            dataGridView_process.TabIndex = 1;
            // 
            // dataGridView_musteri
            // 
            dataGridView_musteri.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_musteri.Dock = DockStyle.Fill;
            dataGridView_musteri.Location = new Point(3, 3);
            dataGridView_musteri.Name = "dataGridView_musteri";
            dataGridView_musteri.RowTemplate.Height = 25;
            dataGridView_musteri.Size = new Size(344, 303);
            dataGridView_musteri.TabIndex = 0;
            dataGridView_musteri.CellEnter += dataGridView_musteri_CellEnter;
            // 
            // panel_process
            // 
            panel_process.Controls.Add(button_process_del);
            panel_process.Controls.Add(textBox_process_del);
            panel_process.Controls.Add(button_process_add);
            panel_process.Dock = DockStyle.Fill;
            panel_process.Location = new Point(3, 363);
            panel_process.Name = "panel_process";
            panel_process.Size = new Size(794, 84);
            panel_process.TabIndex = 1;
            // 
            // button_process_del
            // 
            button_process_del.Location = new Point(98, 44);
            button_process_del.Name = "button_process_del";
            button_process_del.Size = new Size(97, 31);
            button_process_del.TabIndex = 2;
            button_process_del.Text = "VERESİYE SİL";
            button_process_del.UseVisualStyleBackColor = true;
            button_process_del.Click += button_process_del_Click;
            // 
            // textBox_process_del
            // 
            textBox_process_del.Location = new Point(98, 13);
            textBox_process_del.Name = "textBox_process_del";
            textBox_process_del.Size = new Size(97, 23);
            textBox_process_del.TabIndex = 1;
            // 
            // button_process_add
            // 
            button_process_add.Location = new Point(9, 13);
            button_process_add.Name = "button_process_add";
            button_process_add.Size = new Size(83, 62);
            button_process_add.TabIndex = 0;
            button_process_add.Text = "VERESİYE EKLE";
            button_process_add.UseVisualStyleBackColor = true;
            button_process_add.Click += button_process_add_Click;
            // 
            // panel_search
            // 
            panel_search.Controls.Add(textBox_searh);
            panel_search.Controls.Add(button_f5);
            panel_search.Dock = DockStyle.Fill;
            panel_search.Location = new Point(3, 3);
            panel_search.Name = "panel_search";
            panel_search.Size = new Size(794, 39);
            panel_search.TabIndex = 2;
            // 
            // textBox_searh
            // 
            textBox_searh.Location = new Point(98, 11);
            textBox_searh.Name = "textBox_searh";
            textBox_searh.Size = new Size(100, 23);
            textBox_searh.TabIndex = 1;
            textBox_searh.Text = "MÜŞTERİ ARA";
            textBox_searh.TextChanged += textBox_searh_TextChanged;
            // 
            // button_f5
            // 
            button_f5.Location = new Point(10, 7);
            button_f5.Name = "button_f5";
            button_f5.Size = new Size(82, 29);
            button_f5.TabIndex = 0;
            button_f5.Text = "YENİLE";
            button_f5.UseVisualStyleBackColor = true;
            button_f5.Click += button_f5_Click;
            // 
            // Form_user
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "Form_user";
            Text = "Form_user";
            FormClosing += Form_user_FormClosing;
            Load += Form_user_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_process).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_musteri).EndInit();
            panel_process.ResumeLayout(false);
            panel_process.PerformLayout();
            panel_search.ResumeLayout(false);
            panel_search.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private DataGridView dataGridView_process;
        private Panel panel_process;
        private Button button_process_del;
        private TextBox textBox_process_del;
        private Button button_process_add;
        private Panel panel_search;
        public DataGridView dataGridView_musteri;
        private Button button_f5;
        private TextBox textBox_searh;
    }
}