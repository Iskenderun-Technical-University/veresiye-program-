namespace veresiye_defteri_v1._1
{
    partial class Form_add_process
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
            richTextBox_explanation = new RichTextBox();
            label2 = new Label();
            textBox_fiyat = new TextBox();
            button_process_save = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(86, 24);
            label1.TabIndex = 0;
            label1.Text = "AÇIKLAMA:";
            // 
            // richTextBox_explanation
            // 
            richTextBox_explanation.Location = new Point(12, 36);
            richTextBox_explanation.Name = "richTextBox_explanation";
            richTextBox_explanation.Size = new Size(307, 79);
            richTextBox_explanation.TabIndex = 1;
            richTextBox_explanation.Text = "";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 129);
            label2.Name = "label2";
            label2.Size = new Size(50, 24);
            label2.TabIndex = 2;
            label2.Text = "FİYAT:";
            // 
            // textBox_fiyat
            // 
            textBox_fiyat.Location = new Point(68, 129);
            textBox_fiyat.Name = "textBox_fiyat";
            textBox_fiyat.Size = new Size(100, 23);
            textBox_fiyat.TabIndex = 3;
            // 
            // button_process_save
            // 
            button_process_save.Location = new Point(234, 129);
            button_process_save.Name = "button_process_save";
            button_process_save.Size = new Size(85, 34);
            button_process_save.TabIndex = 4;
            button_process_save.Text = "KAYDET";
            button_process_save.UseVisualStyleBackColor = true;
            button_process_save.Click += button_process_save_Click;
            // 
            // Form_add_process
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 188);
            Controls.Add(button_process_save);
            Controls.Add(textBox_fiyat);
            Controls.Add(label2);
            Controls.Add(richTextBox_explanation);
            Controls.Add(label1);
            Name = "Form_add_process";
            Text = "Form_add_process";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RichTextBox richTextBox_explanation;
        private Label label2;
        private TextBox textBox_fiyat;
        private Button button_process_save;
    }
}