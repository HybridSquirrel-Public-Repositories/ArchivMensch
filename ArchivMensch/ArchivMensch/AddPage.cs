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
        BackendUI backendUI = new BackendUI();
       
        
        public AddPage()
        {
            InitializeComponent();
        }

        public void SetSettings(string setTable, int rows, DataGridView dataGrid)
        {
            this.dataGrid = dataGrid;
            table = setTable;
            TableLabel.Text = table;

            int y = -34;
         
               
            for(int i = 0; i < rows; i++)
            {

                Controls.Add(backendUI.CreateLabel(dataGrid.Columns[i].Name, 13, y += 47));
                Controls.Add(backendUI.CreateTextBox(dataGrid.Columns[i].Name, 13, y += 22));
            }
        }

  

        private void AddButton_Click(object sender, EventArgs e)
        {
            string input = "(";
            int x = 0;

            Action<Control.ControlCollection> nullfields = null;
            nullfields = (controls) =>
            {
                foreach (Control control in controls)
                {
                    if (control is TextBox)
                    { if ((control as TextBox).Text == "" || (control as TextBox).Text == " ") { (control as TextBox).Text = "NULL"; } }
                    else
                    { nullfields(control.Controls); }
                }

            };
            nullfields(Controls);


            Action<Control.ControlCollection> formater = null;
            formater = (controls) =>
            {
                foreach (Control control in controls)
                { 
                    if (control is TextBox)
                    { 
                        if ((control as TextBox).Text != "" || (control as TextBox).Text != " ") 
                        {
                            string intchecker = (control as TextBox).Text;
                            if (Int32.TryParse(intchecker, out x)) { input += (control as TextBox).Text + ", "; }
                            else { input += "'" +(control as TextBox).Text + "'" + ", "; }
                        } 
                    }
                    else { formater(control.Controls); }
                }
            };

            formater(Controls);

            input = input.Remove(input.Length - 2);
            input += ")";

            backendDatabase.AddData(table, input);
            backendDatabase.LoadData(dataGrid, table);
            Close();
        
        }


        private void ClearButton_Click(object sender, EventArgs e)
        {

            Action<Control.ControlCollection> clear = null;
            clear = (controls) =>
            {
                foreach (Control control in controls)
                {
                    if (control is TextBox) 
                    { (control as TextBox).Clear(); }
                    else
                    { clear(control.Controls); }
                }
                    
            };
            clear(Controls);

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddPage_Load(object sender, EventArgs e)
        {

        }
    }
}
