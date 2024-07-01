using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmoecQueingSystem
{
    class MainClass
    {
        public static readonly string con_string = "Data Source=PpYCHa; Initial Catalog=Queing;Persist Security Info=True; User ID=sa; Password=admin";
        //public static readonly string con_string = "Data Source=192.168.1.22; Initial Catalog=Queing; Integrated Security=True;";

        public static readonly SqlConnection con = new SqlConnection(con_string);

        //Method to check user validation

        public static bool IsValidUser(string user, string password)
        {
            bool isValid = false;

            string qry = @"Select * from users where username = '" + user + "' and password ='" + password + "' ";
            SqlCommand cmd = new SqlCommand(qry, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                isValid = true;
                ROLE = dt.Rows[0]["role"].ToString();
                USER = dt.Rows[0]["username"].ToString();
            }

            return isValid;
        }

        public static string role;

        public static string ROLE
        {
            get { return role; }
            set { role = value; }
        }


        public static string user;

        public static string USER
        {
            get { return user; }
            set { user = value; }
        }

        //Method for Crud Operation

        public static int SQL(string qry, Hashtable ht)
        {
            int res = 0;

            try
            {
                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.CommandType = CommandType.Text;

                foreach (DictionaryEntry item in ht)
                {
                    cmd.Parameters.AddWithValue(item.Key.ToString(), item.Value);
                }
                if (con.State == ConnectionState.Closed) { con.Open(); };
                res = cmd.ExecuteNonQuery();
                if (con.State == ConnectionState.Open) { con.Close(); };
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                con.Close();
            }


            return res;
        }

        //For loading data from database

        public static void LoadData(string qry, DataGridView gv, ListBox lb)
        {
            //Serial no in gridView

            gv.CellFormatting += new DataGridViewCellFormattingEventHandler(gv_CellFormatting);
            try
            {
                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                //for (int i = 0; i < lb.Items.Count; i++)
                //{
                //    string colName = ((DataGridViewColumn).lb.Items[i]).Name;
                //    gv.Columns[colName].DataPropertyName = dt.Columns[i].ToString();
                //}

                for (int i = 0; i < lb.Items.Count; i++)
                {
                    DataGridViewColumn col = (DataGridViewColumn)lb.Items[i];
                    string colName = col.Name;
                    gv.Columns[colName].DataPropertyName = dt.Columns[i].ToString();
                }

                gv.DataSource = dt;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                con.Close();
            }
        }

        private static void gv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //Guna.UI2.WinForms.Guna2DataGridView gv = (Guna.UI2.WinForms.Guna2DataGridView)sender;
            DataGridView gv = (DataGridView)sender;
            int count = 0;

            //foreach (DataGridViewRow row in gv.Rows)
            //{
            //    count++;
            //    row.Cells[0].Value = count;
            //}
        }




        public static void CBFill(string qry, ComboBox cb)
        {
            SqlCommand cmd = new SqlCommand(qry, con);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cb.DisplayMember = "name";
            cb.ValueMember = "id";
            cb.DataSource = dt;
            cb.SelectedIndex = -1;
        }
    }
}
