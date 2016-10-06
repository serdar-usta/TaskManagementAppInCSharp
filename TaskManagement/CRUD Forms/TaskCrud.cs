using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManagement.Entitites;

namespace TaskManagement.CRUD_Forms
{
    public partial class TaskCrud : Form
    {
        TaskManContext _db;
        private int _currentTaskId;
        TaskManagement.Entitites.Task task;

        public TaskCrud()
        {
            InitializeComponent();
        }

        public TaskCrud(int selectedTaskId)
        {
            InitializeComponent();

            _currentTaskId = selectedTaskId;
        }

        private void TaskCrud_Load(object sender, EventArgs e)
        {
            FillRequestComboBox();
            cmbRequests.SelectedIndex = -1;
            FillProjectComboBox();
            cmbProject.SelectedIndex = -1;
            FillEmployeeComboBox();
            cmbAssignedTo.SelectedIndex = -1;

            if (_currentTaskId > 0)
            {
                using (_db = new TaskManContext())
                {
                    task = _db.Tasks.Find(_currentTaskId);

                    if (task != null)
                    {
                        txtTitle.Text = task.Title;
                        txtDescription.Text = task.Text;
                        cmbRequests.SelectedValue = task.RequestId;
                        dtpCreationDate.Value = task.CreationDate;
                        mskAssignmentDate.Text = task.AssignmentDate.HasValue ? task.AssignmentDate.Value.ToString() : string.Empty;
                        mskEstimatedDuration.Text = task.EstimatedDuration.HasValue ? task.EstimatedDuration.Value.ToString() : string.Empty;
                        mskDeadline.Text = task.Deadline.HasValue ? task.Deadline.Value.ToString() : string.Empty;
                        mskCompletedDate.Text = task.CompletedDate.HasValue ? task.CompletedDate.Value.ToString() : string.Empty;
                        cmbProject.SelectedValue = task.ProjectId;
                        cmbAssignedTo.SelectedValue = task.AssignedTo;
                        chkIsPassive.Checked = task.IsPassive;
                    }
                }
            }
            else
            {
                txtDescription.Text = string.Empty;
                txtTitle.Text = string.Empty;
            }
        }

        #region FillComboBoxes
        void FillRequestComboBox()
        {
            using (_db = new TaskManContext())
            {
                cmbRequests.DataSource = null;
                cmbRequests.DisplayMember = "Title";
                cmbRequests.ValueMember = "Id";
                cmbRequests.DataSource = _db.Requests.ToList();
            }
        }
        void FillProjectComboBox()
        {
            using (_db = new TaskManContext())
            {
                cmbProject.DataSource = null;
                cmbProject.DisplayMember = "Name";
                cmbProject.ValueMember = "Id";
                cmbProject.DataSource = _db.Projects.ToList();
            }
        }
        void FillEmployeeComboBox()
        {
            using (_db = new TaskManContext())
            {
                cmbAssignedTo.DataSource = null;
                cmbAssignedTo.DisplayMember = "FirstName";
                cmbAssignedTo.ValueMember = "Id";
                cmbAssignedTo.DataSource = _db.Employees.ToList();
            }
        }

        #endregion

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                DateTime assignDate;
                float duration;
                DateTime deadline;
                DateTime compDate;

                using (_db = new TaskManContext())
                {
                    if (_currentTaskId == 0)
                    {
                        task = new Entitites.Task();
                        task.Title = txtTitle.Text;
                        task.Text = txtDescription.Text;
                        if (cmbRequests.SelectedIndex > -1)
                            task.RequestId = (int)cmbRequests.SelectedValue;
                        task.CreationDate = dtpCreationDate.Value;
                        if (DateTime.TryParse(mskAssignmentDate.Text, out assignDate))
                            task.AssignmentDate = assignDate;
                        if (float.TryParse(mskEstimatedDuration.Text, out duration))
                            task.EstimatedDuration = duration;
                        if (DateTime.TryParse(mskDeadline.Text, out deadline))
                            task.Deadline = deadline;
                        if (DateTime.TryParse(mskCompletedDate.Text, out compDate))
                            task.CompletedDate = compDate;
                        if (cmbProject.SelectedIndex > -1)
                            task.ProjectId = (int)cmbProject.SelectedValue;
                        if (cmbAssignedTo.SelectedIndex > -1)
                            task.AssignedTo = (int)cmbAssignedTo.SelectedValue;
                        task.IsPassive = chkIsPassive.Checked;

                        _db.Tasks.Add(task);

                        MessageBox.Show("Birim iş kaydı başarıyla gerçekleştirildi!");
                    }
                    else
                    {
                        task = _db.Tasks.Find(_currentTaskId);
                        task.Title = txtTitle.Text;
                        task.Text = txtDescription.Text;
                        if (cmbRequests.SelectedIndex > -1)
                            task.RequestId = (int)cmbRequests.SelectedValue;
                        task.CreationDate = dtpCreationDate.Value;
                        if (DateTime.TryParse(mskAssignmentDate.Text, out assignDate))
                            task.AssignmentDate = assignDate;
                        if (float.TryParse(mskEstimatedDuration.Text, out duration))
                            task.EstimatedDuration = duration;
                        if (DateTime.TryParse(mskDeadline.Text, out deadline))
                            task.Deadline = deadline;
                        if (DateTime.TryParse(mskCompletedDate.Text, out compDate))
                            task.CompletedDate = compDate;
                        if (cmbProject.SelectedIndex > -1)
                            task.ProjectId = (int)cmbProject.SelectedValue;
                        if (cmbAssignedTo.SelectedIndex > -1)
                            task.AssignedTo = (int)cmbAssignedTo.SelectedValue;
                        task.IsPassive = chkIsPassive.Checked;

                        MessageBox.Show("Birim iş güncelleme işlemi başarıyla gerçekleştirildi!");
                    }
                    _db.SaveChanges();
                    RefreshGridView();
                    this.Close();
                }
            }
        }

        #region FormValidation
        bool ValidateForm()
        {
            bool result = true;
            if (!ValidateTitleTextBox())
                result = false;
            if (!ValidateDescTextBox())
                result = false;
            if (!ValidateCreationDatePicker())
                result = false;
            if (!result)
            {
                SystemSound sound = SystemSounds.Exclamation;
                sound.Play();
            }
            return result;
        }
        bool ValidateTitleTextBox()
        {
            bool result = true;
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                errorProvider1.SetError(txtTitle, "Bir iş başlığı belirtilmelisiniz!");
                result = false;
            }
            else
            {
                errorProvider1.SetError(txtTitle, string.Empty);
            }
            return result;
        }
        bool ValidateDescTextBox()
        {
            bool result = true;
            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                errorProvider1.SetError(txtDescription, "İş ile ilgili açıklama belirtilmelisiniz!");
                result = false;
            }
            else
            {
                errorProvider1.SetError(txtDescription, string.Empty);
            }
            return result;
        }
        bool ValidateCreationDatePicker()
        {
            bool result = true;
            if (dtpCreationDate.Value < DateTime.Today)
            {
                errorProvider1.SetError(dtpCreationDate, "İşin oluşturulma tarihi günümüzden daha öncesi olarak belirlenemez!");
                result = false;
            }
            else
            {
                errorProvider1.SetError(dtpCreationDate, string.Empty);
            }
            return result;
        }
        #endregion

        void RefreshGridView()
        {
            foreach (Form form in this.MdiParent.MdiChildren)
            {
                if (form is TaskListing)
                {
                    ((TaskListing)form).GetFullTasks();
                }
            }
        }

        private void btnClearReq_Click(object sender, EventArgs e)
        {
            cmbRequests.SelectedIndex = -1;
            txtDescription.Text = string.Empty;
            txtTitle.Text = string.Empty;
            dtpCreationDate.Value = DateTime.Today;
            mskAssignmentDate.Text = string.Empty;
            mskEstimatedDuration.Text = string.Empty;
            mskDeadline.Text = string.Empty;
            mskCompletedDate.Text = string.Empty;
            cmbProject.SelectedIndex = -1;
            cmbAssignedTo.SelectedIndex = -1;
        }

        private void btnClearProj_Click(object sender, EventArgs e)
        {
            cmbProject.SelectedIndex = -1;
        }

        private void btnClearEmp_Click(object sender, EventArgs e)
        {
            cmbAssignedTo.SelectedIndex = -1;
        }

        private void cmbRequests_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (_db = new TaskManContext())
            {
                if (cmbRequests.SelectedIndex > -1)
                {
                    Request request = (Request)cmbRequests.SelectedItem;
                    txtTitle.Text = request.Text;
                    txtDescription.Text = request.Text;
                    cmbProject.SelectedValue = request.ProjectId;
                    cmbAssignedTo.SelectedValue = request.Owner;
                }
            }
        }
    }
}
