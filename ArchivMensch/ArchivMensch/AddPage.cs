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
    public partial class AddPage : Form
    {
        string table;
        DataGridView dataGrid;
        BackendDatabase backendDatabase = new BackendDatabase();
       
        
        public AddPage()
        {
            InitializeComponent();
        }

        public void SetSettings(string SetTable, DataGridView dataGrid)
        {
            table = SetTable;
            this.dataGrid = dataGrid;
        }

        #region TextBox
        private void FirstNameBox_TextChanged(object sender, EventArgs e)
        {
        }
      
        private void LastNameBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void SocialSecurityNumberBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddressBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void EmailBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void PhoneNumberBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ClassBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void CourseBox_TextChanged(object sender, EventArgs e)
        {
        }
        
        #endregion

        private void AddButton_Click(object sender, EventArgs e)
        {
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                {
                    if (control is TextBox)
                    { if ((control as TextBox).Text == "" || (control as TextBox).Text == " ") { (control as TextBox).Text = "NULL"; } }
                    else
                    { func(control.Controls); }
                }

            };
            func(Controls);

            if(PhoneNumberBox.Text == "" || PhoneNumberBox.Text == " ") { PhoneNumberBox.Text = "0"; }

            string insert = "('" + FirstNameBox.Text + "', '" + LastNameBox.Text + "', " + SocialSecurityNumberBox.Text + ", '" + AddressBox.Text + "', " + PhoneNumberBox.Text + ", '" + EmailBox.Text + "', '" + ClassBox.Text + "', '" + CourseBox.Text + "');";
            backendDatabase.AddData(table, insert);
            backendDatabase.LoadData(dataGrid, table);
            Close();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {

            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                {
                    if (control is TextBox) 
                    { (control as TextBox).Clear(); }
                    else
                    { func(control.Controls); }
                }
                    
            };
            func(Controls);

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
