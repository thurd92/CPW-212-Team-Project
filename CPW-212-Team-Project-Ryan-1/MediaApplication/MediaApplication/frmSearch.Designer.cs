namespace MediaApplication
{
    partial class frmSearch
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
            this.lstBoxMovieResults = new System.Windows.Forms.ListBox();
            this.lstBoxTVResults = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstBoxMovieResults
            // 
            this.lstBoxMovieResults.FormattingEnabled = true;
            this.lstBoxMovieResults.Location = new System.Drawing.Point(12, 63);
            this.lstBoxMovieResults.Name = "lstBoxMovieResults";
            this.lstBoxMovieResults.Size = new System.Drawing.Size(149, 186);
            this.lstBoxMovieResults.TabIndex = 0;
            // 
            // lstBoxTVResults
            // 
            this.lstBoxTVResults.FormattingEnabled = true;
            this.lstBoxTVResults.Location = new System.Drawing.Point(181, 63);
            this.lstBoxTVResults.Name = "lstBoxTVResults";
            this.lstBoxTVResults.Size = new System.Drawing.Size(148, 186);
            this.lstBoxTVResults.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Movies";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "TVShows";
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstBoxTVResults);
            this.Controls.Add(this.lstBoxMovieResults);
            this.Name = "frmSearch";
            this.Text = "Search Media";
            this.Load += new System.EventHandler(this.frmSearch_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBoxMovieResults;
        private System.Windows.Forms.ListBox lstBoxTVResults;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}