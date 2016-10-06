namespace TaskManagement.CRUD_Forms
{
    partial class EmployeeListing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeListing));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.chkActiveEmployees = new System.Windows.Forms.CheckBox();
            this.btnSearchEmployee = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.cmsUpdate = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemEditEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemEmployeeTasks = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.cmsUpdate.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.chkActiveEmployees);
            this.splitContainer1.Panel1.Controls.Add(this.btnSearchEmployee);
            this.splitContainer1.Panel1.Controls.Add(this.txtSearch);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvEmployees);
            this.splitContainer1.Size = new System.Drawing.Size(664, 463);
            this.splitContainer1.SplitterDistance = 42;
            this.splitContainer1.TabIndex = 0;
            // 
            // chkActiveEmployees
            // 
            this.chkActiveEmployees.AutoSize = true;
            this.chkActiveEmployees.Location = new System.Drawing.Point(500, 15);
            this.chkActiveEmployees.Name = "chkActiveEmployees";
            this.chkActiveEmployees.Size = new System.Drawing.Size(134, 17);
            this.chkActiveEmployees.TabIndex = 2;
            this.chkActiveEmployees.Text = "Yalnızca Aktif Personel";
            this.chkActiveEmployees.UseVisualStyleBackColor = true;
            this.chkActiveEmployees.CheckedChanged += new System.EventHandler(this.chkActiveEmployees_CheckedChanged);
            // 
            // btnSearchEmployee
            // 
            this.btnSearchEmployee.Location = new System.Drawing.Point(204, 13);
            this.btnSearchEmployee.Name = "btnSearchEmployee";
            this.btnSearchEmployee.Size = new System.Drawing.Size(50, 20);
            this.btnSearchEmployee.TabIndex = 1;
            this.btnSearchEmployee.Text = "Ara";
            this.btnSearchEmployee.UseVisualStyleBackColor = true;
            this.btnSearchEmployee.Click += new System.EventHandler(this.btnSearchEmployee_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(13, 13);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(185, 20);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.AllowUserToOrderColumns = true;
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.ContextMenuStrip = this.cmsUpdate;
            this.dgvEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmployees.Location = new System.Drawing.Point(0, 0);
            this.dgvEmployees.MultiSelect = false;
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployees.Size = new System.Drawing.Size(664, 417);
            this.dgvEmployees.TabIndex = 0;
            // 
            // cmsUpdate
            // 
            this.cmsUpdate.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemEditEmployee,
            this.menuItemEmployeeTasks});
            this.cmsUpdate.Name = "cmsUpdate";
            this.cmsUpdate.Size = new System.Drawing.Size(228, 48);
            // 
            // menuItemEditEmployee
            // 
            this.menuItemEditEmployee.Name = "menuItemEditEmployee";
            this.menuItemEditEmployee.Size = new System.Drawing.Size(227, 22);
            this.menuItemEditEmployee.Text = "Güncelle";
            this.menuItemEditEmployee.Click += new System.EventHandler(this.menuItemEditEmployee_Click);
            // 
            // menuItemEmployeeTasks
            // 
            this.menuItemEmployeeTasks.Name = "menuItemEmployeeTasks";
            this.menuItemEmployeeTasks.Size = new System.Drawing.Size(227, 22);
            this.menuItemEmployeeTasks.Text = "İlgili Personelin İşlerini Listele";
            this.menuItemEmployeeTasks.Click += new System.EventHandler(this.menuItemEmployeeTasks_Click);
            // 
            // EmployeeListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 463);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmployeeListing";
            this.Text = "EmployeeListing";
            this.Load += new System.EventHandler(this.EmployeeListing_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.cmsUpdate.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnSearchEmployee;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.ContextMenuStrip cmsUpdate;
        private System.Windows.Forms.ToolStripMenuItem menuItemEditEmployee;
        private System.Windows.Forms.CheckBox chkActiveEmployees;
        private System.Windows.Forms.ToolStripMenuItem menuItemEmployeeTasks;
    }
}