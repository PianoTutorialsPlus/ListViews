namespace ListViews.View
{
    partial class FormListScreen
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
            this.buttonAddItem = new System.Windows.Forms.Button();
            this.buttonDeleteItem = new System.Windows.Forms.Button();
            this.listBoxItems = new System.Windows.Forms.ListBox();
            this.textBoxItemCount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxCollection = new System.Windows.Forms.ListBox();
            this.buttonAddList = new System.Windows.Forms.Button();
            this.buttonDeleteList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAddItem
            // 
            this.buttonAddItem.Location = new System.Drawing.Point(433, 242);
            this.buttonAddItem.Name = "buttonAddItem";
            this.buttonAddItem.Size = new System.Drawing.Size(110, 58);
            this.buttonAddItem.TabIndex = 1;
            this.buttonAddItem.Text = "Add Item";
            this.buttonAddItem.UseVisualStyleBackColor = true;
            this.buttonAddItem.Click += new System.EventHandler(this.buttonAddItem_Click);
            // 
            // buttonDeleteItem
            // 
            this.buttonDeleteItem.Location = new System.Drawing.Point(600, 242);
            this.buttonDeleteItem.Name = "buttonDeleteItem";
            this.buttonDeleteItem.Size = new System.Drawing.Size(100, 58);
            this.buttonDeleteItem.TabIndex = 2;
            this.buttonDeleteItem.Text = "Delete Item";
            this.buttonDeleteItem.UseVisualStyleBackColor = true;
            this.buttonDeleteItem.Click += new System.EventHandler(this.buttonDeleteItem_Click);
            // 
            // listBoxItems
            // 
            this.listBoxItems.FormattingEnabled = true;
            this.listBoxItems.Location = new System.Drawing.Point(433, 29);
            this.listBoxItems.Name = "listBoxItems";
            this.listBoxItems.Size = new System.Drawing.Size(267, 186);
            this.listBoxItems.TabIndex = 3;
            // 
            // textBoxItemCount
            // 
            this.textBoxItemCount.Location = new System.Drawing.Point(546, 327);
            this.textBoxItemCount.Name = "textBoxItemCount";
            this.textBoxItemCount.Size = new System.Drawing.Size(153, 20);
            this.textBoxItemCount.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(453, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Anzahl Items";
            // 
            // listBoxCollection
            // 
            this.listBoxCollection.FormattingEnabled = true;
            this.listBoxCollection.Location = new System.Drawing.Point(91, 29);
            this.listBoxCollection.Name = "listBoxCollection";
            this.listBoxCollection.Size = new System.Drawing.Size(293, 186);
            this.listBoxCollection.TabIndex = 6;
            this.listBoxCollection.SelectedIndexChanged += new System.EventHandler(this.Refresh);
            // 
            // buttonAddList
            // 
            this.buttonAddList.Location = new System.Drawing.Point(91, 242);
            this.buttonAddList.Name = "buttonAddList";
            this.buttonAddList.Size = new System.Drawing.Size(107, 57);
            this.buttonAddList.TabIndex = 7;
            this.buttonAddList.Text = "Add List";
            this.buttonAddList.UseVisualStyleBackColor = true;
            this.buttonAddList.Click += new System.EventHandler(this.buttonAddList_Click);
            // 
            // buttonDeleteList
            // 
            this.buttonDeleteList.Location = new System.Drawing.Point(277, 242);
            this.buttonDeleteList.Name = "buttonDeleteList";
            this.buttonDeleteList.Size = new System.Drawing.Size(107, 57);
            this.buttonDeleteList.TabIndex = 8;
            this.buttonDeleteList.Text = "Delete List";
            this.buttonDeleteList.UseMnemonic = false;
            this.buttonDeleteList.UseVisualStyleBackColor = true;
            this.buttonDeleteList.Click += new System.EventHandler(this.buttonDeleteList_Click);
            // 
            // FormListScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDeleteList);
            this.Controls.Add(this.buttonAddList);
            this.Controls.Add(this.listBoxCollection);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxItemCount);
            this.Controls.Add(this.listBoxItems);
            this.Controls.Add(this.buttonDeleteItem);
            this.Controls.Add(this.buttonAddItem);
            this.Name = "FormListScreen";
            this.Text = "ListScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonAddItem;
        private System.Windows.Forms.Button buttonDeleteItem;
        private System.Windows.Forms.ListBox listBoxItems;
        private System.Windows.Forms.TextBox textBoxItemCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxCollection;
        private System.Windows.Forms.Button buttonAddList;
        private System.Windows.Forms.Button buttonDeleteList;
    }
}