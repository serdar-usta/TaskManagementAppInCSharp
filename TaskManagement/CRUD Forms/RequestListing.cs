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
    public partial class RequestListing : Form
    {
        TaskManContext _db;
        int selectedRequestId;

        public RequestListing()
        {
            InitializeComponent();
        }

        private void RequestListing_Load(object sender, EventArgs e)
        {
            GetFullRequests();
        }

        private void chkIsPassive_CheckedChanged(object sender, EventArgs e)
        {
            GetActiveRequests();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (_db = new TaskManContext())
            {
                string value = txtSearch.Text;

                var filteredRequests = (from req in _db.Requests
                                        join cus in _db.Customers on req.Owner equals cus.Id
                                        join proj in _db.Projects on req.ProjectId equals proj.Id
                                        where req.Title.ToLower().Contains(value.ToLower())
                                        select new
                                        {
                                            ID = req.Id,
                                            Başlık = req.Title,
                                            Açıklama = req.Text,
                                            Müşteri = cus.Company,
                                            Proje = proj.Name,
                                            Tarih = req.RequestDate,
                                            Tür = req.RequestType,
                                            Durum = req.IsPassive
                                        }).ToList();

                dgvRequests.DataSource = null;
                dgvRequests.DataSource = filteredRequests;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == string.Empty)
                GetFullRequests();
        }

        private void menuItemEditRequest_Click(object sender, EventArgs e)
        {
            selectedRequestId = (int)dgvRequests.SelectedRows[0].Cells["ID"].Value;
            Form1 mainForm = (Form1)MdiParent;
            Employee employee = mainForm._user;

            if (employee.Title != Title.Developer || employee.Title != Title.TestSpecialist || employee.Title != Title.DBA)
            {
                RequestCrud editForm = new RequestCrud(selectedRequestId);
                editForm.Text = "Müşteri Talep Güncelleme";
                editForm.MdiParent = this.MdiParent;
                editForm.Show();
            }
            else
            {
                MessageBox.Show("Bu modüle erişiminiz bulunmamaktadır.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void GetFullRequests()
        {
            using (_db = new TaskManContext())
            {
                dgvRequests.DataSource = (from req in _db.Requests
                                          join cus in _db.Customers on req.Owner equals cus.Id
                                          join proj in _db.Projects on req.ProjectId equals proj.Id
                                          select new
                                          {
                                              ID = req.Id,
                                              Başlık = req.Title,
                                              Açıklama = req.Text,
                                              Müşteri = cus.Company,
                                              Proje = proj.Name,
                                              Tarih = req.RequestDate,
                                              Tür = req.RequestType,
                                              Durum = req.IsPassive
                                          }).ToList();
            }
        }

        public void GetActiveRequests()
        {
            using (_db = new TaskManContext())
            {
                dgvRequests.DataSource = (from req in _db.Requests
                                          join cus in _db.Customers on req.Owner equals cus.Id
                                          join proj in _db.Projects on req.ProjectId equals proj.Id
                                          where req.IsPassive == false
                                          select new
                                          {
                                              ID = req.Id,
                                              Başlık = req.Title,
                                              Açıklama = req.Text,
                                              Müşteri = cus.Company,
                                              Proje = proj.Name,
                                              Tarih = req.RequestDate,
                                              Tür = req.RequestType,
                                              Durum = req.IsPassive
                                          }).ToList();
            }
        }
    }
}
