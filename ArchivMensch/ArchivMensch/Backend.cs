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
            SetConnection();
            sQLiteConnection.Open();
            sQLiteCommand = sQLiteConnection.CreateCommand();
            sQLiteDataAdapter = new SQLiteDataAdapter("INSERT INTO " + table + " VALUES" + value, sQLiteConnection);
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

        public void EditData(string table, string value, string id)
        {
            SetConnection();
            sQLiteConnection.Open();
            sQLiteCommand = sQLiteConnection.CreateCommand();
            sQLiteDataAdapter = new SQLiteDataAdapter("UPDATE " + table + " SET " + value + "WHERE SocialSecurityNumber = " + id, sQLiteConnection);
            dataSet.Reset();
            sQLiteDataAdapter.Fill(dataSet);
            sQLiteConnection.Close();
        }

        public void FindData(DataGridView dataGrid, string one, string two)
        {
            
            SetConnection();
            sQLiteConnection.Open();
            sQLiteCommand = sQLiteConnection.CreateCommand();
            sQLiteDataAdapter = new SQLiteDataAdapter("SELECT * FROM " + one + " INNER JOIN Guardian_Line ON "
                + one + ".LastName = Guardian_Line.StudentLastName INNER JOIN " + two + " ON Guardian_Line.GuardianLastName = " + two +".LastName", sQLiteConnection);
            dataSet.Reset();
            sQLiteDataAdapter.Fill(dataSet);
            dataTable = dataSet.Tables[0];
            dataGrid.DataSource = dataTable;
            sQLiteConnection.Close();
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

       

        public Label CreateLabel(string label, int x, int y)
        {
            Label newLabel = new Label();

            newLabel.Location = new System.Drawing.Point(x, y);
            newLabel.Text = label;
            newLabel.Name = label + "Label";
            return newLabel;

        }
        public TextBox CreateTextBox(string label, int x, int y)
        {
            TextBox newTextBox = new TextBox();

            newTextBox.Location = new System.Drawing.Point(x, y + 2);
            newTextBox.Name = label + "Box";
            return newTextBox;
        }

    }


}
