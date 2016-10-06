using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManagement.Entitites;

namespace TaskManagement.CRUD_Forms
{
    public partial class ProjectCrud : Form
    {
        TaskManContext _db;
        private int _currentProjectId;
        Project project;

        public ProjectCrud()
        {
            InitializeComponent();
        }

        public ProjectCrud(int projectId)
        {
            InitializeComponent();

            _currentProjectId = projectId;
        }

        private void ProjectCrud_Load(object sender, EventArgs e)
        {
            dtpEndDate.Value = dtpStartDate.Value.AddDays(7);

            if (_currentProjectId > 0)
            {
                using (_db = new TaskManContext())
                {
                    project = _db.Projects.Find(_currentProjectId);

                    if (project != null)
                    {
                        txtProjectName.Text = project.Name;
                        txtDescription.Text = project.Description;
                        dtpStartDate.Value = project.StartDate;
                        dtpEndDate.Value = project.EndDate;
                        mskCompDate.Text = project.CompletedDate.HasValue ? project.CompletedDate.Value.ToString() : string.Empty;
                        chkIsActive.Checked = project.IsPassive;
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                DateTime compDate;
                using (_db = new TaskManContext())
                {
                    if (_currentProjectId == 0)
                    {
                        project = new Project();
                        project.Name = txtProjectName.Text;
                        project.Description = txtDescription.Text;
                        project.StartDate = dtpStartDate.Value;
                        project.EndDate = dtpEndDate.Value;
                        if (DateTime.TryParse(mskCompDate.Text, out compDate))
                            project.CompletedDate = compDate;
                        project.IsPassive = chkIsActive.Checked;
                        _db.Projects.Add(project);

                        MessageBox.Show("Proje kaydı başarıyla gerçekleştirildi!");
                    }
                    else
                    {
                        project = _db.Projects.Find(_currentProjectId);
                        project.Name = txtProjectName.Text;
                        project.Description = txtDescription.Text;
                        project.StartDate = dtpStartDate.Value;
                        project.EndDate = dtpEndDate.Value;
                        if (DateTime.TryParse(mskCompDate.Text, out compDate))
                            project.CompletedDate = compDate;
                        project.IsPassive = chkIsActive.Checked;

                        MessageBox.Show("Proje güncelleme işlemi başarıyla gerçekleştirildi!");
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

            if (!ValidateProjectNameTextBox())
                result = false;
            if (!ValidateStartDatePicker())
                result = false;
            if (!ValidateEndDatePicker())
                result = false;
            if (!result)
            {
                SystemSound sound = SystemSounds.Exclamation;
                sound.Play();
            }

            return result;
        }
        bool ValidateProjectNameTextBox()
        {
            bool result = true;

            if (string.IsNullOrWhiteSpace(txtProjectName.Text))
            {
                errorProvider1.SetError(txtProjectName, "Proje adı belirtilmelisiniz!");
                result = false;
            }
            else
            {
                errorProvider1.SetError(txtProjectName, string.Empty);
            }
            return result;
        }
        bool ValidateStartDatePicker()
        {
            bool result = true;
            if (dtpStartDate.Value < DateTime.Today)
            {
                errorProvider1.SetError(dtpStartDate, "Proje başlangıç tarihi günümüzden daha önce olarak belirlenemez!");
                result = false;
            }
            else
            {
                errorProvider1.SetError(dtpStartDate, string.Empty);
            }
            return result;
        }
        bool ValidateEndDatePicker()
        {
            bool result = true;
            if (dtpEndDate.Value < dtpStartDate.Value)
            {
                errorProvider1.SetError(dtpEndDate, "Proje bitiş tarihi başlangıç tarihinden önce olarak belirlenemez!");
                result = false;
            }
            else
            {
                errorProvider1.SetError(dtpEndDate, string.Empty);
            }
            return result;
        }

        private void txtProjectName_TextChanged(object sender, EventArgs e)
        {
            ValidateProjectNameTextBox();
        }
        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            ValidateStartDatePicker();
        }
        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            ValidateEndDatePicker();
        }
        #endregion

        void RefreshGridView()
        {
            foreach (Form form in this.MdiParent.MdiChildren)
            {
                if (form is ProjectListing)
                {
                    ((ProjectListing)form).GetFullProjects();
                }
            }
        }
    }
}
