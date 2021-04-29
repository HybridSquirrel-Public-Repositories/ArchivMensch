using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArchivMensch
{
    public partial class DirectQuery : Form
    {
        BackendDatabase backendDatabase = new BackendDatabase();
        public DirectQuery()
        {
            InitializeComponent();
        }

        private void DirectQuery_Load(object sender, EventArgs e)
        {
            backendDatabase.LoadData(DataGrid,"Student");
        }

        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            try { backendDatabase.DirectQuery(DataGrid, CommandBox.Text); }
            catch (Exception error) { MessageBox.Show("SQLite Error: \n" + error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
