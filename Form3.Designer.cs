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
            // Delete
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(384, 361);
            Controls.Add(dataAdd);
            Name = "Delete";
            Text = "Удаление";
            Load += Form3_Load;
            Controls.SetChildIndex(dataAdd, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label dataAdd;
    }
}