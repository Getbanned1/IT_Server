﻿namespace It_Server
{
    partial class Add
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
            button2 = new Button();
            textBox1 = new TextBox();
            dataAdd = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox6 = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.Silver;
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(280, 326);
            button2.Name = "button2";
            button2.Size = new Size(85, 23);
            button2.TabIndex = 5;
            button2.Text = "Применить";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(114, 37);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(173, 23);
            textBox1.TabIndex = 6;
            // 
            // dataAdd
            // 
            dataAdd.AutoSize = true;
            dataAdd.ForeColor = SystemColors.ButtonHighlight;
            dataAdd.Location = new Point(14, 11);
            dataAdd.Name = "dataAdd";
            dataAdd.Size = new Size(351, 15);
            dataAdd.TabIndex = 7;
            dataAdd.Text = "Введите данные для добавления(Имя Фамилия Отчество и тд.)";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(114, 77);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(173, 23);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(114, 123);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(173, 23);
            textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(114, 166);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(173, 23);
            textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(114, 209);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(173, 23);
            textBox5.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(14, 40);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 12;
            label1.Text = "Имя";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(14, 80);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 13;
            label2.Text = "Фамилия";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(14, 126);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 14;
            label3.Text = "Отчество";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(14, 169);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 15;
            label4.Text = "Оборудование";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(14, 212);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 16;
            label5.Text = "Отдел";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(114, 252);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(173, 23);
            textBox6.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(14, 255);
            label6.Name = "label6";
            label6.Size = new Size(66, 15);
            label6.TabIndex = 18;
            label6.Text = "Состояние";
            // 
            // Add
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(384, 361);
            Controls.Add(label6);
            Controls.Add(textBox6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(dataAdd);
            Controls.Add(textBox1);
            Controls.Add(button2);
            MaximumSize = new Size(400, 400);
            MinimumSize = new Size(400, 400);
            Name = "Add";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Добавление";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox6;
        private Label label6;
        public Label dataAdd;
    }
}