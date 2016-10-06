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
    public partial class RequestCrud : Form
    {
        TaskManContext _db;
        private int _currentRequestId;
        Request request;

        public RequestCrud()
        {
            InitializeComponent();
        }

        public RequestCrud(int selectedRequestId)
        {
            InitializeComponent();

            _currentRequestId = selectedRequestId;
        }

        private void RequestCrud_Load(object sender, EventArgs e)
        {
            FillCustomerComboBox();
            cmbCustomers.SelectedIndex = -1;
            FillProjectComboBox();
            cmbProjects.SelectedIndex = -1;
            FillRequestTypeCombBox();
            cmbRequestType.SelectedIndex = -1;

            if(_currentRequestId > 0)
            {
                using (_db = new TaskManContext())
                {
                    request = _db.Requests.Find(_currentRequestId);

                    if(request != null)
                    {
                        txtTitle.Text = request.Title;
                        txtDescription.Text = request.Text;
                        cmbCustomers.SelectedValue = request.Owner;
                        cmbProjects.SelectedValue = request.ProjectId;
                        dtpRequestDate.Value = request.RequestDate;
                        cmbRequestType.SelectedItem = request.RequestType;
                        chkIsPassive.Checked = request.IsPassive;
                    }
                }
            }
        }

        #region FillComboBoxes
        void FillCustomerComboBox()
        {
            using (_db = new TaskManContext())
            {
                cmbCustomers.DataSource = null;
                cmbCustomers.DisplayMember = "Company";
                cmbCustomers.ValueMember = "Id";
                cmbCustomers.DataSource = _db.Customers.ToList();
            }
        }
        void FillProjectComboBox()
        {
            using (_db = new TaskManContext())
            {
                cmbProjects.DataSource = null;
                cmbProjects.DisplayMember = "Name";
                cmbProjects.ValueMember = "Id";
                cmbProjects.DataSource = (from pr in _db.Projects
                                          where pr.IsPassive == false
                                          select new
                                          {
                                              pr.Id,
                                              pr.Name,
                                              pr.Description,
                                              pr.StartDate,
                                              pr.EndDate,
                                              pr.CompletedDate,
                                              pr.IsPassive
                                          }).ToList();
            }
        }
        void FillRequestTypeCombBox()
        {
            cmbRequestType.DataSource = null;
            cmbRequestType.DataSource = Enum.GetValues(typeof(RequestType));
        }
        #endregion

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(ValidateForm())
            {
                using (_db = new TaskManContext())
                {
                    if(_currentRequestId == 0)
                    {
                        request = new Request();
                        request.Title = txtTitle.Text;
                        request.Text = txtDescription.Text;
                        request.Owner = (int)cmbCustomers.SelectedValue;
                        request.ProjectId = (int)cmbProjects.SelectedValue;
                        request.RequestDate = dtpRequestDate.Value;
                        request.RequestType = (RequestType)cmbRequestType.SelectedValue;
                        request.IsPassive = chkIsPassive.Checked;
                        _db.Requests.Add(request);

                        MessageBox.Show("Talep kaydı başarıyla oluşturuldu!");
                    }
                    else
                    {
                        request = _db.Requests.Find(_currentRequestId);
                        request.Title = txtTitle.Text;
                        request.Text = txtDescription.Text;
                        request.Owner = (int)cmbCustomers.SelectedValue;
                        request.ProjectId = (int)cmbProjects.SelectedValue;
                        request.RequestDate = dtpRequestDate.Value;
                        request.RequestType = (RequestType)cmbRequestType.SelectedValue;
                        request.IsPassive = chkIsPassive.Checked;

                        MessageBox.Show("Talep güncelleme işlemi başarıyla gerçekleştirildi!");
                    }
                    _db.SaveChanges();
                    RefreshGirdView();
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
            if (!ValidateDescriptionTextBox())
                result = false;
            if (!ValidateCustomerComboBox())
                result = false;
            if (!ValidateProjectComboBox())
                result = false;
            if (!ValidateRequestTypeComboBox())
                result = false;
            if(!result)
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
                errorProvider1.SetError(txtTitle, "Bir talep başlığı belirtilmelisiniz!");
                result = false;
            }
            else
            {
                errorProvider1.SetError(txtTitle, string.Empty);
            }
            return result;
        }
        bool ValidateDescriptionTextBox()
        {
            bool result = true;

            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                errorProvider1.SetError(txtDescription, "Talep ile ilgili açıklama belirtilmelisiniz!");
                result = false;
            }
            else
            {
                errorProvider1.SetError(txtDescription, string.Empty);
            }
            return result;
        }
        bool ValidateCustomerComboBox()
        {
            bool result = true;

            if(cmbCustomers.SelectedIndex < 0)
            {
                errorProvider1.SetError(cmbCustomers, "Lütfen talebi ileten müşteriyi belirtin!");
                result = false;
            }
            else
            {
                errorProvider1.SetError(cmbCustomers, string.Empty);
            }
            return result;
        }
        bool ValidateProjectComboBox()
        {
            bool result = true;

            if (cmbProjects.SelectedIndex < 0)
            {
                errorProvider1.SetError(cmbProjects, "Lütfen talebin ilgili projesini belirtin!");
                result = false;
            }
            else
            {
                errorProvider1.SetError(cmbProjects, string.Empty);
            }
            return result;
        }
        bool ValidateRequestTypeComboBox()
        {
            bool result = true;

            if (cmbRequestType.SelectedIndex < 0)
            {
                errorProvider1.SetError(cmbRequestType, "Lütfen talebin türünü belirtin!");
                result = false;
            }
            else
            {
                errorProvider1.SetError(cmbRequestType, string.Empty);
            }
            return result;
        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {
            ValidateTitleTextBox();
        }
        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            ValidateDescriptionTextBox();
        }
        #endregion

        void RefreshGirdView()
        {
            foreach (Form form in this.MdiParent.MdiChildren)
            {
                if(form is RequestListing)
                {
                    ((RequestListing)form).GetFullRequests();
                }
            }
        }
    }
}
