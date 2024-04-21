using Humanizer;
using MySqlConnector;
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

namespace It_Server
{
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttondel_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox1.Text))
            {
                DeleteData();
            }
        }
        private void DeleteData()
        {
            SQLiteConnection m_dbConn = new SQLiteConnection("Data Source=It-Server.db");
            SQLiteCommand m_sqlCmd = new SQLiteCommand();
            m_sqlCmd.Connection = m_dbConn;
            using (DataTable dt = new DataTable())
            {
                using (m_dbConn)
                {
                    try
                    {
                        m_dbConn.Open();
                        string sql = $"DELETE FROM Data WHERE Name=@Name or Surname=@Surname or Patronymic=@Patronymic or Equipment=@Equipment or Department=@Department or ItemID=@ItemID or Condition=@Condition ";
                        SQLiteCommand com = new SQLiteCommand(sql, m_dbConn);
                        com.Parameters.AddWithValue("Name", textBox1.Text);
                        com.Parameters.AddWithValue("Surname", textBox1.Text);
                        com.Parameters.AddWithValue("Patronymic", textBox1.Text);
                        com.Parameters.AddWithValue("Equipment", textBox1.Text);
                        com.Parameters.AddWithValue("Department", textBox1.Text);
                        com.Parameters.AddWithValue("ItemID", textBox1.Text);
                        com.Parameters.AddWithValue("Condition", textBox1.Text);
                        using (SQLiteDataAdapter ad = new SQLiteDataAdapter(com))
                        {
                            com.Connection = m_dbConn;
                            ad.Fill(dt);

                        }
                        m_dbConn.Close();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
                



                

                
            }
        }
    }
}
