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
    public partial class EmployeeListing : Form
    {
        TaskManContext _db;
        int selectedEmployeeId;

        public EmployeeListing()
        {
            InitializeComponent();
        }

        private void EmployeeListing_Load(object sender, EventArgs e)
        {
            GetFullEmployees();
        }

        private void btnSearchEmployee_Click(object sender, EventArgs e)
        {
            using (_db = new TaskManContext())
            {
                string value = txtSearch.Text;

                var searchResult = (from emp in _db.Employees
                                    where (emp.FirstName + " " + emp.LastName).ToLower().Contains(value.ToLower())
                                    select new
                                    {
                                        ID = emp.Id,
                                        Ad = emp.FirstName,
                                        Soyad = emp.LastName,
                                        DoğumTarihi = emp.DateOfBirth,
                                        Unvan = emp.Title,
                                        KullanıcıAdı = emp.Username,
                                        Parola = emp.Password,
                                        Çalışmıyor = emp.NotWork
                                    }).ToList();

                dgvEmployees.DataSource = null;
                dgvEmployees.DataSource = searchResult;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == string.Empty)
            {
                GetFullEmployees();
            }
        }

        private void chkActiveEmployees_CheckedChanged(object sender, EventArgs e)
        {
            if (chkActiveEmployees.Checked)
            {
                using (_db = new TaskManContext())
                {
                    dgvEmployees.DataSource = (from emp in _db.Employees
                                               where !emp.NotWork
                                               select new
                                               {
                                                   ID = emp.Id,
                                                   Ad = emp.FirstName,
                                                   Soyad = emp.LastName,
                                                   DoğumTarihi = emp.DateOfBirth,
                                                   Unvan = emp.Title,
                                                   KullanıcıAdı = emp.Username,
                                                   Parola = emp.Password,
                                                   Çalışmıyor = emp.NotWork
                                               }).ToList();
                }
            }
            else
            {
                GetFullEmployees();
            }
        }

        private void menuItemEditEmployee_Click(object sender, EventArgs e)
        {
            selectedEmployeeId = (int)dgvEmployees.SelectedRows[0].Cells["Id"].Value;

            EmployeeCrud editForm = new EmployeeCrud(selectedEmployeeId);
            editForm.Text = "Personel Bilgi Güncelleme";
            editForm.MdiParent = this.MdiParent;
            editForm.Show();
        }

        private void menuItemEmployeeTasks_Click(object sender, EventArgs e)
        {
            selectedEmployeeId = (int)dgvEmployees.SelectedRows[0].Cells["ID"].Value;

            TaskListing requestList = new TaskListing(selectedEmployeeId);
            requestList.Text = "Personele ait İşler";
            requestList.MdiParent = this.MdiParent;
            requestList.Show();
        }

        public void GetFullEmployees()
        {
            using (_db = new TaskManContext())
            {
                dgvEmployees.DataSource = (from emp in _db.Employees
                                           select new
                                           {
                                               ID = emp.Id,
                                               Ad = emp.FirstName,
                                               Soyad = emp.LastName,
                                               DoğumTarihi = emp.DateOfBirth,
                                               Unvan = emp.Title,
                                               KullanıcıAdı = emp.Username,
                                               Parola = emp.Password,
                                               Çalışmıyor = emp.NotWork
                                           }).ToList();
            }
        }
    }
}
