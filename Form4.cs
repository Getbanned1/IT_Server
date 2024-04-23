using LinqToDB.SqlQuery;
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
    public partial class Change : Form
    {
        public Change()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void UpdateData()
        {
            SQLiteConnection m_dbConn = new SQLiteConnection("Data Source=It-Server.db");
            SQLiteCommand m_sqlCmd = new SQLiteCommand();
            m_sqlCmd.Connection = m_dbConn;
            Random randomid = new Random();
            using (DataTable dt = new DataTable())
            {
                string SqlExpression = "UPDATE Data SET Name = '"+ textBox7.Text + "', Surname='"+ textBox2.Text + "', Patronymic='"+ textBox3.Text + "', Equipment='"+ textBox4.Text + "', Department='"+ textBox5.Text + "', Condition='"+ textBox6.Text + "' WHERE ItemId='"+ textBox1.Text + "'";
                using (var connection = new SQLiteConnection("Data Source=It-Server.db"))
                {
                    connection.Open();
                    SQLiteCommand com = new SQLiteCommand(SqlExpression, connection);
                    int number = com.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }
    }
}
