using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManagement.CRUD_Forms;
using TaskManagement.Entitites;

namespace TaskManagement
{
    public partial class Form1 : Form
    {
        public Employee _user;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mainMenu.Hide();

            LoginForm loginForm = new LoginForm();
            loginForm.Text = "Giriş";
            loginForm.MdiParent = this;
            loginForm.FormClosing += loginForm_FormClosing;
            loginForm.Show();
        }

        void loginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            LoginForm loginForm = (LoginForm)sender;

            if (loginForm.Employee != null)
            {
                this._user = loginForm.Employee;

                AuthenticateUser(_user);

                mainMenu.Show();
            }
            else if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
            }
        }

        void AuthenticateUser(Employee user)
        {
            switch (user.Title)
            {
                case Title.Developer:
                case Title.TestSpecialist:
                case Title.DBA:
                    // User Task Listing
                    // Create/Update User Task(self)
                    // Project Listing
                    menuItemReqMan.Visible = false;
                    menuItemEditProject.Visible = false;
                    menuItemCusMan.Visible = false;
                    menuItemEmpMan.Visible = false;
                    break;
                case Title.BusinessAnalyst:
                    // User Task Listing
                    // Create/Update User Task(self)
                    // Project Listing------------
                    // Customer Listing------------
                    // Create/Update Customer------
                    // Request Listing
                    // Create/Update Request
                    // Convert Request to Task
                    menuItemEditProject.Visible = false;
                    menuItemEmpMan.Visible = false;
                    break;
                case Title.TeamLead:
                case Title.ProjectManagement:
                    //God Mode

                    // Create/Update/Delete Employee-----------
                    // Employee Listing------------------------
                    // User Task Listing
                    // Create/Update User Task(self)
                    // Project Listing-------------------------
                    // Create/Update/Delete Project------------
                    // Customer Listing------------------------
                    // Create/Update Customer------------------
                    // Request Listing
                    // Create/Update Request
                    // Convert Request to Task
                    // All Task Listing
                    // Task Listing By Project
                    // Task Listing By Employee
                    // Create/Update/Assign Task
                    break;
                default:
                    Application.Exit();
                    break;
            }
        }

        private void menuItemEditEmp_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                if(form is EmployeeCrud)
                {
                    form.BringToFront();
                    return;
                }
            }

            EmployeeCrud editForm = new EmployeeCrud();
            editForm.Text = "PERSONEL EKLE";
            editForm.MdiParent = this;
            //editForm.Owner = this;
            editForm.Show();
        }

        private void menuItemListEmp_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                if(form is EmployeeListing)
                {
                    form.BringToFront();
                    return;
                }
            }

            EmployeeListing listForm = new EmployeeListing();
            listForm.Text = "PERSONEL LİSTESİ";
            listForm.MdiParent = this;
            //listForm.Owner = this;
            listForm.Show();
        }

        private void menuItemEditCus_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                if(form is CustomerCrud)
                {
                    form.BringToFront();
                    return;
                }
            }

            CustomerCrud editForm = new CustomerCrud();
            editForm.Text = "MÜŞTERİ EKLE";
            editForm.MdiParent = this;
            //editForm.Owner = this;
            editForm.Show();
        }

        private void menuItemListCus_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                if(form is CustomerListing)
                {
                    form.BringToFront();
                    return;
                }
            }

            CustomerListing listForm = new CustomerListing();
            listForm.Text = "MÜŞTERİ LİSTESİ";
            listForm.MdiParent = this;
            //listForm.Owner = this;
            listForm.Show();
        }

        private void menuItemEditProject_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren)
            {
                if(item is ProjectCrud)
                {
                    item.BringToFront();
                    return;
                }
            }

            ProjectCrud editForm = new ProjectCrud();
            editForm.Text = "YENİ PROJE OLUŞTUR";
            editForm.MdiParent = this;
            editForm.Show();
        }

        private void menuItemListProject_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren)
            {
                if(item is ProjectListing)
                {
                    item.BringToFront();
                    return;
                }
            }

            ProjectListing listForm = new ProjectListing();
            listForm.Text = "AKTİF PROJE LİSTESİ";
            listForm.MdiParent = this;
            listForm.Show();
        }

        private void menuItemEditRequest_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                if(form is RequestCrud)
                {
                    form.BringToFront();
                    return;
                }
            }

            RequestCrud editForm = new RequestCrud();
            editForm.Text = "YENİ TALEP OLUŞTUR";
            editForm.MdiParent = this;
            editForm.Show();
        }

        private void menuItemListRequests_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                if(form is RequestListing)
                {
                    form.BringToFront();
                    return;
                }
            }

            RequestListing listForm = new RequestListing();
            listForm.Text = "AKTİF TALEP LİSTESİ";
            listForm.MdiParent = this;
            listForm.Show();
        }

        private void menuItemEditTask_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form is TaskCrud)
                {
                    form.BringToFront();
                    return;
                }
            }

            TaskCrud editForm = new TaskCrud();
            editForm.Text = "YENİ BİRİM İŞ OLUŞTUR";
            editForm.MdiParent = this;
            editForm.Show();
        }

        private void menuItemListTasks_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form is TaskListing)
                {
                    form.BringToFront();
                    return;
                }
            }

            TaskListing listForm = new TaskListing();
            listForm.Text = "AKTİF BİRİM İŞ LİSTESİ";
            listForm.MdiParent = this;
            listForm.Show();
        }
    }
}
