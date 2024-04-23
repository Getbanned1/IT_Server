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
        
        
        string path = @"C:\Users\79616\Source\Repos\Getbanned1\IT_Server\bin - Копировать\Debug\net7.0-windows\Ресурсы\Фамилии.txt";
        string path2 = @"C:\Users\79616\Source\Repos\Getbanned1\IT_Server\bin - Копировать\Debug\net7.0-windows\Ресурсы\Имена женские.txt";
        string path3 = @"C:\Users\79616\Source\Repos\Getbanned1\IT_Server\bin - Копировать\Debug\net7.0-windows\Ресурсы\Имена мужские.txt";
        string path4 = @"C:\Users\79616\Source\Repos\Getbanned1\IT_Server\bin - Копировать\Debug\net7.0-windows\Ресурсы\Отчества женские.txt";
        string path5 = @"C:\Users\79616\Source\Repos\Getbanned1\IT_Server\bin - Копировать\Debug\net7.0-windows\Ресурсы\Отчества мужские.txt";
        string path6 = @"C:\Users\79616\Source\Repos\Getbanned1\IT_Server\bin - Копировать\Debug\net7.0-windows\Ресурсы\Список оборудования.txt";
        string path7 = @"C:\Users\79616\Source\Repos\Getbanned1\IT_Server\bin - Копировать\Debug\net7.0-windows\Ресурсы\Список отделов.txt";
        

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
            List<string> conditions = new List<string>();
            conditions.Add("Не Списано");
            conditions.Add("Списано");
            Random rand = new Random();
            Random randomid = new Random();
                try
                {
                    using (SQLiteConnection connection = new SQLiteConnection(fullpath))
                    {
                        
                        
                        for (int i = 0; i <= 200; i++)
                        {
                            using(SQLiteCommand command = connection.CreateCommand())
                            {
                                connection.Open();
                                string CommandText = "INSERT INTO Data (Name,Surname,Patronymic,Equipment,Department,ItemID,Condition) VALUES('" + FNames[rand.Next(FNames.Count)] + "','" + Surnames[rand.Next(Surnames.Count)] + "','" + FPatronymic[rand.Next(FPatronymic.Count)] + "','" + Equipment[rand.Next(Equipment.Count)] + "','" + Department[rand.Next(Department.Count)] + "','"+"93"+randomid.Next(100000,999999).ToString() +"','"+ conditions[rand.Next(conditions.Count)] +"')";
                                command.CommandText = CommandText;
                                command.Connection = connection;
                                command.ExecuteNonQuery();
                                
                            }
                        using (SQLiteCommand command = connection.CreateCommand())
                        {
                            string CommandText = "INSERT INTO Data (Name,Surname,Patronymic,Equipment,Department,ItemID,Condition) VALUES('" + MNames[rand.Next(MNames.Count)] + "','" + Surnames[rand.Next(Surnames.Count)] + "','" + MPatronymic[rand.Next(MPatronymic.Count)] + "','" + Equipment[rand.Next(Equipment.Count)] + "','" + Department[rand.Next(Department.Count)] + "','"+"93"+randomid.Next(100000,999999).ToString() + "','" + conditions[rand.Next(conditions.Count)] + "')";
                            command.CommandText = CommandText;
                            command.Connection = connection;
                            command.ExecuteNonQuery();
                            
                        }
                        connection.Close();
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
