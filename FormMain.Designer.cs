namespace CodeNest_Code_Editor
{
    partial class FormMain
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
            this.menuStripMainMenus = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBoxEditor = new System.Windows.Forms.RichTextBox();
            this.statusStripMainStatus = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelMain = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialogMain = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogMain = new System.Windows.Forms.SaveFileDialog();
            this.richTextBoxLineNumbers = new System.Windows.Forms.RichTextBox();
            this.panelMain = new System.Windows.Forms.Panel();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMainMenus.SuspendLayout();
            this.statusStripMainStatus.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMainMenus
            // 
            this.menuStripMainMenus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStripMainMenus.Location = new System.Drawing.Point(0, 0);
            this.menuStripMainMenus.Name = "menuStripMainMenus";
            this.menuStripMainMenus.Size = new System.Drawing.Size(1184, 24);
            this.menuStripMainMenus.TabIndex = 0;
            this.menuStripMainMenus.Text = "Menus";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // richTextBoxEditor
            // 
            this.richTextBoxEditor.Location = new System.Drawing.Point(132, 3);
            this.richTextBoxEditor.Name = "richTextBoxEditor";
            this.richTextBoxEditor.Size = new System.Drawing.Size(1052, 491);
            this.richTextBoxEditor.TabIndex = 1;
            this.richTextBoxEditor.Text = "";
            this.richTextBoxEditor.TextChanged += new System.EventHandler(this.richTextBoxEditor_TextChanged);
            // 
            // statusStripMainStatus
            // 
            this.statusStripMainStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusStripMainStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelMain});
            this.statusStripMainStatus.Location = new System.Drawing.Point(0, 24);
            this.statusStripMainStatus.Name = "statusStripMainStatus";
            this.statusStripMainStatus.Size = new System.Drawing.Size(1184, 22);
            this.statusStripMainStatus.TabIndex = 2;
            this.statusStripMainStatus.Text = "statusStripMain";
            // 
            // toolStripStatusLabelMain
            // 
            this.toolStripStatusLabelMain.Name = "toolStripStatusLabelMain";
            this.toolStripStatusLabelMain.Size = new System.Drawing.Size(139, 17);
            this.toolStripStatusLabelMain.Text = "toolStripStatusLabelMain";
            // 
            // openFileDialogMain
            // 
            this.openFileDialogMain.FileName = "openFileDialogMain";
            // 
            // richTextBoxLineNumbers
            // 
            this.richTextBoxLineNumbers.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBoxLineNumbers.Location = new System.Drawing.Point(3, 3);
            this.richTextBoxLineNumbers.Name = "richTextBoxLineNumbers";
            this.richTextBoxLineNumbers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.richTextBoxLineNumbers.Size = new System.Drawing.Size(126, 491);
            this.richTextBoxLineNumbers.TabIndex = 3;
            this.richTextBoxLineNumbers.Text = "";
            // 
            // panelMain
            // 
            this.panelMain.AutoSize = true;
            this.panelMain.Controls.Add(this.richTextBoxLineNumbers);
            this.panelMain.Controls.Add(this.richTextBoxEditor);
            this.panelMain.Location = new System.Drawing.Point(0, 50);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1187, 497);
            this.panelMain.TabIndex = 4;
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 544);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.statusStripMainStatus);
            this.Controls.Add(this.menuStripMainMenus);
            this.MainMenuStrip = this.menuStripMainMenus;
            this.Name = "FormMain";
            this.Text = "CodeNest";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStripMainMenus.ResumeLayout(false);
            this.menuStripMainMenus.PerformLayout();
            this.statusStripMainStatus.ResumeLayout(false);
            this.statusStripMainStatus.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMainMenus;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBoxEditor;
        private System.Windows.Forms.StatusStrip statusStripMainStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelMain;
        private System.Windows.Forms.OpenFileDialog openFileDialogMain;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMain;
        private System.Windows.Forms.RichTextBox richTextBoxLineNumbers;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

