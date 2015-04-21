namespace StaufferRestaurant
{
    partial class frmTables
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTables));
            this.lstTableList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstTableList
            // 
            this.lstTableList.FormattingEnabled = true;
            this.lstTableList.Location = new System.Drawing.Point(12, 12);
            this.lstTableList.Name = "lstTableList";
            this.lstTableList.Size = new System.Drawing.Size(92, 186);
            this.lstTableList.TabIndex = 0;
            // 
            // frmTables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.lstTableList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTables";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tables";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTables_FormClosing);
            this.Load += new System.EventHandler(this.frmTables_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstTableList;
    }
}