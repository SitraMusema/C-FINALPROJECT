using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Stadium_Management_System
{
    public partial class UserEvent : Form
    {
        public UserEvent()
        {
            InitializeComponent();
        }
        private void VisibleLabels()
        {
            lbleID.Visible = true;
            lbleName.Visible = true;
            lbleDate.Visible = true;
            lbleTime.Visible = true;
            lbleventId.Visible = true;
            lbleventName.Visible = true;
            lbleventDate.Visible = true;
            lbleventTime.Visible = true;
            btnresTic.Visible = true;

        }

        private void dgvEvent_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            VisibleLabels();
            lbleventId.Text = dgvEvent.CurrentRow.Cells[0].Value.ToString();
            lbleventName.Text = dgvEvent.CurrentRow.Cells[1].Value.ToString();
            lbleventDate.Text = dgvEvent.CurrentRow.Cells[2].Value.ToString();
            lbleventTime.Text = dgvEvent.CurrentRow.Cells[3].Value.ToString();
        }

        private void UserEvent_Load(object sender, EventArgs e)
        {
            Event r = new Event();
            DataTable dt = r.displayEvent();
            dgvEvent.DataSource = dt;
        }

        public void btnresTic_Click(object sender, EventArgs e)
        {
           //this.Hide();
            UserReservation ur = new UserReservation();
           /*UserMainMenu u = new UserMainMenu();
            u.panelDesktop.Controls.Remove(this);
            ur.TopLevel = false;
            ur.FormBorderStyle = FormBorderStyle.None;
            ur.Dock = DockStyle.Fill;
            u.panelDesktop.Controls.Add(ur);
            ur.BringToFront();*/
            ur.Show();

            
            




        }

        private void btnSearchName_Click(object sender, EventArgs e)
        {
            Event ev = new Event();
            DataTable dt = ev.displayEventByName(txtSearchname.Text);
            dgvEvent.DataSource = dt;
        }
    }
}
