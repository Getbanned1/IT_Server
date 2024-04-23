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
        public string fullpath = @"Data Source=" + Path.GetFullPath("It-Server.db");
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
            SQLiteConnection m_dbConn = new SQLiteConnection(fullpath);
            SQLiteCommand m_sqlCmd = new SQLiteCommand();
            m_sqlCmd.Connection = m_dbConn;
            Random randomid = new Random();
            using (DataTable dt = new DataTable())
            {
                using (SQLiteCommand com = new SQLiteCommand("Insert INTO Data(Name, Surname, Patronymic, Equipment, Department, ItemID, Condition)VALUES(?, ?, ?, ?, ?, ?, ?)", m_dbConn))
                {
                    m_dbConn.Open();
                    com.Parameters.AddWithValue("@Name", textBox1.Text.ToString());
                    com.Parameters.AddWithValue("@Surname", textBox2.Text.ToString());
                    com.Parameters.AddWithValue("@Patronymic", textBox3.Text.ToString());
                    com.Parameters.AddWithValue("@Equipment", textBox4.Text.ToString());
                    com.Parameters.AddWithValue("@Department", textBox5.Text.ToString());
                    com.Parameters.AddWithValue("@ItemID", "93" + randomid.Next(100000, 999999).ToString());
                    com.Parameters.AddWithValue("@Condition", textBox6.Text.ToString());
                    using (SQLiteDataAdapter ad = new SQLiteDataAdapter(com))
                    {
                        com.Connection = m_dbConn;
                        ad.Fill(dt);

                    }
                    m_dbConn.Close();
                }
           
            }
        }
    }
}
