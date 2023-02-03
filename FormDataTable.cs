using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

// chenming xu Date 03/02/2023
// id30063012 wiki prototype project
namespace DataTable
{
    public partial class TheDataTable : Form
    {
        public TheDataTable()
        {
            InitializeComponent();
        }
        // global variables - 2 Dim array of string
        static int row = 12;
        static int col = 5;
        string[,] DataTable = new string[row, col];

        private void ClearTextBoxes()
        {
            txtName.Clear();
            txtCategory.Clear();
            txtStructure.Clear();
            txtDefinition.Clear();
            txtName.Focus();
        }


        
        private void DisplayArray()
        {
            ListViewData.Items.Clear();
            for (int i = 0; i < row; i++)
            {
                if (!String.IsNullOrEmpty(DataTable[i, 0]))
                {
                    ListViewItem item = new ListViewItem(DataTable[i, 0]);
                    item.SubItems.Add(DataTable[i, 1]);
                    ListViewData.Items.Add(item);
                }
            }
        }


        

        private void AddButton_MouseClick(object sender, MouseEventArgs e)
        {
            // Check if all textbox are filled
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtDefinition.Text) ||
                string.IsNullOrEmpty(txtCategory.Text) || string.IsNullOrEmpty(txtStructure.Text))
            {
                toolStripStatusLabel1.Text = "Error: Please fill all fields.";
                return;
            }

            for (int i = 0; i < row; i++)
            {
                if (String.IsNullOrEmpty(DataTable[i, 0]))
                {
                    DataTable[i, 0] = txtName.Text;
                    DataTable[i, 1] = txtCategory.Text;
                    DataTable[i, 2] = txtStructure.Text;
                    DataTable[i, 3] = txtDefinition.Text;
                    MessageBox.Show("Definition added successfully!");
                    break;
                }
            }
            ClearTextBoxes();
            DisplayArray();

        }
        private void EditButton_Click(object sender, EventArgs e)
        {
            if (ListViewData.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Please select a definition from the List View to edit");
                return;
            }

            int selectedIndex = ListViewData.SelectedIndices[0];
            for (int i = 0; i < row; i++)
            {
                if (DataTable[i, 0] == ListViewData.Items[selectedIndex].Text)
                {
                    DataTable[i, 0] = txtName.Text;
                    DataTable[i, 1] = txtCategory.Text;
                    DataTable[i, 2] = txtStructure.Text;
                    DataTable[i, 3] = txtStructure.Text;

                    ListViewData.Items[selectedIndex].Text = DataTable[i, 0];
                    ListViewData.Items[selectedIndex].SubItems[1].Text = DataTable[i, 1];
                    MessageBox.Show("Edit successful");
                    break;
                }
            }
        }

        private void ListViewData_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (ListViewData.SelectedIndices.Count == 0)
            {
                return;
            }

            int selectedIndex = ListViewData.SelectedIndices[0];
            for (int i = 0; i < row; i++)
            {
                if (DataTable[i, 0] == ListViewData.Items[selectedIndex].Text)
                {
                    txtName.Text = DataTable[i, 0];
                    txtCategory.Text = DataTable[i, 1];
                    txtStructure.Text = DataTable[i, 2];
                    txtDefinition.Text = DataTable[i, 3];
                    break;
                }
            }
        }


        private void DeleteButton_Click(object sender, EventArgs e)
        {

        }
        private void LoadButton_Click(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

        }

        private void BinarySearch_Click(object sender, EventArgs e)
        {

        }

        private void BubbleSort_Click(object sender, EventArgs e)
        {

        }

        
    }
}
