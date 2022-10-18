
namespace Stadium_Management_System
{
    partial class AdminEvent
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEid = new System.Windows.Forms.TextBox();
            this.txtEname = new System.Windows.Forms.TextBox();
            this.txtEtime = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSeaname = new System.Windows.Forms.TextBox();
            this.btnEsearch = new System.Windows.Forms.Button();
            this.dgvAevent = new System.Windows.Forms.DataGridView();
            this.btnAsave = new System.Windows.Forms.Button();
            this.btbAupdate = new System.Windows.Forms.Button();
            this.btnAdelete = new System.Windows.Forms.Button();
            this.txtEdate = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAevent)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "EventID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Event Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Event Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Event Time";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtEid
            // 
            this.txtEid.Location = new System.Drawing.Point(205, 69);
            this.txtEid.Name = "txtEid";
            this.txtEid.Size = new System.Drawing.Size(274, 27);
            this.txtEid.TabIndex = 4;
            // 
            // txtEname
            // 
            this.txtEname.Location = new System.Drawing.Point(205, 121);
            this.txtEname.Name = "txtEname";
            this.txtEname.Size = new System.Drawing.Size(274, 27);
            this.txtEname.TabIndex = 5;
            // 
            // txtEtime
            // 
            this.txtEtime.Location = new System.Drawing.Point(205, 214);
            this.txtEtime.Name = "txtEtime";
            this.txtEtime.Size = new System.Drawing.Size(274, 27);
            this.txtEtime.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(754, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Search by Name";
            // 
            // txtSeaname
            // 
            this.txtSeaname.Location = new System.Drawing.Point(892, 69);
            this.txtSeaname.Name = "txtSeaname";
            this.txtSeaname.Size = new System.Drawing.Size(125, 27);
            this.txtSeaname.TabIndex = 11;
            // 
            // btnEsearch
            // 
            this.btnEsearch.BackColor = System.Drawing.Color.LightPink;
            this.btnEsearch.FlatAppearance.BorderSize = 0;
            this.btnEsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEsearch.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEsearch.Location = new System.Drawing.Point(1081, 67);
            this.btnEsearch.Name = "btnEsearch";
            this.btnEsearch.Size = new System.Drawing.Size(94, 29);
            this.btnEsearch.TabIndex = 12;
            this.btnEsearch.Text = "Search";
            this.btnEsearch.UseVisualStyleBackColor = false;
            this.btnEsearch.Click += new System.EventHandler(this.btnEsearch_Click);
            // 
            // dgvAevent
            // 
            this.dgvAevent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAevent.Location = new System.Drawing.Point(754, 121);
            this.dgvAevent.Name = "dgvAevent";
            this.dgvAevent.RowHeadersWidth = 51;
            this.dgvAevent.RowTemplate.Height = 29;
            this.dgvAevent.Size = new System.Drawing.Size(573, 261);
            this.dgvAevent.TabIndex = 13;
            this.dgvAevent.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAevent_RowHeaderMouseDoubleClick);
            // 
            // btnAsave
            // 
            this.btnAsave.BackColor = System.Drawing.Color.LightPink;
            this.btnAsave.FlatAppearance.BorderSize = 0;
            this.btnAsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsave.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAsave.Location = new System.Drawing.Point(50, 297);
            this.btnAsave.Name = "btnAsave";
            this.btnAsave.Size = new System.Drawing.Size(94, 38);
            this.btnAsave.TabIndex = 14;
            this.btnAsave.Text = "Save";
            this.btnAsave.UseVisualStyleBackColor = false;
            this.btnAsave.Click += new System.EventHandler(this.btnAsave_Click);
            // 
            // btbAupdate
            // 
            this.btbAupdate.BackColor = System.Drawing.Color.LightPink;
            this.btbAupdate.FlatAppearance.BorderSize = 0;
            this.btbAupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btbAupdate.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btbAupdate.Location = new System.Drawing.Point(193, 297);
            this.btbAupdate.Name = "btbAupdate";
            this.btbAupdate.Size = new System.Drawing.Size(94, 38);
            this.btbAupdate.TabIndex = 15;
            this.btbAupdate.Text = "Update";
            this.btbAupdate.UseVisualStyleBackColor = false;
            this.btbAupdate.Click += new System.EventHandler(this.btbAupdate_Click);
            // 
            // btnAdelete
            // 
            this.btnAdelete.BackColor = System.Drawing.Color.LightPink;
            this.btnAdelete.FlatAppearance.BorderSize = 0;
            this.btnAdelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdelete.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdelete.Location = new System.Drawing.Point(348, 297);
            this.btnAdelete.Name = "btnAdelete";
            this.btnAdelete.Size = new System.Drawing.Size(94, 38);
            this.btnAdelete.TabIndex = 16;
            this.btnAdelete.Text = "Delete";
            this.btnAdelete.UseVisualStyleBackColor = false;
            this.btnAdelete.Click += new System.EventHandler(this.btnAdelete_Click);
            // 
            // txtEdate
            // 
            this.txtEdate.Location = new System.Drawing.Point(205, 168);
            this.txtEdate.Name = "txtEdate";
            this.txtEdate.Size = new System.Drawing.Size(274, 27);
            this.txtEdate.TabIndex = 17;
            // 
            // AdminEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1399, 668);
            this.Controls.Add(this.txtEdate);
            this.Controls.Add(this.btnAdelete);
            this.Controls.Add(this.btbAupdate);
            this.Controls.Add(this.btnAsave);
            this.Controls.Add(this.dgvAevent);
            this.Controls.Add(this.btnEsearch);
            this.Controls.Add(this.txtSeaname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEtime);
            this.Controls.Add(this.txtEname);
            this.Controls.Add(this.txtEid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdminEvent";
            this.Text = "Event";
            this.Load += new System.EventHandler(this.AdminEvent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAevent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEid;
        private System.Windows.Forms.TextBox txtEname;
        private System.Windows.Forms.TextBox txtEtime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSeaname;
        private System.Windows.Forms.Button btnEsearch;
        private System.Windows.Forms.DataGridView dgvAevent;
        private System.Windows.Forms.Button btnAsave;
        private System.Windows.Forms.Button btbAupdate;
        private System.Windows.Forms.Button btnAdelete;
        private System.Windows.Forms.TextBox txtEdate;
    }
}