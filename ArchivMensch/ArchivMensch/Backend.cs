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

        public void LoadData(DataGridView dataGrid)
        {
              
            SetConnection();
            sQLiteConnection.Open();
            sQLiteCommand = sQLiteConnection.CreateCommand();
            sQLiteDataAdapter = new SQLiteDataAdapter("SELECT * FROM Student",sQLiteConnection);
            dataSet.Reset();
            sQLiteDataAdapter.Fill(dataSet);
            dataTable = dataSet.Tables[0];
            dataGrid.DataSource = dataTable;
            sQLiteConnection.Close();
        }

        public void AddData()
        {

        }

        public void DeleteData()
        {

        }

        public void EditData()
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
