using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalDB
{
    public partial class Form1 : Form
    {
        CRUDsystem ds = new CRUDsystem();
        public Form1()
        {

            InitializeComponent();
        }



        private void Txt_Ptnt_Nm_Enter(object sender, EventArgs e)
        {
            if (Txt_Ptnt_Nm.Text == "Patient Name")
            {
                Txt_Ptnt_Nm.Text = "";
                Txt_Ptnt_Nm.ForeColor = Color.Black;
            }
        }
        private void Txt_Ptnt_Nm_Leave(object sender, EventArgs e)
        {
            if (Txt_Ptnt_Nm.Text == "")
            {
                Txt_Ptnt_Nm.Text = "Patient Name";
                Txt_Ptnt_Nm.ForeColor = Color.DarkGray;
            }
        }
        private void Txt_Ptnt_Srn_Enter(object sender, EventArgs e)
        {
            if (Txt_Ptnt_Srn.Text == "Patient Surname")
            {
                Txt_Ptnt_Srn.Text = "";
                Txt_Ptnt_Srn.ForeColor = Color.Black;
            }
        }

        private void Txt_Ptnt_Srn_Leave(object sender, EventArgs e)
        {
            if (Txt_Ptnt_Srn.Text == "")
            {
                Txt_Ptnt_Srn.Text = "Patient Surname";
                Txt_Ptnt_Srn.ForeColor = Color.DarkGray;
            }
        }

        private void Txt_Ptnt_Fnm_Enter(object sender, EventArgs e)
        {
            if (Txt_Ptnt_Fnm.Text == "Patient Father Name")
            {
                Txt_Ptnt_Fnm.Text = "";
                Txt_Ptnt_Fnm.ForeColor = Color.Black;
            }
        }
        private void Txt_Ptnt_Fnm_Leave(object sender, EventArgs e)
        {
            if (Txt_Ptnt_Fnm.Text == "")
            {
                Txt_Ptnt_Fnm.Text = "Patient Father Name";
                Txt_Ptnt_Fnm.ForeColor = Color.DarkGray;
            }
        }
        private void Txt_Doc_Nm_Enter(object sender, EventArgs e)
        {
            if (Txt_Doc_Nm.Text == "Doctor Name")
            {
                Txt_Doc_Nm.Text = "";
                Txt_Doc_Nm.ForeColor = Color.Black;
            }
        }
        private void Txt_Doc_Nm_Leave(object sender, EventArgs e)
        {
            if (Txt_Doc_Nm.Text == "")
            {
                Txt_Doc_Nm.Text = "Doctor Name";
                Txt_Doc_Nm.ForeColor = Color.DarkGray;
            }
        }
        private void Txt_Doc_ID_Enter(object sender, EventArgs e)
        {
            if (Txt_Doc_ID.Text == "Doctor ID")
            {
                Txt_Doc_ID.Text = "";
                Txt_Doc_ID.ForeColor = Color.Black;
            }
        }
        private void Txt_Doc_ID_Leave(object sender, EventArgs e)
        {
            if (Txt_Doc_ID.Text == "")
            {
                Txt_Doc_ID.Text = "Doctor ID";
                Txt_Doc_ID.ForeColor = Color.DarkGray;
            }
        }
        private void Txt_Ptnt_Gndr_Enter(object sender, EventArgs e)
        {
            if (Txt_Ptnt_Gndr.Text == "Patient Gender")
            {
                Txt_Ptnt_Gndr.Text = "";
                Txt_Ptnt_Gndr.ForeColor = Color.Black;
            }
        }
        private void Txt_Ptnt_Gndr_Leave(object sender, EventArgs e)
        {
            if (Txt_Ptnt_Gndr.Text == "")
            {
                Txt_Ptnt_Gndr.Text = "Patient Gender";
                Txt_Ptnt_Gndr.ForeColor = Color.DarkGray;
            }
        }
        private void Txt_Ptnt_Ds_Enter(object sender, EventArgs e)
        {
            if (Txt_Ptnt_Ds.Text == "Patient Disease")
            {
                Txt_Ptnt_Ds.Text = "";
                Txt_Ptnt_Ds.ForeColor = Color.Black;
            }

        }
        private void Txt_Ptnt_Ds_Leave(object sender, EventArgs e)
        {
            if (Txt_Ptnt_Ds.Text == "")
            {
                Txt_Ptnt_Ds.Text = "Patient Disease";
                Txt_Ptnt_Ds.ForeColor = Color.DarkGray;
            }
        }
        private void Txt_Ptnt_Adrs_Enter(object sender, EventArgs e)
        {
            if (Txt_Ptnt_Adrs.Text == "Patient Adress")
            {
                Txt_Ptnt_Adrs.Text = "";
                Txt_Ptnt_Adrs.ForeColor = Color.Black;
            }
        }
        private void Txt_Ptnt_Adrs_Leave(object sender, EventArgs e)
        {
            if (Txt_Ptnt_Adrs.Text == "")
            {
                Txt_Ptnt_Adrs.Text = "Patient Adress";
                Txt_Ptnt_Adrs.ForeColor = Color.DarkGray;
            }
        }
        private void Txt_Ptnt_Nmbr_Enter(object sender, EventArgs e)
        {
            if (Txt_Ptnt_Nmbr.Text == "Patient Number")
            {
                Txt_Ptnt_Nmbr.Text = "";
                Txt_Ptnt_Nmbr.ForeColor = Color.Black;
            }
        }
        private void Txt_Ptnt_Nmbr_Leave(object sender, EventArgs e)
        {
            if (Txt_Ptnt_Nmbr.Text == "")
            {
                Txt_Ptnt_Nmbr.Text = "Patient Number";
                Txt_Ptnt_Nmbr.ForeColor = Color.DarkGray;
            }
        }
        private void Txt_Ptnt_Age_Enter(object sender, EventArgs e)
        {
            if (Txt_Ptnt_Age.Text == "Patient Age")
            {
                Txt_Ptnt_Age.Text = "";
                Txt_Ptnt_Age.ForeColor = Color.Black;
            }

        }
        private void Txt_Ptnt_Age_Leave(object sender, EventArgs e)
        {
            if (Txt_Ptnt_Age.Text == "")
            {
                Txt_Ptnt_Age.Text = "Patient Age";
                Txt_Ptnt_Age.ForeColor = Color.DarkGray;
            }
        }

        private void Btn_Dlt_Click(object sender, EventArgs e)
        {
            if (Txt_Ptnt_ID.Text == "")
            {
                MessageBox.Show("Id cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Convert.ToInt32(Txt_Ptnt_ID.Text) <= 0)
            {
                MessageBox.Show("Id cannot be 0 or negative", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!ds.ID_Select(Convert.ToInt32(Txt_Ptnt_ID.Text)))
            {
                MessageBox.Show("Enter valid Id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int a = ds.Delete(Convert.ToInt32(Txt_Ptnt_ID.Text));

            if (a == 2)
            {
                MessageBox.Show("Delete Succesfull!");
            }
            else
            {
                MessageBox.Show("Unsuccesfull Operation!");
            }
        }

        private void Btn_Upt_Click(object sender, EventArgs e)
        {
            if (Txt_Ptnt_ID.Text == "")
            {
                MessageBox.Show("Id cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

                if (Convert.ToInt32(Txt_Ptnt_ID.Text) <= 0)
                {
                    MessageBox.Show("Id cannot be 0 or negative", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int a = ds.Update(Convert.ToInt32(Txt_Ptnt_ID.Text), Txt_Ptnt_Nm.Text, Txt_Ptnt_Srn.Text, Txt_Ptnt_Gndr.Text, Txt_Ptnt_Ds.Text, Txt_Ptnt_Fnm.Text, Txt_Ptnt_Adrs.Text, Txt_Doc_Nm.Text, Txt_Ptnt_Nmbr.Text, Txt_Doc_ID.Text, Txt_Ptnt_Age.Text);
                if (a == 2)
                {
                    MessageBox.Show("Update Succesfull!");
                }
                else
                {
                    MessageBox.Show("Unsuccesfull Operation!");
                }
            
        }
            private void Btn_Fnd_Click(object sender, EventArgs e)
            {
                {
                    DataGridView.DataSource = ds.Select();
                }
            }

            private void Btn_Crt_Click(object sender, EventArgs e)
            {
           
                
                    int a = ds.Insert(Txt_Ptnt_Nm.Text, Txt_Ptnt_Srn.Text, Txt_Ptnt_Gndr.Text, Txt_Ptnt_Ds.Text, Txt_Ptnt_Fnm.Text, Txt_Ptnt_Adrs.Text, Txt_Doc_Nm.Text, Txt_Ptnt_Nmbr.Text, Txt_Doc_ID.Text, Txt_Ptnt_Age.Text);
                    if (a == 2)
                    {
                        MessageBox.Show("Create Succesfull!");
                    }
                    else
                    {
                        MessageBox.Show("Unsuccesfull Operation!");
                    }
                
            }
        }
    }

 

