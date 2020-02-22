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
            this.buttonRunPreExec = new System.Windows.Forms.Button();
            this.buttonLoadTest = new System.Windows.Forms.Button();
            this.buttonApply = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.numericUpDownStress = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonEditor = new System.Windows.Forms.Button();
            this.listPanelGrimoires = new EditorForms.ListPanel();
            this.buttonAddGrim = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStress)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(15, 414);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(117, 24);
            this.buttonLoad.TabIndex = 0;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // flowPanel
            // 
            this.flowPanel.Location = new System.Drawing.Point(653, 41);
            this.flowPanel.Name = "flowPanel";
            this.flowPanel.Size = new System.Drawing.Size(79, 40);
            this.flowPanel.TabIndex = 1;
            this.flowPanel.Visible = false;
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.Location = new System.Drawing.Point(12, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Generate New";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(15, 304);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(117, 104);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonTest
            // 
            this.buttonTest.Location = new System.Drawing.Point(12, 98);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(75, 44);
            this.buttonTest.TabIndex = 4;
            this.buttonTest.Text = "Load Actions";
            this.buttonTest.UseVisualStyleBackColor = true;
            this.buttonTest.Visible = false;
            this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // buttonRunPreExec
            // 
            this.buttonRunPreExec.Location = new System.Drawing.Point(653, 185);
            this.buttonRunPreExec.Name = "buttonRunPreExec";
            this.buttonRunPreExec.Size = new System.Drawing.Size(75, 39);
            this.buttonRunPreExec.TabIndex = 6;
            this.buttonRunPreExec.Text = "Run Pre Execute";
            this.buttonRunPreExec.UseVisualStyleBackColor = true;
            this.buttonRunPreExec.Click += new System.EventHandler(this.buttonRunTest_Click);
            // 
            // buttonLoadTest
            // 
            this.buttonLoadTest.Location = new System.Drawing.Point(653, 145);
            this.buttonLoadTest.Name = "buttonLoadTest";
            this.buttonLoadTest.Size = new System.Drawing.Size(75, 34);
            this.buttonLoadTest.TabIndex = 7;
            this.buttonLoadTest.Text = "Run Load";
            this.buttonLoadTest.UseVisualStyleBackColor = true;
            this.buttonLoadTest.Click += new System.EventHandler(this.buttonLoadTest_Click);
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(653, 116);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(75, 23);
            this.buttonApply.TabIndex = 8;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Visible = false;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(653, 87);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 9;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Visible = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // numericUpDownStress
            // 
            this.numericUpDownStress.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownStress.Location = new System.Drawing.Point(12, 61);
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
            this.numericUpDownStress.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Stress Iterations";
            this.label1.Visible = false;
            // 
            // buttonEditor
            // 
            this.buttonEditor.Location = new System.Drawing.Point(653, 12);
            this.buttonEditor.Name = "buttonEditor";
            this.buttonEditor.Size = new System.Drawing.Size(75, 23);
            this.buttonEditor.TabIndex = 12;
            this.buttonEditor.Text = "Show Edit";
            this.buttonEditor.UseVisualStyleBackColor = true;
            this.buttonEditor.Visible = false;
            this.buttonEditor.Click += new System.EventHandler(this.buttonEditor_Click);
            // 
            // listPanelGrimoires
            // 
            this.listPanelGrimoires.AutoScroll = true;
            this.listPanelGrimoires.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listPanelGrimoires.Location = new System.Drawing.Point(157, 19);
            this.listPanelGrimoires.Name = "listPanelGrimoires";
            this.listPanelGrimoires.Size = new System.Drawing.Size(447, 363);
            this.listPanelGrimoires.TabIndex = 13;
            // 
            // buttonAddGrim
            // 
            this.buttonAddGrim.Location = new System.Drawing.Point(157, 386);
            this.buttonAddGrim.Name = "buttonAddGrim";
            this.buttonAddGrim.Size = new System.Drawing.Size(456, 52);
            this.buttonAddGrim.TabIndex = 14;
            this.buttonAddGrim.Text = "Add Grimoire";
            this.buttonAddGrim.UseVisualStyleBackColor = true;
            this.buttonAddGrim.Click += new System.EventHandler(this.buttonAddGrim_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(653, 230);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 39);
            this.button2.TabIndex = 15;
            this.button2.Text = "Run Execute";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(653, 275);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 39);
            this.button3.TabIndex = 16;
            this.button3.Text = "Run Post Execute";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(610, 185);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(37, 129);
            this.button4.TabIndex = 17;
            this.button4.Text = "->\r\n\r\n\r\n->\r\n\r\n\r\n->";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // WarlockEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonAddGrim);
            this.Controls.Add(this.listPanelGrimoires);
            this.Controls.Add(this.buttonEditor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownStress);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.buttonLoadTest);
            this.Controls.Add(this.buttonRunPreExec);
            this.Controls.Add(this.buttonTest);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.flowPanel);
            this.Controls.Add(this.buttonLoad);
            this.Name = "WarlockEditor";
            this.Text = "Warlock Editor";
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
        private System.Windows.Forms.Button buttonRunPreExec;
        private System.Windows.Forms.Button buttonLoadTest;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.NumericUpDown numericUpDownStress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonEditor;
        private ListPanel listPanelGrimoires;
        private System.Windows.Forms.Button buttonAddGrim;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

