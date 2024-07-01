using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AmoecQueingSystem
{
    public partial class MainForm : MaterialForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public int id = 0;

        private void bt_Save_Click(object sender, EventArgs e)
        {
            string qry = "";

            if (id == 0)
            {
                qry = @"Insert into users values(@username,@password,@role)";
            }
            else
            {
                qry = @"UPDATE users set username = @username, password = @password, role = @role where id = @id";
            }

            Hashtable ht = new Hashtable();
            ht.Add("@id", id);

            ht.Add("@username", tb_Username.Text);
            ht.Add("@password", tb_Password.Text);
            ht.Add("@role", cb_Role.SelectedItem);
            if (MainClass.SQL(qry, ht) > 0)
            {

                MaterialMessageBox.Show("Data saved succesfully");

                id = 0;
                tb_Username.Text = "";
                tb_Password.Text = "";
                cb_Role.SelectedIndex = 0;
                cb_Role.SelectedIndex = -1;
                tb_Username.Focus();

                LoadData();
            }

        }
        private void LoadData()
        {
            ListBox lb = new ListBox();
            lb.Items.Add(dgvId);
            lb.Items.Add(dgvUsername);
            lb.Items.Add(dgvPassword);
            lb.Items.Add(dgvRole);

            string qry = @"Select id, username, password, role from users";

            MainClass.LoadData(qry, dataGridView_User, lb);
        }

        private void dataGridView_User_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dataGridView_User.CurrentRow.Cells["dgvId"].Value);
            tb_Username.Text = dataGridView_User.Rows[e.RowIndex].Cells[1].Value.ToString();
            tb_Password.Text = dataGridView_User.Rows[e.RowIndex].Cells[2].Value.ToString();
            cb_Role.Text = dataGridView_User.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void bt_Delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete?", "Confirmation", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {

                string qry = "Delete from users where id = " + id + "";
                Hashtable ht = new Hashtable();


                if (MainClass.SQL(qry, ht) > 0)
                {
                    MessageBox.Show("Deleted successfully");
                    LoadData(); // Reload your data after deletion
                    id = 0;
                }
                else
                {
                    MessageBox.Show("Failed to delete user");
                    id = 0;
                }
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void bt_Reset_Click(object sender, EventArgs e)
        {
            MainClass.con.Open();

            string qry = "DELETE FROM queue_numbers";

            using (SqlCommand cmd = new SqlCommand(qry, MainClass.con))
            {
                cmd.ExecuteNonQuery(); // Execute the delete query
            }

            MainClass.con.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // Get the selected date from the dateTimePicker
            DateTime selectedDate = dateTimePicker1.Value.Date;

            MainClass.con.Open();

            // Construct the query to count the total queue_number for the selected date
            string qry = "SELECT COUNT(date) FROM queue_numbers WHERE CONVERT(DATE, date) = @date";

            using (SqlCommand cmd = new SqlCommand(qry, MainClass.con))
            {
                // Pass the selected date as a parameter to the query
                cmd.Parameters.AddWithValue("@date", selectedDate);

                // Execute the query and get the total count
                int totalQueueNumbers = (int)cmd.ExecuteScalar();

                // Use the total count as needed, such as displaying it in a label
                label_Served.Text =   totalQueueNumbers.ToString();
            }

            MainClass.con.Close();
        }
    }
}
