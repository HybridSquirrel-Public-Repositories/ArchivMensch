using System;
using System.Data;
using System.Windows.Forms;


namespace ArchivMensch
{
    public partial class MainPage : Form
    {
        BackendDatabase backendDatabase = new BackendDatabase();
        public MainPage()
        {
            InitializeComponent();
            backendDatabase.LoadData(dataGridView1);
        }



        private void Add_Click(object sender, EventArgs e)
        {
            AddPage addPage = new AddPage();
            addPage.Show();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Change_Click(object sender, EventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }


}
