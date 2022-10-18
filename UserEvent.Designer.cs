
namespace Stadium_Management_System
{
    partial class UserEvent
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
            this.dgvEvent = new System.Windows.Forms.DataGridView();
            this.lblSeaName = new System.Windows.Forms.Label();
            this.txtSearchname = new System.Windows.Forms.TextBox();
            this.btnSearchName = new System.Windows.Forms.Button();
            this.lbleID = new System.Windows.Forms.Label();
            this.lbleName = new System.Windows.Forms.Label();
            this.lbleDate = new System.Windows.Forms.Label();
            this.lbleTime = new System.Windows.Forms.Label();
            this.lbleventId = new System.Windows.Forms.Label();
            this.lbleventName = new System.Windows.Forms.Label();
            this.lbleventDate = new System.Windows.Forms.Label();
            this.lbleventTime = new System.Windows.Forms.Label();
            this.btnresTic = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvent)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEvent
            // 
            this.dgvEvent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvent.Location = new System.Drawing.Point(12, 64);
            this.dgvEvent.Name = "dgvEvent";
            this.dgvEvent.RowHeadersWidth = 51;
            this.dgvEvent.RowTemplate.Height = 29;
            this.dgvEvent.Size = new System.Drawing.Size(750, 521);
            this.dgvEvent.TabIndex = 0;
            this.dgvEvent.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvEvent_RowHeaderMouseDoubleClick);
            // 
            // lblSeaName
            // 
            this.lblSeaName.AutoSize = true;
            this.lblSeaName.Location = new System.Drawing.Point(13, 23);
            this.lblSeaName.Name = "lblSeaName";
            this.lblSeaName.Size = new System.Drawing.Size(124, 20);
            this.lblSeaName.TabIndex = 1;
            this.lblSeaName.Text = "Search by Name: ";
            // 
            // txtSearchname
            // 
            this.txtSearchname.Location = new System.Drawing.Point(143, 16);
            this.txtSearchname.Name = "txtSearchname";
            this.txtSearchname.Size = new System.Drawing.Size(226, 27);
            this.txtSearchname.TabIndex = 2;
            // 
            // btnSearchName
            // 
            this.btnSearchName.Location = new System.Drawing.Point(430, 16);
            this.btnSearchName.Name = "btnSearchName";
            this.btnSearchName.Size = new System.Drawing.Size(94, 29);
            this.btnSearchName.TabIndex = 3;
            this.btnSearchName.Text = "Search";
            this.btnSearchName.UseVisualStyleBackColor = true;
            this.btnSearchName.Click += new System.EventHandler(this.btnSearchName_Click);
            // 
            // lbleID
            // 
            this.lbleID.AutoSize = true;
            this.lbleID.Location = new System.Drawing.Point(964, 147);
            this.lbleID.Name = "lbleID";
            this.lbleID.Size = new System.Drawing.Size(67, 20);
            this.lbleID.TabIndex = 4;
            this.lbleID.Text = "EventID :";
            this.lbleID.Visible = false;
            // 
            // lbleName
            // 
            this.lbleName.AutoSize = true;
            this.lbleName.Location = new System.Drawing.Point(964, 195);
            this.lbleName.Name = "lbleName";
            this.lbleName.Size = new System.Drawing.Size(96, 20);
            this.lbleName.TabIndex = 5;
            this.lbleName.Text = "Event Name :";
            this.lbleName.Visible = false;
            // 
            // lbleDate
            // 
            this.lbleDate.AutoSize = true;
            this.lbleDate.Location = new System.Drawing.Point(964, 248);
            this.lbleDate.Name = "lbleDate";
            this.lbleDate.Size = new System.Drawing.Size(88, 20);
            this.lbleDate.TabIndex = 6;
            this.lbleDate.Text = "Event Date :";
            this.lbleDate.Visible = false;
            // 
            // lbleTime
            // 
            this.lbleTime.AutoSize = true;
            this.lbleTime.Location = new System.Drawing.Point(964, 295);
            this.lbleTime.Name = "lbleTime";
            this.lbleTime.Size = new System.Drawing.Size(89, 20);
            this.lbleTime.TabIndex = 7;
            this.lbleTime.Text = "Event Time :";
            this.lbleTime.Visible = false;
            // 
            // lbleventId
            // 
            this.lbleventId.AutoSize = true;
            this.lbleventId.BackColor = System.Drawing.SystemColors.Control;
            this.lbleventId.ForeColor = System.Drawing.Color.Black;
            this.lbleventId.Location = new System.Drawing.Point(1100, 147);
            this.lbleventId.Name = "lbleventId";
            this.lbleventId.Size = new System.Drawing.Size(50, 20);
            this.lbleventId.TabIndex = 8;
            this.lbleventId.Text = "label1";
            this.lbleventId.Visible = false;
            // 
            // lbleventName
            // 
            this.lbleventName.AutoSize = true;
            this.lbleventName.BackColor = System.Drawing.SystemColors.Control;
            this.lbleventName.ForeColor = System.Drawing.Color.Black;
            this.lbleventName.Location = new System.Drawing.Point(1100, 195);
            this.lbleventName.Name = "lbleventName";
            this.lbleventName.Size = new System.Drawing.Size(50, 20);
            this.lbleventName.TabIndex = 9;
            this.lbleventName.Text = "label1";
            this.lbleventName.Visible = false;
            // 
            // lbleventDate
            // 
            this.lbleventDate.AutoSize = true;
            this.lbleventDate.BackColor = System.Drawing.SystemColors.Control;
            this.lbleventDate.ForeColor = System.Drawing.Color.Black;
            this.lbleventDate.Location = new System.Drawing.Point(1100, 248);
            this.lbleventDate.Name = "lbleventDate";
            this.lbleventDate.Size = new System.Drawing.Size(50, 20);
            this.lbleventDate.TabIndex = 10;
            this.lbleventDate.Text = "label1";
            this.lbleventDate.Visible = false;
            // 
            // lbleventTime
            // 
            this.lbleventTime.AutoSize = true;
            this.lbleventTime.BackColor = System.Drawing.SystemColors.Control;
            this.lbleventTime.ForeColor = System.Drawing.Color.Black;
            this.lbleventTime.Location = new System.Drawing.Point(1100, 295);
            this.lbleventTime.Name = "lbleventTime";
            this.lbleventTime.Size = new System.Drawing.Size(50, 20);
            this.lbleventTime.TabIndex = 11;
            this.lbleventTime.Text = "label1";
            this.lbleventTime.Visible = false;
            // 
            // btnresTic
            // 
            this.btnresTic.Location = new System.Drawing.Point(1014, 353);
            this.btnresTic.Name = "btnresTic";
            this.btnresTic.Size = new System.Drawing.Size(136, 29);
            this.btnresTic.TabIndex = 12;
            this.btnresTic.Text = "Reserve a ticket";
            this.btnresTic.UseVisualStyleBackColor = true;
            this.btnresTic.Visible = false;
            this.btnresTic.Click += new System.EventHandler(this.btnresTic_Click);
            // 
            // UserEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 692);
            this.Controls.Add(this.btnresTic);
            this.Controls.Add(this.lbleventTime);
            this.Controls.Add(this.lbleventDate);
            this.Controls.Add(this.lbleventName);
            this.Controls.Add(this.lbleventId);
            this.Controls.Add(this.lbleTime);
            this.Controls.Add(this.lbleDate);
            this.Controls.Add(this.lbleName);
            this.Controls.Add(this.lbleID);
            this.Controls.Add(this.btnSearchName);
            this.Controls.Add(this.txtSearchname);
            this.Controls.Add(this.lblSeaName);
            this.Controls.Add(this.dgvEvent);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "UserEvent";
            this.Text = "UserEvent";
            this.Load += new System.EventHandler(this.UserEvent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEvent;
        private System.Windows.Forms.Label lblSeaName;
        private System.Windows.Forms.TextBox txtSearchname;
        private System.Windows.Forms.Button btnSearchName;
        private System.Windows.Forms.Label lbleID;
        private System.Windows.Forms.Label lbleName;
        private System.Windows.Forms.Label lbleDate;
        private System.Windows.Forms.Label lbleTime;
        private System.Windows.Forms.Label lbleventId;
        private System.Windows.Forms.Label lbleventName;
        private System.Windows.Forms.Label lbleventDate;
        private System.Windows.Forms.Label lbleventTime;
        private System.Windows.Forms.Button btnresTic;
    }
}