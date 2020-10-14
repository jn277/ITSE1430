﻿namespace CharacterCreator.Winforms
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this._miFile = new System.Windows.Forms.ToolStripMenuItem();
            this._miFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this._miHelp = new System.Windows.Forms.ToolStripMenuItem();
            this._miHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this._miCharacter = new System.Windows.Forms.ToolStripMenuItem();
            this._miCharacterNew = new System.Windows.Forms.ToolStripMenuItem();
            this._miCharacterEdit = new System.Windows.Forms.ToolStripMenuItem();
            this._lstCharacters = new System.Windows.Forms.ListBox();
            this._miCharacterDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._miFile,
            this._miHelp,
            this._miCharacter});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // _miFile
            // 
            this._miFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._miFileExit});
            this._miFile.Name = "_miFile";
            this._miFile.Size = new System.Drawing.Size(37, 20);
            this._miFile.Text = "&File";
            // 
            // _miFileExit
            // 
            this._miFileExit.Name = "_miFileExit";
            this._miFileExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this._miFileExit.Size = new System.Drawing.Size(134, 22);
            this._miFileExit.Text = "E&xit";
            // 
            // _miHelp
            // 
            this._miHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._miHelpAbout});
            this._miHelp.Name = "_miHelp";
            this._miHelp.Size = new System.Drawing.Size(44, 20);
            this._miHelp.Text = "&Help";
            // 
            // _miHelpAbout
            // 
            this._miHelpAbout.Name = "_miHelpAbout";
            this._miHelpAbout.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this._miHelpAbout.Size = new System.Drawing.Size(126, 22);
            this._miHelpAbout.Text = "A&bout";
            // 
            // _miCharacter
            // 
            this._miCharacter.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._miCharacterNew,
            this._miCharacterEdit,
            this._miCharacterDelete});
            this._miCharacter.Name = "_miCharacter";
            this._miCharacter.Size = new System.Drawing.Size(70, 20);
            this._miCharacter.Text = "&Character";
            // 
            // _miCharacterNew
            // 
            this._miCharacterNew.Name = "_miCharacterNew";
            this._miCharacterNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this._miCharacterNew.Size = new System.Drawing.Size(180, 22);
            this._miCharacterNew.Text = "N&ew";
            // 
            // _miCharacterEdit
            // 
            this._miCharacterEdit.Name = "_miCharacterEdit";
            this._miCharacterEdit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this._miCharacterEdit.Size = new System.Drawing.Size(180, 22);
            this._miCharacterEdit.Text = "E&dit";
            // 
            // _lstCharacters
            // 
            this._lstCharacters.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._lstCharacters.FormattingEnabled = true;
            this._lstCharacters.Location = new System.Drawing.Point(13, 41);
            this._lstCharacters.Name = "_lstCharacters";
            this._lstCharacters.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this._lstCharacters.Size = new System.Drawing.Size(238, 303);
            this._lstCharacters.TabIndex = 1;
            // 
            // _miCharacterDelete
            // 
            this._miCharacterDelete.Name = "_miCharacterDelete";
            this._miCharacterDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this._miCharacterDelete.Size = new System.Drawing.Size(180, 22);
            this._miCharacterDelete.Text = "D&elete";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 412);
            this.Controls.Add(this._lstCharacters);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(260, 420);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Character";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem _miFile;
        private System.Windows.Forms.ToolStripMenuItem _miFileExit;
        private System.Windows.Forms.ToolStripMenuItem _miHelp;
        private System.Windows.Forms.ToolStripMenuItem _miHelpAbout;
        private System.Windows.Forms.ToolStripMenuItem _miCharacter;
        private System.Windows.Forms.ToolStripMenuItem _miCharacterNew;
        private System.Windows.Forms.ListBox _lstCharacters;
        private System.Windows.Forms.ToolStripMenuItem _miCharacterEdit;
        private System.Windows.Forms.ToolStripMenuItem _miCharacterDelete;
    }
}

