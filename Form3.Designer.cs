namespace It_Server
{
    partial class Delete
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
            dataAdd = new Label();
            textBox1 = new TextBox();
            buttondel = new Button();
            SuspendLayout();
            // 
            // dataAdd
            // 
            dataAdd.AutoSize = true;
            dataAdd.ForeColor = SystemColors.ButtonHighlight;
            dataAdd.Location = new Point(28, 11);
            dataAdd.Name = "dataAdd";
            dataAdd.Size = new Size(337, 15);
            dataAdd.TabIndex = 8;
            dataAdd.Text = "Введите данные для удаления(Имя Фамилия Отчество и тд.)";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(28, 50);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(337, 23);
            textBox1.TabIndex = 9;
            // 
            // buttondel
            // 
            buttondel.BackColor = Color.Silver;
            buttondel.ForeColor = SystemColors.ActiveCaptionText;
            buttondel.Location = new Point(280, 326);
            buttondel.Name = "buttondel";
            buttondel.Size = new Size(85, 23);
            buttondel.TabIndex = 10;
            buttondel.Text = "Применить";
            buttondel.UseVisualStyleBackColor = false;
            buttondel.Click += buttondel_Click;
            // 
            // Delete
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(384, 361);
            Controls.Add(buttondel);
            Controls.Add(textBox1);
            Controls.Add(dataAdd);
            Name = "Delete";
            Text = "Удаление";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label dataAdd;
        private TextBox textBox1;
        private Button buttondel;
    }
}