namespace TaskManagement.CRUD_Forms
{
    partial class ProjectListing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectListing));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.chkActiveProjects = new System.Windows.Forms.CheckBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvProjects = new System.Windows.Forms.DataGridView();
            this.cmsProjects = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemEditProjects = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemProjectTasks = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjects)).BeginInit();
            this.cmsProjects.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.chkActiveProjects);
            this.splitContainer1.Panel1.Controls.Add(this.btnSearch);
            this.splitContainer1.Panel1.Controls.Add(this.txtSearch);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvProjects);
            this.splitContainer1.Size = new System.Drawing.Size(712, 505);
            this.splitContainer1.SplitterDistance = 55;
            this.splitContainer1.TabIndex = 0;
            // 
            // chkActiveProjects
            // 
            this.chkActiveProjects.AutoSize = true;
            this.chkActiveProjects.Location = new System.Drawing.Point(572, 15);
            this.chkActiveProjects.Name = "chkActiveProjects";
            this.chkActiveProjects.Size = new System.Drawing.Size(128, 17);
            this.chkActiveProjects.TabIndex = 2;
            this.chkActiveProjects.Text = "Yalnızca Aktif Projeler";
            this.chkActiveProjects.UseVisualStyleBackColor = true;
            this.chkActiveProjects.CheckedChanged += new System.EventHandler(this.chkActiveProjects_CheckedChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(215, 13);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(53, 21);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Ara";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(13, 13);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(196, 20);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dgvProjects
            // 
            this.dgvProjects.AllowUserToOrderColumns = true;
            this.dgvProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProjects.ContextMenuStrip = this.cmsProjects;
            this.dgvProjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProjects.Location = new System.Drawing.Point(0, 0);
            this.dgvProjects.MultiSelect = false;
            this.dgvProjects.Name = "dgvProjects";
            this.dgvProjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProjects.Size = new System.Drawing.Size(712, 446);
            this.dgvProjects.TabIndex = 0;
            // 
            // cmsProjects
            // 
            this.cmsProjects.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemEditProjects,
            this.menuItemProjectTasks});
            this.cmsProjects.Name = "cmsProjects";
            this.cmsProjects.Size = new System.Drawing.Size(248, 48);
            // 
            // menuItemEditProjects
            // 
            this.menuItemEditProjects.Name = "menuItemEditProjects";
            this.menuItemEditProjects.Size = new System.Drawing.Size(247, 22);
            this.menuItemEditProjects.Text = "Proje Bilgilerini Güncelle";
            this.menuItemEditProjects.Click += new System.EventHandler(this.menuItemEditProjects_Click);
            // 
            // menuItemProjectTasks
            // 
            this.menuItemProjectTasks.Name = "menuItemProjectTasks";
            this.menuItemProjectTasks.Size = new System.Drawing.Size(247, 22);
            this.menuItemProjectTasks.Text = "Projeyle İlgili Görevleri Görüntüle";
            this.menuItemProjectTasks.Click += new System.EventHandler(this.menuItemProjectTasks_Click);
            // 
            // ProjectListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 505);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProjectListing";
            this.Text = "ProjectListing";
            this.Load += new System.EventHandler(this.ProjectListing_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjects)).EndInit();
            this.cmsProjects.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvProjects;
        private System.Windows.Forms.ContextMenuStrip cmsProjects;
        private System.Windows.Forms.ToolStripMenuItem menuItemEditProjects;
        private System.Windows.Forms.ToolStripMenuItem menuItemProjectTasks;
        private System.Windows.Forms.CheckBox chkActiveProjects;
    }
}