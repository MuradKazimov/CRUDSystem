namespace HospitalDB
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Lbl_Hosp = new System.Windows.Forms.Label();
            this.Ptnt_ID = new System.Windows.Forms.Label();
            this.Txt_Ptnt_Nm = new System.Windows.Forms.TextBox();
            this.Txt_Ptnt_Srn = new System.Windows.Forms.TextBox();
            this.Txt_Ptnt_Fnm = new System.Windows.Forms.TextBox();
            this.Txt_Doc_Nm = new System.Windows.Forms.TextBox();
            this.Txt_Doc_ID = new System.Windows.Forms.TextBox();
            this.Txt_Ptnt_Gndr = new System.Windows.Forms.TextBox();
            this.Txt_Ptnt_Ds = new System.Windows.Forms.TextBox();
            this.Txt_Ptnt_Adrs = new System.Windows.Forms.TextBox();
            this.Txt_Ptnt_Nmbr = new System.Windows.Forms.TextBox();
            this.Txt_Ptnt_Age = new System.Windows.Forms.TextBox();
            this.Txt_Ptnt_ID = new System.Windows.Forms.TextBox();
            this.Btn_Crt = new System.Windows.Forms.Button();
            this.Btn_Fnd = new System.Windows.Forms.Button();
            this.Btn_Upt = new System.Windows.Forms.Button();
            this.Btn_Dlt = new System.Windows.Forms.Button();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Hosp
            // 
            this.Lbl_Hosp.AutoSize = true;
            this.Lbl_Hosp.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Hosp.Location = new System.Drawing.Point(119, 47);
            this.Lbl_Hosp.Name = "Lbl_Hosp";
            this.Lbl_Hosp.Size = new System.Drawing.Size(413, 39);
            this.Lbl_Hosp.TabIndex = 0;
            this.Lbl_Hosp.Text = "Hospital Patients Database";
            // 
            // Ptnt_ID
            // 
            this.Ptnt_ID.AutoSize = true;
            this.Ptnt_ID.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.Ptnt_ID.Location = new System.Drawing.Point(637, 65);
            this.Ptnt_ID.Name = "Ptnt_ID";
            this.Ptnt_ID.Size = new System.Drawing.Size(112, 26);
            this.Ptnt_ID.TabIndex = 11;
            this.Ptnt_ID.Text = "Patient ID:";
            // 
            // Txt_Ptnt_Nm
            // 
            this.Txt_Ptnt_Nm.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.Txt_Ptnt_Nm.ForeColor = System.Drawing.Color.DarkGray;
            this.Txt_Ptnt_Nm.Location = new System.Drawing.Point(77, 151);
            this.Txt_Ptnt_Nm.Multiline = true;
            this.Txt_Ptnt_Nm.Name = "Txt_Ptnt_Nm";
            this.Txt_Ptnt_Nm.Size = new System.Drawing.Size(230, 45);
            this.Txt_Ptnt_Nm.TabIndex = 12;
            this.Txt_Ptnt_Nm.Text = "Patient Name";
            this.Txt_Ptnt_Nm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txt_Ptnt_Nm.Enter += new System.EventHandler(this.Txt_Ptnt_Nm_Enter);
            this.Txt_Ptnt_Nm.Leave += new System.EventHandler(this.Txt_Ptnt_Nm_Leave);
            // 
            // Txt_Ptnt_Srn
            // 
            this.Txt_Ptnt_Srn.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.Txt_Ptnt_Srn.ForeColor = System.Drawing.Color.DarkGray;
            this.Txt_Ptnt_Srn.Location = new System.Drawing.Point(77, 212);
            this.Txt_Ptnt_Srn.Multiline = true;
            this.Txt_Ptnt_Srn.Name = "Txt_Ptnt_Srn";
            this.Txt_Ptnt_Srn.Size = new System.Drawing.Size(230, 45);
            this.Txt_Ptnt_Srn.TabIndex = 13;
            this.Txt_Ptnt_Srn.Text = "Patient Surname";
            this.Txt_Ptnt_Srn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txt_Ptnt_Srn.Enter += new System.EventHandler(this.Txt_Ptnt_Srn_Enter);
            this.Txt_Ptnt_Srn.Leave += new System.EventHandler(this.Txt_Ptnt_Srn_Leave);
            // 
            // Txt_Ptnt_Fnm
            // 
            this.Txt_Ptnt_Fnm.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.Txt_Ptnt_Fnm.ForeColor = System.Drawing.Color.DarkGray;
            this.Txt_Ptnt_Fnm.Location = new System.Drawing.Point(77, 273);
            this.Txt_Ptnt_Fnm.Multiline = true;
            this.Txt_Ptnt_Fnm.Name = "Txt_Ptnt_Fnm";
            this.Txt_Ptnt_Fnm.Size = new System.Drawing.Size(230, 45);
            this.Txt_Ptnt_Fnm.TabIndex = 14;
            this.Txt_Ptnt_Fnm.Text = "Patient Father Name";
            this.Txt_Ptnt_Fnm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txt_Ptnt_Fnm.Enter += new System.EventHandler(this.Txt_Ptnt_Fnm_Enter);
            this.Txt_Ptnt_Fnm.Leave += new System.EventHandler(this.Txt_Ptnt_Fnm_Leave);
            // 
            // Txt_Doc_Nm
            // 
            this.Txt_Doc_Nm.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.Txt_Doc_Nm.ForeColor = System.Drawing.Color.DarkGray;
            this.Txt_Doc_Nm.Location = new System.Drawing.Point(77, 334);
            this.Txt_Doc_Nm.Multiline = true;
            this.Txt_Doc_Nm.Name = "Txt_Doc_Nm";
            this.Txt_Doc_Nm.Size = new System.Drawing.Size(230, 45);
            this.Txt_Doc_Nm.TabIndex = 15;
            this.Txt_Doc_Nm.Text = "Doctor Name";
            this.Txt_Doc_Nm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txt_Doc_Nm.Enter += new System.EventHandler(this.Txt_Doc_Nm_Enter);
            this.Txt_Doc_Nm.Leave += new System.EventHandler(this.Txt_Doc_Nm_Leave);
            // 
            // Txt_Doc_ID
            // 
            this.Txt_Doc_ID.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.Txt_Doc_ID.ForeColor = System.Drawing.Color.DarkGray;
            this.Txt_Doc_ID.Location = new System.Drawing.Point(77, 395);
            this.Txt_Doc_ID.Multiline = true;
            this.Txt_Doc_ID.Name = "Txt_Doc_ID";
            this.Txt_Doc_ID.Size = new System.Drawing.Size(230, 45);
            this.Txt_Doc_ID.TabIndex = 16;
            this.Txt_Doc_ID.Text = "Doctor ID";
            this.Txt_Doc_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txt_Doc_ID.Enter += new System.EventHandler(this.Txt_Doc_ID_Enter);
            this.Txt_Doc_ID.Leave += new System.EventHandler(this.Txt_Doc_ID_Leave);
            // 
            // Txt_Ptnt_Gndr
            // 
            this.Txt_Ptnt_Gndr.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.Txt_Ptnt_Gndr.ForeColor = System.Drawing.Color.DarkGray;
            this.Txt_Ptnt_Gndr.Location = new System.Drawing.Point(355, 151);
            this.Txt_Ptnt_Gndr.Multiline = true;
            this.Txt_Ptnt_Gndr.Name = "Txt_Ptnt_Gndr";
            this.Txt_Ptnt_Gndr.Size = new System.Drawing.Size(230, 45);
            this.Txt_Ptnt_Gndr.TabIndex = 17;
            this.Txt_Ptnt_Gndr.Text = "Patient Gender";
            this.Txt_Ptnt_Gndr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txt_Ptnt_Gndr.Enter += new System.EventHandler(this.Txt_Ptnt_Gndr_Enter);
            this.Txt_Ptnt_Gndr.Leave += new System.EventHandler(this.Txt_Ptnt_Gndr_Leave);
            // 
            // Txt_Ptnt_Ds
            // 
            this.Txt_Ptnt_Ds.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.Txt_Ptnt_Ds.ForeColor = System.Drawing.Color.DarkGray;
            this.Txt_Ptnt_Ds.Location = new System.Drawing.Point(355, 212);
            this.Txt_Ptnt_Ds.Multiline = true;
            this.Txt_Ptnt_Ds.Name = "Txt_Ptnt_Ds";
            this.Txt_Ptnt_Ds.Size = new System.Drawing.Size(230, 45);
            this.Txt_Ptnt_Ds.TabIndex = 18;
            this.Txt_Ptnt_Ds.Text = "Patient Disease";
            this.Txt_Ptnt_Ds.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txt_Ptnt_Ds.Enter += new System.EventHandler(this.Txt_Ptnt_Ds_Enter);
            this.Txt_Ptnt_Ds.Leave += new System.EventHandler(this.Txt_Ptnt_Ds_Leave);
            // 
            // Txt_Ptnt_Adrs
            // 
            this.Txt_Ptnt_Adrs.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.Txt_Ptnt_Adrs.ForeColor = System.Drawing.Color.DarkGray;
            this.Txt_Ptnt_Adrs.Location = new System.Drawing.Point(355, 273);
            this.Txt_Ptnt_Adrs.Multiline = true;
            this.Txt_Ptnt_Adrs.Name = "Txt_Ptnt_Adrs";
            this.Txt_Ptnt_Adrs.Size = new System.Drawing.Size(230, 45);
            this.Txt_Ptnt_Adrs.TabIndex = 19;
            this.Txt_Ptnt_Adrs.Text = "Patient Adress";
            this.Txt_Ptnt_Adrs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txt_Ptnt_Adrs.Enter += new System.EventHandler(this.Txt_Ptnt_Adrs_Enter);
            this.Txt_Ptnt_Adrs.Leave += new System.EventHandler(this.Txt_Ptnt_Adrs_Leave);
            // 
            // Txt_Ptnt_Nmbr
            // 
            this.Txt_Ptnt_Nmbr.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.Txt_Ptnt_Nmbr.ForeColor = System.Drawing.Color.DarkGray;
            this.Txt_Ptnt_Nmbr.Location = new System.Drawing.Point(355, 334);
            this.Txt_Ptnt_Nmbr.Multiline = true;
            this.Txt_Ptnt_Nmbr.Name = "Txt_Ptnt_Nmbr";
            this.Txt_Ptnt_Nmbr.Size = new System.Drawing.Size(230, 45);
            this.Txt_Ptnt_Nmbr.TabIndex = 20;
            this.Txt_Ptnt_Nmbr.Text = "Patient Number";
            this.Txt_Ptnt_Nmbr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txt_Ptnt_Nmbr.Enter += new System.EventHandler(this.Txt_Ptnt_Nmbr_Enter);
            this.Txt_Ptnt_Nmbr.Leave += new System.EventHandler(this.Txt_Ptnt_Nmbr_Leave);
            // 
            // Txt_Ptnt_Age
            // 
            this.Txt_Ptnt_Age.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.Txt_Ptnt_Age.ForeColor = System.Drawing.Color.DarkGray;
            this.Txt_Ptnt_Age.Location = new System.Drawing.Point(355, 395);
            this.Txt_Ptnt_Age.Multiline = true;
            this.Txt_Ptnt_Age.Name = "Txt_Ptnt_Age";
            this.Txt_Ptnt_Age.Size = new System.Drawing.Size(230, 45);
            this.Txt_Ptnt_Age.TabIndex = 21;
            this.Txt_Ptnt_Age.Text = "Patient Age";
            this.Txt_Ptnt_Age.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txt_Ptnt_Age.Enter += new System.EventHandler(this.Txt_Ptnt_Age_Enter);
            this.Txt_Ptnt_Age.Leave += new System.EventHandler(this.Txt_Ptnt_Age_Leave);
            // 
            // Txt_Ptnt_ID
            // 
            this.Txt_Ptnt_ID.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Ptnt_ID.Location = new System.Drawing.Point(775, 58);
            this.Txt_Ptnt_ID.Multiline = true;
            this.Txt_Ptnt_ID.Name = "Txt_Ptnt_ID";
            this.Txt_Ptnt_ID.Size = new System.Drawing.Size(182, 41);
            this.Txt_Ptnt_ID.TabIndex = 22;
            this.Txt_Ptnt_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Btn_Crt
            // 
            this.Btn_Crt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Crt.Location = new System.Drawing.Point(77, 471);
            this.Btn_Crt.Name = "Btn_Crt";
            this.Btn_Crt.Size = new System.Drawing.Size(100, 55);
            this.Btn_Crt.TabIndex = 23;
            this.Btn_Crt.Text = "Create";
            this.Btn_Crt.UseVisualStyleBackColor = true;
            this.Btn_Crt.Click += new System.EventHandler(this.Btn_Crt_Click);
            // 
            // Btn_Fnd
            // 
            this.Btn_Fnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Fnd.Location = new System.Drawing.Point(207, 471);
            this.Btn_Fnd.Name = "Btn_Fnd";
            this.Btn_Fnd.Size = new System.Drawing.Size(100, 55);
            this.Btn_Fnd.TabIndex = 24;
            this.Btn_Fnd.Text = "Find";
            this.Btn_Fnd.UseVisualStyleBackColor = true;
            this.Btn_Fnd.Click += new System.EventHandler(this.Btn_Fnd_Click);
            // 
            // Btn_Upt
            // 
            this.Btn_Upt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Upt.Location = new System.Drawing.Point(355, 471);
            this.Btn_Upt.Name = "Btn_Upt";
            this.Btn_Upt.Size = new System.Drawing.Size(100, 55);
            this.Btn_Upt.TabIndex = 25;
            this.Btn_Upt.Text = "Update";
            this.Btn_Upt.UseVisualStyleBackColor = true;
            this.Btn_Upt.Click += new System.EventHandler(this.Btn_Upt_Click);
            // 
            // Btn_Dlt
            // 
            this.Btn_Dlt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Dlt.Location = new System.Drawing.Point(485, 471);
            this.Btn_Dlt.Name = "Btn_Dlt";
            this.Btn_Dlt.Size = new System.Drawing.Size(100, 55);
            this.Btn_Dlt.TabIndex = 26;
            this.Btn_Dlt.Text = "Delete";
            this.Btn_Dlt.UseVisualStyleBackColor = true;
            this.Btn_Dlt.Click += new System.EventHandler(this.Btn_Dlt_Click);
            // 
            // DataGridView
            // 
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(632, 151);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.Size = new System.Drawing.Size(353, 375);
            this.DataGridView.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1062, 562);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.Btn_Dlt);
            this.Controls.Add(this.Btn_Upt);
            this.Controls.Add(this.Btn_Fnd);
            this.Controls.Add(this.Btn_Crt);
            this.Controls.Add(this.Txt_Ptnt_ID);
            this.Controls.Add(this.Txt_Ptnt_Age);
            this.Controls.Add(this.Txt_Ptnt_Nmbr);
            this.Controls.Add(this.Txt_Ptnt_Adrs);
            this.Controls.Add(this.Txt_Ptnt_Ds);
            this.Controls.Add(this.Txt_Ptnt_Gndr);
            this.Controls.Add(this.Txt_Doc_ID);
            this.Controls.Add(this.Txt_Doc_Nm);
            this.Controls.Add(this.Txt_Ptnt_Fnm);
            this.Controls.Add(this.Txt_Ptnt_Srn);
            this.Controls.Add(this.Txt_Ptnt_Nm);
            this.Controls.Add(this.Ptnt_ID);
            this.Controls.Add(this.Lbl_Hosp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Database APP";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Hosp;
        private System.Windows.Forms.Label Ptnt_ID;
        private System.Windows.Forms.TextBox Txt_Ptnt_Nm;
        private System.Windows.Forms.TextBox Txt_Ptnt_Srn;
        private System.Windows.Forms.TextBox Txt_Ptnt_Fnm;
        private System.Windows.Forms.TextBox Txt_Doc_Nm;
        private System.Windows.Forms.TextBox Txt_Doc_ID;
        private System.Windows.Forms.TextBox Txt_Ptnt_Gndr;
        private System.Windows.Forms.TextBox Txt_Ptnt_Ds;
        private System.Windows.Forms.TextBox Txt_Ptnt_Adrs;
        private System.Windows.Forms.TextBox Txt_Ptnt_Nmbr;
        private System.Windows.Forms.TextBox Txt_Ptnt_Age;
        private System.Windows.Forms.TextBox Txt_Ptnt_ID;
        private System.Windows.Forms.Button Btn_Crt;
        private System.Windows.Forms.Button Btn_Fnd;
        private System.Windows.Forms.Button Btn_Upt;
        private System.Windows.Forms.Button Btn_Dlt;
        private System.Windows.Forms.DataGridView DataGridView;
    }
}

