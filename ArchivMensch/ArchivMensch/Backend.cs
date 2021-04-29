using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

using System.Windows.Forms;


//Backend connect SQL and pass them to forms
namespace ArchivMensch
{

    //https://www.youtube.com/watch?v=dYlo6M3m75Y
    //https://www.youtube.com/watch?v=ayp3tHEkRc0
    //https://www.youtube.com/watch?v=anTP-mgktiI
    //https://www.youtube.com/watch?v=U777GVhKUQk






    class BackendDatabase
    {
        private SQLiteConnection sQLiteConnection;
        private SQLiteCommand sQLiteCommand;
        private DataTable dataTable = new DataTable();
        private DataSet dataSet = new DataSet();
        private SQLiteDataAdapter sQLiteDataAdapter;

        public void SetConnection()
        {
            sQLiteConnection = new SQLiteConnection("Data Source= D:\\Projects\\ArchivMensch\\ArchivMensch\\ArchivMensch\\ArchivMensch.db");
        }

        public void LoadData(DataGridView dataGrid, string table)
        {
              
            SetConnection();
            sQLiteConnection.Open();
            sQLiteCommand = sQLiteConnection.CreateCommand();
            sQLiteDataAdapter = new SQLiteDataAdapter("SELECT * FROM " + table,sQLiteConnection);
            dataSet.Reset();
            sQLiteDataAdapter.Fill(dataSet);
            dataTable = dataSet.Tables[0];
            dataGrid.DataSource = dataTable;
            sQLiteConnection.Close();
        }

        public void AddData(string table, string value)
        {
            string insert = "";
            switch (table)
            {
                case "Student":
                    insert = " (FirstName, LastName, SocialSecurityNumber, Address, PhoneNumber, EMail, Class, Course) VALUES";
                    break;

            }

            SetConnection();
            sQLiteConnection.Open();
            sQLiteCommand = sQLiteConnection.CreateCommand();
            sQLiteDataAdapter = new SQLiteDataAdapter("INSERT INTO " + table + insert + value, sQLiteConnection);
            dataSet.Reset();
            sQLiteDataAdapter.Fill(dataSet);
            sQLiteConnection.Close();
        }

        public void DeleteData(string table, string value)
        {
            SetConnection();
            sQLiteConnection.Open();
            sQLiteCommand = sQLiteConnection.CreateCommand();

            if(table == "Class")
            {
                sQLiteDataAdapter = new SQLiteDataAdapter("DELETE FROM " + table + " WHERE ClassName = " + value + ";", sQLiteConnection);

            }
            else if(table == "Course")
            {
                sQLiteDataAdapter = new SQLiteDataAdapter("DELETE FROM " + table + " WHERE CourseID = " + "'"+ value + "'" + ";", sQLiteConnection);

            }
            else
            {
                sQLiteDataAdapter = new SQLiteDataAdapter("DELETE FROM " + table + " WHERE SocialSecurityNumber = " + value + ";", sQLiteConnection);
            }
            
            dataSet.Reset();
            sQLiteDataAdapter.Fill(dataSet);
            sQLiteConnection.Close();
        }

        public void EditData(string table, string value)
        {
          
        }

        public void FindData()
        {

            
        }

        public void DirectQuery(DataGridView dataGrid, string sqlCommand)
        {
            SetConnection();
            sQLiteConnection.Open();
            sQLiteCommand = sQLiteConnection.CreateCommand();
            sQLiteDataAdapter = new SQLiteDataAdapter(sqlCommand, sQLiteConnection);
            dataSet.Reset();
            sQLiteDataAdapter.Fill(dataSet);
            dataTable = dataSet.Tables[0];
            dataGrid.DataSource = dataTable;
            sQLiteConnection.Close();
        }
    }

    class BackendUI
    {



    }


}
