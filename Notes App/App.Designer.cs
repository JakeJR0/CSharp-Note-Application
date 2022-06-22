namespace Notes_App
{
    partial class Notes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notes));
            this.NoteOpener = new System.Windows.Forms.OpenFileDialog();
            this.SaveNote = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FontSelector = new System.Windows.Forms.FontDialog();
            this.MainPage = new System.Windows.Forms.Panel();
            this.NoteInput = new System.Windows.Forms.RichTextBox();
            this.Settings = new System.Windows.Forms.Panel();
            this.TransparencyLabel = new System.Windows.Forms.Label();
            this.STitle = new System.Windows.Forms.Label();
            this.SettingsExit = new System.Windows.Forms.Button();
            this.TransparencyBar = new System.Windows.Forms.TrackBar();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.MainPage.SuspendLayout();
            this.Settings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TransparencyBar)).BeginInit();
            this.SuspendLayout();
            // 
            // NoteOpener
            // 
            this.NoteOpener.DefaultExt = "txt";
            this.NoteOpener.FileName = "Untitled";
            this.NoteOpener.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            this.NoteOpener.Title = "Select your notes";
            // 
            // SaveNote
            // 
            this.SaveNote.DefaultExt = "txt";
            this.SaveNote.FileName = "Untitled";
            this.SaveNote.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            this.SaveNote.Title = "Save your notes";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(970, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openFileToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.newToolStripMenuItem.Text = "New File";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.openFileToolStripMenuItem.Text = "Open File";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editorToolStripMenuItem
            // 
            this.editorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.editorToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.editorToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.editorToolStripMenuItem.Name = "editorToolStripMenuItem";
            this.editorToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.editorToolStripMenuItem.Text = "Editor";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // FontSelector
            // 
            this.FontSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.FontSelector.MaxSize = 72;
            this.FontSelector.MinSize = 11;
            this.FontSelector.ShowEffects = false;
            // 
            // MainPage
            // 
            this.MainPage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainPage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MainPage.Controls.Add(this.NoteInput);
            this.MainPage.Location = new System.Drawing.Point(12, 42);
            this.MainPage.Name = "MainPage";
            this.MainPage.Size = new System.Drawing.Size(946, 464);
            this.MainPage.TabIndex = 2;
            // 
            // NoteInput
            // 
            this.NoteInput.AcceptsTab = true;
            this.NoteInput.AccessibleDescription = "This is where you are able to type in notes.";
            this.NoteInput.AccessibleName = "Text Box";
            this.NoteInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NoteInput.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.NoteInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NoteInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.NoteInput.Location = new System.Drawing.Point(16, 17);
            this.NoteInput.Name = "NoteInput";
            this.NoteInput.Size = new System.Drawing.Size(916, 432);
            this.NoteInput.TabIndex = 2;
            this.NoteInput.Text = "";
            // 
            // Settings
            // 
            this.Settings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Settings.Controls.Add(this.TransparencyBar);
            this.Settings.Controls.Add(this.TransparencyLabel);
            this.Settings.Controls.Add(this.STitle);
            this.Settings.Controls.Add(this.SettingsExit);
            this.Settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Settings.ForeColor = System.Drawing.Color.Black;
            this.Settings.Location = new System.Drawing.Point(12, 42);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(946, 464);
            this.Settings.TabIndex = 3;
            // 
            // TransparencyLabel
            // 
            this.TransparencyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.TransparencyLabel.Location = new System.Drawing.Point(6, 98);
            this.TransparencyLabel.Name = "TransparencyLabel";
            this.TransparencyLabel.Size = new System.Drawing.Size(213, 45);
            this.TransparencyLabel.TabIndex = 2;
            this.TransparencyLabel.Text = "Editor Transparency:";
            this.TransparencyLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // STitle
            // 
            this.STitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.STitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.STitle.Location = new System.Drawing.Point(0, 0);
            this.STitle.Name = "STitle";
            this.STitle.Size = new System.Drawing.Size(946, 52);
            this.STitle.TabIndex = 1;
            this.STitle.Text = "Editor Settings";
            this.STitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SettingsExit
            // 
            this.SettingsExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SettingsExit.ForeColor = System.Drawing.Color.Crimson;
            this.SettingsExit.Location = new System.Drawing.Point(0, 432);
            this.SettingsExit.Name = "SettingsExit";
            this.SettingsExit.Size = new System.Drawing.Size(946, 32);
            this.SettingsExit.TabIndex = 0;
            this.SettingsExit.Text = "X";
            this.SettingsExit.UseVisualStyleBackColor = true;
            this.SettingsExit.Click += new System.EventHandler(this.SettingsExit_Click);
            // 
            // TransparencyBar
            // 
            this.TransparencyBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TransparencyBar.Location = new System.Drawing.Point(225, 98);
            this.TransparencyBar.Minimum = 3;
            this.TransparencyBar.Name = "TransparencyBar";
            this.TransparencyBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TransparencyBar.RightToLeftLayout = true;
            this.TransparencyBar.Size = new System.Drawing.Size(718, 45);
            this.TransparencyBar.TabIndex = 7;
            this.TransparencyBar.Value = 10;
            this.TransparencyBar.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.fontToolStripMenuItem.Text = "Font";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click_1);
            // 
            // Notes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(970, 518);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.MainPage);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Cornsilk;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Notes";
            this.Text = "Sharp Notes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Notes_FormClosing);
            this.Load += new System.EventHandler(this.Notes_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.MainPage.ResumeLayout(false);
            this.Settings.ResumeLayout(false);
            this.Settings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TransparencyBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog NoteOpener;
        private System.Windows.Forms.SaveFileDialog SaveNote;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.FontDialog FontSelector;
        private System.Windows.Forms.ToolStripMenuItem editorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.Panel MainPage;
        private System.Windows.Forms.RichTextBox NoteInput;
        private System.Windows.Forms.Panel Settings;
        private System.Windows.Forms.Button SettingsExit;
        private System.Windows.Forms.Label TransparencyLabel;
        private System.Windows.Forms.Label STitle;
        private System.Windows.Forms.TrackBar TransparencyBar;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
    }
}

