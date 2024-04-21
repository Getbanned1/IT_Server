using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace It_Server
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddData();
        }
        private void AddData()
        {
            Random randomid = new Random();
            using (SQLiteCommand com = new SQLiteCommand("Insert INTO Data Name=@Name or Surname=@Surname or Patronymic=@Patronymic or Equipment=@Equipment or Department=@Department or ItemID=@ItemID or Condition=@Condition"))
            {
                com.Parameters.AddWithValue("Name", textBox1.Text.ToString());
                com.Parameters.AddWithValue("Surname", textBox2.Text.ToString());
                com.Parameters.AddWithValue("Patronymic", textBox3.Text.ToString());
                com.Parameters.AddWithValue("Equipment", textBox4.Text.ToString());
                com.Parameters.AddWithValue("Department", textBox5.Text.ToString());
                com.Parameters.AddWithValue("ItemID", "93" + randomid.Next(100000, 999999).ToString());
                com.Parameters.AddWithValue("Condition", textBox6.Text.ToString());
            }
        }
    }
}
