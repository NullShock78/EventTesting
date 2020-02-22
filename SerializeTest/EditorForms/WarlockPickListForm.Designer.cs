namespace EditorForms
{
    partial class WarlockPickListForm
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
            this.listPanelItems = new EditorForms.ListPanel();
            this.SuspendLayout();
            // 
            // listPanelItems
            // 
            this.listPanelItems.AutoScroll = true;
            this.listPanelItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listPanelItems.Location = new System.Drawing.Point(0, 0);
            this.listPanelItems.Name = "listPanelItems";
            this.listPanelItems.Size = new System.Drawing.Size(305, 266);
            this.listPanelItems.TabIndex = 0;
            // 
            // WarlockPickListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 266);
            this.Controls.Add(this.listPanelItems);
            this.Name = "WarlockPickListForm";
            this.Text = "WarlockPickListForm";
            this.ResumeLayout(false);

        }

        #endregion

        private ListPanel listPanelItems;
    }
}