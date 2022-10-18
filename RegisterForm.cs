using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Stadium_Management_System
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "choose photo(*.jpg;*.png;*.jpeg;*.bmp;) | *.jpg;*.png;*.jpeg;*.bmp;";
            if (op.ShowDialog() == DialogResult.OK)
            {
                picUser.Image = Image.FromFile(op.FileName);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void txtCpwd_Leave(object sender, EventArgs e)
        {
            string pwd = txtPwd.Text;
            string cpwd = txtCpwd.Text;
            if (pwd.CompareTo(cpwd) != 0)
            {
                MessageBox.Show("doesn't match");
                txtPwd.Text = "";
                txtCpwd.Text = "";
            }
            else
            {
                MessageBox.Show("match");
            }
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            picUser.Image.Save(ms, picUser.Image.RawFormat);
            byte[] photo = ms.ToArray();
            User u = new User(txtfname.Text, txtlname.Text, txtCpwd.Text, txtemail.Text, txtUserName.Text, txtPwd.Text, photo);
            u.createUser();

            LoginForm l = new LoginForm();
            l.Show();
            this.Visible = false;
        }

        private void btnClickhere_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.Show();
            this.Visible = false;

        }
    }
}
