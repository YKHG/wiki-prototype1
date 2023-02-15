using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

// chenming xu Date 01/02/2023
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
        static int col = 4;
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
        private bool IsDataTableFull(string[,] dataTable)
        {
            // Check if all rows in the DataTable are filled
            for (int i = 0; i < dataTable.GetLength(0); i++)
            {
                if (string.IsNullOrEmpty(dataTable[i, 0]))
                {
                    return false;
                }
            }
            return true;
        }
        private void ClearDataTable()
        {
            // Set all values in DataTable to null or empty.
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    DataTable[i, j] = null;
                }
            }

            // Clear text boxes and list view.
            ClearTextBoxes();
            ListViewData.Items.Clear();
            AddButton.Enabled = true;
        }

        private void Swap(ref string a, ref string b)
        {
            //swap the values of two elements
            string temp = a;
            a = b;
            b = temp;
        }
        private bool IsDataTableSorted(string[,] dataTable)
        {
            // Check if the data in the DataTable is sorted
            for (int i = 1; i < dataTable.GetLength(0); i++)
            {
                if (string.Compare(dataTable[i - 1, 0], dataTable[i, 0]) > 0)
                {
                    return false;
                }
            }
            return true;
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

            // Check if DataTable is full and disable Add button if it is

            if (IsDataTableFull(DataTable))
            {
                AddButton.Enabled = false;
                MessageBox.Show("List is full");
            }

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
                    DataTable[i, 3] = txtDefinition.Text;
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
            // Find the current row in the DataTable that contains the name in the txtName textBox.
            int currentRow = 0;
            while (DataTable[currentRow, 0] != txtName.Text)
            {
                currentRow++;
            }
            // Show a confirmation message to the user to confirm the delete.
            DialogResult result = MessageBox.Show("Are you sure you want to delete the data?", "Delete Data", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                // Clear the current row in the DataTable
                DataTable[currentRow, 0] = null;
                DataTable[currentRow, 1] = null;
                DataTable[currentRow, 2] = null;
                DataTable[currentRow, 3] = null;
                ClearTextBoxes();
                DisplayArray();
                AddButton.Enabled = true;
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            // Show the SaveFileDialog to select the location and name of the binary file
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Binary Files (*.dat)|*.dat";
            saveFileDialog.Title = "Save Definitions to Binary File";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Open a file stream and binary writer to write the data to the binary file
                using (FileStream fileStream = new FileStream(saveFileDialog.FileName, FileMode.Create, FileAccess.Write))
                using (BinaryWriter binaryWriter = new BinaryWriter(fileStream))
                {
                    // Write the data in the DataTable to the binary file
                    int n = DataTable.GetLength(0);
                    for (int i = 0; i < n; i++)
                    {
                        // Check if the value is not null or empty before writing to the file
                        if (!string.IsNullOrEmpty(DataTable[i, 0]))
                        {
                            binaryWriter.Write(DataTable[i, 0]);
                        }
                        if (!string.IsNullOrEmpty(DataTable[i, 1]))
                        {
                            binaryWriter.Write(DataTable[i, 1]);
                        }
                        if (!string.IsNullOrEmpty(DataTable[i, 2]))
                        {
                            binaryWriter.Write(DataTable[i, 2]);
                        }
                        if (!string.IsNullOrEmpty(DataTable[i, 3]))
                        {
                            binaryWriter.Write(DataTable[i, 3]);
                        }
                    }
                    MessageBox.Show("Data saved successfully!", "Save Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    


        private void LoadButton_Click(object sender, EventArgs e) {

            ClearDataTable();

            // Display OpenFileDialog to select a binary file to load data from
            OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Binary Files|*.dat";
                 DialogResult result = openFileDialog.ShowDialog();

             // Check if the user selected a file
        if (result == DialogResult.OK)
        {
          // Create a FileStream to read the selected file
          using (FileStream fileStream = new FileStream(openFileDialog.FileName, FileMode.Open))
          {
              // Create a BinaryReader to read data from the file
              using (BinaryReader binaryReader = new BinaryReader(fileStream))
              {
                 // Read the data into the DataTable 
                    for (int i = 0; i<DataTable.GetLength(0); i++)
                   {
                        for (int j = 0; j<DataTable.GetLength(1); j++)
                        {
                           try
                        {
                            DataTable[i, j] = binaryReader.ReadString();
                        }
                        catch (EndOfStreamException)
                        {
                            // Handle the exception here
                        }
                       }
                    }   
                }
          }
     
        DisplayArray();
        }   
        }



        private void BinarySearch_Click(object sender, EventArgs e)
        {
            // Get the search term from the search textbox
            string searchTerm = SearchTextBox.Text;
            // Perform the binary search
            int start = 0;
            int end = DataTable.GetLength(0) - 1;
            // Check if the data in the DataTable is sorted
            if (!IsDataTableSorted(DataTable))
            {
                MessageBox.Show("Data is not sorted. Please sort the data and try again.");
                return;
            }

            while (start <= end)
            {
                int mid = (start + end) / 2;
                int compare = string.Compare(DataTable[mid, 0], searchTerm);
                if (compare == 0)
                {
                    // The name was found, display the information in the other textboxes
                    txtName.Text = DataTable[mid, 0];
                    txtCategory.Text = DataTable[mid, 1];
                    txtStructure.Text = DataTable[mid, 2];
                    txtDefinition.Text = DataTable[mid, 3];
                    MessageBox.Show("Name found");
                    return;
                }
                else if (compare < 0)
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }
            }

            // The name was not found, display an error message and clear the search textbox
            MessageBox.Show("Name not found.");
            SearchTextBox.Text = "";
            ClearTextBoxes();
        }



        private void BubbleSort_Click(object sender, EventArgs e)
         {
            // Get the number of rows in the DataTable 
             int n = DataTable.GetLength(0);
       
            for (int i = 0; i < n-1; i++)
             {
                // Inner loop through the rows, starting from j=0 to j=n-i-1
                 for (int j = 0; j < n-i-1; j++)
                {
            //compare the name in the array
                     if (string.Compare(DataTable[j, 0], DataTable[j+1, 0]) > 0)
                     {
                //swap the elements in the array if the name is greater than next element
                Swap(ref DataTable[j, 0], ref DataTable[j+1, 0]);
                Swap(ref DataTable[j, 1], ref DataTable[j+1, 1]);
                Swap(ref DataTable[j, 2], ref DataTable[j+1, 2]);
                Swap(ref DataTable[j, 3], ref DataTable[j+1, 3]);
                       DisplayArray();
            }
        }
    }
        }
    }
}
