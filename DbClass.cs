using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace It_Server
{
    internal class DbClass : Form1
    {
        
        
        string path = @"C:\Users\79616\source\repos\It_Server\It_Server\Ресурсы\Фамилии.txt";
        string path2 = @"C:\Users\79616\source\repos\It_Server\It_Server\Ресурсы\Имена женские.txt";
        string path3 = @"C:\Users\79616\source\repos\It_Server\It_Server\Ресурсы\Имена мужские.txt";
        string path4 = @"C:\Users\79616\source\repos\It_Server\It_Server\Ресурсы\Отчества женские.txt";
        string path5 = @"C:\Users\79616\source\repos\It_Server\It_Server\Ресурсы\Отчества мужские.txt";
        string path6 = @"C:\Users\79616\source\repos\It_Server\It_Server\Ресурсы\Список оборудования.txt";
        string path7 = @"C:\Users\79616\source\repos\It_Server\It_Server\Ресурсы\Список отделов.txt";
        

        Random rand = new Random();
        

        public void AppendDataForDB()
        {
            var Surnames = ReadDataForDB(path);
            var FNames = ReadDataForDB(path2);
            var MNames = ReadDataForDB(path3);
            var FPatronymic = ReadDataForDB(path4);
            var MPatronymic = ReadDataForDB(path5);
            var Equipment = ReadDataForDB(path6);
            var Department = ReadDataForDB(path7);

            Random rand = new Random();
            
                try
                {
                    using (SQLiteConnection connection = new SQLiteConnection("Data Source=C:\\Users\\79616\\source\\repos\\It_Server\\It_Server\\It-Server.db"))
                    {
                        
                        connection.Open();
                        for (int i = 0; i <= 200; i++)
                        {
                            using(SQLiteCommand command = connection.CreateCommand())
                            { 
                                string CommandText = "INSERT INTO Data (Name,Surname,Patronymic,Equipment,Department) VALUES('" + FNames[rand.Next(FNames.Count)] + "','" + Surnames[rand.Next(Surnames.Count)] + "','" + FPatronymic[rand.Next(FPatronymic.Count)] + "','" + Equipment[rand.Next(Equipment.Count)] + "','" + Department[rand.Next(Department.Count)] + "')";
                                command.CommandText = CommandText;
                                command.Connection = connection;
                                //command.ExecuteNonQuery();
                                
                            }
                        using (SQLiteCommand command = connection.CreateCommand())
                        {
                            string CommandText = "INSERT INTO Data (Name,Surname,Patronymic,Equipment,Department) VALUES('" + MNames[rand.Next(MNames.Count)] + "','" + Surnames[rand.Next(Surnames.Count)] + "','" + MPatronymic[rand.Next(MPatronymic.Count)] + "','" + Equipment[rand.Next(Equipment.Count)] + "','" + Department[rand.Next(Department.Count)] + "')";
                            command.CommandText = CommandText;
                            command.Connection = connection;
                            //command.ExecuteNonQuery();
                            
                        }
                    }                                 
                        
                    }
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show("Errors: " + ex.Message);
                }

            
            
        }

        private List<string> ReadDataForDB(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {   
                List<string> lines = File.ReadAllLines(path).ToList();
                return lines;
            }

        }
    }
}
