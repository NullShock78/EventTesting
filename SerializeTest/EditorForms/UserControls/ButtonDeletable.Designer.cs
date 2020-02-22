namespace EditorForms.UserControls
{
    partial class ButtonDeletable
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonItem = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonItem
            // 
            this.buttonItem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonItem.Location = new System.Drawing.Point(0, 0);
            this.buttonItem.Margin = new System.Windows.Forms.Padding(0);
            this.buttonItem.Name = "buttonItem";
            this.buttonItem.Size = new System.Drawing.Size(226, 32);
            this.buttonItem.TabIndex = 0;
            this.buttonItem.Text = "text";
            this.buttonItem.UseVisualStyleBackColor = true;
            this.buttonItem.Click += new System.EventHandler(this.buttonItem_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelete.BackColor = System.Drawing.Color.Red;
            this.buttonDelete.Location = new System.Drawing.Point(229, 0);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(0);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(68, 32);
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // ButtonDeletable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonItem);
            this.Name = "ButtonDeletable";
            this.Size = new System.Drawing.Size(297, 32);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonItem;
        private System.Windows.Forms.Button buttonDelete;
    }
}
