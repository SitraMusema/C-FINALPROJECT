
namespace Stadium_Management_System
{
    partial class AdminTicket
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
            this.txtticketid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtamount = new System.Windows.Forms.TextBox();
            this.txteventname = new System.Windows.Forms.TextBox();
            this.cmbtickettype = new System.Windows.Forms.ComboBox();
            this.btnTsave = new System.Windows.Forms.Button();
            this.btnTupdate = new System.Windows.Forms.Button();
            this.btnTdelete = new System.Windows.Forms.Button();
            this.dgvTicket = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txtseaTitype = new System.Windows.Forms.TextBox();
            this.btnTsearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTicket)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ticket ID :";
            // 
            // txtticketid
            // 
            this.txtticketid.Location = new System.Drawing.Point(213, 65);
            this.txtticketid.Name = "txtticketid";
            this.txtticketid.Size = new System.Drawing.Size(151, 27);
            this.txtticketid.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ticket Type :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Event Name :";
            // 
            // txtamount
            // 
            this.txtamount.Location = new System.Drawing.Point(213, 167);
            this.txtamount.Name = "txtamount";
            this.txtamount.Size = new System.Drawing.Size(151, 27);
            this.txtamount.TabIndex = 5;
            // 
            // txteventname
            // 
            this.txteventname.Location = new System.Drawing.Point(213, 216);
            this.txteventname.Name = "txteventname";
            this.txteventname.Size = new System.Drawing.Size(151, 27);
            this.txteventname.TabIndex = 6;
            // 
            // cmbtickettype
            // 
            this.cmbtickettype.FormattingEnabled = true;
            this.cmbtickettype.Items.AddRange(new object[] {
            "REGULAR",
            "VIP"});
            this.cmbtickettype.Location = new System.Drawing.Point(213, 112);
            this.cmbtickettype.Name = "cmbtickettype";
            this.cmbtickettype.Size = new System.Drawing.Size(151, 28);
            this.cmbtickettype.TabIndex = 7;
            // 
            // btnTsave
            // 
            this.btnTsave.BackColor = System.Drawing.Color.LightBlue;
            this.btnTsave.FlatAppearance.BorderSize = 0;
            this.btnTsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTsave.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTsave.Location = new System.Drawing.Point(190, 329);
            this.btnTsave.Name = "btnTsave";
            this.btnTsave.Size = new System.Drawing.Size(94, 34);
            this.btnTsave.TabIndex = 8;
            this.btnTsave.Text = "Save";
            this.btnTsave.UseVisualStyleBackColor = false;
            this.btnTsave.Click += new System.EventHandler(this.btnTsave_Click);
            // 
            // btnTupdate
            // 
            this.btnTupdate.BackColor = System.Drawing.Color.LightBlue;
            this.btnTupdate.FlatAppearance.BorderSize = 0;
            this.btnTupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTupdate.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTupdate.Location = new System.Drawing.Point(376, 329);
            this.btnTupdate.Name = "btnTupdate";
            this.btnTupdate.Size = new System.Drawing.Size(112, 34);
            this.btnTupdate.TabIndex = 9;
            this.btnTupdate.Text = "Update";
            this.btnTupdate.UseVisualStyleBackColor = false;
            this.btnTupdate.Click += new System.EventHandler(this.btnTupdate_Click);
            // 
            // btnTdelete
            // 
            this.btnTdelete.BackColor = System.Drawing.Color.LightBlue;
            this.btnTdelete.FlatAppearance.BorderSize = 0;
            this.btnTdelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTdelete.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTdelete.Location = new System.Drawing.Point(573, 329);
            this.btnTdelete.Name = "btnTdelete";
            this.btnTdelete.Size = new System.Drawing.Size(94, 34);
            this.btnTdelete.TabIndex = 10;
            this.btnTdelete.Text = "Delete";
            this.btnTdelete.UseVisualStyleBackColor = false;
            this.btnTdelete.Click += new System.EventHandler(this.btnTdelete_Click);
            // 
            // dgvTicket
            // 
            this.dgvTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTicket.Location = new System.Drawing.Point(679, 72);
            this.dgvTicket.Name = "dgvTicket";
            this.dgvTicket.RowHeadersWidth = 51;
            this.dgvTicket.RowTemplate.Height = 29;
            this.dgvTicket.Size = new System.Drawing.Size(432, 204);
            this.dgvTicket.TabIndex = 11;
            this.dgvTicket.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTicket_RowHeaderMouseDoubleClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(623, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Search by Ticket Type :";
            // 
            // txtseaTitype
            // 
            this.txtseaTitype.Location = new System.Drawing.Point(800, 24);
            this.txtseaTitype.Name = "txtseaTitype";
            this.txtseaTitype.Size = new System.Drawing.Size(179, 27);
            this.txtseaTitype.TabIndex = 13;
            // 
            // btnTsearch
            // 
            this.btnTsearch.BackColor = System.Drawing.Color.LightBlue;
            this.btnTsearch.FlatAppearance.BorderSize = 0;
            this.btnTsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTsearch.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTsearch.Location = new System.Drawing.Point(1013, 24);
            this.btnTsearch.Name = "btnTsearch";
            this.btnTsearch.Size = new System.Drawing.Size(98, 35);
            this.btnTsearch.TabIndex = 14;
            this.btnTsearch.Text = "Search";
            this.btnTsearch.UseVisualStyleBackColor = false;
            this.btnTsearch.Click += new System.EventHandler(this.btnTsearch_Click);
            // 
            // AdminTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 545);
            this.Controls.Add(this.btnTsearch);
            this.Controls.Add(this.txtseaTitype);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvTicket);
            this.Controls.Add(this.btnTdelete);
            this.Controls.Add(this.btnTupdate);
            this.Controls.Add(this.btnTsave);
            this.Controls.Add(this.cmbtickettype);
            this.Controls.Add(this.txteventname);
            this.Controls.Add(this.txtamount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtticketid);
            this.Controls.Add(this.label1);
            this.Name = "AdminTicket";
            this.Text = "AdminTicket";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTicket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtticketid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtamount;
        private System.Windows.Forms.TextBox txteventname;
        private System.Windows.Forms.ComboBox cmbtickettype;
        private System.Windows.Forms.Button btnTsave;
        private System.Windows.Forms.Button btnTupdate;
        private System.Windows.Forms.Button btnTdelete;
        private System.Windows.Forms.DataGridView dgvTicket;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtseaTitype;
        private System.Windows.Forms.Button btnTsearch;
    }
}