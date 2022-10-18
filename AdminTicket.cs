using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Stadium_Management_System
{
    public partial class AdminTicket : Form
    {
        public AdminTicket()
        {
            InitializeComponent();
        }

        private void btnTsave_Click(object sender, EventArgs e)
        {
            Ticket t = new Ticket(int.Parse(txtticketid.Text), cmbtickettype.Text, txtamount.Text, txteventname.Text);
            t.insertTicket();
        }

        private void btnTupdate_Click(object sender, EventArgs e)
        {
            Ticket t = new Ticket(int.Parse(txtticketid.Text), cmbtickettype.Text, txtamount.Text, txteventname.Text);
            t.ticketid = int.Parse(txtticketid.Text);
            t.tickettype = cmbtickettype.Text;
            t.amount = txtamount.Text;
            t.eventt = txteventname.Text;
            t.updateTicket();
        }

        private void btnTdelete_Click(object sender, EventArgs e)
        {
            Ticket t = new Ticket(int.Parse(txtticketid.Text), cmbtickettype.Text, txtamount.Text, txteventname.Text);
            t.ticketid = int.Parse(txtticketid.Text);
            t.tickettype = cmbtickettype.Text;
            t.amount = txtamount.Text;
            t.eventt = txteventname.Text;
            t.deleteTicket();
        }

        private void btnTsearch_Click(object sender, EventArgs e)
        {
            Ticket t = new Ticket();
            DataTable dt = t.ticketbyType(txtseaTitype.Text);
            dgvTicket.DataSource = dt;
        }

        private void dgvTicket_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtticketid.Text = dgvTicket.CurrentRow.Cells[0].Value.ToString();
            cmbtickettype.Text = dgvTicket.CurrentRow.Cells[1].Value.ToString();
            txtamount.Text = dgvTicket.CurrentRow.Cells[2].Value.ToString();
            txteventname.Text = dgvTicket.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
