using System.Data;
using System.Data.SQLite;
using System.IO;

namespace It_Server
{
    public partial class Form1 : Form
    {
        private string dbFileName;
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
            dbFileName = "C:\\Users\\vorin\\Desktop\\Проекты\\IT-server\\It_Server\\It_Server\\DB Browser for SQLite\\It-Server.db";
            //dbFileName = "D:\\MyDatabase.db";
            if (!File.Exists(dbFileName))
                MessageBox.Show("Please, create DB and blank table (Push \"Create\" button))");
            try
            {
                m_dbConn = new SQLiteConnection("Data Source=" + dbFileName);
                m_dbConn.Open();
                m_sqlCmd.Connection = m_dbConn;
                lbStatusText.Text = "Connected";

            }
            catch (SQLiteException ex)
            {
                lbStatusText.Text = "DisConnected";

                MessageBox.Show("Error: " + ex.Message);
            }
            DbClass db = new DbClass();
            DataTable dt = new DataTable();
            SQLiteDataAdapter ad = new SQLiteDataAdapter("SELECT * FROM Data", m_dbConn);
            db.AppendDataForDB();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;

            m_dbConn.Close();

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
    internal class DbClass : Form1
    {
        private string dbFileName;
        private SQLiteConnection m_dbConn;
        SQLiteCommand com = new SQLiteCommand();
        //string path = @"Фамилии.txt";
        //string path2 = @"C:\Users\vorin\Desktop\Проекты\IT-server\It_Server\It_Server\Ресурсы\Имена женские.txt";
        //string path3 = @"C:\Users\vorin\Desktop\Проекты\IT-server\It_Server\It_Server\Ресурсы\Имена мужские.txt";
        //string path4 = @"C:\Users\vorin\Desktop\Проекты\IT-server\It_Server\It_Server\Ресурсы\Отчества женские.txt";
        //string path5 = @"Отчества мужские.txt";
        //string path6 = @"Список оборудования.txt";
        //string path7 = @"Список отделов.txt";




        public void AppendDataForDB()
        {
            //var Surnames = ReadDataForDB(path);
            //var FNames = ReadDataForDB(path2);
            //var MNames = ReadDataForDB(path3);
            //var FPatronymic = ReadDataForDB(path4);
            //var VPatronymic = ReadDataForDB(path5);
            //var Equipment = ReadDataForDB(path6);
            //var Department = ReadDataForDB(path7);

            Random rand = new Random();
            for (int i = 0; i <= 10; i++)
            {
                try
                {

                    com.CommandText = "INSERT INTO Data2 (Name,Surname,Patronymic,Equipment,Department) VALUES('{FNames},{Surnames},{MNames},{Equipment},{Department}')";
                    //com.Parameters.AddWithValue("Name", MNames);
                    //MessageBox.Show(m_sqlCmd.ExecuteNonQuery().ToString());
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

            }

        }

        private List<string> ReadDataForDB(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string text = reader.ReadLine();
                List<string> list = new List<string>();
                list.Add(text);
                return list;
            }

        }
    }
}
