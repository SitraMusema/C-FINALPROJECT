using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Stadium_Management_System
{
    public partial class AdminstratorMainMenu : Form
    {
        public AdminstratorMainMenu()
        {
            InitializeComponent();
        }
        private Button currentbtn;

        public Color color2 = Color.LightCoral;
        public Color color1 = Color.LightPink;
        public Color color4 = Color.LightBlue;
        public Color color5 = Color.LightSeaGreen;

       


        private void ActivateButton(object senderbtn, Color color)
        {
            if (senderbtn != null)
            {
                DisableButton();
                currentbtn = (Button)senderbtn;
                //currentbtn.BackColor = color;
                currentbtn.ForeColor = color;
                currentbtn.TextAlign = ContentAlignment.MiddleCenter;
                currentbtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentbtn.ImageAlign = ContentAlignment.MiddleRight;

                panelNav1.BackColor = color;
                panelNav1.Location = new Point(0, currentbtn.Location.Y);
                panelNav1.Visible = true;
                panelNav1.BringToFront();

            }

        }
        private void DisableButton()
        {
            if (currentbtn != null)
            {
                currentbtn.BackColor = Color.Navy;
                currentbtn.ForeColor = Color.White;
                currentbtn.TextAlign = ContentAlignment.MiddleLeft;
                currentbtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentbtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void Navpostion(Button b)
        {
            panelNav1.Location = new Point(b.Location.X - panelNav1.Width, b.Location.Y);

        }
        private void btnAevent_Click(object sender, EventArgs e)
        {
            Navpostion(btnAevent);
            ActivateButton(sender, color1);
            AdminEvent a = new AdminEvent();
           a.TopLevel = false;
            a.FormBorderStyle = FormBorderStyle.None;
            a.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(a);
            a.BringToFront();
            a.Show();
            lblTitletext.Text = a.Text;
            panel3.BackColor = btnAevent.ForeColor;



        }

        private void btnAcustomer_Click(object sender, EventArgs e)
        {
            Navpostion(btnAcustomer);
            ActivateButton(sender, color2);
            AdminCustomer c = new AdminCustomer();
            c.TopLevel = false;
            c.FormBorderStyle = FormBorderStyle.None;
            c.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(c);
            c.BringToFront();
            c.Show();
            lblTitletext.Text = c.Text;
            panel3.BackColor = btnAcustomer.ForeColor;


        }


       

        private void btnHome_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, color5);
            Home h = new Home();
            h.TopLevel = false;
            h.FormBorderStyle = FormBorderStyle.None;
            h.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(h);
            h.BringToFront();
            h.Show();
            lblTitletext.Text = h.Text;
            panel3.BackColor = Color.LightSeaGreen;


        }

     

        private void AdminstratorMainMenu_Load(object sender, EventArgs e)
        {
            Home h = new Home();
            h.TopLevel = false;
            h.FormBorderStyle = FormBorderStyle.None;
            h.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(h);
            h.BringToFront();
            h.Show();
        }

        private void btnAticket_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, color4);
            AdminTicket h = new AdminTicket();
            h.TopLevel = false;
            h.FormBorderStyle = FormBorderStyle.None;
            h.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(h);
            h.BringToFront();
            h.Show();
            lblTitletext.Text = btnAticket.Text;
            panel3.BackColor = Color.LightBlue;
        }
    }
}
