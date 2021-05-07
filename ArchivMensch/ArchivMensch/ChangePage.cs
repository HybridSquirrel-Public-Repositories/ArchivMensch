using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ArchivMensch
{
    public partial class ChangePage : Form
    {
        List<string> values = new List<string>();
        List<string> paramaters = new List<string>();
        string table;
        string id = "";
        DataGridView dataGrid;
        BackendDatabase backendDatabase = new BackendDatabase();
        BackendUI backendUI = new BackendUI();
        public ChangePage()
        {
            InitializeComponent();
        }

        public void SetSettings(string setTable, int rows, DataGridView dataGrid, string value)
        {

            string[] values = value.Split(',');
           
            this.dataGrid = dataGrid;
            table = setTable;
            TableLabel.Text = table;
            id = values[0];
       
            
            int y = -34;

            for (int i = 0; i < rows; i++)
            {
                this.values.Add(values[i]);
                this.paramaters.Add(dataGrid.Columns[i].Name);
                Controls.Add(backendUI.CreateLabel(dataGrid.Columns[i].Name + ": " + values[i], 13, y += 47));
                Controls.Add(backendUI.CreateTextBox(dataGrid.Columns[i].Name, 13, y += 22));

            }
        }

        private void GetData()
        {

        }

        private void ChangePage_Load(object sender, EventArgs e)
        {

        }



        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {


            string input = "";
            int x = 0;
            int y = 0;

            Action<Control.ControlCollection> formatfields = null;
            formatfields = (controls) =>
            {
                foreach (Control control in controls)
                {
                    if (control is TextBox)
                    { if ((control as TextBox).Text == "" || (control as TextBox).Text == " ") { (control as TextBox).Text = values[y]; y += 1; } }
                    else
                    { formatfields(control.Controls); }
                    
                }
            };
            formatfields(Controls);
            y = 0;
            
            Action<Control.ControlCollection> formater = null;
            formater = (controls) =>
            {
                foreach (Control control in controls)
                {
                    if (control is TextBox)
                    {
                        input += paramaters[y] + " = ";
                        y += 1;
                        if ((control as TextBox).Text != "" || (control as TextBox).Text != " ")
                        {
                            string intchecker = (control as TextBox).Text;
                            if (Int32.TryParse(intchecker, out x)) { input += (control as TextBox).Text + ", "; }
                            else { input += "'" + (control as TextBox).Text + "'" + ", "; }
                        }
                    }
                    else { formater(control.Controls); }
                }
            };

            formater(Controls);

            input = input.Remove(input.Length - 2);

            backendDatabase.EditData(table, input, id);

            //Close();
        }
    }
}
