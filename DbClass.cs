using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace It_Server
{
    internal class DbClass : Form1
    {
        private string dbFileName;
        private SQLiteConnection m_dbConn;
        SQLiteCommand com = new SQLiteCommand();
        string path = @"C:\Users\79616\source\repos\It_Server\It_Server\Ресурсы\Фамилии.txt";
        string path2 = @"C:\Users\79616\source\repos\It_Server\It_Server\Ресурсы\Имена женские.txt";
        string path3 = @"C:\Users\79616\source\repos\It_Server\It_Server\Ресурсы\Имена мужские.txt";
        string path4 = @"C:\Users\79616\source\repos\It_Server\It_Server\Ресурсы\Отчества женские.txt";
        string path5 = @"C:\Users\79616\source\repos\It_Server\It_Server\Ресурсы\Отчества мужские.txt";
        string path6 = @"C:\Users\79616\source\repos\It_Server\It_Server\Ресурсы\Список оборудования.txt";
        string path7 = @"C:\Users\79616\source\repos\It_Server\It_Server\Ресурсы\Список отделов.txt";
        



        public void AppendDataForDB()
        {
            var Surnames = ReadDataForDB(path);
            var FNames = ReadDataForDB(path2);
            var MNames = ReadDataForDB(path3);
            var FPatronymic = ReadDataForDB(path4);
            var VPatronymic = ReadDataForDB(path5);
            var Equipment = ReadDataForDB(path6);
            var Department = ReadDataForDB(path7);

            Random rand = new Random();
            for(int i = 0; i<=10;i++)
            {
                try
                {
                    
                    com.CommandText = "INSERT INTO Data2 (Name,Surname,Patronymic,Equipment,Department) VALUES('{FNames},{Surnames},{MNames},{Equipment},{Department}')";
                    com.Parameters.AddWithValue("Name", MNames);
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
