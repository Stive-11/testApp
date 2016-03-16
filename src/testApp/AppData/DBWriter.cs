using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using testApp.Models;

namespace testApp.AppData
{
    public class DBWriter
    {
        private SqlConnection myConnection;
        public DBWriter()
        {
           var dbFileName = Directory.GetParent(Directory.GetCurrentDirectory()) + @"\AppData\persons.mdf";

            var connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = " + dbFileName +                                       
                                    @" Integrated Security = True; Connect Timeout = 30";
            myConnection = new SqlConnection(connectionString);
        }

        public bool SavePerson(PersonInfo person)
        {
            try
            {
                using (myConnection)
                {
                    myConnection.Open();
                    GetCommand(person).ExecuteNonQuery();
                    myConnection.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
            return true;
        }

        private SqlCommand GetCommand(PersonInfo person)
        {
            SqlCommand myCommand = new SqlCommand();
            myCommand.Connection = myConnection;
            var command = "INSERT INTO Person (FirstName, LastName, Company, Email, Vip) " +
                                    "Values (@firstname, @lastname, @company, @email, @vip)";
            myCommand.CommandText = command;
            myCommand.Parameters.AddWithValue("@firstname", person.FirstName);
            myCommand.Parameters.AddWithValue("@lastname", person.LastName);
            myCommand.Parameters.AddWithValue("@company", person.Company);
            myCommand.Parameters.AddWithValue("@email", person.Email);
            myCommand.Parameters.AddWithValue("@vip", person.Vip);
            
            return myCommand;
        }
    }
}
