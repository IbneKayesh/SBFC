namespace SBFC
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
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.pnlDesktop = new System.Windows.Forms.Panel();
            this.txtSourceExt = new System.Windows.Forms.TextBox();
            this.btnDeleteFiles = new System.Windows.Forms.Button();
            this.lblDestinationPath = new System.Windows.Forms.Label();
            this.txtDestinationPath = new System.Windows.Forms.TextBox();
            this.btnPng2Jpeg = new System.Windows.Forms.Button();
            this.lblSourcesPath = new System.Windows.Forms.Label();
            this.txtSourcesPath = new System.Windows.Forms.TextBox();
            this.pnlTitleBar.SuspendLayout();
            this.pnlDesktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = global::SBFC.Properties.Resources.minimize_28;
            this.btnMinimize.Location = new System.Drawing.Point(672, 0);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(39, 35);
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::SBFC.Properties.Resources.close_28;
            this.btnClose.Location = new System.Drawing.Point(711, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(39, 35);
            this.btnClose.TabIndex = 3;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(61)))), ((int)(((byte)(124)))));
            this.pnlTitleBar.Controls.Add(this.lblPageTitle);
            this.pnlTitleBar.Controls.Add(this.btnMinimize);
            this.pnlTitleBar.Controls.Add(this.btnClose);
            this.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTitleBar.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(750, 35);
            this.pnlTitleBar.TabIndex = 1;
            this.pnlTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseDown);
            // 
            // lblPageTitle
            // 
            this.lblPageTitle.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.lblPageTitle.AutoSize = true;
            this.lblPageTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblPageTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblPageTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPageTitle.ForeColor = System.Drawing.Color.White;
            this.lblPageTitle.Location = new System.Drawing.Point(0, 0);
            this.lblPageTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.Padding = new System.Windows.Forms.Padding(3, 7, 0, 0);
            this.lblPageTitle.Size = new System.Drawing.Size(179, 28);
            this.lblPageTitle.TabIndex = 5;
            this.lblPageTitle.Tag = "Home";
            this.lblPageTitle.Text = "Sieve Batch File Convert";
            // 
            // pnlDesktop
            // 
            this.pnlDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.pnlDesktop.Controls.Add(this.txtSourceExt);
            this.pnlDesktop.Controls.Add(this.btnDeleteFiles);
            this.pnlDesktop.Controls.Add(this.lblDestinationPath);
            this.pnlDesktop.Controls.Add(this.txtDestinationPath);
            this.pnlDesktop.Controls.Add(this.btnPng2Jpeg);
            this.pnlDesktop.Controls.Add(this.lblSourcesPath);
            this.pnlDesktop.Controls.Add(this.txtSourcesPath);
            this.pnlDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDesktop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnlDesktop.Location = new System.Drawing.Point(0, 35);
            this.pnlDesktop.Margin = new System.Windows.Forms.Padding(4);
            this.pnlDesktop.Name = "pnlDesktop";
            this.pnlDesktop.Size = new System.Drawing.Size(750, 167);
            this.pnlDesktop.TabIndex = 2;
            // 
            // txtSourceExt
            // 
            this.txtSourceExt.Location = new System.Drawing.Point(86, 52);
            this.txtSourceExt.Name = "txtSourceExt";
            this.txtSourceExt.PlaceholderText = "Filter by extension .txt";
            this.txtSourceExt.Size = new System.Drawing.Size(267, 29);
            this.txtSourceExt.TabIndex = 11;
            // 
            // btnDeleteFiles
            // 
            this.btnDeleteFiles.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnDeleteFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteFiles.ForeColor = System.Drawing.Color.White;
            this.btnDeleteFiles.Image = global::SBFC.Properties.Resources.del_doc_28;
            this.btnDeleteFiles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteFiles.Location = new System.Drawing.Point(261, 108);
            this.btnDeleteFiles.Name = "btnDeleteFiles";
            this.btnDeleteFiles.Size = new System.Drawing.Size(130, 35);
            this.btnDeleteFiles.TabIndex = 10;
            this.btnDeleteFiles.Text = "Delete Files";
            this.btnDeleteFiles.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteFiles.UseVisualStyleBackColor = false;
            // 
            // lblDestinationPath
            // 
            this.lblDestinationPath.AutoSize = true;
            this.lblDestinationPath.Location = new System.Drawing.Point(368, 21);
            this.lblDestinationPath.Name = "lblDestinationPath";
            this.lblDestinationPath.Size = new System.Drawing.Size(92, 21);
            this.lblDestinationPath.TabIndex = 9;
            this.lblDestinationPath.Text = "Destination:";
            // 
            // txtDestinationPath
            // 
            this.txtDestinationPath.Location = new System.Drawing.Point(466, 18);
            this.txtDestinationPath.Name = "txtDestinationPath";
            this.txtDestinationPath.PlaceholderText = "Enter Destination Path";
            this.txtDestinationPath.Size = new System.Drawing.Size(267, 29);
            this.txtDestinationPath.TabIndex = 8;
            this.txtDestinationPath.Click += new System.EventHandler(this.txtDestinationPath_Click);
            // 
            // btnPng2Jpeg
            // 
            this.btnPng2Jpeg.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnPng2Jpeg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPng2Jpeg.ForeColor = System.Drawing.Color.White;
            this.btnPng2Jpeg.Image = global::SBFC.Properties.Resources.gear_28;
            this.btnPng2Jpeg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPng2Jpeg.Location = new System.Drawing.Point(95, 108);
            this.btnPng2Jpeg.Name = "btnPng2Jpeg";
            this.btnPng2Jpeg.Size = new System.Drawing.Size(130, 35);
            this.btnPng2Jpeg.TabIndex = 6;
            this.btnPng2Jpeg.Text = "PNG 2 JPG";
            this.btnPng2Jpeg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPng2Jpeg.UseVisualStyleBackColor = false;
            this.btnPng2Jpeg.Click += new System.EventHandler(this.btnPng2Jpeg_Click);
            // 
            // lblSourcesPath
            // 
            this.lblSourcesPath.AutoSize = true;
            this.lblSourcesPath.Location = new System.Drawing.Point(12, 21);
            this.lblSourcesPath.Name = "lblSourcesPath";
            this.lblSourcesPath.Size = new System.Drawing.Size(68, 21);
            this.lblSourcesPath.TabIndex = 5;
            this.lblSourcesPath.Text = "Sources:";
            // 
            // txtSourcesPath
            // 
            this.txtSourcesPath.Location = new System.Drawing.Point(86, 17);
            this.txtSourcesPath.Name = "txtSourcesPath";
            this.txtSourcesPath.PlaceholderText = "Enter Sources Path";
            this.txtSourcesPath.Size = new System.Drawing.Size(267, 29);
            this.txtSourcesPath.TabIndex = 4;
            this.txtSourcesPath.Click += new System.EventHandler(this.txtSourcesPath_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 202);
            this.ControlBox = false;
            this.Controls.Add(this.pnlDesktop);
            this.Controls.Add(this.pnlTitleBar);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sieve Batch Converter";
            this.pnlTitleBar.ResumeLayout(false);
            this.pnlTitleBar.PerformLayout();
            this.pnlDesktop.ResumeLayout(false);
            this.pnlDesktop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnMinimize;
        private Button btnClose;
        private Panel pnlTitleBar;
        private Label lblPageTitle;
        private Panel pnlDesktop;
        private Button btnPng2Jpeg;
        private Label lblSourcesPath;
        private TextBox txtSourcesPath;
        private Label lblDestinationPath;
        private TextBox txtDestinationPath;
        private Button btnDeleteFiles;
        private TextBox txtSourceExt;
    }
}