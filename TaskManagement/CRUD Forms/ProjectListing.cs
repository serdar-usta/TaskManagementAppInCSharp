using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManagement.Entitites;

namespace TaskManagement.CRUD_Forms
{
    public partial class ProjectListing : Form
    {
        TaskManContext _db;
        int selectedProjectId;
        bool _isProject = true;

        public ProjectListing()
        {
            InitializeComponent();
        }

        private void ProjectListing_Load(object sender, EventArgs e)
        {
            GetFullProjects();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (_db = new TaskManContext())
            {
                string value = txtSearch.Text;

                var filteredProjects = (from pr in _db.Projects
                                        where pr.Name.ToLower().Contains(value.ToLower())
                                        select new
                                        {
                                            ID = pr.Id,
                                            Ad = pr.Name,
                                            Açıklama = pr.Description,
                                            Başlangıç = pr.StartDate,
                                            Bitiş = pr.EndDate,
                                            Tamamlanma = pr.CompletedDate,
                                            Pasif = pr.IsPassive
                                        }).ToList();

                dgvProjects.DataSource = null;
                dgvProjects.DataSource = filteredProjects;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == string.Empty)
                GetFullProjects();
        }

        private void chkActiveProjects_CheckedChanged(object sender, EventArgs e)
        {
            GetActiveProjects();
        }

        private void menuItemEditProjects_Click(object sender, EventArgs e)
        {
            selectedProjectId = (int)dgvProjects.SelectedRows[0].Cells["ID"].Value;
            Form1 mainForm = (Form1)MdiParent;
            Employee employee = mainForm._user;

            if (employee.Title == Title.TeamLead || employee.Title == Title.ProjectManagement)
            {
                ProjectCrud editForm = new ProjectCrud(selectedProjectId);
                editForm.Text = "Proje Bilgisi Güncelleme";
                editForm.MdiParent = this.MdiParent;
                editForm.Show();
            }
            else
            {
                MessageBox.Show("Bu modüle erişiminiz bulunmamaktadır.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void menuItemProjectTasks_Click(object sender, EventArgs e)
        {
            selectedProjectId = (int)dgvProjects.SelectedRows[0].Cells["ID"].Value;
            Form1 mainForm = (Form1)MdiParent;
            Employee employee = mainForm._user;

            if (employee.Title == Title.TeamLead || employee.Title == Title.ProjectManagement)
            {
                TaskListing taskList = new TaskListing(selectedProjectId, _isProject);
                taskList.Text = "Projeyle İlgili Görevler";
                taskList.MdiParent = this.MdiParent;
                taskList.Show();
            }
            else
            {
                MessageBox.Show("Bu modüle erişiminiz bulunmamaktadır.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void GetFullProjects()
        {
            using (_db = new TaskManContext())
            {
                dgvProjects.DataSource = (from pr in _db.Projects
                                          select new
                                          {
                                              ID=pr.Id,
                                              Ad=pr.Name,
                                              Açıklama=pr.Description,
                                              Başlangıç=pr.StartDate,
                                              Bitiş=pr.EndDate,
                                              Tamamlanma=pr.CompletedDate,
                                              Pasif=pr.IsPassive
                                          }).ToList();
            }
        }

        public void GetActiveProjects()
        {
            if (chkActiveProjects.Checked)
            {
                using (_db = new TaskManContext())
                {
                    dgvProjects.DataSource = (from pr in _db.Projects
                                              where pr.IsPassive == false
                                              select new
                                              {
                                                  ID = pr.Id,
                                                  Ad = pr.Name,
                                                  Açıklama = pr.Description,
                                                  Başlangıç = pr.StartDate,
                                                  Bitiş = pr.EndDate,
                                                  Tamamlanma = pr.CompletedDate,
                                                  Pasif = pr.IsPassive
                                              }).ToList();
                }
            }
            else
            {
                GetFullProjects();
            }
        }
    }
}
