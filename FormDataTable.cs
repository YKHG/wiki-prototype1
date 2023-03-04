using DataTable.wiki;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

// chenming xu Date 01/02/2023
// id30063012 wiki prototype project
namespace DataTable
{

    public partial class TheDataTable : Form
    {
        public TheDataTable()
        {
            InitializeComponent();
            PopulateCategoryComboBox();
            ListViewData.SelectedIndexChanged += ListViewData_SelectedIndexChanged_1;

        }

        //list for data structure 
        List<Information> Wiki = new List<Information>();

        private void ClearTextBoxes()
        {
            // clear the content in all text boxes
            txtName.Clear();
            txtCategory.Clear();
            txtStructure.Clear();
            txtDefinition.Clear();
            comboBox1.SelectedIndex = -1;
            rbLinear.Checked = false;
            rbNonLinear.Checked = false;
            txtName.Focus();
        }
        // Custom ValidName method to check for duplicate names
        private bool ValidName(string name)
        {
            return Wiki.Exists(info => info.Name == name);
        }

        private bool IsDataTableFull()
        {
            // Check if all rows in the Wiki list are filled
            return Wiki.Count >= 12;
        }

        private bool IsListSorted(List<Information> Wiki)
        {
            // Check if the data in the Wiki list is sorted
            for (int i = 1; i < Wiki.Count; i++)
            {
                if (string.Compare(Wiki[i - 1].Name, Wiki[i].Name) > 0)
                {
                    return false;
                }
            }
            return true;
        }


        private void ClearDataTable()
        {
            // Clear the Wiki list
            Wiki.Clear();

            // Clear text boxes and list view
            ClearTextBoxes();
            ListViewData.Items.Clear();
            AddButton.Enabled = true;
        }



        private void Swap(ref string a, ref string b)
        {
            string temp = a;
            a = b;
            b = temp;
        }



        private void DisplayList()
        {
            ListViewData.Items.Clear();
            foreach (Information info in Wiki)
            {
                // add datable item to listview item.
                ListViewItem item = new ListViewItem(info.Name);
                // Add the second column's value as a subitem to the ListViewItem.
                item.SubItems.Add(info.Category);
                //add listViewItem to listViewData
                ListViewData.Items.Add(item);
            }
        }



        private void AddButton_MouseClick(object sender, MouseEventArgs e)
        {
            // Check if Wiki list is full and disable Add button if it is
            if (IsDataTableFull())
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

            if (ValidName(txtName.Text))
            {
                toolStripStatusLabel1.Text = "Error: Name already exists.";
                return;
            }
            // Get the selected radio button
            string structure = GetSelectedRadioButtonValue();

            // Create a new Information object with the data from the text boxes
            Information info = new Information
            {
                Name = txtName.Text,
                Category = txtCategory.Text,
                Structure = txtStructure.Text,
                Definition = txtDefinition.Text
            };

            // Add the Information object to the Wiki list
            Wiki.Add(info);
            MessageBox.Show("Data added successfully!");

            // Clear the text boxes and display the updated list
            ClearTextBoxes();
            DisplayList();
        }
       


        



        // Custom method to get the selected radio button value
        private string GetSelectedRadioButtonValue()
        {
            if (rbLinear.Checked)
            {
                return "Linear";
            }
            else if (rbNonLinear.Checked)
            {
                return "Non-Linear";
            }
            else
            {
                return "";
            }
        }

        private void HighlightStructure(int index)
        {
            switch (index)
            {
                case 0: // Linear
                    rbLinear.Checked = true;
                    rbNonLinear.Checked = false;
                    break;
                case 1: // Non-Linear
                    rbLinear.Checked = false;
                    rbNonLinear.Checked = true;
                    break;
                default:
                    break;
            }
        }


        private void PopulateCategoryComboBox()
        {
            string categoriesFile = "categories.txt";
            if (File.Exists(categoriesFile))
            {
                comboBox1.Items.Clear();
                string[] categories = File.ReadAllLines(categoriesFile);
                foreach (string category in categories)
                {
                    comboBox1.Items.Add(category);
                }
            }
            else
            {
                MessageBox.Show("Categories file not found.");
            }
        }



        private void EditButton_Click(object sender, EventArgs e)
        {
            // Check if a data item is selected in the list view
            if (ListViewData.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Please select a data from the List View to edit");
                return;
            }

            int selectedIndex = ListViewData.SelectedIndices[0];

            // Find the Information object in the Wiki list that matches the selected item in the list view
            Information info = Wiki.FirstOrDefault(x => x.Name == ListViewData.Items[selectedIndex].Text);

            if (info == null)
            {
                MessageBox.Show("Error: Could not find selected data item");
                return;
            }

            // Update the Information object with the values from the text boxes
            info.Name = txtName.Text;
            info.Category = txtCategory.Text;
            info.Structure = txtStructure.Text;
            info.Definition = txtDefinition.Text;

            // Update the selected item in the list view with the updated values from the Information object
            ListViewData.Items[selectedIndex].Text = info.Name;
            ListViewData.Items[selectedIndex].SubItems[1].Text = info.Category;

            MessageBox.Show("Edit successful");
        }




        private void ListViewData_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (ListViewData.SelectedItems.Count == 1)
            {
                // Get the selected item index and find the corresponding Information object
                int selectedIndex = ListViewData.SelectedIndices[0];
                Information info = Wiki[selectedIndex];

                // Highlight the appropriate radio button
                if (info.Structure == "Linear")
                {
                    HighlightStructure(0);
                }
                else if (info.Structure == "Non-Linear")
                {
                    HighlightStructure(1);
                }

                // Populate the text boxes with the Information object's data
                txtName.Text = info.Name;
                txtCategory.Text = info.Category;
                txtStructure.Text = info.Structure;
                txtDefinition.Text = info.Definition;
                  comboBox1.Text = info.Category;
                HighlightStructure(info.Structure == "Linear" ? 0 : 1);
            }
        }



            private void DeleteButton_Click(object sender, EventArgs e)
        {
            // check if a definition is selected in the list view
            if (ListViewData.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Please select a definition from the List View to delete");
                return;
            }

            // Check if an item is selected
            if (ListViewData.SelectedItems.Count > 0)
            {
                // Display a dialog box asking for confirmation
                DialogResult result = MessageBox.Show("Are you sure you want to delete this item?",
                                                      "Delete Item",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Remove the selected item from the Wiki list
                    Information selectedInfo = Wiki[ListViewData.SelectedIndices[0]];
                    Wiki.Remove(selectedInfo);
                    AddButton.Enabled = true;
                    // Clear the text boxes and display the updated list
                    ClearTextBoxes();
                    DisplayList();
                }
            }
        }



private void SaveButton_Click(object sender, EventArgs e)
{
    SaveFileDialog saveFileDialog = new SaveFileDialog();
    saveFileDialog.Filter = "Binary Files|*.dat";
    saveFileDialog.Title = "Save Data Table";

    if (saveFileDialog.ShowDialog() == DialogResult.OK)
    {
        using (FileStream fileStream = new FileStream(saveFileDialog.FileName, FileMode.Create))
        using (BinaryWriter binaryWriter = new BinaryWriter(fileStream))
        {
            // Write the data from the Wiki list to the file
            foreach (Information info in Wiki)
            {
                binaryWriter.Write(info.Name);
                binaryWriter.Write(info.Category);
                binaryWriter.Write(info.Structure);
                binaryWriter.Write(info.Definition);
            }
            toolStripStatusLabel1.Text = "Data saved successfully!";
        }
    }
}





        private void LoadButton_Click(object sender, EventArgs e)
        {
            ClearDataTable();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Binary Files|*.dat";
            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                using (FileStream fileStream = new FileStream(openFileDialog.FileName, FileMode.Open))
                using (BinaryReader binaryReader = new BinaryReader(fileStream))
                {
                    while (fileStream.Position != fileStream.Length)
                    {
                        var data = new Information();
                        data.Name = binaryReader.ReadString();
                        data.Category = binaryReader.ReadString();
                        data.Structure = binaryReader.ReadString();
                        data.Definition = binaryReader.ReadString();
                        Wiki.Add(data);
                    }
                }
                DisplayList();
            }
        }



        private void BinarySearch_Click(object sender, EventArgs e)
        {

            if (!IsListSorted(Wiki))
            {
                MessageBox.Show("Data is not sorted. Please sort the data and try again.");
                return;
            }
            // Get the search term from the search textbox
            string searchTerm = SearchTextBox.Text;
            // Perform the binary search
            int index = Wiki.BinarySearch(new Information { Name = searchTerm });
            if (index >= 0)
            {
                // The name was found, display the information in the other textboxes
                txtName.Text = Wiki[index].Name;
                txtCategory.Text = Wiki[index].Category;
                txtStructure.Text = Wiki[index].Structure;
                txtDefinition.Text = Wiki[index].Definition;
                HighlightStructure(Wiki[index].Structure == "Linear" ? 0 : 1);
                MessageBox.Show("Name found");
                // Highlight the name in the ListView
                ListViewItem item = ListViewData.FindItemWithText(Wiki[index].Name);
                if (item != null)
                {
                    item.Selected = true;
                    item.Focused = true;
                }
                // Clear the search textbox
                SearchTextBox.Text = "";
                return;
            }
            else
            {
                // The name was not found, display an error message and clear the search textbox
                MessageBox.Show("Name not found.");
                SearchTextBox.Text = "";
                ClearTextBoxes();
            }
        }




        private void BubbleSort_Click(object sender, EventArgs e)
        {
            // Check if the data is already sorted
            if (IsListSorted(Wiki))
            {
                MessageBox.Show("Data is already sorted.");
                return;
            }

            int n = Wiki.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (string.Compare(Wiki[j].Name, Wiki[j + 1].Name) > 0)
                    {
                        // Swap the elements if the name is greater than the next element
                        Information temp = Wiki[j];
                        Wiki[j] = Wiki[j + 1];
                        Wiki[j + 1] = temp;
                    }
                }
            }

            // Update the ListView and display a success message
            DisplayList();
            MessageBox.Show("Data sorted successfully.");
        }
        
        private void txtName_DoubleClick(object sender, EventArgs e)
        {
            // Clear the text boxes when the user double-clicks on the name field
            ClearTextBoxes();
        }

        // private void TheDataTable_FormClosing(object sender, FormClosingEventArgs e)
        // {
        // Save the data before closing the form
        //     SaveButton_Click(sender, null);
        //}
    }

}