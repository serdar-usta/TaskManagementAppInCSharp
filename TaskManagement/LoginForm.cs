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

namespace TaskManagement
{
    public partial class LoginForm : Form
    {
        TaskManContext _db;

        public Employee Employee;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            using (_db = new TaskManContext())
            {
                Employee employee;

                #region Sorgu Çeşitleri
                /* SQL'DE KULLANILACAK SORGU DA BU...
                 * select * from Employee
                 * where Username = 'password' and Password = 'password'
                 */

                /*
                employee = (from emp in Db.Employees
                            where emp.Username == username && emp.Password == password
                            select emp).SingleOrDefault();

                employee = Db.Employees
                    .Where(emp => emp.Username == username)
                    .Where(emp => emp.Password == password)
                    .SingleOrDefault();

                employee = Db.Employees
                    .Where(emp => emp.Username == username && emp.Password == password)
                    .SingleOrDefault();

                employee = Db.Employees
                    .FirstOrDefault(emp => emp.Username == username && emp.Password == password);
                 */

                /*
                 * Anonim Tip Select sorgusu
                var worker = Db.Employees
                    .Where(emp => emp.Username == username && emp.Password == password)
                    .Select(emp => new { Name = emp.FirstName, Surname = emp.LastName })
                    .FirstOrDefault();
                */

                #endregion

                employee = _db.Employees
                    .SingleOrDefault(emp => emp.Username == username && emp.Password == password && emp.NotWork == false);

                if(employee != null)
                {
                    this.Employee = employee;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre bilgileri yanlış. Lütfen tekrar deneyin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnShow_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
        }

        private void btnShow_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }
    }
}
