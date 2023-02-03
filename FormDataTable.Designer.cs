namespace DataTable
{
    partial class FormDataTable
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonFillDisplay = new System.Windows.Forms.Button();
            this.TextBoxInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ListViewData = new System.Windows.Forms.ListView();
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Structure = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Definition = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AddButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.BubbleSort = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.BinarySearch = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.LoadButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txtDefinition = new System.Windows.Forms.Label();
            this.txtStructure = new System.Windows.Forms.Label();
            this.txtCategory = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonFillDisplay
            // 
            this.ButtonFillDisplay.Location = new System.Drawing.Point(22, 22);
            this.ButtonFillDisplay.Margin = new System.Windows.Forms.Padding(6);
            this.ButtonFillDisplay.Name = "ButtonFillDisplay";
            this.ButtonFillDisplay.Size = new System.Drawing.Size(176, 42);
            this.ButtonFillDisplay.TabIndex = 0;
            this.ButtonFillDisplay.Text = "Fill and Display";
            this.ButtonFillDisplay.UseVisualStyleBackColor = true;
            this.ButtonFillDisplay.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButtonFillDisplay_MouseClick);
            // 
            // TextBoxInput
            // 
            this.TextBoxInput.Location = new System.Drawing.Point(282, 50);
            this.TextBoxInput.Margin = new System.Windows.Forms.Padding(6);
            this.TextBoxInput.Name = "TextBoxInput";
            this.TextBoxInput.Size = new System.Drawing.Size(180, 29);
            this.TextBoxInput.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(282, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Input Number";
            // 
            // ListViewData
            // 
            this.ListViewData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Name,
            this.Category,
            this.Structure,
            this.Definition});
            this.ListViewData.HideSelection = false;
            this.ListViewData.Location = new System.Drawing.Point(37, 123);
            this.ListViewData.Margin = new System.Windows.Forms.Padding(6);
            this.ListViewData.Name = "ListViewData";
            this.ListViewData.Size = new System.Drawing.Size(522, 665);
            this.ListViewData.TabIndex = 4;
            this.ListViewData.UseCompatibleStateImageBehavior = false;
            this.ListViewData.View = System.Windows.Forms.View.Details;
            // 
            // Name
            // 
            this.Name.Text = "Name";
            this.Name.Width = 102;
            // 
            // Category
            // 
            this.Category.Text = "Category";
            this.Category.Width = 130;
            // 
            // Structure
            // 
            this.Structure.Text = "Structure";
            this.Structure.Width = 112;
            // 
            // Definition
            // 
            this.Definition.Text = "Definition";
            this.Definition.Width = 120;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(1097, 162);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(110, 41);
            this.AddButton.TabIndex = 5;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(1097, 232);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(110, 42);
            this.EditButton.TabIndex = 6;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // BubbleSort
            // 
            this.BubbleSort.Location = new System.Drawing.Point(1074, 659);
            this.BubbleSort.Name = "BubbleSort";
            this.BubbleSort.Size = new System.Drawing.Size(159, 42);
            this.BubbleSort.TabIndex = 7;
            this.BubbleSort.Text = "BubbleSort";
            this.BubbleSort.UseVisualStyleBackColor = true;
            this.BubbleSort.Click += new System.EventHandler(this.BubbleSort_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(1097, 314);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(110, 42);
            this.DeleteButton.TabIndex = 8;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // BinarySearch
            // 
            this.BinarySearch.Location = new System.Drawing.Point(1074, 581);
            this.BinarySearch.Name = "BinarySearch";
            this.BinarySearch.Size = new System.Drawing.Size(159, 50);
            this.BinarySearch.TabIndex = 9;
            this.BinarySearch.Text = "BinarySearch";
            this.BinarySearch.UseVisualStyleBackColor = true;
            this.BinarySearch.Click += new System.EventHandler(this.BinarySearch_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(1097, 392);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(110, 44);
            this.SaveButton.TabIndex = 10;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(1097, 465);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(110, 44);
            this.LoadButton.TabIndex = 11;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(778, 167);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(192, 29);
            this.textBox1.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(778, 245);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(192, 29);
            this.textBox2.TabIndex = 13;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(778, 327);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(192, 29);
            this.textBox3.TabIndex = 14;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(778, 399);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(192, 29);
            this.textBox4.TabIndex = 15;
            // 
            // txtDefinition
            // 
            this.txtDefinition.AutoSize = true;
            this.txtDefinition.Location = new System.Drawing.Point(773, 371);
            this.txtDefinition.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.txtDefinition.Name = "txtDefinition";
            this.txtDefinition.Size = new System.Drawing.Size(140, 25);
            this.txtDefinition.TabIndex = 16;
            this.txtDefinition.Text = "Input Definition";
            // 
            // txtStructure
            // 
            this.txtStructure.AutoSize = true;
            this.txtStructure.Location = new System.Drawing.Point(773, 299);
            this.txtStructure.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.txtStructure.Name = "txtStructure";
            this.txtStructure.Size = new System.Drawing.Size(139, 25);
            this.txtStructure.TabIndex = 17;
            this.txtStructure.Text = "Input Structure";
            // 
            // txtCategory
            // 
            this.txtCategory.AutoSize = true;
            this.txtCategory.Location = new System.Drawing.Point(773, 217);
            this.txtCategory.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(140, 25);
            this.txtCategory.TabIndex = 18;
            this.txtCategory.Text = "Input Category";
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Location = new System.Drawing.Point(773, 139);
            this.txtName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(112, 25);
            this.txtName.TabIndex = 19;
            this.txtName.Text = "Input Name";
            // 
            // FormDataTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 866);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.txtStructure);
            this.Controls.Add(this.txtDefinition);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.BinarySearch);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.BubbleSort);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.ListViewData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxInput);
            this.Controls.Add(this.ButtonFillDisplay);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormDataTable";
            this.Text = "My Data Table";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonFillDisplay;
        private System.Windows.Forms.TextBox TextBoxInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView ListViewData;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader Category;
        private System.Windows.Forms.ColumnHeader Structure;
        private System.Windows.Forms.ColumnHeader Definition;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button BubbleSort;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button BinarySearch;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label txtDefinition;
        private System.Windows.Forms.Label txtStructure;
        private System.Windows.Forms.Label txtCategory;
        private System.Windows.Forms.Label txtName;
    }
}

