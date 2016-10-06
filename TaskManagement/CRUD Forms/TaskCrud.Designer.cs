namespace TaskManagement.CRUD_Forms
{
    partial class TaskCrud
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskCrud));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.cmbRequests = new System.Windows.Forms.ComboBox();
            this.dtpCreationDate = new System.Windows.Forms.DateTimePicker();
            this.mskAssignmentDate = new System.Windows.Forms.MaskedTextBox();
            this.mskDeadline = new System.Windows.Forms.MaskedTextBox();
            this.mskCompletedDate = new System.Windows.Forms.MaskedTextBox();
            this.cmbProject = new System.Windows.Forms.ComboBox();
            this.cmbAssignedTo = new System.Windows.Forms.ComboBox();
            this.chkIsPassive = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.mskEstimatedDuration = new System.Windows.Forms.MaskedTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnClearReq = new System.Windows.Forms.Button();
            this.btnClearProj = new System.Windows.Forms.Button();
            this.btnClearEmp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "BAŞLIK:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "AÇIKLAMA:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "TALEP:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "OLUŞTURULMA TARİHİ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "ATANMA TARİHİ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "TAHMİNİ SÜRE:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(76, 333);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "SON TARİH:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 370);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "TAMAMLANMA TARİHİ:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(100, 407);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "PROJE:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 444);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "SORUMLU PERSONEL:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(73, 481);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "İŞ DURUMU:";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(151, 18);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(289, 20);
            this.txtTitle.TabIndex = 6;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(151, 53);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(289, 121);
            this.txtDescription.TabIndex = 7;
            // 
            // cmbRequests
            // 
            this.cmbRequests.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRequests.FormattingEnabled = true;
            this.cmbRequests.Location = new System.Drawing.Point(151, 183);
            this.cmbRequests.Name = "cmbRequests";
            this.cmbRequests.Size = new System.Drawing.Size(289, 21);
            this.cmbRequests.TabIndex = 8;
            this.cmbRequests.SelectedIndexChanged += new System.EventHandler(this.cmbRequests_SelectedIndexChanged);
            // 
            // dtpCreationDate
            // 
            this.dtpCreationDate.Location = new System.Drawing.Point(151, 219);
            this.dtpCreationDate.Name = "dtpCreationDate";
            this.dtpCreationDate.Size = new System.Drawing.Size(289, 20);
            this.dtpCreationDate.TabIndex = 9;
            // 
            // mskAssignmentDate
            // 
            this.mskAssignmentDate.Location = new System.Drawing.Point(149, 259);
            this.mskAssignmentDate.Mask = "00/00/0000";
            this.mskAssignmentDate.Name = "mskAssignmentDate";
            this.mskAssignmentDate.Size = new System.Drawing.Size(289, 20);
            this.mskAssignmentDate.TabIndex = 10;
            // 
            // mskDeadline
            // 
            this.mskDeadline.Location = new System.Drawing.Point(149, 330);
            this.mskDeadline.Mask = "00/00/0000";
            this.mskDeadline.Name = "mskDeadline";
            this.mskDeadline.Size = new System.Drawing.Size(290, 20);
            this.mskDeadline.TabIndex = 12;
            this.mskDeadline.ValidatingType = typeof(System.DateTime);
            // 
            // mskCompletedDate
            // 
            this.mskCompletedDate.Location = new System.Drawing.Point(149, 367);
            this.mskCompletedDate.Mask = "00/00/0000";
            this.mskCompletedDate.Name = "mskCompletedDate";
            this.mskCompletedDate.Size = new System.Drawing.Size(290, 20);
            this.mskCompletedDate.TabIndex = 13;
            this.mskCompletedDate.ValidatingType = typeof(System.DateTime);
            // 
            // cmbProject
            // 
            this.cmbProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProject.FormattingEnabled = true;
            this.cmbProject.Location = new System.Drawing.Point(149, 404);
            this.cmbProject.Name = "cmbProject";
            this.cmbProject.Size = new System.Drawing.Size(290, 21);
            this.cmbProject.TabIndex = 14;
            // 
            // cmbAssignedTo
            // 
            this.cmbAssignedTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAssignedTo.FormattingEnabled = true;
            this.cmbAssignedTo.Location = new System.Drawing.Point(149, 441);
            this.cmbAssignedTo.Name = "cmbAssignedTo";
            this.cmbAssignedTo.Size = new System.Drawing.Size(290, 21);
            this.cmbAssignedTo.TabIndex = 15;
            // 
            // chkIsPassive
            // 
            this.chkIsPassive.AutoSize = true;
            this.chkIsPassive.Location = new System.Drawing.Point(149, 481);
            this.chkIsPassive.Name = "chkIsPassive";
            this.chkIsPassive.Size = new System.Drawing.Size(49, 17);
            this.chkIsPassive.TabIndex = 16;
            this.chkIsPassive.Text = "Pasif";
            this.chkIsPassive.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(382, 516);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 35);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // mskEstimatedDuration
            // 
            this.mskEstimatedDuration.Location = new System.Drawing.Point(149, 296);
            this.mskEstimatedDuration.Mask = "000";
            this.mskEstimatedDuration.Name = "mskEstimatedDuration";
            this.mskEstimatedDuration.Size = new System.Drawing.Size(289, 20);
            this.mskEstimatedDuration.TabIndex = 18;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnClearReq
            // 
            this.btnClearReq.Location = new System.Drawing.Point(464, 182);
            this.btnClearReq.Name = "btnClearReq";
            this.btnClearReq.Size = new System.Drawing.Size(51, 20);
            this.btnClearReq.TabIndex = 19;
            this.btnClearReq.Text = "Temizle";
            this.btnClearReq.UseVisualStyleBackColor = true;
            this.btnClearReq.Click += new System.EventHandler(this.btnClearReq_Click);
            // 
            // btnClearProj
            // 
            this.btnClearProj.Location = new System.Drawing.Point(464, 404);
            this.btnClearProj.Name = "btnClearProj";
            this.btnClearProj.Size = new System.Drawing.Size(51, 20);
            this.btnClearProj.TabIndex = 20;
            this.btnClearProj.Text = "Temizle";
            this.btnClearProj.UseVisualStyleBackColor = true;
            this.btnClearProj.Click += new System.EventHandler(this.btnClearProj_Click);
            // 
            // btnClearEmp
            // 
            this.btnClearEmp.Location = new System.Drawing.Point(464, 441);
            this.btnClearEmp.Name = "btnClearEmp";
            this.btnClearEmp.Size = new System.Drawing.Size(51, 20);
            this.btnClearEmp.TabIndex = 21;
            this.btnClearEmp.Text = "Temizle";
            this.btnClearEmp.UseVisualStyleBackColor = true;
            this.btnClearEmp.Click += new System.EventHandler(this.btnClearEmp_Click);
            // 
            // TaskCrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 570);
            this.Controls.Add(this.btnClearEmp);
            this.Controls.Add(this.btnClearProj);
            this.Controls.Add(this.btnClearReq);
            this.Controls.Add(this.mskEstimatedDuration);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.chkIsPassive);
            this.Controls.Add(this.cmbAssignedTo);
            this.Controls.Add(this.cmbProject);
            this.Controls.Add(this.mskCompletedDate);
            this.Controls.Add(this.mskDeadline);
            this.Controls.Add(this.mskAssignmentDate);
            this.Controls.Add(this.dtpCreationDate);
            this.Controls.Add(this.cmbRequests);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TaskCrud";
            this.Text = "TaskCrud";
            this.Load += new System.EventHandler(this.TaskCrud_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.ComboBox cmbRequests;
        private System.Windows.Forms.DateTimePicker dtpCreationDate;
        private System.Windows.Forms.MaskedTextBox mskAssignmentDate;
        private System.Windows.Forms.MaskedTextBox mskDeadline;
        private System.Windows.Forms.MaskedTextBox mskCompletedDate;
        private System.Windows.Forms.ComboBox cmbProject;
        private System.Windows.Forms.ComboBox cmbAssignedTo;
        private System.Windows.Forms.CheckBox chkIsPassive;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.MaskedTextBox mskEstimatedDuration;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnClearReq;
        private System.Windows.Forms.Button btnClearEmp;
        private System.Windows.Forms.Button btnClearProj;
    }
}