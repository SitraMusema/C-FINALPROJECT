using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Stadium_Management_System
{
    public partial class AdminCustomer : Form
    {
        public AdminCustomer()
        {
            InitializeComponent();
        }

        private void AdminCustomer_Load(object sender, EventArgs e)
        {
            User u = new User();
            lblCountUser.Text = u.allUsers();
            lblCountAdminstrator.Text = u.allAdminstrator();
        }

        private void btnusevsearch_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            User u = new User();
            label3.Text = u.usersByEvent(txtEventName.Text);
        }
    }
}
