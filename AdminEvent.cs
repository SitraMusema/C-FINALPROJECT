using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Stadium_Management_System
{
    public partial class AdminEvent : Form
    {
        public AdminEvent()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAsave_Click(object sender, EventArgs e)
        {
            Event ev = new Event(int.Parse(txtEid.Text), txtEname.Text, txtEdate.Text, txtEtime.Text);
            ev.insertEvent();
        }

        private void btbAupdate_Click(object sender, EventArgs e)
        {
            Event ev = new Event(int.Parse(txtEid.Text), txtEname.Text, txtEdate.Text, txtEtime.Text);
            ev.id = int.Parse(txtEid.Text);
            ev.name = txtEname.Text;
            ev.date = txtEdate.Text;
            ev.time = txtEtime.Text;
            ev.updateEvent();

        }

        private void btnAdelete_Click(object sender, EventArgs e)
        {
            Event ev = new Event(int.Parse(txtEid.Text), txtEname.Text, txtEdate.Text, txtEtime.Text);
            ev.id = int.Parse(txtEid.Text);
            ev.name = txtEname.Text;
            ev.date = txtEdate.Text;
            ev.time = txtEtime.Text;
            ev.deleteEvent();
        }

        private void btnEsearch_Click(object sender, EventArgs e)
        {
            Event ev = new Event();
            DataTable dt = ev.displayEventByName(txtSeaname.Text);
            dgvAevent.DataSource = dt;
        }

        private void dgvAevent_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtEid.Text = dgvAevent.CurrentRow.Cells[0].Value.ToString();
            txtEname.Text = dgvAevent.CurrentRow.Cells[1].Value.ToString();
            txtEdate.Text = dgvAevent.CurrentRow.Cells[2].Value.ToString();
            txtEtime.Text = dgvAevent.CurrentRow.Cells[3].Value.ToString();
        }

        private void AdminEvent_Load(object sender, EventArgs e)
        {
            
        }
    }
}
