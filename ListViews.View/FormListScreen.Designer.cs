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
            this.itemListView = new System.Windows.Forms.ListView();
            this.buttonAddItem = new System.Windows.Forms.Button();
            this.buttonDeleteItem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // itemListView
            // 
            this.itemListView.HideSelection = false;
            this.itemListView.Location = new System.Drawing.Point(433, 21);
            this.itemListView.Name = "itemListView";
            this.itemListView.Size = new System.Drawing.Size(267, 203);
            this.itemListView.TabIndex = 0;
            this.itemListView.UseCompatibleStateImageBehavior = false;
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
            // 
            // FormListScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDeleteItem);
            this.Controls.Add(this.buttonAddItem);
            this.Controls.Add(this.itemListView);
            this.Name = "FormListScreen";
            this.Text = "ListScreen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView itemListView;
        private System.Windows.Forms.Button buttonAddItem;
        private System.Windows.Forms.Button buttonDeleteItem;
    }
}