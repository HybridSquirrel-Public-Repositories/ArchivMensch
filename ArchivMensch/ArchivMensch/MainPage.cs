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

            
        }

        private void MainPage_Load(object sender, EventArgs e)
        {

            ViewModeBox.DropDownStyle = ComboBoxStyle.DropDownList;
            backendDatabase.LoadData(DataGrid, ViewModeBox.Text);

        }

        private void DataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void AddButton_Click(object sender, EventArgs e)
        {

            AddPage addPage = new AddPage();
            addPage.Show();
            addPage.SetSettings(ViewModeBox.Text, DataGrid);
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
           /*
            string value = "";
            if (ViewModeBox.Text == "Class")
            {
                value = DataGrid.CurrentRow.Cells["ClassName"].Value.ToString();

            }
            else if (ViewModeBox.Text == "Course")
            {
                value = DataGrid.CurrentRow.Cells["CourseID"].Value.ToString();

            }
            else
            {
                value = DataGrid.CurrentRow.Cells["SocialSecurityNumber"].Value.ToString();
            }
            
            backendDatabase.DeleteData(ViewModeBox.Text, value);
            backendDatabase.LoadData(DataGrid, ViewModeBox.Text);
            */
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DirectQueryButton_Click(object sender, EventArgs e)
        {
            DirectQuery directQuery = new DirectQuery();
            directQuery.Show();
        }

        private void ViewModeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            backendDatabase.LoadData(DataGrid, ViewModeBox.Text);
        }
    }


}
