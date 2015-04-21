namespace StaufferRestaurant
{
    partial class frmStaufferRestaurant
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStaufferRestaurant));
            this.mnuMainStrip = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileClose = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWindowCascade = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWindowTile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWindowTileHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWindowTileVertical = new System.Windows.Forms.ToolStripMenuItem();
<<<<<<< HEAD
            this.ReservationTips = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.mnuMainStrip.SuspendLayout();
            this.statusStrip1.SuspendLayout();
=======
            this.stsStatusStrip = new System.Windows.Forms.StatusStrip();
            this.stsCurrentForm = new System.Windows.Forms.ToolStripStatusLabel();
            this.stsMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.stsDateTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.mnuForms = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFormsTables = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainStrip.SuspendLayout();
            this.stsStatusStrip.SuspendLayout();
>>>>>>> origin/master
            this.SuspendLayout();
            // 
            // mnuMainStrip
            // 
            this.mnuMainStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuForms,
            this.mnuWindow});
            this.mnuMainStrip.Location = new System.Drawing.Point(0, 0);
            this.mnuMainStrip.Name = "mnuMainStrip";
            this.mnuMainStrip.Size = new System.Drawing.Size(1352, 24);
            this.mnuMainStrip.TabIndex = 1;
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileClose,
            this.mnuFileExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "&File";
            // 
            // mnuFileClose
            // 
            this.mnuFileClose.Name = "mnuFileClose";
            this.mnuFileClose.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.mnuFileClose.Size = new System.Drawing.Size(152, 22);
            this.mnuFileClose.Text = "&Close";
            this.mnuFileClose.ToolTipText = "Closes the active child form";
            this.mnuFileClose.Click += new System.EventHandler(this.mnuFileClose_Click);
            // 
            // mnuFileExit
            // 
            this.mnuFileExit.Name = "mnuFileExit";
            this.mnuFileExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mnuFileExit.Size = new System.Drawing.Size(152, 22);
            this.mnuFileExit.Text = "&Exit";
            this.mnuFileExit.ToolTipText = "Exits the program";
            this.mnuFileExit.Click += new System.EventHandler(this.mnuFileExit_Click);
            // 
            // mnuWindow
            // 
            this.mnuWindow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuWindowCascade,
            this.mnuWindowTile});
            this.mnuWindow.Name = "mnuWindow";
            this.mnuWindow.Size = new System.Drawing.Size(63, 20);
            this.mnuWindow.Text = "&Window";
            // 
            // mnuWindowCascade
            // 
            this.mnuWindowCascade.Name = "mnuWindowCascade";
            this.mnuWindowCascade.Size = new System.Drawing.Size(118, 22);
            this.mnuWindowCascade.Text = "C&ascade";
            this.mnuWindowCascade.Click += new System.EventHandler(this.mnuWindowCascade_Click);
            // 
            // mnuWindowTile
            // 
            this.mnuWindowTile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuWindowTileHorizontal,
            this.mnuWindowTileVertical});
            this.mnuWindowTile.Name = "mnuWindowTile";
            this.mnuWindowTile.Size = new System.Drawing.Size(118, 22);
            this.mnuWindowTile.Text = "&Tile";
            // 
            // mnuWindowTileHorizontal
            // 
            this.mnuWindowTileHorizontal.Name = "mnuWindowTileHorizontal";
            this.mnuWindowTileHorizontal.Size = new System.Drawing.Size(152, 22);
            this.mnuWindowTileHorizontal.Text = "&Horizontal";
            this.mnuWindowTileHorizontal.Click += new System.EventHandler(this.mnuWindowTileHorizontal_Click);
            // 
            // mnuWindowTileVertical
            // 
            this.mnuWindowTileVertical.Name = "mnuWindowTileVertical";
            this.mnuWindowTileVertical.Size = new System.Drawing.Size(152, 22);
            this.mnuWindowTileVertical.Text = "&Vertical";
            this.mnuWindowTileVertical.Click += new System.EventHandler(this.mnuWindowTileVertical_Click);
            // 
<<<<<<< HEAD
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 590);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1352, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
=======
            // stsStatusStrip
            // 
            this.stsStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stsCurrentForm,
            this.stsMessage,
            this.stsDateTime});
            this.stsStatusStrip.Location = new System.Drawing.Point(0, 590);
            this.stsStatusStrip.Name = "stsStatusStrip";
            this.stsStatusStrip.Size = new System.Drawing.Size(1352, 22);
            this.stsStatusStrip.TabIndex = 3;
            this.stsStatusStrip.Text = "statusStrip1";
            // 
            // stsCurrentForm
            // 
            this.stsCurrentForm.AutoSize = false;
            this.stsCurrentForm.Name = "stsCurrentForm";
            this.stsCurrentForm.Size = new System.Drawing.Size(200, 17);
            // 
            // stsMessage
            // 
            this.stsMessage.Name = "stsMessage";
            this.stsMessage.Size = new System.Drawing.Size(937, 17);
            this.stsMessage.Spring = true;
            // 
            // stsDateTime
            // 
            this.stsDateTime.AutoSize = false;
            this.stsDateTime.Name = "stsDateTime";
            this.stsDateTime.Size = new System.Drawing.Size(200, 17);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // mnuForms
            // 
            this.mnuForms.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFormsTables});
            this.mnuForms.Name = "mnuForms";
            this.mnuForms.Size = new System.Drawing.Size(47, 20);
            this.mnuForms.Text = "&Form";
            // 
            // mnuFormsTables
            // 
            this.mnuFormsTables.Name = "mnuFormsTables";
            this.mnuFormsTables.Size = new System.Drawing.Size(152, 22);
            this.mnuFormsTables.Text = "Ta&bles";
            this.mnuFormsTables.Click += new System.EventHandler(this.mnuFormsTables_Click);
>>>>>>> origin/master
            // 
            // frmStaufferRestaurant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 612);
<<<<<<< HEAD
            this.Controls.Add(this.statusStrip1);
=======
            this.Controls.Add(this.stsStatusStrip);
>>>>>>> origin/master
            this.Controls.Add(this.mnuMainStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuMainStrip;
            this.MinimumSize = new System.Drawing.Size(1358, 620);
            this.Name = "frmStaufferRestaurant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stauffer Restaurant Reservation System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mnuMainStrip.ResumeLayout(false);
            this.mnuMainStrip.PerformLayout();
<<<<<<< HEAD
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
=======
            this.stsStatusStrip.ResumeLayout(false);
            this.stsStatusStrip.PerformLayout();
>>>>>>> origin/master
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMainStrip;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuFileClose;
        private System.Windows.Forms.ToolStripMenuItem mnuFileExit;
        private System.Windows.Forms.ToolStripMenuItem mnuWindow;
        private System.Windows.Forms.ToolStripMenuItem mnuWindowCascade;
        private System.Windows.Forms.ToolStripMenuItem mnuWindowTile;
        private System.Windows.Forms.ToolStripMenuItem mnuWindowTileHorizontal;
        private System.Windows.Forms.ToolStripMenuItem mnuWindowTileVertical;
<<<<<<< HEAD
        private System.Windows.Forms.ToolTip ReservationTips;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
=======
        private System.Windows.Forms.StatusStrip stsStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel stsCurrentForm;
        private System.Windows.Forms.ToolStripStatusLabel stsMessage;
        private System.Windows.Forms.ToolStripStatusLabel stsDateTime;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolStripMenuItem mnuForms;
        private System.Windows.Forms.ToolStripMenuItem mnuFormsTables;
>>>>>>> origin/master
    }
}

