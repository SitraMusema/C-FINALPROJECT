using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Stadium_Management_System
{
    public partial class UserReservation : Form
    {
        public UserReservation()
        {
            InitializeComponent();
        }
        public UserReservation(string text)
        {
            txtrname.Text = text;
        }


        private void UserReservation_Load(object sender, EventArgs e)
        {
            Ticket t = new Ticket();
            DataTable dt2 = t.displayTicket();
            dgvTicket.DataSource = dt2;
            Seat s = new Seat();
            DataTable dt3 = s.displaySeat();
            dgvSeat.DataSource = dt3;

        }
      

        private void dgvReservation_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtResid.Text= dgvReservation.CurrentRow.Cells[0].Value.ToString();
            txtResDate.Text = dgvReservation.CurrentRow.Cells[1].Value.ToString();
            txtResTime.Text = dgvReservation.CurrentRow.Cells[2].Value.ToString();
             txtUser.Text = dgvReservation.CurrentRow.Cells[4].Value.ToString();
            txtTickid.Text = dgvReservation.CurrentRow.Cells[5].Value.ToString();
            txtAmount.Text = dgvReservation.CurrentRow.Cells[6].Value.ToString();
            cmbticket.Text = dgvReservation.CurrentRow.Cells[7].Value.ToString();
             txtEvename.Text = dgvReservation.CurrentRow.Cells[8].Value.ToString();
            txtSeatno.Text = dgvReservation.CurrentRow.Cells[9].Value.ToString();
            cmbSeattype.Text = dgvReservation.CurrentRow.Cells[10].Value.ToString();
        }

        private void btnrsearch_Click(object sender, EventArgs e)
        {
           /* LoginForm lg = new LoginForm();
            string name = lg.name;
            //UserReservation form = new UserReservation(txtUserName.Text);
            MessageBox.Show(name);
            if(name ==txtrname.Text)
            { */
                Reservation r = new Reservation();
               DataTable dt1 = r.displayUserreservation(txtrname.Text);
               dgvReservation.DataSource = dt1;
           /* }
            else
            {
                MessageBox.Show(" Enter the Name you logged in with");
            }*/
           
            

        }

        private void dgvTicket_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtTickid.Text = dgvTicket.CurrentRow.Cells[0].Value.ToString();
            txtAmount.Text = dgvTicket.CurrentRow.Cells[2].Value.ToString();
            cmbticket.Text = dgvTicket.CurrentRow.Cells[1].Value.ToString();
            txtEvename.Text = dgvTicket.CurrentRow.Cells[3].Value.ToString();
        }

        private void dgvSeat_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            txtSeatno.Text = dgvSeat.CurrentRow.Cells[0].Value.ToString();
            cmbSeattype.Text = dgvSeat.CurrentRow.Cells[1].Value.ToString();
        }

       

        private void btnRsave_Click(object sender, EventArgs e)
        {
            Reservation r = new Reservation(int.Parse(txtResid.Text), txtResDate.Text, txtResTime.Text, txtUser.Text, int.Parse(txtTickid.Text));
         
            Seat s = new Seat(int.Parse(txtSeatno.Text),cmbSeattype.Text,int.Parse(txtResid.Text));
           
            r.insertReservation();

            //s.insertSeat();

        }

        private void btnRupdate_Click(object sender, EventArgs e)
        {
            Reservation r = new Reservation(int.Parse(txtResid.Text), txtResDate.Text, txtResTime.Text, txtUser.Text, int.Parse(txtTickid.Text));
            r.resid = int.Parse(txtResid.Text);
            r.resDate = txtResDate.Text;
            r.resTime = txtResTime.Text;
            r.user = txtUser.Text;
            r.ticket = int.Parse(txtTickid.Text);
            Seat s = new Seat(int.Parse(txtSeatno.Text), cmbSeattype.Text, int.Parse(txtResid.Text));
            s.seatNumber = int.Parse(txtSeatno.Text);
            s.seatType = cmbSeattype.Text;
            s.reservation = int.Parse(txtResid.Text);

            r.updateReservation();
           // s.updateReservation();
        }

       
    }
}
