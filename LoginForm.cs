using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Stadium_Management_System
{
    public partial class LoginForm : Form
    {
        public string userName;
        public LoginForm()
        {
            InitializeComponent();
        }
       

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void txtUserName_Click(object sender, EventArgs e)
        {
              txtUserName.Text = txtUserName.Text;
            //txtUserName.Clear();
        }
      
        private void txtPassword_Click(object sender, EventArgs e)
        {
          /* // txtPassword.Text = String.Empty;
            txtPassword.Clear();
            txtPassword.ForeColor = Color.DimGray;*/
           
             txtPassword.PasswordChar = '*';

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm r = new RegisterForm();
            
            r.Show();
            this.Visible = false;
            
        }


        private void btnSignin_Click(object sender, EventArgs e)
        {
            
                Login lg = new Login();
                string role = lg.getRole(txtUserName.Text, txtPassword.Text);
           
                if (role.CompareTo("No Role") != 0)
                {
                        if (role=="Adminstrator")
                         {
                             AdminstratorMainMenu a = new AdminstratorMainMenu();
                             a.Show();
                             this.Visible = false;
                        }
                        else
                        {
                             UserMainMenu u = new UserMainMenu();
                             u.Show();
                             this.Visible = false;
                        }
                           
                }
                else
                {
                    MessageBox.Show("Invalid UserName and Password");
                    txtUserName.Clear();
                    txtPassword.Clear();
                    txtUserName.Focus();
                }
            }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void txtUserName_Leave(object sender, EventArgs e)
        {
        }
    }
}

