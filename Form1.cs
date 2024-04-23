using System.Data;
using System.Data.SQLite;
using System.IO;

namespace It_Server
{
    public partial class Form1 : Form
    {
        protected string dbFileName;
        private SQLiteConnection m_dbConn;
        private SQLiteCommand m_sqlCmd;
        public Form1()
        {

            InitializeComponent();

        }
        public void DbConnect()
        {

            m_dbConn = new SQLiteConnection();
            m_sqlCmd = new SQLiteCommand();
            try
            {
                m_dbConn = new SQLiteConnection(@"Data Source=It-Server.db");
                m_dbConn.Open();
                m_sqlCmd.Connection = m_dbConn;

                lbStatusText.Text = "Connected";

            }
            catch (SQLiteException ex)
            {
                lbStatusText.Text = "Disconnected";

                MessageBox.Show("Error: " + ex.Message);
            }
            DbClass db = new DbClass();
            //db.AppendDataForDB();
            DataTable dt = new DataTable();
            using (SQLiteDataAdapter ad = new SQLiteDataAdapter("SELECT * FROM Data", m_dbConn))
            {
                ad.Fill(dt);
                dataGridView1.DataSource = dt;
            }

            m_dbConn.Close();

        }
        private void Search_Click(object sender, EventArgs e)
        {
            Search.Text = string.Empty;
            DbConnect();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Delete form3 = new Delete();
            form3.Show();




        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add addForm = new Add();
            addForm.Show();
            DbClass db = new DbClass();
            DbConnect();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Change change = new Change();
            change.Show();

        }

        private void checkBox_Stay()
        {
            m_dbConn = new SQLiteConnection("Data Source=It-Server.db");
            m_dbConn.Open();
            DataTable dt = new DataTable();
            using (SQLiteDataAdapter ad = new SQLiteDataAdapter("SELECT * FROM Data", m_dbConn))
            {
                ad.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            m_dbConn.Close();
        }

        private void checkBox1_Change()
        {

            m_dbConn = new SQLiteConnection("Data Source=It-Server.db");
            m_dbConn.Open();
            DataTable dt = new DataTable();
            using (SQLiteDataAdapter ad = new SQLiteDataAdapter("SELECT * FROM Data WHERE Condition = 'Списано'", m_dbConn))
            {
                ad.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            m_dbConn.Close();
        }
        private void checkBox2_Change()
        {

            m_dbConn = new SQLiteConnection("Data Source=It-Server.db");
            m_dbConn.Open();
            DataTable dt = new DataTable();
            using (SQLiteDataAdapter ad = new SQLiteDataAdapter("SELECT * FROM Data WHERE Condition = 'Не Списано'", m_dbConn))
            {
                ad.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            m_dbConn.Close();
        }

        private void Check(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true && checkBox2.Checked == true)
            {
                checkBox_Stay();
            }
            else if (checkBox1.Checked == false && checkBox2.Checked == true | checkBox2.Checked == true)
            {
                checkBox2_Change();
            }
            else if (checkBox1.Checked == true && checkBox2.Checked == true)
            {
                checkBox_Stay();

            }
            else if (checkBox1.Checked == true && checkBox2.Checked == false | checkBox1.Checked == true)
            {
                checkBox1_Change();
            }
            else if (checkBox1.Checked == false && checkBox2.Checked == false)
            {
                checkBox_Stay();
            }
        }
        private void SearchClick(object sender, EventArgs e)
        {
            Search.Text = string.Empty;
            DbConnect();

        }
        private void SearchInDB()
        {
            if (!string.IsNullOrEmpty(Search.Text))
            {
                try
                {
                    m_dbConn = new SQLiteConnection("Data Source=It-Server.db");
                    m_sqlCmd.Connection = m_dbConn;
                    using (DataTable dt = new DataTable())
                    {
                        using (SQLiteCommand com = new SQLiteCommand("SELECT * FROM Data WHERE Name=@Name or Surname=@Surname or Patronymic=@Patronymic or Equipment=@Equipment or Department=@Department or ItemID=@ItemID or Condition=@Condition"))
                        {
                            com.Parameters.AddWithValue("Name", Search.Text.ToString());
                            com.Parameters.AddWithValue("Surname", Search.Text.ToString());
                            com.Parameters.AddWithValue("Patronymic", Search.Text.ToString());
                            com.Parameters.AddWithValue("Equipment", Search.Text.ToString());
                            com.Parameters.AddWithValue("Department", Search.Text.ToString());
                            com.Parameters.AddWithValue("ItemID", Search.Text.ToString());
                            com.Parameters.AddWithValue("Condition", Search.Text.ToString());
                            m_dbConn.Open();
                            using (SQLiteDataAdapter ad = new SQLiteDataAdapter(com))
                            {
                                com.Connection = m_dbConn;
                                ad.Fill(dt);
                                dataGridView1.DataSource = dt;
                            }
                            m_dbConn.Close();
                        }
                    }
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SearchInDB();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Search_SelectedIndexChanged(object sender, EventArgs e)
        {

        }






    }
}
