namespace It_Server
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
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.Silver;
            button2.ForeColor = SystemColors.ControlDarkDark;
            button2.Location = new Point(287, 126);
            button2.Name = "button2";
            button2.Size = new Size(85, 23);
            button2.TabIndex = 5;
            button2.Text = "Применить";
            button2.UseVisualStyleBackColor = false;
            // 
            // Add
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(384, 161);
            Controls.Add(button2);
            MaximumSize = new Size(400, 200);
            MinimumSize = new Size(400, 200);
            Name = "Add";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Добавление";
            ResumeLayout(false);
        }

        #endregion

        private Button button2;
    }
}