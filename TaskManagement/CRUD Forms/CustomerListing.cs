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
    public partial class CustomerListing : Form
    {
        TaskManContext _db;
        int selectedCustomerId;

        public CustomerListing()
        {
            InitializeComponent();
        }

        private void CustomerListing_Load(object sender, EventArgs e)
        {
            GetFullCustomers();
        }

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            using (_db = new TaskManContext())
            {
                string value = txtSearch.Text;

                var filteredCustomers = (from cus in _db.Customers
                                         where cus.Company.ToLower().Contains(value.ToLower())
                                         select new
                                         {
                                             ID = cus.Id,
                                             Adı = cus.FirstName,
                                             Soyadı = cus.LastName,
                                             Firma = cus.Company,
                                         }).ToList();

                dgvCustomers.DataSource = null;
                dgvCustomers.DataSource = filteredCustomers;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == string.Empty)
            {
                GetFullCustomers();
            }
        }

        private void menuItemEditCustomer_Click(object sender, EventArgs e)
        {
            Form1 mainForm = (Form1)MdiParent;
            Employee emp = mainForm._user;
            selectedCustomerId = (int)dgvCustomers.SelectedRows[0].Cells["ID"].Value;

            if (emp.Title == Title.TeamLead || emp.Title == Title.ProjectManagement || emp.Title == Title.BusinessAnalyst)
            {
                CustomerCrud editForm = new CustomerCrud(selectedCustomerId);
                editForm.Text = "Müşteri Bilgisi Güncelleme";
                editForm.MdiParent = this.MdiParent;
                editForm.Show();
            }
            else
            {
                MessageBox.Show("Bu modüle erişiminiz bulunmamaktadır.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        public void GetFullCustomers()
        {
            using (_db = new TaskManContext())
            {
                dgvCustomers.DataSource = (from cus in _db.Customers
                                           select new
                                           {
                                               ID = cus.Id,
                                               Adı = cus.FirstName,
                                               Soyadı = cus.LastName,
                                               Firma = cus.Company,
                                           }).ToList();
            }
        }
    }
}
