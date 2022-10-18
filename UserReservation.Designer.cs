
namespace Stadium_Management_System
{
    partial class UserReservation
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtResDate = new System.Windows.Forms.TextBox();
            this.txtResTime = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.dgvReservation = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.txtrname = new System.Windows.Forms.TextBox();
            this.btnrsearch = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSeatno = new System.Windows.Forms.TextBox();
            this.dgvTicket = new System.Windows.Forms.DataGridView();
            this.dgvSeat = new System.Windows.Forms.DataGridView();
            this.cmbticket = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbSeattype = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEvename = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtResid = new System.Windows.Forms.TextBox();
            this.btnRsave = new System.Windows.Forms.Button();
            this.btnRupdate = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTickid = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTicket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeat)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 406);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reservation Date :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 447);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Reservation Time :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(121, 485);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "FullName :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(496, 447);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Payment amount :";
            // 
            // txtResDate
            // 
            this.txtResDate.Location = new System.Drawing.Point(273, 406);
            this.txtResDate.Name = "txtResDate";
            this.txtResDate.Size = new System.Drawing.Size(151, 27);
            this.txtResDate.TabIndex = 6;
            // 
            // txtResTime
            // 
            this.txtResTime.Location = new System.Drawing.Point(273, 447);
            this.txtResTime.Name = "txtResTime";
            this.txtResTime.Size = new System.Drawing.Size(151, 27);
            this.txtResTime.TabIndex = 7;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(273, 485);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(151, 27);
            this.txtUser.TabIndex = 9;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(631, 440);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(183, 27);
            this.txtAmount.TabIndex = 10;
            // 
            // dgvReservation
            // 
            this.dgvReservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservation.Location = new System.Drawing.Point(12, 58);
            this.dgvReservation.Name = "dgvReservation";
            this.dgvReservation.RowHeadersWidth = 51;
            this.dgvReservation.RowTemplate.Height = 29;
            this.dgvReservation.Size = new System.Drawing.Size(581, 250);
            this.dgvReservation.TabIndex = 11;
            this.dgvReservation.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvReservation_RowHeaderMouseDoubleClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Enter name :";
            // 
            // txtrname
            // 
            this.txtrname.Location = new System.Drawing.Point(121, 12);
            this.txtrname.Name = "txtrname";
            this.txtrname.Size = new System.Drawing.Size(175, 27);
            this.txtrname.TabIndex = 13;
            // 
            // btnrsearch
            // 
            this.btnrsearch.Location = new System.Drawing.Point(341, 13);
            this.btnrsearch.Name = "btnrsearch";
            this.btnrsearch.Size = new System.Drawing.Size(94, 29);
            this.btnrsearch.TabIndex = 14;
            this.btnrsearch.Text = "Search";
            this.btnrsearch.UseVisualStyleBackColor = true;
            this.btnrsearch.Click += new System.EventHandler(this.btnrsearch_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(497, 403);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Ticket type :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(849, 364);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Seat Number :";
            // 
            // txtSeatno
            // 
            this.txtSeatno.Location = new System.Drawing.Point(1011, 361);
            this.txtSeatno.Name = "txtSeatno";
            this.txtSeatno.Size = new System.Drawing.Size(151, 27);
            this.txtSeatno.TabIndex = 18;
            // 
            // dgvTicket
            // 
            this.dgvTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTicket.Location = new System.Drawing.Point(631, 58);
            this.dgvTicket.Name = "dgvTicket";
            this.dgvTicket.RowHeadersWidth = 51;
            this.dgvTicket.RowTemplate.Height = 29;
            this.dgvTicket.Size = new System.Drawing.Size(383, 246);
            this.dgvTicket.TabIndex = 19;
            this.dgvTicket.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTicket_RowHeaderMouseDoubleClick);
            // 
            // dgvSeat
            // 
            this.dgvSeat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSeat.Location = new System.Drawing.Point(1039, 58);
            this.dgvSeat.Name = "dgvSeat";
            this.dgvSeat.RowHeadersWidth = 51;
            this.dgvSeat.RowTemplate.Height = 29;
            this.dgvSeat.Size = new System.Drawing.Size(383, 246);
            this.dgvSeat.TabIndex = 20;
            this.dgvSeat.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSeat_RowHeaderMouseDoubleClick);
            // 
            // cmbticket
            // 
            this.cmbticket.FormattingEnabled = true;
            this.cmbticket.Items.AddRange(new object[] {
            "REGULAR",
            "VIP"});
            this.cmbticket.Location = new System.Drawing.Point(631, 400);
            this.cmbticket.Name = "cmbticket";
            this.cmbticket.Size = new System.Drawing.Size(183, 28);
            this.cmbticket.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(849, 406);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Seat Type :";
            // 
            // cmbSeattype
            // 
            this.cmbSeattype.FormattingEnabled = true;
            this.cmbSeattype.Items.AddRange(new object[] {
            "REGULAR",
            "VIP"});
            this.cmbSeattype.Location = new System.Drawing.Point(1011, 403);
            this.cmbSeattype.Name = "cmbSeattype";
            this.cmbSeattype.Size = new System.Drawing.Size(151, 28);
            this.cmbSeattype.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(497, 488);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 20);
            this.label9.TabIndex = 24;
            this.label9.Text = "Event Name :";
            // 
            // txtEvename
            // 
            this.txtEvename.Location = new System.Drawing.Point(631, 485);
            this.txtEvename.Name = "txtEvename";
            this.txtEvename.Size = new System.Drawing.Size(183, 27);
            this.txtEvename.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(122, 364);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 20);
            this.label10.TabIndex = 26;
            this.label10.Text = "Reservation ID :";
            // 
            // txtResid
            // 
            this.txtResid.Location = new System.Drawing.Point(273, 361);
            this.txtResid.Name = "txtResid";
            this.txtResid.Size = new System.Drawing.Size(151, 27);
            this.txtResid.TabIndex = 27;
            // 
            // btnRsave
            // 
            this.btnRsave.BackColor = System.Drawing.Color.LightCoral;
            this.btnRsave.FlatAppearance.BorderSize = 0;
            this.btnRsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRsave.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRsave.Location = new System.Drawing.Point(341, 571);
            this.btnRsave.Name = "btnRsave";
            this.btnRsave.Size = new System.Drawing.Size(109, 36);
            this.btnRsave.TabIndex = 28;
            this.btnRsave.Text = "Save";
            this.btnRsave.UseVisualStyleBackColor = false;
            this.btnRsave.Click += new System.EventHandler(this.btnRsave_Click);
            // 
            // btnRupdate
            // 
            this.btnRupdate.BackColor = System.Drawing.Color.LightCoral;
            this.btnRupdate.FlatAppearance.BorderSize = 0;
            this.btnRupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRupdate.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRupdate.Location = new System.Drawing.Point(547, 571);
            this.btnRupdate.Name = "btnRupdate";
            this.btnRupdate.Size = new System.Drawing.Size(109, 36);
            this.btnRupdate.TabIndex = 29;
            this.btnRupdate.Text = "Update";
            this.btnRupdate.UseVisualStyleBackColor = false;
            this.btnRupdate.Click += new System.EventHandler(this.btnRupdate_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(496, 364);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 20);
            this.label11.TabIndex = 31;
            this.label11.Text = "Ticket ID :";
            // 
            // txtTickid
            // 
            this.txtTickid.Location = new System.Drawing.Point(631, 361);
            this.txtTickid.Name = "txtTickid";
            this.txtTickid.Size = new System.Drawing.Size(183, 27);
            this.txtTickid.TabIndex = 32;
            // 
            // UserReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1470, 732);
            this.Controls.Add(this.txtTickid);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnRupdate);
            this.Controls.Add(this.btnRsave);
            this.Controls.Add(this.txtResid);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtEvename);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbSeattype);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbticket);
            this.Controls.Add(this.dgvSeat);
            this.Controls.Add(this.dgvTicket);
            this.Controls.Add(this.txtSeatno);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnrsearch);
            this.Controls.Add(this.txtrname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvReservation);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtResTime);
            this.Controls.Add(this.txtResDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UserReservation";
            this.Text = "UserReservation";
            this.Load += new System.EventHandler(this.UserReservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTicket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtResDate;
        private System.Windows.Forms.TextBox txtResTime;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.DataGridView dgvReservation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtrname;
        private System.Windows.Forms.Button btnrsearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSeatno;
        private System.Windows.Forms.DataGridView dgvTicket;
        private System.Windows.Forms.DataGridView dgvSeat;
        private System.Windows.Forms.ComboBox cmbticket;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbSeattype;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEvename;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtResid;
        private System.Windows.Forms.Button btnRsave;
        private System.Windows.Forms.Button btnRupdate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTickid;
    }
}