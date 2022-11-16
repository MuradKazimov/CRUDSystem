using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalDB
{
    
    public class CRUDsystem
    {
        bool ren;
        string query = "";
        SqlConnection con = new SqlConnection(DAL.GetConnect);
        SqlCommand cmd;
        int result;
        public int Insert(string patient_Name, string patient_Surname, string patient_Father_Name, string doctor_Name, string doctor_ID, string patient_Gender, string patient_Disease, string patient_Adress, string patient_Number, string patient_Age)
        {
            query = "Insert into Patients values('" + patient_Name + "','" + patient_Surname + "','" + patient_Father_Name + "','" + doctor_Name + "','" + doctor_ID + "','" + patient_Gender + "','" + patient_Disease + "','" + patient_Adress + "','" + patient_Number + "','" + patient_Age + "')";
            cmd = new SqlCommand(query, con);
            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    result = 2;
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
            finally
            {
                if (con.State != ConnectionState.Closed)
                {
                    con.Close();
                }
            }
            return result;
        }
        public int Update(int iD, string patient_Name, string patient_Surname, string patient_Father_Name, string doctor_Name, string doctor_ID, string patient_Gender, string patient_Disease, string patient_Adress, string patient_Number, string patient_Age)
        {
            
            if (string.IsNullOrEmpty(patient_Name) || iD < 0)
            {
                return 0;
            }
           
           
            query = "Update Patients set Patient_Name='" + patient_Name + "',Patient_Surname='" + patient_Surname + "',Patient_Father_Name='" + patient_Father_Name + "',Doctor_Name='" + doctor_Name + "',Doctor_ID='" + doctor_ID + "',Patient_Gender='" + patient_Gender + "',Patient_Disease='" + patient_Disease + "',Patient_Adress='" + patient_Adress + "',Patient_Number='" + patient_Number + "',Patient_Age='" + patient_Age  + "'where ID=" + iD;

            cmd = new SqlCommand(query, con);
            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    result = 2;
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
            finally
            {
                if (con.State != ConnectionState.Closed)
                {
                    con.Close();
                }
            }
            return result;
        }
        public int Delete(int iD)
        {
            query = "Delete from Patients where id=" + iD;
            cmd = new SqlCommand(query, con);
            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    result = 2;
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
            finally
            {
                if (con.State != ConnectionState.Closed)
                {
                    con.Close();
                }
            }
            return result;
        }
        public List<Data> Select()
        {
            string query = "select * from Patients";
            cmd = new SqlCommand(query, con);
            List<Data> list = new List<Data>();
            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    list.Add(new Data((int)dr[0], dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString(), dr[9].ToString(), dr[10].ToString()));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (con.State != ConnectionState.Closed)
                {
                    con.Close();
                }
            }
            return list;

        }
        public bool ID_Select(int ID)
        {
            string query = "select id from Patients where id=" + ID;
            cmd = new SqlCommand(query, con);
            try
            {
                string t = "";
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                IDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    t = dr[0].ToString();
                }
                if (t == ID.ToString())
                {
                    ren = true;
                }
                else
                {
                    ren = false;
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
            finally
            {
                if (con.State != ConnectionState.Closed)
                {
                    con.Close();
                }
            }

            return ren;
        }
    }
}
    

