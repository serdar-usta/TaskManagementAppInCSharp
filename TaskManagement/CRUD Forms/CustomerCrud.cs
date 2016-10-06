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
    public partial class CustomerCrud : Form
    {
        TaskManContext _db;
        private int _currentCustomerId;
        Customer customer;

        public CustomerCrud()
        {
            InitializeComponent();
        }
        public CustomerCrud(int customerId)
        {
            InitializeComponent();

            _currentCustomerId = customerId;
        }
        private void CustomerCrud_Load(object sender, EventArgs e)
        {
            if (_currentCustomerId > 0)
            {
                using (_db = new TaskManContext())
                {
                    customer = _db.Customers.Find(_currentCustomerId);
                    if (customer != null)
                    {
                        txtFirstName.Text = customer.FirstName;
                        txtLastName.Text = customer.LastName;
                        txtCompanyName.Text = customer.Company;
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                using (_db = new TaskManContext())
                {
                    if (_currentCustomerId == 0)
                    {
                        customer = new Customer();
                        customer.FirstName = txtFirstName.Text;
                        customer.LastName = txtLastName.Text;
                        customer.Company = txtCompanyName.Text;
                        _db.Customers.Add(customer);

                        MessageBox.Show("Kayıt işlemi başarıyla gerçekleştirildi!");
                    }
                    else
                    {
                        customer = _db.Customers.Find(_currentCustomerId);
                        customer.FirstName = txtFirstName.Text;
                        customer.LastName = txtLastName.Text;
                        customer.Company = txtCompanyName.Text;

                        MessageBox.Show("Güncelleme işlemi başarıyla gerçekleştirildi!");
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

            if (!ValidateFirstNameTextBox())
                result = false;
            if (!ValidateLastNameTextBox())
                result = false;
            if (!ValidateCompanyNameTextBox())
                result = false;
            if (!result)
            {
                SystemSound sound = SystemSounds.Exclamation;
                sound.Play();
            }

            return result;
        }
        bool ValidateFirstNameTextBox()
        {
            bool result = true;

            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                errorProvider1.SetError(txtFirstName, "Müşteri adı boş geçilemez!");
                result = false;
            }
            else
            {
                errorProvider1.SetError(txtFirstName, string.Empty);
            }

            return result;
        }
        bool ValidateLastNameTextBox()
        {
            bool result = true;
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                errorProvider1.SetError(txtLastName, "Müşteri soyadı boş geçilemez!");
                result = false;
            }
            else
            {
                errorProvider1.SetError(txtLastName, string.Empty);
            }
            return result;
        }
        bool ValidateCompanyNameTextBox()
        {
            bool result = true;
            if (string.IsNullOrWhiteSpace(txtCompanyName.Text))
            {
                errorProvider1.SetError(txtCompanyName, "Müşteri şirket adı boş geçilemez!");
                result = false;
            }
            else
            {
                errorProvider1.SetError(txtCompanyName, string.Empty);
            }
            return result;
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            ValidateFirstNameTextBox();
        }
        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            ValidateLastNameTextBox();
        }
        private void txtCompanyName_TextChanged(object sender, EventArgs e)
        {
            ValidateCompanyNameTextBox();
        }
        #endregion

        void RefreshGridView()
        {
            foreach (Form form in this.MdiParent.MdiChildren)
            {
                if(form is CustomerListing)
                {
                    ((CustomerListing)form).GetFullCustomers();
                }
            }
        }

    }
}
