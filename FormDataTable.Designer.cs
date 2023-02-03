namespace DataTable
{
    partial class TheDataTable
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
            this.ListViewData = new System.Windows.Forms.ListView();
            this.Names = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.txtStructure = new System.Windows.Forms.TextBox();
            this.txtDefinition = new System.Windows.Forms.TextBox();
            this.dassssss = new System.Windows.Forms.Label();
            this.sssssss = new System.Windows.Forms.Label();
            this.ssss = new System.Windows.Forms.Label();
            this.txtName1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListViewData
            // 
            this.ListViewData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Names,
            this.Category,
            this.Structure,
            this.Definition});
            this.ListViewData.HideSelection = false;
            this.ListViewData.Location = new System.Drawing.Point(15, 156);
            this.ListViewData.Margin = new System.Windows.Forms.Padding(6);
            this.ListViewData.Name = "ListViewData";
            this.ListViewData.Size = new System.Drawing.Size(647, 665);
            this.ListViewData.TabIndex = 4;
            this.ListViewData.UseCompatibleStateImageBehavior = false;
            this.ListViewData.View = System.Windows.Forms.View.Details;
            this.ListViewData.SelectedIndexChanged += new System.EventHandler(this.ListViewData_SelectedIndexChanged_1);
            // 
            // Names
            // 
            this.Names.Text = "Name";
            this.Names.Width = 102;
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
            this.AddButton.Location = new System.Drawing.Point(1123, 23);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(110, 41);
            this.AddButton.TabIndex = 5;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AddButton_MouseClick);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(1123, 96);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(110, 42);
            this.EditButton.TabIndex = 6;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // BubbleSort
            // 
            this.BubbleSort.Location = new System.Drawing.Point(683, 625);
            this.BubbleSort.Name = "BubbleSort";
            this.BubbleSort.Size = new System.Drawing.Size(159, 42);
            this.BubbleSort.TabIndex = 7;
            this.BubbleSort.Text = "BubbleSort";
            this.BubbleSort.UseVisualStyleBackColor = true;
            this.BubbleSort.Click += new System.EventHandler(this.BubbleSort_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(1123, 167);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(110, 42);
            this.DeleteButton.TabIndex = 8;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // BinarySearch
            // 
            this.BinarySearch.Location = new System.Drawing.Point(683, 740);
            this.BinarySearch.Name = "BinarySearch";
            this.BinarySearch.Size = new System.Drawing.Size(159, 50);
            this.BinarySearch.TabIndex = 9;
            this.BinarySearch.Text = "BinarySearch";
            this.BinarySearch.UseVisualStyleBackColor = true;
            this.BinarySearch.Click += new System.EventHandler(this.BinarySearch_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(1123, 245);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(110, 44);
            this.SaveButton.TabIndex = 10;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(1123, 327);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(110, 44);
            this.LoadButton.TabIndex = 11;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(682, 167);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(192, 29);
            this.txtName.TabIndex = 12;
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(683, 245);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(192, 29);
            this.txtCategory.TabIndex = 13;
            // 
            // txtStructure
            // 
            this.txtStructure.Location = new System.Drawing.Point(682, 327);
            this.txtStructure.Name = "txtStructure";
            this.txtStructure.Size = new System.Drawing.Size(192, 29);
            this.txtStructure.TabIndex = 14;
            // 
            // txtDefinition
            // 
            this.txtDefinition.Location = new System.Drawing.Point(682, 399);
            this.txtDefinition.Multiline = true;
            this.txtDefinition.Name = "txtDefinition";
            this.txtDefinition.Size = new System.Drawing.Size(333, 153);
            this.txtDefinition.TabIndex = 15;
            // 
            // dassssss
            // 
            this.dassssss.AutoSize = true;
            this.dassssss.Location = new System.Drawing.Point(677, 371);
            this.dassssss.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.dassssss.Name = "dassssss";
            this.dassssss.Size = new System.Drawing.Size(140, 25);
            this.dassssss.TabIndex = 16;
            this.dassssss.Text = "Input Definition";
            // 
            // sssssss
            // 
            this.sssssss.AutoSize = true;
            this.sssssss.Location = new System.Drawing.Point(678, 299);
            this.sssssss.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.sssssss.Name = "sssssss";
            this.sssssss.Size = new System.Drawing.Size(139, 25);
            this.sssssss.TabIndex = 17;
            this.sssssss.Text = "Input Structure";
            // 
            // ssss
            // 
            this.ssss.AutoSize = true;
            this.ssss.Location = new System.Drawing.Point(678, 217);
            this.ssss.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ssss.Name = "ssss";
            this.ssss.Size = new System.Drawing.Size(140, 25);
            this.ssss.TabIndex = 18;
            this.ssss.Text = "Input Category";
            // 
            // txtName1
            // 
            this.txtName1.AutoSize = true;
            this.txtName1.Location = new System.Drawing.Point(678, 139);
            this.txtName1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.txtName1.Name = "txtName1";
            this.txtName1.Size = new System.Drawing.Size(112, 25);
            this.txtName1.TabIndex = 19;
            this.txtName1.Text = "Input Name";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 827);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1278, 39);
            this.statusStrip1.TabIndex = 20;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(206, 30);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // TheDataTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 866);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.txtName1);
            this.Controls.Add(this.ssss);
            this.Controls.Add(this.sssssss);
            this.Controls.Add(this.dassssss);
            this.Controls.Add(this.txtDefinition);
            this.Controls.Add(this.txtStructure);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.BinarySearch);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.BubbleSort);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.ListViewData);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "TheDataTable";
            this.Text = "My Data Table";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView ListViewData;
        private System.Windows.Forms.ColumnHeader Names;
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
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.TextBox txtStructure;
        private System.Windows.Forms.TextBox txtDefinition;
        private System.Windows.Forms.Label dassssss;
        private System.Windows.Forms.Label sssssss;
        private System.Windows.Forms.Label ssss;
        private System.Windows.Forms.Label txtName1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

