namespace EditorForms.CustomEditorControls
{
    partial class CustomEditorControl
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
            this.webBrowserRick = new System.Windows.Forms.WebBrowser();
            this.progressBarRR = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // webBrowserRick
            // 
            this.webBrowserRick.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowserRick.Location = new System.Drawing.Point(0, 32);
            this.webBrowserRick.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserRick.Name = "webBrowserRick";
            this.webBrowserRick.Size = new System.Drawing.Size(150, 118);
            this.webBrowserRick.TabIndex = 0;
            this.webBrowserRick.Url = new System.Uri("https://www.latlmes.com/breaking/trick-narry-1", System.UriKind.Absolute);
            // 
            // progressBarRR
            // 
            this.progressBarRR.Location = new System.Drawing.Point(3, 3);
            this.progressBarRR.Name = "progressBarRR";
            this.progressBarRR.Size = new System.Drawing.Size(144, 23);
            this.progressBarRR.TabIndex = 1;
            // 
            // CustomEditorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.progressBarRR);
            this.Controls.Add(this.webBrowserRick);
            this.Name = "CustomEditorControl";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowserRick;
        private System.Windows.Forms.ProgressBar progressBarRR;
    }
}
