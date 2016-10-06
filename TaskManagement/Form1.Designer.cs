namespace TaskManagement
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.menuItemEmpMan = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemEditEmp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemListEmp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCusMan = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemEditCus = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemListCus = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemProjMan = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemEditProject = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemListProject = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemReqMan = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemEditRequest = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemListRequests = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemTaskMan = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemEditTask = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemListTasks = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemEmpMan,
            this.menuItemCusMan,
            this.menuItemProjMan,
            this.menuItemReqMan,
            this.menuItemTaskMan});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(996, 24);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "menuStrip1";
            // 
            // menuItemEmpMan
            // 
            this.menuItemEmpMan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemEditEmp,
            this.menuItemListEmp});
            this.menuItemEmpMan.Name = "menuItemEmpMan";
            this.menuItemEmpMan.Size = new System.Drawing.Size(114, 20);
            this.menuItemEmpMan.Text = "Personel Yönetimi";
            // 
            // menuItemEditEmp
            // 
            this.menuItemEditEmp.Name = "menuItemEditEmp";
            this.menuItemEditEmp.Size = new System.Drawing.Size(171, 22);
            this.menuItemEditEmp.Text = "Personel Ekle";
            this.menuItemEditEmp.Click += new System.EventHandler(this.menuItemEditEmp_Click);
            // 
            // menuItemListEmp
            // 
            this.menuItemListEmp.Name = "menuItemListEmp";
            this.menuItemListEmp.Size = new System.Drawing.Size(171, 22);
            this.menuItemListEmp.Text = "Personelleri Listele";
            this.menuItemListEmp.Click += new System.EventHandler(this.menuItemListEmp_Click);
            // 
            // menuItemCusMan
            // 
            this.menuItemCusMan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemEditCus,
            this.menuItemListCus});
            this.menuItemCusMan.Name = "menuItemCusMan";
            this.menuItemCusMan.Size = new System.Drawing.Size(109, 20);
            this.menuItemCusMan.Text = "Müşteri Yönetimi";
            // 
            // menuItemEditCus
            // 
            this.menuItemEditCus.Name = "menuItemEditCus";
            this.menuItemEditCus.Size = new System.Drawing.Size(166, 22);
            this.menuItemEditCus.Text = "Müşteri Ekle";
            this.menuItemEditCus.Click += new System.EventHandler(this.menuItemEditCus_Click);
            // 
            // menuItemListCus
            // 
            this.menuItemListCus.Name = "menuItemListCus";
            this.menuItemListCus.Size = new System.Drawing.Size(166, 22);
            this.menuItemListCus.Text = "Müşterileri Listele";
            this.menuItemListCus.Click += new System.EventHandler(this.menuItemListCus_Click);
            // 
            // menuItemProjMan
            // 
            this.menuItemProjMan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemEditProject,
            this.menuItemListProject});
            this.menuItemProjMan.Name = "menuItemProjMan";
            this.menuItemProjMan.Size = new System.Drawing.Size(96, 20);
            this.menuItemProjMan.Text = "Proje Yönetimi";
            // 
            // menuItemEditProject
            // 
            this.menuItemEditProject.Name = "menuItemEditProject";
            this.menuItemEditProject.Size = new System.Drawing.Size(153, 22);
            this.menuItemEditProject.Text = "Proje Ekle";
            this.menuItemEditProject.Click += new System.EventHandler(this.menuItemEditProject_Click);
            // 
            // menuItemListProject
            // 
            this.menuItemListProject.Name = "menuItemListProject";
            this.menuItemListProject.Size = new System.Drawing.Size(153, 22);
            this.menuItemListProject.Text = "Projeleri Listele";
            this.menuItemListProject.Click += new System.EventHandler(this.menuItemListProject_Click);
            // 
            // menuItemReqMan
            // 
            this.menuItemReqMan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemEditRequest,
            this.menuItemListRequests});
            this.menuItemReqMan.Name = "menuItemReqMan";
            this.menuItemReqMan.Size = new System.Drawing.Size(140, 20);
            this.menuItemReqMan.Text = "Müşteri Talep Yönetimi";
            // 
            // menuItemEditRequest
            // 
            this.menuItemEditRequest.Name = "menuItemEditRequest";
            this.menuItemEditRequest.Size = new System.Drawing.Size(154, 22);
            this.menuItemEditRequest.Text = "Talep Oluştur";
            this.menuItemEditRequest.Click += new System.EventHandler(this.menuItemEditRequest_Click);
            // 
            // menuItemListRequests
            // 
            this.menuItemListRequests.Name = "menuItemListRequests";
            this.menuItemListRequests.Size = new System.Drawing.Size(154, 22);
            this.menuItemListRequests.Text = "Talepleri Listele";
            this.menuItemListRequests.Click += new System.EventHandler(this.menuItemListRequests_Click);
            // 
            // menuItemTaskMan
            // 
            this.menuItemTaskMan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemEditTask,
            this.menuItemListTasks});
            this.menuItemTaskMan.Name = "menuItemTaskMan";
            this.menuItemTaskMan.Size = new System.Drawing.Size(108, 20);
            this.menuItemTaskMan.Text = "Birim İş Yönetimi";
            // 
            // menuItemEditTask
            // 
            this.menuItemEditTask.Name = "menuItemEditTask";
            this.menuItemEditTask.Size = new System.Drawing.Size(165, 22);
            this.menuItemEditTask.Text = "Yeni İş Oluştur";
            this.menuItemEditTask.Click += new System.EventHandler(this.menuItemEditTask_Click);
            // 
            // menuItemListTasks
            // 
            this.menuItemListTasks.Name = "menuItemListTasks";
            this.menuItemListTasks.Size = new System.Drawing.Size(165, 22);
            this.menuItemListTasks.Text = "Birim İşleri Listele";
            this.menuItemListTasks.Click += new System.EventHandler(this.menuItemListTasks_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 676);
            this.Controls.Add(this.mainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mainMenu;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MASTER Project Management";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem menuItemEmpMan;
        private System.Windows.Forms.ToolStripMenuItem menuItemEditEmp;
        private System.Windows.Forms.ToolStripMenuItem menuItemListEmp;
        private System.Windows.Forms.ToolStripMenuItem menuItemCusMan;
        private System.Windows.Forms.ToolStripMenuItem menuItemEditCus;
        private System.Windows.Forms.ToolStripMenuItem menuItemListCus;
        private System.Windows.Forms.ToolStripMenuItem menuItemProjMan;
        private System.Windows.Forms.ToolStripMenuItem menuItemEditProject;
        private System.Windows.Forms.ToolStripMenuItem menuItemListProject;
        private System.Windows.Forms.ToolStripMenuItem menuItemReqMan;
        private System.Windows.Forms.ToolStripMenuItem menuItemEditRequest;
        private System.Windows.Forms.ToolStripMenuItem menuItemListRequests;
        private System.Windows.Forms.ToolStripMenuItem menuItemTaskMan;
        private System.Windows.Forms.ToolStripMenuItem menuItemEditTask;
        private System.Windows.Forms.ToolStripMenuItem menuItemListTasks;
    }
}

