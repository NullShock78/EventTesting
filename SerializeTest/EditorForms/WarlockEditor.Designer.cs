namespace EditorForms
{
    partial class WarlockEditor
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
            this.buttonLoad = new System.Windows.Forms.Button();
            this.flowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonTest = new System.Windows.Forms.Button();
            this.buttonRunTest = new System.Windows.Forms.Button();
            this.buttonLoadTest = new System.Windows.Forms.Button();
            this.buttonApply = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.numericUpDownStress = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStress)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(46, 229);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonLoad.TabIndex = 0;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // flowPanel
            // 
            this.flowPanel.Location = new System.Drawing.Point(168, 41);
            this.flowPanel.Name = "flowPanel";
            this.flowPanel.Size = new System.Drawing.Size(564, 341);
            this.flowPanel.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.Location = new System.Drawing.Point(46, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Generate New";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Enabled = false;
            this.buttonSave.Location = new System.Drawing.Point(46, 90);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Visible = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonTest
            // 
            this.buttonTest.Enabled = false;
            this.buttonTest.Location = new System.Drawing.Point(46, 116);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(75, 44);
            this.buttonTest.TabIndex = 4;
            this.buttonTest.Text = "Load Actions";
            this.buttonTest.UseVisualStyleBackColor = true;
            this.buttonTest.Visible = false;
            this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // buttonRunTest
            // 
            this.buttonRunTest.Location = new System.Drawing.Point(46, 371);
            this.buttonRunTest.Name = "buttonRunTest";
            this.buttonRunTest.Size = new System.Drawing.Size(75, 23);
            this.buttonRunTest.TabIndex = 6;
            this.buttonRunTest.Text = "Run Executes";
            this.buttonRunTest.UseVisualStyleBackColor = true;
            this.buttonRunTest.Click += new System.EventHandler(this.buttonRunTest_Click);
            // 
            // buttonLoadTest
            // 
            this.buttonLoadTest.Location = new System.Drawing.Point(46, 342);
            this.buttonLoadTest.Name = "buttonLoadTest";
            this.buttonLoadTest.Size = new System.Drawing.Size(75, 23);
            this.buttonLoadTest.TabIndex = 7;
            this.buttonLoadTest.Text = "Run Load";
            this.buttonLoadTest.UseVisualStyleBackColor = true;
            this.buttonLoadTest.Click += new System.EventHandler(this.buttonLoadTest_Click);
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(168, 389);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(75, 23);
            this.buttonApply.TabIndex = 8;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(653, 388);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 9;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // numericUpDownStress
            // 
            this.numericUpDownStress.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownStress.Location = new System.Drawing.Point(46, 64);
            this.numericUpDownStress.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownStress.Name = "numericUpDownStress";
            this.numericUpDownStress.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownStress.TabIndex = 10;
            this.numericUpDownStress.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Stress Iterations";
            // 
            // WarlockEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownStress);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.buttonLoadTest);
            this.Controls.Add(this.buttonRunTest);
            this.Controls.Add(this.buttonTest);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.flowPanel);
            this.Controls.Add(this.buttonLoad);
            this.Name = "WarlockEditor";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStress)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.FlowLayoutPanel flowPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonTest;
        private System.Windows.Forms.Button buttonRunTest;
        private System.Windows.Forms.Button buttonLoadTest;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.NumericUpDown numericUpDownStress;
        private System.Windows.Forms.Label label1;
    }
}

