﻿namespace MovieLibrary.WinformsHost
{
    partial class MovieForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose ( bool disposing )
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
        {
            this.label1 = new System.Windows.Forms.Label();
            this._txtName = new System.Windows.Forms.TextBox();
            this._txtDescription = new System.Windows.Forms.TextBox();
            this._txtRunLength = new System.Windows.Forms.TextBox();
            this._chkIsClassic = new System.Windows.Forms.CheckBox();
            this._comboRating = new System.Windows.Forms.ComboBox();
            this._btnSave = new System.Windows.Forms.Button();
            this._btnCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this._txtReleaseYear = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // _txtName
            // 
            this._txtName.Location = new System.Drawing.Point(152, 48);
            this._txtName.Name = "_txtName";
            this._txtName.Size = new System.Drawing.Size(199, 23);
            this._txtName.TabIndex = 0;
            // 
            // _txtDescription
            // 
            this._txtDescription.Location = new System.Drawing.Point(152, 104);
            this._txtDescription.Multiline = true;
            this._txtDescription.Name = "_txtDescription";
            this._txtDescription.Size = new System.Drawing.Size(199, 111);
            this._txtDescription.TabIndex = 2;
            // 
            // _txtRunLength
            // 
            this._txtRunLength.Location = new System.Drawing.Point(152, 235);
            this._txtRunLength.Name = "_txtRunLength";
            this._txtRunLength.Size = new System.Drawing.Size(78, 23);
            this._txtRunLength.TabIndex = 3;
            // 
            // _chkIsClassic
            // 
            this._chkIsClassic.AutoSize = true;
            this._chkIsClassic.Location = new System.Drawing.Point(152, 290);
            this._chkIsClassic.Name = "_chkIsClassic";
            this._chkIsClassic.Size = new System.Drawing.Size(78, 19);
            this._chkIsClassic.TabIndex = 6;
            this._chkIsClassic.Text = "Is Classic?";
            this._chkIsClassic.UseVisualStyleBackColor = true;
            // 
            // _comboRating
            // 
            this._comboRating.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboRating.FormattingEnabled = true;
            this._comboRating.Items.AddRange(new object[] {
            "G",
            "PG",
            "PG-13",
            "R"});
            this._comboRating.Location = new System.Drawing.Point(152, 358);
            this._comboRating.Name = "_comboRating";
            this._comboRating.Size = new System.Drawing.Size(121, 23);
            this._comboRating.TabIndex = 7;
            // 
            // _btnSave
            // 
            this._btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._btnSave.Location = new System.Drawing.Point(570, 428);
            this._btnSave.Name = "_btnSave";
            this._btnSave.Size = new System.Drawing.Size(75, 23);
            this._btnSave.TabIndex = 4;
            this._btnSave.Text = "Save";
            this._btnSave.UseVisualStyleBackColor = true;
            // 
            // _btnCancel
            // 
            this._btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._btnCancel.Location = new System.Drawing.Point(675, 428);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(75, 23);
            this._btnCancel.TabIndex = 5;
            this._btnCancel.Text = "Cancel";
            this._btnCancel.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Run Length";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 358);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Rating";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 413);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Release Year";
            // 
            // _txtReleaseYear
            // 
            this._txtReleaseYear.Location = new System.Drawing.Point(152, 410);
            this._txtReleaseYear.Name = "_txtReleaseYear";
            this._txtReleaseYear.Size = new System.Drawing.Size(100, 23);
            this._txtReleaseYear.TabIndex = 12;
            this._txtReleaseYear.Text = "1900";
            // 
            // MovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this._btnCancel;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._txtReleaseYear);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._btnCancel);
            this.Controls.Add(this._btnSave);
            this.Controls.Add(this._comboRating);
            this.Controls.Add(this._chkIsClassic);
            this.Controls.Add(this._txtRunLength);
            this.Controls.Add(this._txtDescription);
            this.Controls.Add(this._txtName);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Name = "MovieForm";
            this.Text = "Add Movie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _txtName;
        private System.Windows.Forms.TextBox _txtDescription;
        private System.Windows.Forms.TextBox _txtRunLength;
        private System.Windows.Forms.CheckBox _chkIsClassic;
        private System.Windows.Forms.ComboBox _comboRating;
        private System.Windows.Forms.Button _btnSave;
        private System.Windows.Forms.Button _btnCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox _txtReleaseYear;
    }
}

