using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Day4
{
    //interface will have just definitions for
    //methods
    //properties
    //events
    //indxer
    //by default all memebers are public

    interface IDataAccess
    {
        string ReadData(string connectionName);
        void writeData(string connectionName);
        string DataConnection { get; set; }
    }

    interface IMessaging
    {
        void SendSMS();
        void SendEmail();
    }
    class FileAccess : IDataAccess, IMessaging
    {
        public string DataConnection { get; set; }

        public string ReadData(string connectionName)
        {

            Console.WriteLine("Reading data from File");
            return "File data";
        }

        public void SendEmail()
        {
            //throw new NotImplementedException();
        }

        public void SendSMS()
        {
            //throw new NotImplementedException();
        }

        public void writeData(string connectionName)
        {
            Console.Write("writing data to File server");

        }
    }
    class SQLDataAccess : IDataAccess
    {
        public string DataConnection { get; set; }

        public string ReadData(string connectionName)
        {

            Console.WriteLine("Reading data from SQL Server");
            return "SQL data";
        }

        public void writeData(string connectionName)
        {
            Console.Write("writing data to SQL server");

        }
    }
    class Interfaces
    {
        static void Main(string[] args)
        {
            //SQLDataAccess access = new SQLDataAccess();
            ////IDataAccess iaccess = access;
            //access.DataConnection = "sql";
            //SaveData(access);

            FileAccess access = new FileAccess();
            access.DataConnection = "filename";
            SaveData(access);
            //access.ReadData("sql");
            //access.writeData("sql");
            Console.ReadLine();
        }

        static void SaveData(IDataAccess access) //interface
        {
            access.ReadData(access.DataConnection);
            access.writeData(access.DataConnection);
        }
    }
}

