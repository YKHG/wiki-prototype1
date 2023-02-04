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
            // clear the content in all text boxes
            txtName.Clear();
            txtCategory.Clear();
            txtStructure.Clear();
            txtDefinition.Clear();
            txtName.Focus();
        }


        // display the contents of the 2D array in the list view
        private void DisplayArray()
        {
            ListViewData.Items.Clear();
            //iterate through each row in the DataTable
            for (int i = 0; i < row; i++)
            {
                //if the first column of the name in datatable is not null or empty, 
                if (!String.IsNullOrEmpty(DataTable[i, 0]))
                {
                    // add datable item to listview item.
                    ListViewItem item = new ListViewItem(DataTable[i, 0]);
                    // Add the second column's value as a subitem to the ListViewItem.
                    item.SubItems.Add(DataTable[i, 1]);
                    //add listViewItem to listViewData
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
            // add the values entered in the text boxes to the next available row in array
            for (int i = 0; i < row; i++)
            {
                if (String.IsNullOrEmpty(DataTable[i, 0]))
                {
                    DataTable[i, 0] = txtName.Text;
                    DataTable[i, 1] = txtCategory.Text;
                    DataTable[i, 2] = txtStructure.Text;
                    DataTable[i, 3] = txtDefinition.Text;
                    MessageBox.Show("Data added successfully!");
                    break;
                }
            }
            ClearTextBoxes();
            DisplayArray();

        }
        private void EditButton_Click(object sender, EventArgs e)
        {
            // check if a dataTable is selected in the list view
            if (ListViewData.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Please select a data from the List View to edit");
                return;
            }

            int selectedIndex = ListViewData.SelectedIndices[0];
            //iterate through each row in the DataTable
            for (int i = 0; i < row; i++)
            {
                //if the column in the DataTable matches the selected item in the ListViewData 
                if (DataTable[i, 0] == ListViewData.Items[selectedIndex].Text)
                {
                    //update the DataTable with the values from the TextBox 
                    DataTable[i, 0] = txtName.Text;
                    DataTable[i, 1] = txtCategory.Text;
                    DataTable[i, 2] = txtStructure.Text;
                    DataTable[i, 3] = txtStructure.Text;
                    //update the selected item in the ListViewData with the updated values from the DataTable
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
                //use selected index for i. and display selected row and show it on text boxes.
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
