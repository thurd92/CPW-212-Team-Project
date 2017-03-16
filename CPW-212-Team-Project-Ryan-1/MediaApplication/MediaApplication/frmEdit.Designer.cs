namespace MediaApplication
{
    partial class frmEdit
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtEditName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEditGenre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEditCast = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEditAward = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.chkTV = new System.Windows.Forms.CheckBox();
            this.chkMovie = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            // 
            // txtEditName
            // 
            this.txtEditName.Location = new System.Drawing.Point(110, 82);
            this.txtEditName.Name = "txtEditName";
            this.txtEditName.Size = new System.Drawing.Size(117, 20);
            this.txtEditName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Genre:";
            // 
            // txtEditGenre
            // 
            this.txtEditGenre.Location = new System.Drawing.Point(110, 115);
            this.txtEditGenre.Name = "txtEditGenre";
            this.txtEditGenre.Size = new System.Drawing.Size(117, 20);
            this.txtEditGenre.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cast:";
            // 
            // txtEditCast
            // 
            this.txtEditCast.Location = new System.Drawing.Point(110, 151);
            this.txtEditCast.Name = "txtEditCast";
            this.txtEditCast.Size = new System.Drawing.Size(117, 20);
            this.txtEditCast.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Award(s):";
            // 
            // txtEditAward
            // 
            this.txtEditAward.Location = new System.Drawing.Point(110, 189);
            this.txtEditAward.Name = "txtEditAward";
            this.txtEditAward.Size = new System.Drawing.Size(117, 20);
            this.txtEditAward.TabIndex = 3;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(110, 227);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Save";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // chkTV
            // 
            this.chkTV.AutoSize = true;
            this.chkTV.Location = new System.Drawing.Point(171, 24);
            this.chkTV.Name = "chkTV";
            this.chkTV.Size = new System.Drawing.Size(70, 17);
            this.chkTV.TabIndex = 1;
            this.chkTV.Text = "TV Show";
            this.chkTV.UseVisualStyleBackColor = true;
            // 
            // chkMovie
            // 
            this.chkMovie.AutoSize = true;
            this.chkMovie.Location = new System.Drawing.Point(30, 24);
            this.chkMovie.Name = "chkMovie";
            this.chkMovie.Size = new System.Drawing.Size(55, 17);
            this.chkMovie.TabIndex = 0;
            this.chkMovie.Text = "Movie";
            this.chkMovie.UseVisualStyleBackColor = true;
            // 
            // frmEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txtEditAward);
            this.Controls.Add(this.txtEditCast);
            this.Controls.Add(this.txtEditGenre);
            this.Controls.Add(this.txtEditName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkTV);
            this.Controls.Add(this.chkMovie);
            this.Name = "frmEdit";
            this.Text = "Edit Media";
            this.Load += new System.EventHandler(this.frmEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEditName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEditGenre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEditCast;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEditAward;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.CheckBox chkTV;
        private System.Windows.Forms.CheckBox chkMovie;
    }
}