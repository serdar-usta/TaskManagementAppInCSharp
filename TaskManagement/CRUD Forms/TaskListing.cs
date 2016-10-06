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
    public partial class TaskListing : Form
    {
        TaskManContext _db;
        int selectedTaskId;
        int selectedProjectId;
        int selectedEmployeeId;
        Employee _employee;

        public TaskListing()
        {
            InitializeComponent();
        }

        public TaskListing(int projectId, bool isProject)
        {
            InitializeComponent();

            selectedProjectId = projectId;
        }

        public TaskListing(int employeeId)
        {
            InitializeComponent();

            selectedEmployeeId = employeeId;
        }

        private void TaskListing_Load(object sender, EventArgs e)
        {
            Form1 mainForm = (Form1)MdiParent;
            _employee = mainForm._user;


            if (selectedProjectId == 0 && selectedEmployeeId == 0)
            {
                if(_employee.Title == Title.TeamLead || _employee.Title == Title.ProjectManagement)
                {
                    GetFullTasks();
                }
                else
                {
                    GetEmployeeTasks(_employee.Id);
                }
                
            }
                
            else if (selectedProjectId > 0 && selectedEmployeeId == 0)
                GetProjectTasks(selectedProjectId);
            else if (selectedProjectId == 0 && selectedEmployeeId > 0)
                GetEmployeeTasks(selectedEmployeeId);
        }

        public void GetFullTasks()
        {
            using (_db = new TaskManContext())
            {
                dgvTasks.DataSource = (from task in _db.Tasks
                                       join req in _db.Requests on task.RequestId equals req.Id
                                       join prj in _db.Projects on task.ProjectId equals prj.Id
                                       join emp in _db.Employees on task.AssignedTo equals emp.Id
                                       select new
                                       {
                                           ID = task.Id,
                                           Başlık = task.Title,
                                           Açıklama = task.Text,
                                           Talep = req.Title,
                                           Oluşturulma = task.CreationDate,
                                           Atanma = task.AssignmentDate,
                                           Süre = task.EstimatedDuration,
                                           Son = task.Deadline,
                                           Tamamlanma = task.CompletedDate,
                                           Proje = prj.Name,
                                           Sorumlu = emp.FirstName + " " + emp.LastName,
                                           Durum = task.IsPassive
                                       }).ToList();
            }
        }

        public void GetActiveTasks()
        {
            using (_db = new TaskManContext())
            {
                dgvTasks.DataSource = (from task in _db.Tasks
                                       join req in _db.Requests on task.RequestId equals req.Id
                                       join prj in _db.Projects on task.ProjectId equals prj.Id
                                       join emp in _db.Employees on task.AssignedTo equals emp.Id
                                       where task.IsPassive == false
                                       select new
                                       {
                                           ID = task.Id,
                                           Başlık = task.Title,
                                           Açıklama = task.Text,
                                           Talep = req.Title,
                                           Oluşturulma = task.CreationDate,
                                           Atanma = task.AssignmentDate,
                                           Süre = task.EstimatedDuration,
                                           Son = task.Deadline,
                                           Tamamlanma = task.CompletedDate,
                                           Proje = prj.Name,
                                           Sorumlu = emp.FirstName + " " + emp.LastName,
                                           Durum = task.IsPassive
                                       }).ToList();
            }
        }

        public void GetProjectTasks(int projectId)
        {
            using (_db = new TaskManContext())
            {
                dgvTasks.DataSource = (from task in _db.Tasks
                                       join req in _db.Requests on task.RequestId equals req.Id
                                       join prj in _db.Projects on task.ProjectId equals prj.Id
                                       join emp in _db.Employees on task.AssignedTo equals emp.Id
                                       where task.IsPassive == false
                                       where task.ProjectId == projectId
                                       select new
                                       {
                                           ID = task.Id,
                                           Başlık = task.Title,
                                           Açıklama = task.Text,
                                           Talep = req.Title,
                                           Oluşturulma = task.CreationDate,
                                           Atanma = task.AssignmentDate,
                                           Süre = task.EstimatedDuration,
                                           Son = task.Deadline,
                                           Tamamlanma = task.CompletedDate,
                                           Proje = prj.Name,
                                           Sorumlu = emp.FirstName + " " + emp.LastName,
                                           Durum = task.IsPassive
                                       }).ToList();
            }
        }

        public void GetEmployeeTasks(int employeeId)
        {
            using (_db = new TaskManContext())
            {
                dgvTasks.DataSource = (from task in _db.Tasks
                                       join req in _db.Requests on task.RequestId equals req.Id
                                       join prj in _db.Projects on task.ProjectId equals prj.Id
                                       join emp in _db.Employees on task.AssignedTo equals emp.Id
                                       where task.IsPassive == false
                                       where task.AssignedTo == employeeId
                                       select new
                                       {
                                           ID = task.Id,
                                           Başlık = task.Title,
                                           Açıklama = task.Text,
                                           Talep = req.Title,
                                           Oluşturulma = task.CreationDate,
                                           Atanma = task.AssignmentDate,
                                           Süre = task.EstimatedDuration,
                                           Son = task.Deadline,
                                           Tamamlanma = task.CompletedDate,
                                           Proje = prj.Name,
                                           Sorumlu = emp.FirstName + " " + emp.LastName,
                                           Durum = task.IsPassive
                                       }).ToList();
            }
        }

        private void chkIsPassive_CheckedChanged(object sender, EventArgs e)
        {
            GetActiveTasks();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (_db = new TaskManContext())
            {
                string value = txtSearch.Text;

                var filteredTasks = (from task in _db.Tasks
                                     join req in _db.Requests on task.RequestId equals req.Id
                                     join prj in _db.Projects on task.ProjectId equals prj.Id
                                     join emp in _db.Employees on task.AssignedTo equals emp.Id
                                     where task.Title.ToLower().Contains(value.ToLower())
                                     select new
                                     {
                                         ID = task.Id,
                                         Başlık = task.Title,
                                         Açıklama = task.Text,
                                         Talep = req.Title,
                                         Oluşturulma = task.CreationDate,
                                         Atanma = task.AssignmentDate,
                                         Süre = task.EstimatedDuration,
                                         Son = task.Deadline,
                                         Tamamlanma = task.CompletedDate,
                                         Proje = prj.Name,
                                         Sorumlu = emp.FirstName + " " + emp.LastName,
                                         Durum = task.IsPassive
                                     }).ToList();

                dgvTasks.DataSource = null;
                dgvTasks.DataSource = filteredTasks;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == string.Empty)
            {
                if (!chkIsPassive.Checked)
                    GetFullTasks();
                else
                    GetActiveTasks();
            }
        }

        private void menuItemEditTask_Click(object sender, EventArgs e)
        {
            selectedTaskId = (int)dgvTasks.SelectedRows[0].Cells["ID"].Value;

            TaskCrud editForm = new TaskCrud(selectedTaskId);
            editForm.Text = "Birim iş Bilgisi Güncelleme";
            editForm.MdiParent = this.MdiParent;
            editForm.Show();

        }
    }
}
