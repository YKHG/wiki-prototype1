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
using System.IO;
// chenming xu Date 03/02/2023
// id30063012 wiki prototype project
namespace DataTable
{
    public partial class FormDataTable : Form
    {
        public FormDataTable()
        {
            InitializeComponent();
        }
        // global variables - 2 Dim array of string
        static int row = 12;
        static int col = 5;
        string[,] DataTable = new string[row, col];

        private void ClearTextBoxes()
        {
            
        }



        private void FillArray()
        {
            Random random = new Random();
            for (int x = 0; x < row; x++)
            {
                for (int y = 0; y < col; y++)
                {
                    DataTable[x, y] = random.Next(10, 99).ToString();
                }
            }
        }
        private void DisplayArray()
        {
           
        }

        private void ButtonFillDisplay_MouseClick(object sender, MouseEventArgs e)
        {
            FillArray();
            DisplayArray();
        }


        private void AddButton_Click(object sender, EventArgs e)
        {
           
        }
        private void EditButton_Click(object sender, EventArgs e)
        {
          
            
               
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
