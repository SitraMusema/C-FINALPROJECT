
namespace Stadium_Management_System
{
    partial class AdminstratorMainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelNav1 = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnAcustomer = new System.Windows.Forms.Button();
            this.btnAticket = new System.Windows.Forms.Button();
            this.btnAevent = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTitletext = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.panelNav1);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.btnAcustomer);
            this.panel1.Controls.Add(this.btnAticket);
            this.panel1.Controls.Add(this.btnAevent);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 670);
            this.panel1.TabIndex = 0;
            // 
            // panelNav1
            // 
            this.panelNav1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panelNav1.Location = new System.Drawing.Point(3, 133);
            this.panelNav1.Name = "panelNav1";
            this.panelNav1.Size = new System.Drawing.Size(10, 50);
            this.panelNav1.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Image = global::Stadium_Management_System.Properties.Resources.house_24;
            this.btnHome.Location = new System.Drawing.Point(12, 145);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(58, 38);
            this.btnHome.TabIndex = 5;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnAcustomer
            // 
            this.btnAcustomer.FlatAppearance.BorderSize = 0;
            this.btnAcustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcustomer.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAcustomer.ForeColor = System.Drawing.Color.White;
            this.btnAcustomer.Image = global::Stadium_Management_System.Properties.Resources.guest_24;
            this.btnAcustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAcustomer.Location = new System.Drawing.Point(12, 301);
            this.btnAcustomer.Name = "btnAcustomer";
            this.btnAcustomer.Padding = new System.Windows.Forms.Padding(10);
            this.btnAcustomer.Size = new System.Drawing.Size(190, 50);
            this.btnAcustomer.TabIndex = 4;
            this.btnAcustomer.Text = "Members";
            this.btnAcustomer.UseVisualStyleBackColor = true;
            this.btnAcustomer.Click += new System.EventHandler(this.btnAcustomer_Click);
            // 
            // btnAticket
            // 
            this.btnAticket.FlatAppearance.BorderSize = 0;
            this.btnAticket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAticket.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAticket.ForeColor = System.Drawing.Color.White;
            this.btnAticket.Image = global::Stadium_Management_System.Properties.Resources.ticket_24;
            this.btnAticket.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAticket.Location = new System.Drawing.Point(12, 245);
            this.btnAticket.Name = "btnAticket";
            this.btnAticket.Padding = new System.Windows.Forms.Padding(10);
            this.btnAticket.Size = new System.Drawing.Size(190, 50);
            this.btnAticket.TabIndex = 2;
            this.btnAticket.Text = "  Ticket";
            this.btnAticket.UseVisualStyleBackColor = true;
            this.btnAticket.Click += new System.EventHandler(this.btnAticket_Click);
            // 
            // btnAevent
            // 
            this.btnAevent.FlatAppearance.BorderSize = 0;
            this.btnAevent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAevent.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAevent.ForeColor = System.Drawing.Color.White;
            this.btnAevent.Image = global::Stadium_Management_System.Properties.Resources.calendar_3_24;
            this.btnAevent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAevent.Location = new System.Drawing.Point(12, 189);
            this.btnAevent.Name = "btnAevent";
            this.btnAevent.Padding = new System.Windows.Forms.Padding(10);
            this.btnAevent.Size = new System.Drawing.Size(190, 50);
            this.btnAevent.TabIndex = 1;
            this.btnAevent.Text = "  Event";
            this.btnAevent.UseVisualStyleBackColor = true;
            this.btnAevent.Click += new System.EventHandler(this.btnAevent_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(202, 125);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Stadium_Management_System.Properties.Resources.icons8_admin_settings_male_96;
            this.pictureBox1.Location = new System.Drawing.Point(25, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel3.Controls.Add(this.lblTitletext);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(202, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1116, 125);
            this.panel3.TabIndex = 1;
            // 
            // lblTitletext
            // 
            this.lblTitletext.AutoSize = true;
            this.lblTitletext.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitletext.ForeColor = System.Drawing.Color.White;
            this.lblTitletext.Location = new System.Drawing.Point(293, 62);
            this.lblTitletext.Name = "lblTitletext";
            this.lblTitletext.Size = new System.Drawing.Size(355, 26);
            this.lblTitletext.TabIndex = 0;
            this.lblTitletext.Text = "Stadium Management System";
            // 
            // panelDesktop
            // 
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(202, 125);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1116, 545);
            this.panelDesktop.TabIndex = 2;
            // 
            // AdminstratorMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1318, 670);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "AdminstratorMainMenu";
            this.Text = "AdminstratorMainMenu";
            this.Load += new System.EventHandler(this.AdminstratorMainMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAcustomer;
        private System.Windows.Forms.Button btnAticket;
        private System.Windows.Forms.Button btnAevent;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Label lblTitletext;
       
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panelNav1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}