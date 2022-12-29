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
            this.itemListView = new System.Windows.Forms.ListBox();
            this.textBoxItemCount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            // itemListView
            // 
            this.itemListView.FormattingEnabled = true;
            this.itemListView.Location = new System.Drawing.Point(433, 29);
            this.itemListView.Name = "itemListView";
            this.itemListView.Size = new System.Drawing.Size(267, 186);
            this.itemListView.TabIndex = 3;
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
            // FormListScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxItemCount);
            this.Controls.Add(this.itemListView);
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
        private System.Windows.Forms.ListBox itemListView;
        private System.Windows.Forms.TextBox textBoxItemCount;
        private System.Windows.Forms.Label label1;
    }
}