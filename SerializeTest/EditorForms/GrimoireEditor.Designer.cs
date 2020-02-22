namespace EditorForms
{
    partial class GrimoireEditor
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
            this.splitContainerGrimoire = new System.Windows.Forms.SplitContainer();
            this.tabControlSpells = new System.Windows.Forms.TabControl();
            this.tabPageLoad = new System.Windows.Forms.TabPage();
            this.panelLoadTop = new System.Windows.Forms.Panel();
            this.buttonAddLoad = new System.Windows.Forms.Button();
            this.listPanelLoadSpells = new EditorForms.ListPanel();
            this.tabPagePreExec = new System.Windows.Forms.TabPage();
            this.panelPreExTop = new System.Windows.Forms.Panel();
            this.buttonAddPreExecute = new System.Windows.Forms.Button();
            this.listPanelPreExecSpells = new EditorForms.ListPanel();
            this.tabPageExec = new System.Windows.Forms.TabPage();
            this.panelExecTop = new System.Windows.Forms.Panel();
            this.buttonAddExecute = new System.Windows.Forms.Button();
            this.listPanelExecSpells = new EditorForms.ListPanel();
            this.tabPagePostExec = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonAddPostExecute = new System.Windows.Forms.Button();
            this.listPanelPostExecSpells = new EditorForms.ListPanel();
            this.splitContainerSpell = new System.Windows.Forms.SplitContainer();
            this.labelCurrentSpell = new System.Windows.Forms.Label();
            this.listPanelConditionals = new EditorForms.ListPanel();
            this.listPanelActions = new EditorForms.ListPanel();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.loadControlCurrent = new EditorForms.UserControls.LoadControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerGrimoire)).BeginInit();
            this.splitContainerGrimoire.Panel1.SuspendLayout();
            this.splitContainerGrimoire.Panel2.SuspendLayout();
            this.splitContainerGrimoire.SuspendLayout();
            this.tabControlSpells.SuspendLayout();
            this.tabPageLoad.SuspendLayout();
            this.panelLoadTop.SuspendLayout();
            this.tabPagePreExec.SuspendLayout();
            this.panelPreExTop.SuspendLayout();
            this.tabPageExec.SuspendLayout();
            this.panelExecTop.SuspendLayout();
            this.tabPagePostExec.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerSpell)).BeginInit();
            this.splitContainerSpell.Panel1.SuspendLayout();
            this.splitContainerSpell.Panel2.SuspendLayout();
            this.splitContainerSpell.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerGrimoire
            // 
            this.splitContainerGrimoire.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerGrimoire.Location = new System.Drawing.Point(0, 0);
            this.splitContainerGrimoire.Name = "splitContainerGrimoire";
            // 
            // splitContainerGrimoire.Panel1
            // 
            this.splitContainerGrimoire.Panel1.Controls.Add(this.tabControlSpells);
            // 
            // splitContainerGrimoire.Panel2
            // 
            this.splitContainerGrimoire.Panel2.Controls.Add(this.splitContainerSpell);
            this.splitContainerGrimoire.Size = new System.Drawing.Size(575, 622);
            this.splitContainerGrimoire.SplitterDistance = 235;
            this.splitContainerGrimoire.TabIndex = 0;
            // 
            // tabControlSpells
            // 
            this.tabControlSpells.Controls.Add(this.tabPageLoad);
            this.tabControlSpells.Controls.Add(this.tabPagePreExec);
            this.tabControlSpells.Controls.Add(this.tabPageExec);
            this.tabControlSpells.Controls.Add(this.tabPagePostExec);
            this.tabControlSpells.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlSpells.Location = new System.Drawing.Point(0, 0);
            this.tabControlSpells.Name = "tabControlSpells";
            this.tabControlSpells.SelectedIndex = 0;
            this.tabControlSpells.Size = new System.Drawing.Size(235, 622);
            this.tabControlSpells.TabIndex = 0;
            // 
            // tabPageLoad
            // 
            this.tabPageLoad.Controls.Add(this.panelLoadTop);
            this.tabPageLoad.Controls.Add(this.listPanelLoadSpells);
            this.tabPageLoad.Location = new System.Drawing.Point(4, 22);
            this.tabPageLoad.Name = "tabPageLoad";
            this.tabPageLoad.Size = new System.Drawing.Size(227, 596);
            this.tabPageLoad.TabIndex = 0;
            this.tabPageLoad.Text = "Load";
            this.tabPageLoad.UseVisualStyleBackColor = true;
            // 
            // panelLoadTop
            // 
            this.panelLoadTop.Controls.Add(this.buttonAddLoad);
            this.panelLoadTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLoadTop.Location = new System.Drawing.Point(0, 0);
            this.panelLoadTop.Name = "panelLoadTop";
            this.panelLoadTop.Size = new System.Drawing.Size(227, 32);
            this.panelLoadTop.TabIndex = 1;
            // 
            // buttonAddLoad
            // 
            this.buttonAddLoad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAddLoad.Location = new System.Drawing.Point(0, 0);
            this.buttonAddLoad.Name = "buttonAddLoad";
            this.buttonAddLoad.Size = new System.Drawing.Size(227, 32);
            this.buttonAddLoad.TabIndex = 0;
            this.buttonAddLoad.Text = "Add";
            this.buttonAddLoad.UseVisualStyleBackColor = true;
            this.buttonAddLoad.Click += new System.EventHandler(this.buttonAddLoad_Click);
            // 
            // listPanelLoadSpells
            // 
            this.listPanelLoadSpells.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listPanelLoadSpells.AutoScroll = true;
            this.listPanelLoadSpells.Location = new System.Drawing.Point(3, 38);
            this.listPanelLoadSpells.Name = "listPanelLoadSpells";
            this.listPanelLoadSpells.Size = new System.Drawing.Size(221, 558);
            this.listPanelLoadSpells.TabIndex = 0;
            // 
            // tabPagePreExec
            // 
            this.tabPagePreExec.Controls.Add(this.panelPreExTop);
            this.tabPagePreExec.Controls.Add(this.listPanelPreExecSpells);
            this.tabPagePreExec.Location = new System.Drawing.Point(4, 22);
            this.tabPagePreExec.Name = "tabPagePreExec";
            this.tabPagePreExec.Size = new System.Drawing.Size(227, 596);
            this.tabPagePreExec.TabIndex = 1;
            this.tabPagePreExec.Text = "PreExecute";
            this.tabPagePreExec.UseVisualStyleBackColor = true;
            // 
            // panelPreExTop
            // 
            this.panelPreExTop.Controls.Add(this.buttonAddPreExecute);
            this.panelPreExTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPreExTop.Location = new System.Drawing.Point(0, 0);
            this.panelPreExTop.Name = "panelPreExTop";
            this.panelPreExTop.Size = new System.Drawing.Size(227, 32);
            this.panelPreExTop.TabIndex = 1;
            // 
            // buttonAddPreExecute
            // 
            this.buttonAddPreExecute.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAddPreExecute.Location = new System.Drawing.Point(0, 0);
            this.buttonAddPreExecute.Name = "buttonAddPreExecute";
            this.buttonAddPreExecute.Size = new System.Drawing.Size(227, 32);
            this.buttonAddPreExecute.TabIndex = 1;
            this.buttonAddPreExecute.Text = "Add";
            this.buttonAddPreExecute.UseVisualStyleBackColor = true;
            this.buttonAddPreExecute.Click += new System.EventHandler(this.buttonAddPreExecute_Click);
            // 
            // listPanelPreExecSpells
            // 
            this.listPanelPreExecSpells.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listPanelPreExecSpells.AutoScroll = true;
            this.listPanelPreExecSpells.Location = new System.Drawing.Point(3, 38);
            this.listPanelPreExecSpells.Name = "listPanelPreExecSpells";
            this.listPanelPreExecSpells.Size = new System.Drawing.Size(221, 558);
            this.listPanelPreExecSpells.TabIndex = 0;
            // 
            // tabPageExec
            // 
            this.tabPageExec.Controls.Add(this.panelExecTop);
            this.tabPageExec.Controls.Add(this.listPanelExecSpells);
            this.tabPageExec.Location = new System.Drawing.Point(4, 22);
            this.tabPageExec.Name = "tabPageExec";
            this.tabPageExec.Size = new System.Drawing.Size(227, 596);
            this.tabPageExec.TabIndex = 2;
            this.tabPageExec.Text = "Execute";
            this.tabPageExec.UseVisualStyleBackColor = true;
            // 
            // panelExecTop
            // 
            this.panelExecTop.Controls.Add(this.buttonAddExecute);
            this.panelExecTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelExecTop.Location = new System.Drawing.Point(0, 0);
            this.panelExecTop.Name = "panelExecTop";
            this.panelExecTop.Size = new System.Drawing.Size(227, 32);
            this.panelExecTop.TabIndex = 1;
            // 
            // buttonAddExecute
            // 
            this.buttonAddExecute.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAddExecute.Location = new System.Drawing.Point(0, 0);
            this.buttonAddExecute.Name = "buttonAddExecute";
            this.buttonAddExecute.Size = new System.Drawing.Size(227, 32);
            this.buttonAddExecute.TabIndex = 1;
            this.buttonAddExecute.Text = "Add";
            this.buttonAddExecute.UseVisualStyleBackColor = true;
            this.buttonAddExecute.Click += new System.EventHandler(this.buttonAddExecute_Click);
            // 
            // listPanelExecSpells
            // 
            this.listPanelExecSpells.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listPanelExecSpells.AutoScroll = true;
            this.listPanelExecSpells.Location = new System.Drawing.Point(3, 38);
            this.listPanelExecSpells.Name = "listPanelExecSpells";
            this.listPanelExecSpells.Size = new System.Drawing.Size(221, 558);
            this.listPanelExecSpells.TabIndex = 0;
            // 
            // tabPagePostExec
            // 
            this.tabPagePostExec.Controls.Add(this.panel3);
            this.tabPagePostExec.Controls.Add(this.listPanelPostExecSpells);
            this.tabPagePostExec.Location = new System.Drawing.Point(4, 22);
            this.tabPagePostExec.Name = "tabPagePostExec";
            this.tabPagePostExec.Size = new System.Drawing.Size(227, 596);
            this.tabPagePostExec.TabIndex = 3;
            this.tabPagePostExec.Text = "PostExecute";
            this.tabPagePostExec.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonAddPostExecute);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(227, 32);
            this.panel3.TabIndex = 1;
            // 
            // buttonAddPostExecute
            // 
            this.buttonAddPostExecute.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAddPostExecute.Location = new System.Drawing.Point(0, 0);
            this.buttonAddPostExecute.Name = "buttonAddPostExecute";
            this.buttonAddPostExecute.Size = new System.Drawing.Size(227, 32);
            this.buttonAddPostExecute.TabIndex = 1;
            this.buttonAddPostExecute.Text = "Add";
            this.buttonAddPostExecute.UseVisualStyleBackColor = true;
            this.buttonAddPostExecute.Click += new System.EventHandler(this.buttonAddPostExecute_Click);
            // 
            // listPanelPostExecSpells
            // 
            this.listPanelPostExecSpells.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listPanelPostExecSpells.AutoScroll = true;
            this.listPanelPostExecSpells.Location = new System.Drawing.Point(3, 38);
            this.listPanelPostExecSpells.Name = "listPanelPostExecSpells";
            this.listPanelPostExecSpells.Size = new System.Drawing.Size(221, 558);
            this.listPanelPostExecSpells.TabIndex = 0;
            // 
            // splitContainerSpell
            // 
            this.splitContainerSpell.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerSpell.Location = new System.Drawing.Point(0, 0);
            this.splitContainerSpell.Name = "splitContainerSpell";
            this.splitContainerSpell.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerSpell.Panel1
            // 
            this.splitContainerSpell.Panel1.Controls.Add(this.labelCurrentSpell);
            this.splitContainerSpell.Panel1.Controls.Add(this.listPanelConditionals);
            // 
            // splitContainerSpell.Panel2
            // 
            this.splitContainerSpell.Panel2.Controls.Add(this.listPanelActions);
            this.splitContainerSpell.Size = new System.Drawing.Size(336, 622);
            this.splitContainerSpell.SplitterDistance = 220;
            this.splitContainerSpell.TabIndex = 0;
            // 
            // labelCurrentSpell
            // 
            this.labelCurrentSpell.AutoSize = true;
            this.labelCurrentSpell.Location = new System.Drawing.Point(2, 6);
            this.labelCurrentSpell.Name = "labelCurrentSpell";
            this.labelCurrentSpell.Size = new System.Drawing.Size(99, 13);
            this.labelCurrentSpell.TabIndex = 1;
            this.labelCurrentSpell.Text = "Current Spell: None";
            // 
            // listPanelConditionals
            // 
            this.listPanelConditionals.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listPanelConditionals.AutoScroll = true;
            this.listPanelConditionals.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listPanelConditionals.Location = new System.Drawing.Point(0, 22);
            this.listPanelConditionals.Name = "listPanelConditionals";
            this.listPanelConditionals.Size = new System.Drawing.Size(336, 198);
            this.listPanelConditionals.TabIndex = 0;
            // 
            // listPanelActions
            // 
            this.listPanelActions.AutoScroll = true;
            this.listPanelActions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listPanelActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listPanelActions.Location = new System.Drawing.Point(0, 0);
            this.listPanelActions.Name = "listPanelActions";
            this.listPanelActions.Size = new System.Drawing.Size(336, 398);
            this.listPanelActions.TabIndex = 0;
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.splitContainerGrimoire);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.loadControlCurrent);
            this.splitContainerMain.Size = new System.Drawing.Size(841, 622);
            this.splitContainerMain.SplitterDistance = 575;
            this.splitContainerMain.TabIndex = 1;
            // 
            // loadControlCurrent
            // 
            this.loadControlCurrent.BackColor = System.Drawing.Color.White;
            this.loadControlCurrent.Dirty = false;
            this.loadControlCurrent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loadControlCurrent.Location = new System.Drawing.Point(0, 0);
            this.loadControlCurrent.Name = "loadControlCurrent";
            this.loadControlCurrent.Size = new System.Drawing.Size(262, 622);
            this.loadControlCurrent.TabIndex = 0;
            // 
            // GrimoireEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 622);
            this.Controls.Add(this.splitContainerMain);
            this.Name = "GrimoireEditor";
            this.Text = "Grimoire Editor";
            this.splitContainerGrimoire.Panel1.ResumeLayout(false);
            this.splitContainerGrimoire.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerGrimoire)).EndInit();
            this.splitContainerGrimoire.ResumeLayout(false);
            this.tabControlSpells.ResumeLayout(false);
            this.tabPageLoad.ResumeLayout(false);
            this.panelLoadTop.ResumeLayout(false);
            this.tabPagePreExec.ResumeLayout(false);
            this.panelPreExTop.ResumeLayout(false);
            this.tabPageExec.ResumeLayout(false);
            this.panelExecTop.ResumeLayout(false);
            this.tabPagePostExec.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.splitContainerSpell.Panel1.ResumeLayout(false);
            this.splitContainerSpell.Panel1.PerformLayout();
            this.splitContainerSpell.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerSpell)).EndInit();
            this.splitContainerSpell.ResumeLayout(false);
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerGrimoire;
        private ListPanel listPanelLoadSpells;
        private System.Windows.Forms.TabControl tabControlSpells;
        private System.Windows.Forms.TabPage tabPageLoad;
        private System.Windows.Forms.TabPage tabPagePreExec;
        private System.Windows.Forms.TabPage tabPageExec;
        private System.Windows.Forms.TabPage tabPagePostExec;
        private ListPanel listPanelPreExecSpells;
        private ListPanel listPanelExecSpells;
        private ListPanel listPanelPostExecSpells;
        private System.Windows.Forms.SplitContainer splitContainerSpell;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private ListPanel listPanelConditionals;
        private ListPanel listPanelActions;
        private UserControls.LoadControl loadControlCurrent;
        private System.Windows.Forms.Panel panelLoadTop;
        private System.Windows.Forms.Panel panelPreExTop;
        private System.Windows.Forms.Panel panelExecTop;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonAddLoad;
        private System.Windows.Forms.Button buttonAddPreExecute;
        private System.Windows.Forms.Button buttonAddExecute;
        private System.Windows.Forms.Button buttonAddPostExecute;
        private System.Windows.Forms.Label labelCurrentSpell;
    }
}