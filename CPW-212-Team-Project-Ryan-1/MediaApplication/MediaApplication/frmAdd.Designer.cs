namespace MediaApplication
{
    partial class frmAdd
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
            this.chbxMovie = new System.Windows.Forms.CheckBox();
            this.chbxTVShow = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.btnAddAwards = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // chbxMovie
            // 
            this.chbxMovie.AutoSize = true;
            this.chbxMovie.Location = new System.Drawing.Point(31, 25);
            this.chbxMovie.Name = "chbxMovie";
            this.chbxMovie.Size = new System.Drawing.Size(55, 17);
            this.chbxMovie.TabIndex = 1;
            this.chbxMovie.Text = "Movie";
            this.chbxMovie.UseVisualStyleBackColor = true;
            this.chbxMovie.CheckedChanged += new System.EventHandler(this.chbxMovie_CheckedChanged);
            // 
            // chbxTVShow
            // 
            this.chbxTVShow.AutoSize = true;
            this.chbxTVShow.Location = new System.Drawing.Point(178, 25);
            this.chbxTVShow.Name = "chbxTVShow";
            this.chbxTVShow.Size = new System.Drawing.Size(70, 17);
            this.chbxTVShow.TabIndex = 2;
            this.chbxTVShow.Text = "TV Show";
            this.chbxTVShow.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Genre:";
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.Location = new System.Drawing.Point(12, 207);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(75, 23);
            this.btnAddPerson.TabIndex = 4;
            this.btnAddPerson.Text = "Add Cast";
            this.btnAddPerson.UseVisualStyleBackColor = true;
            // 
            // btnAddAwards
            // 
            this.btnAddAwards.Location = new System.Drawing.Point(105, 207);
            this.btnAddAwards.Name = "btnAddAwards";
            this.btnAddAwards.Size = new System.Drawing.Size(75, 23);
            this.btnAddAwards.TabIndex = 5;
            this.btnAddAwards.Text = "Add Award";
            this.btnAddAwards.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(123, 84);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(125, 20);
            this.txtName.TabIndex = 6;
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(123, 135);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(125, 20);
            this.txtGenre.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(197, 207);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnAddAwards);
            this.Controls.Add(this.btnAddPerson);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chbxTVShow);
            this.Controls.Add(this.chbxMovie);
            this.Controls.Add(this.label1);
            this.Name = "frmAdd";
            this.Text = "Add Media";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chbxMovie;
        private System.Windows.Forms.CheckBox chbxTVShow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.Button btnAddAwards;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.Button btnSave;
    }
}