using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Stadium_Management_System
{
    public partial class UserMainMenu : Form
    {
        public UserMainMenu()
        {
            InitializeComponent();
        }

        
        private Button currentbtn;


        public Color color2 = Color.LightCoral;
        public Color color1 = Color.LightPink;
        public Color color4 = Color.LightBlue;
        public Color color5 = Color.LightSeaGreen;
        public Color color3 = Color.PeachPuff;




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

                panelNav.BackColor = color;
                panelNav.Location = new Point(0, currentbtn.Location.Y);
                panelNav.Visible = true;
                panelNav.BringToFront();

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
           panelNav.Location = new Point(b.Location.X - panelNav.Width, b.Location.Y);

        }
       private void btnUevent_Click(object sender, EventArgs e)
        {
            Navpostion(btnUevent);
            ActivateButton(sender, color1);
            UserEvent a = new UserEvent();
            a.TopLevel = false;
            a.FormBorderStyle = FormBorderStyle.None;
            a.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(a);
            a.BringToFront();
            a.Show();
            lblTitletext.Text = btnUevent.Text;
            panel3.BackColor = btnUevent.ForeColor;
       


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

        private void btnAboutus_Click(object sender, EventArgs e)
        {
            Navpostion(btnUevent);
            ActivateButton(sender, color5);
            AboutusForm u = new AboutusForm();
            u.TopLevel = false;
            u.FormBorderStyle = FormBorderStyle.None;
            u.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(u);
            u.BringToFront();
            u.Show();
            lblTitletext.Text = btnAboutus.Text;
            panel3.BackColor = btnAboutus.ForeColor;

        }

        public void btnUreservation_Click(object sender, EventArgs e)
        {
            Navpostion(btnUreservation);
            ActivateButton(sender, color2);
            UserReservation re = new UserReservation();
            re.TopLevel = false;
            re.FormBorderStyle = FormBorderStyle.None;
            re.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(re);
            re.BringToFront();
            re.Show();
            lblTitletext.Text = btnUreservation.Text;
            panel3.BackColor = btnUreservation.ForeColor;


        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UserMainMenu_Load(object sender, EventArgs e)
        {
            Home h = new Home();
            h.TopLevel = false;
            h.FormBorderStyle = FormBorderStyle.None;
            h.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(h);
            h.BringToFront();
            h.Show();
        }
    }
}
