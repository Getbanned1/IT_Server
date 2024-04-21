namespace It_Server
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            form1BindingSource = new BindingSource(components);
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            lbStatusText = new Label();
            form1BindingSource1 = new BindingSource(components);
            bindingSource1 = new BindingSource(components);
            bindingSourceBindingSource = new BindingSource(components);
            button4 = new Button();
            Search = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)form1BindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)form1BindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = SystemColors.ControlDark;
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.ControlDark;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.BackgroundColor = Color.Silver;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.ActiveBorder;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.Location = new Point(140, 77);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(732, 262);
            dataGridView1.TabIndex = 0;
            // 
            // form1BindingSource
            // 
            form1BindingSource.DataSource = typeof(Form1);
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.Silver;
            checkBox1.ForeColor = SystemColors.WindowText;
            checkBox1.Location = new Point(710, 52);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(74, 19);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "Списано";
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.CheckStateChanged += Check;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.BackColor = Color.Silver;
            checkBox2.ForeColor = SystemColors.WindowText;
            checkBox2.Location = new Point(780, 52);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(92, 19);
            checkBox2.TabIndex = 3;
            checkBox2.Text = "Не Списано";
            checkBox2.UseVisualStyleBackColor = false;
            checkBox2.CheckStateChanged += Check;
            // 
            // button1
            // 
            button1.BackColor = Color.Silver;
            button1.ForeColor = SystemColors.WindowText;
            button1.Location = new Point(12, 77);
            button1.Name = "button1";
            button1.Size = new Size(122, 23);
            button1.TabIndex = 4;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Silver;
            button2.ForeColor = SystemColors.WindowText;
            button2.Location = new Point(12, 137);
            button2.Name = "button2";
            button2.Size = new Size(122, 23);
            button2.TabIndex = 5;
            button2.Text = "Удалить";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Silver;
            button3.ForeColor = SystemColors.WindowText;
            button3.Location = new Point(12, 203);
            button3.Name = "button3";
            button3.Size = new Size(122, 23);
            button3.TabIndex = 6;
            button3.Text = "Изменить";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.DimGray;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(227, 42);
            label1.TabIndex = 7;
            label1.Text = "Информационная система для упраления Инвентаризацией";
            // 
            // lbStatusText
            // 
            lbStatusText.AutoSize = true;
            lbStatusText.Location = new Point(12, 324);
            lbStatusText.Name = "lbStatusText";
            lbStatusText.Size = new Size(121, 15);
            lbStatusText.TabIndex = 8;
            lbStatusText.Text = "Подключение к сети";
            // 
            // form1BindingSource1
            // 
            form1BindingSource1.DataSource = typeof(Form1);
            // 
            // bindingSourceBindingSource
            // 
            bindingSourceBindingSource.DataSource = typeof(BindingSource);
            // 
            // button4
            // 
            button4.BackColor = Color.Silver;
            button4.ForeColor = SystemColors.WindowText;
            button4.Location = new Point(804, 12);
            button4.Name = "button4";
            button4.Size = new Size(68, 23);
            button4.TabIndex = 10;
            button4.Text = "Поиск";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // Search
            // 
            Search.BackColor = Color.Silver;
            Search.FormattingEnabled = true;
            Search.Location = new Point(584, 13);
            Search.Name = "Search";
            Search.Size = new Size(214, 23);
            Search.TabIndex = 11;
            Search.Text = "Поиск по управляющим отделам";
            Search.Click += SearchClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(884, 361);
            Controls.Add(Search);
            Controls.Add(button4);
            Controls.Add(lbStatusText);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(dataGridView1);
            ForeColor = SystemColors.ControlLightLight;
            MaximumSize = new Size(900, 400);
            MinimumSize = new Size(900, 400);
            Name = "Form1";
            Text = "IT-Server";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)form1BindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)form1BindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        public Label lbStatusText;
        private BindingSource form1BindingSource1;
        private BindingSource form1BindingSource;
        public BindingSource bindingSource1;
        public DataGridView dataGridView1;
        private BindingSource bindingSourceBindingSource;
        private Button button4;
        private ComboBox Search;
    }
}