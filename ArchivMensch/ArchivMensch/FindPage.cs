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
    public partial class FindPage : Form
    {
        BackendDatabase backendDatabase = new BackendDatabase();
        public FindPage()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FindPage_Load(object sender, EventArgs e)
        {
            SelectionBoxOne.DropDownStyle = ComboBoxStyle.DropDownList;
            SelecetionBoxTwo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            if(SelectionBoxOne.Text != SelecetionBoxTwo.Text)
            {
                if(SelectionBoxOne.Text == "Guardian" && SelecetionBoxTwo.Text == "Class" || SelectionBoxOne.Text == "Class" && SelecetionBoxTwo.Text == "Guardian")
                {
                    
                }
                else
                {
                    backendDatabase.FindData(DataGrid,SelectionBoxOne.Text,SelecetionBoxTwo.Text);
                }
            }
            
        }
    }
}
