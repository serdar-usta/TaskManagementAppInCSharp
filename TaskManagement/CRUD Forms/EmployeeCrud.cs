using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManagement.Entitites;

namespace TaskManagement.CRUD_Forms
{
    public partial class EmployeeCrud : Form
    {
        TaskManContext _db;
        private int _currentEmployeeId;
        Employee employee;

        public EmployeeCrud()
        {
            InitializeComponent();
        }

        public EmployeeCrud(int employeeId)
        {
            InitializeComponent();

            _currentEmployeeId = employeeId;
        }

        private void EmployeeCrud_Load(object sender, EventArgs e)
        {
            FillTitleComboBox();

            if (_currentEmployeeId > 0)
            {
                using (_db = new TaskManContext())
                {
                    employee = _db.Employees.Find(_currentEmployeeId);

                    if (employee != null)
                    {
                        txtFirstName.Text = employee.FirstName;
                        txtLastName.Text = employee.LastName;
                        mskBirthDate.Text = employee.DateOfBirth.HasValue ? employee.DateOfBirth.Value.ToString() : string.Empty;
                        cmbTitle.SelectedValue = (byte)employee.Title;
                        txtUsername.Text = employee.Username;
                        txtPassword.Text = employee.Password;
                        chkWorkStatus.Checked = employee.NotWork;
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                DateTime birth;

                using (_db = new TaskManContext())
                {
                    if (_currentEmployeeId == 0)
                    {
                        employee = new Employee();
                        employee.FirstName = txtFirstName.Text;
                        employee.LastName = txtLastName.Text;
                        if (DateTime.TryParse(mskBirthDate.Text, out birth))
                        {
                            employee.DateOfBirth = birth;
                        }
                        employee.Title = (Title)cmbTitle.SelectedValue;
                        employee.Username = txtUsername.Text;
                        employee.Password = txtPassword.Text;
                        employee.NotWork = chkWorkStatus.Checked;
                        _db.Employees.Add(employee);

                        MessageBox.Show("Kayıt işlemi başarılı!");
                    }
                    else
                    {
                        employee = _db.Employees.Find(_currentEmployeeId);
                        employee.FirstName = txtFirstName.Text;
                        employee.LastName = txtLastName.Text;
                        if (DateTime.TryParse(mskBirthDate.Text, out birth))
                        {
                            employee.DateOfBirth = birth;
                        }
                        employee.Title = (Title)cmbTitle.SelectedValue;
                        employee.Username = txtUsername.Text;
                        employee.Password = txtPassword.Text;
                        employee.NotWork = chkWorkStatus.Checked;

                        MessageBox.Show("Güncelleme işlemi başarılı!");
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
            if (!ValidateTitleComboBox())
                result = false;
            if (!ValidateUsernameTextBox())
                result = false;
            if (!ValidatePasswordTextBox())
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
                errorProvider1.SetError(txtFirstName, "İsim alanı boş geçilemez!");
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
                errorProvider1.SetError(txtLastName, "Soyisim alanı boş geçilemez!");
                result = false;
            }
            else
            {
                errorProvider1.SetError(txtLastName, string.Empty);
            }
            return result;
        }
        bool ValidateTitleComboBox()
        {
            bool result = true;
            if (cmbTitle.SelectedIndex < 0)
            {
                errorProvider1.SetError(cmbTitle, "Lütfen çalışanın pozisyonunu belirtin");
                result = false;
            }
            else
            {
                errorProvider1.SetError(cmbTitle, string.Empty);
            }
            return result;
        }
        bool ValidateUsernameTextBox()
        {
            bool result = true;
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                errorProvider1.SetError(txtUsername, "Kullanıcı adı alanı boş geçilemez!");
                result = false;
            }
            else
            {
                errorProvider1.SetError(txtUsername, string.Empty);
            }
            return result;
        }
        bool ValidatePasswordTextBox()
        {
            bool result = true;
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                errorProvider1.SetError(txtPassword, "Kullanıcı adı alanı boş geçilemez!");
                result = false;
            }
            else
            {
                errorProvider1.SetError(txtPassword, string.Empty);
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
        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            ValidateUsernameTextBox();
        }
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            ValidatePasswordTextBox();
        }
        private void cmbTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidateTitleComboBox();
        }
        #endregion

        #region FillComboBox
        void FillTitleComboBox()
        {
            var list = Enum.GetValues(typeof(Title)).Cast<Title>().Select(x => new ComboEnumValue() { ValueMember = (byte)x, DisplayMember = Helper.DisplayName(x) }).ToList();
            list.RemoveAt(0);
            cmbTitle.DataSource = null;
            cmbTitle.DisplayMember = "DisplayMember";
            cmbTitle.ValueMember = "ValueMember";
            cmbTitle.DataSource = list;
        }
        #endregion

        #region ShowAndHidePassword
        private void btnShowPassword_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
        }
        private void btnShowPassword_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }
        #endregion        

        void RefreshGridView()
        {
            foreach (Form form in this.MdiParent.MdiChildren)
            {
                if (form is EmployeeListing)
                {
                    ((EmployeeListing)form).GetFullEmployees();
                }
            }
        }

    }

    struct ComboEnumValue
    {
        public byte ValueMember { get; set; }
        public string DisplayMember { get; set; }
    }
}
