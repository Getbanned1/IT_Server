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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            form1BindingSource = new BindingSource(components);
            Search = new ComboBox();
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
            dataGridViewCellStyle1.BackColor = SystemColors.ControlDark;
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ControlDark;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.BackgroundColor = SystemColors.ActiveBorder;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ActiveBorder;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new Point(140, 77);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(432, 262);
            dataGridView1.TabIndex = 0;
            // 
            // form1BindingSource
            // 
            form1BindingSource.DataSource = typeof(Form1);
            // 
            // Search
            // 
            Search.BackColor = SystemColors.ActiveBorder;
            Search.ForeColor = SystemColors.ControlLightLight;
            Search.FormattingEnabled = true;
            Search.Location = new Point(332, 12);
            Search.Name = "Search";
            Search.Size = new Size(240, 23);
            Search.TabIndex = 1;
            Search.Text = "Поиск по управляющим отделам";
            Search.SelectedIndexChanged += Search_SelectedIndexChanged;
            Search.Click += Search_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = SystemColors.ControlDarkDark;
            checkBox1.Location = new Point(400, 52);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(74, 19);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "Списано";
            checkBox1.UseVisualStyleBackColor = false;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.BackColor = SystemColors.ControlDarkDark;
            checkBox2.Location = new Point(489, 52);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(92, 19);
            checkBox2.TabIndex = 3;
            checkBox2.Text = "Не Списано";
            checkBox2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveBorder;
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
            button2.BackColor = SystemColors.ActiveBorder;
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
            button3.BackColor = SystemColors.ActiveBorder;
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
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(227, 42);
            label1.TabIndex = 7;
            label1.Text = "Информационная система для упраления Инвентаризацией";
            // 
            // lbStatusText
            // 
            lbStatusText.AutoSize = true;
            lbStatusText.Location = new Point(35, 284);
            lbStatusText.Name = "lbStatusText";
            lbStatusText.Size = new Size(38, 15);
            lbStatusText.TabIndex = 8;
            lbStatusText.Text = "label2";
            // 
            // form1BindingSource1
            // 
            form1BindingSource1.DataSource = typeof(Form1);
            // 
            // bindingSourceBindingSource
            // 
            bindingSourceBindingSource.DataSource = typeof(BindingSource);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(584, 361);
            Controls.Add(lbStatusText);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(Search);
            Controls.Add(dataGridView1);
            ForeColor = SystemColors.ControlLightLight;
            MaximumSize = new Size(600, 400);
            MinimumSize = new Size(600, 400);
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
        private ComboBox Search;
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
    }
}