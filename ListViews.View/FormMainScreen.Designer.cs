namespace ListViews
{
    partial class FormMainScreen
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonLoadList = new System.Windows.Forms.Button();
            this.buttonNewList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonLoadList
            // 
            this.buttonLoadList.Location = new System.Drawing.Point(134, 154);
            this.buttonLoadList.Name = "buttonLoadList";
            this.buttonLoadList.Size = new System.Drawing.Size(128, 61);
            this.buttonLoadList.TabIndex = 0;
            this.buttonLoadList.Text = "Liste Laden";
            this.buttonLoadList.UseVisualStyleBackColor = true;
            // 
            // buttonNewList
            // 
            this.buttonNewList.Location = new System.Drawing.Point(438, 155);
            this.buttonNewList.Name = "buttonNewList";
            this.buttonNewList.Size = new System.Drawing.Size(131, 60);
            this.buttonNewList.TabIndex = 1;
            this.buttonNewList.Text = "Neue Liste";
            this.buttonNewList.UseVisualStyleBackColor = true;
            // 
            // FormMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonNewList);
            this.Controls.Add(this.buttonLoadList);
            this.Name = "FormMainScreen";
            this.Text = "Main Screen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLoadList;
        private System.Windows.Forms.Button buttonNewList;
    }
}

