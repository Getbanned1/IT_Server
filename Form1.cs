using System.Data;
using System.Data.SQLite;
using System.IO;

namespace It_Server
{
    public partial class Form1 : Form
    {
        protected string dbFileName;
        protected SQLiteConnection m_dbConn;
        private SQLiteCommand m_sqlCmd;
        public Form1()
        {

            InitializeComponent();

        }
        public void DbConnect()
        {

            m_dbConn = new SQLiteConnection();
            m_sqlCmd = new SQLiteCommand();
            dbFileName = "";
            //dbFileName = "D:\\MyDatabase.db";
            //if (!File.Exists(dbFileName))
            //    MessageBox.Show("Please, create DB and blank table (Push \"Create\" button))");
            try
            {
                m_dbConn = new SQLiteConnection(@"Data Source=C:\Users\79616\source\repos\It_Server\It_Server\It-Server.db");
                m_dbConn.Open();
                m_sqlCmd.Connection = m_dbConn;
                lbStatusText.Text = "Connected";

            }
            catch (SQLiteException ex)
            {
                lbStatusText.Text = "Disconnected";

                MessageBox.Show("Error: " + ex.Message);
            }
            //DbClass db = new DbClass();
            //db.AppendDataForDB();

            m_dbConn.Close();
            DataTable dt = new DataTable();
            using (SQLiteDataAdapter ad = new SQLiteDataAdapter("SELECT * FROM Data", m_dbConn))
            {
                ad.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }




        private void Search_Click(object sender, EventArgs e)
        {
            Search.Text = string.Empty;
            DbConnect();
        }

        private void button2_Click(object sender, EventArgs e)
        {



        }

        private void button1_Click(object sender, EventArgs e)
        {
            DbClass db = new DbClass();
            db.AppendDataForDB();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Search_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}