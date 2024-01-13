
namespace TGMacro
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlGroup = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEnable = new System.Windows.Forms.Button();
            this.lblNoMacroMessage = new System.Windows.Forms.Label();
            this.pnlMacroList = new System.Windows.Forms.FlowLayoutPanel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.cmbLanguage = new FlatComboExample.NetFX.FlatComboBox();
            this.btnStatus = new System.Windows.Forms.Button();
            this.btnTopMost = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnFile = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.ctHelpMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnUpdates = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.ctFileMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnLoadProject = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSaveProject = new System.Windows.Forms.ToolStripMenuItem();
            this.btnImportProject = new System.Windows.Forms.ToolStripMenuItem();
            this.btnImportScript = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnlGroup.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.ctHelpMenu.SuspendLayout();
            this.ctFileMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlGroup
            // 
            this.pnlGroup.BackColor = System.Drawing.Color.Black;
            this.pnlGroup.Controls.Add(this.btnAdd);
            this.pnlGroup.Controls.Add(this.btnEnable);
            this.pnlGroup.Controls.Add(this.lblNoMacroMessage);
            this.pnlGroup.Controls.Add(this.pnlMacroList);
            this.pnlGroup.Location = new System.Drawing.Point(0, 30);
            this.pnlGroup.Name = "pnlGroup";
            this.pnlGroup.Padding = new System.Windows.Forms.Padding(10, 10, 10, 50);
            this.pnlGroup.Size = new System.Drawing.Size(464, 539);
            this.pnlGroup.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = global::TGMacroX.Properties.Resources.add_32;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.Location = new System.Drawing.Point(230, 487);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(224, 41);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Add New Macro";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnEnable
            // 
            this.btnEnable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.btnEnable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEnable.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.btnEnable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnable.ForeColor = System.Drawing.Color.White;
            this.btnEnable.Image = global::TGMacroX.Properties.Resources.start_32;
            this.btnEnable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnable.Location = new System.Drawing.Point(10, 487);
            this.btnEnable.Name = "btnEnable";
            this.btnEnable.Size = new System.Drawing.Size(214, 41);
            this.btnEnable.TabIndex = 15;
            this.btnEnable.Text = "Enable {HOME}";
            this.btnEnable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEnable.UseVisualStyleBackColor = false;
            // 
            // lblNoMacroMessage
            // 
            this.lblNoMacroMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNoMacroMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.lblNoMacroMessage.ForeColor = System.Drawing.Color.White;
            this.lblNoMacroMessage.Location = new System.Drawing.Point(10, 10);
            this.lblNoMacroMessage.Name = "lblNoMacroMessage";
            this.lblNoMacroMessage.Size = new System.Drawing.Size(444, 471);
            this.lblNoMacroMessage.TabIndex = 13;
            this.lblNoMacroMessage.Text = "No macro to show.\r\n\r\nClick \"Add New\" to create macro.";
            this.lblNoMacroMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNoMacroMessage.Click += new System.EventHandler(this.lblNoMacroMessage_Click);
            // 
            // pnlMacroList
            // 
            this.pnlMacroList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMacroList.AutoScroll = true;
            this.pnlMacroList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pnlMacroList.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlMacroList.Location = new System.Drawing.Point(10, 10);
            this.pnlMacroList.Name = "pnlMacroList";
            this.pnlMacroList.Size = new System.Drawing.Size(444, 471);
            this.pnlMacroList.TabIndex = 0;
            this.pnlMacroList.WrapContents = false;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "TGMacro Project |*.tmacroproj";
            this.saveFileDialog1.Title = "Save Project";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "TGMacro Project |*.TMacroProj";
            this.openFileDialog1.Title = "Load Project";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Black;
            this.pnlMain.Controls.Add(this.cmbLanguage);
            this.pnlMain.Controls.Add(this.btnStatus);
            this.pnlMain.Controls.Add(this.btnTopMost);
            this.pnlMain.Controls.Add(this.btnMin);
            this.pnlMain.Controls.Add(this.btnClose);
            this.pnlMain.Controls.Add(this.btnHelp);
            this.pnlMain.Controls.Add(this.btnFile);
            this.pnlMain.Controls.Add(this.lblTitle);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlMain.MaximumSize = new System.Drawing.Size(0, 30);
            this.pnlMain.MinimumSize = new System.Drawing.Size(0, 30);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.pnlMain.Size = new System.Drawing.Size(464, 30);
            this.pnlMain.TabIndex = 6;
            // 
            // cmbLanguage
            // 
            this.cmbLanguage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.cmbLanguage.BorderColor = System.Drawing.Color.Black;
            this.cmbLanguage.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.cmbLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLanguage.ForeColor = System.Drawing.Color.White;
            this.cmbLanguage.FormattingEnabled = true;
            this.cmbLanguage.Location = new System.Drawing.Point(231, 5);
            this.cmbLanguage.Name = "cmbLanguage";
            this.cmbLanguage.Size = new System.Drawing.Size(121, 23);
            this.cmbLanguage.TabIndex = 15;
            // 
            // btnStatus
            // 
            this.btnStatus.BackgroundImage = global::TGMacroX.Properties.Resources.paused_16;
            this.btnStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStatus.FlatAppearance.BorderSize = 0;
            this.btnStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatus.Location = new System.Drawing.Point(358, 5);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(20, 24);
            this.btnStatus.TabIndex = 11;
            this.btnStatus.UseVisualStyleBackColor = true;
            this.btnStatus.Click += new System.EventHandler(this.btnStatus_Click);
            // 
            // btnTopMost
            // 
            this.btnTopMost.BackgroundImage = global::TGMacroX.Properties.Resources.unlock_16;
            this.btnTopMost.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTopMost.FlatAppearance.BorderSize = 0;
            this.btnTopMost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTopMost.Location = new System.Drawing.Point(384, 0);
            this.btnTopMost.Name = "btnTopMost";
            this.btnTopMost.Size = new System.Drawing.Size(20, 30);
            this.btnTopMost.TabIndex = 10;
            this.btnTopMost.UseVisualStyleBackColor = true;
            this.btnTopMost.Click += new System.EventHandler(this.btnTopMost_Click);
            // 
            // btnMin
            // 
            this.btnMin.BackgroundImage = global::TGMacroX.Properties.Resources.min_16;
            this.btnMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Location = new System.Drawing.Point(410, 0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(20, 30);
            this.btnMin.TabIndex = 13;
            this.btnMin.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::TGMacroX.Properties.Resources.close_16;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(434, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 30);
            this.btnClose.TabIndex = 9;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnHelp
            // 
            this.btnHelp.AutoSize = true;
            this.btnHelp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHelp.BackColor = System.Drawing.Color.Black;
            this.btnHelp.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.ForeColor = System.Drawing.Color.White;
            this.btnHelp.Location = new System.Drawing.Point(135, 0);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(43, 30);
            this.btnHelp.TabIndex = 8;
            this.btnHelp.Text = "&Help";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnFile
            // 
            this.btnFile.AutoSize = true;
            this.btnFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFile.BackColor = System.Drawing.Color.Black;
            this.btnFile.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnFile.FlatAppearance.BorderSize = 0;
            this.btnFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFile.ForeColor = System.Drawing.Color.White;
            this.btnFile.Location = new System.Drawing.Point(98, 0);
            this.btnFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(37, 30);
            this.btnFile.TabIndex = 7;
            this.btnFile.Text = "&File";
            this.btnFile.UseVisualStyleBackColor = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Black;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(10, 0);
            this.lblTitle.MaximumSize = new System.Drawing.Size(0, 30);
            this.lblTitle.MinimumSize = new System.Drawing.Size(0, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.lblTitle.Size = new System.Drawing.Size(88, 30);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "TGMacro X";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ctHelpMenu
            // 
            this.ctHelpMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctHelpMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnUpdates,
            this.btnAbout});
            this.ctHelpMenu.Name = "ctFileMenu";
            this.ctHelpMenu.Size = new System.Drawing.Size(122, 56);
            // 
            // btnUpdates
            // 
            this.btnUpdates.BackColor = System.Drawing.Color.Black;
            this.btnUpdates.ForeColor = System.Drawing.Color.White;
            this.btnUpdates.Image = global::TGMacroX.Properties.Resources.update_16;
            this.btnUpdates.Name = "btnUpdates";
            this.btnUpdates.Size = new System.Drawing.Size(121, 26);
            this.btnUpdates.Text = "Updates";
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.Black;
            this.btnAbout.ForeColor = System.Drawing.Color.White;
            this.btnAbout.Image = global::TGMacroX.Properties.Resources.about_16;
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(121, 26);
            this.btnAbout.Text = "About";
            // 
            // ctFileMenu
            // 
            this.ctFileMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctFileMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLoadProject,
            this.btnSaveProject,
            this.btnImportProject,
            this.btnImportScript});
            this.ctFileMenu.Name = "ctFileMenu";
            this.ctFileMenu.Size = new System.Drawing.Size(155, 108);
            // 
            // btnLoadProject
            // 
            this.btnLoadProject.BackColor = System.Drawing.Color.Black;
            this.btnLoadProject.ForeColor = System.Drawing.Color.White;
            this.btnLoadProject.Image = global::TGMacroX.Properties.Resources.open_16;
            this.btnLoadProject.Name = "btnLoadProject";
            this.btnLoadProject.Size = new System.Drawing.Size(154, 26);
            this.btnLoadProject.Text = "Load Project";
            // 
            // btnSaveProject
            // 
            this.btnSaveProject.BackColor = System.Drawing.Color.Black;
            this.btnSaveProject.ForeColor = System.Drawing.Color.White;
            this.btnSaveProject.Image = global::TGMacroX.Properties.Resources.save_16;
            this.btnSaveProject.Name = "btnSaveProject";
            this.btnSaveProject.Size = new System.Drawing.Size(154, 26);
            this.btnSaveProject.Text = "Save Project";
            // 
            // btnImportProject
            // 
            this.btnImportProject.BackColor = System.Drawing.Color.Black;
            this.btnImportProject.ForeColor = System.Drawing.Color.White;
            this.btnImportProject.Image = global::TGMacroX.Properties.Resources.import_16;
            this.btnImportProject.Name = "btnImportProject";
            this.btnImportProject.Size = new System.Drawing.Size(154, 26);
            this.btnImportProject.Text = "Import Project";
            // 
            // btnImportScript
            // 
            this.btnImportScript.BackColor = System.Drawing.Color.Black;
            this.btnImportScript.ForeColor = System.Drawing.Color.White;
            this.btnImportScript.Image = global::TGMacroX.Properties.Resources.import_sc_16;
            this.btnImportScript.Name = "btnImportScript";
            this.btnImportScript.Size = new System.Drawing.Size(154, 26);
            this.btnImportScript.Text = "Import Script";
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(464, 569);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlGroup);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TGMX";
            this.pnlGroup.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ctHelpMenu.ResumeLayout(false);
            this.ctFileMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGroup;
        private System.Windows.Forms.FlowLayoutPanel pnlMacroList;
        private System.Windows.Forms.Label lblNoMacroMessage;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnEnable;
        private System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.Panel pnlMain;
        public System.Windows.Forms.Button btnStatus;
        public System.Windows.Forms.Button btnTopMost;
        public System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.Button btnHelp;
        public System.Windows.Forms.Button btnFile;
        public System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ContextMenuStrip ctHelpMenu;
        public System.Windows.Forms.ToolStripMenuItem btnUpdates;
        public System.Windows.Forms.ToolStripMenuItem btnAbout;
        private System.Windows.Forms.ContextMenuStrip ctFileMenu;
        public System.Windows.Forms.ToolStripMenuItem btnLoadProject;
        public System.Windows.Forms.ToolStripMenuItem btnSaveProject;
        public System.Windows.Forms.ToolStripMenuItem btnImportProject;
        public System.Windows.Forms.ToolStripMenuItem btnImportScript;
        private System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.Button btnMin;
        private FlatComboExample.NetFX.FlatComboBox cmbLanguage;
    }
}

